using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Threading.Tasks;

namespace YouZanYun
{
    public class YouZanYunAPIClient
    {
        readonly string client_id;
        readonly string client_secret;
        readonly string grant_id;
        readonly RestClient restClient;
        readonly IDistributedCache cache;

        readonly string access_token_cache_key;
        readonly object access_token_lockObj = new object();

        public YouZanYunAPIClient(string client_id, string client_secret, string grant_id, IDistributedCache cache)
        {
            this.client_id = client_id;
            this.client_secret = client_secret;
            this.grant_id = grant_id;
            this.access_token_cache_key = $"Obj:YouZanYun:AccessToken:Authority{grant_id}";

            this.cache = cache;

            restClient = new RestClient("https://open.youzanyun.com");
            restClient.ThrowOnAnyError = true;
            restClient.UseSerializer<RestSharp.Serializers.NewtonsoftJson.JsonNetSerializer>();

            Users = new UsersNode(this);
            User = new UserNode(this);
            Salesman = new SalesmanNode(this);
            Scrm = new ScrmNode(this);
            Trade = new TradeNode(this);
            Trades = new TradesNode(this);
            Crm = new CrmNode(this);
            Guide = new GuideNode(this);
        }

        public GuideNode Guide { get; private set; }
        public UsersNode Users { get; set; }
        public UserNode User { get; private set; }

        public SalesmanNode Salesman { get; set; }
        public ScrmNode Scrm { get; set; }
        public TradeNode Trade { get; private set; }
        public TradesNode Trades { get; set; }
        public CrmNode Crm { get; private set; }

        public async Task<ResponsePagedListBase<T>> PostPagedListAsync<T>(string name, object args, string version = "1.0.0")
        {
            return await PostBaseAsync<ResponsePagedListBase<T>>(name, args, version);
        }

        public async Task<ResponseBase<T>> PostAsync<T>(string name, object args, string version = "1.0.0")
        {
            return await PostBaseAsync<ResponseBase<T>>(name, args, version);
        }

        async Task<T> PostBaseAsync<T>(string name, object args, string version = "1.0.0") where T : ResponseBase
        {
            var url = $"api/{name}/{version}";
            var response = await PostBaseAsync<T>(url, args);
            if (response.ResponseError != null)
            {
                if (response.ResponseError.ErrorCode == 4203)
                {
                    lock (this)
                    {
                        var accessToken = cache.GetString(access_token_cache_key);
                        if (!string.IsNullOrEmpty(accessToken) && accessToken == response.AccessToken)
                        {
                            cache.Remove(access_token_cache_key);
                        }
                    }

                    // 重新获取，这里不再进行accessToken判定
                    response = PostBaseAsync<T>(url, args).Result;

                }
                else
                {
                    throw new YouZanYunAPIResponseException(response.ResponseError);
                }
            }
            return response;
        }

        async Task<T> PostBaseAsync<T>(string url, object args) where T : ResponseBase
        {
            var access_token = await GetAccessTokenAsync();
            var request = new RestRequest(url)
                .AddQueryParameter("access_token", access_token)
                .AddJsonBody(args);

            // var res = restClient.Post(request);

            var response = await restClient.PostAsync<T>(request);
            response.AccessToken = access_token;
            return response;
        }


        public async Task<string> GetAccessTokenAsync()
        {
            string access_token = await cache.GetStringAsync(access_token_cache_key);
            if (string.IsNullOrEmpty(access_token))
            {
                lock (access_token_lockObj)
                {
                    access_token = cache.GetString(access_token_cache_key);
                    // 再次判断
                    if (string.IsNullOrEmpty(access_token))
                    {
                        var request = new RestRequest("/auth/token")
                            .AddHeader("Accept", "*/*")
                            .AddJsonBody(new
                            {
                                client_id,
                                client_secret,
                                grant_id,
                                authorize_type = "silent",
                                refresh = true
                            });

                        var response = restClient.Post<ResponseBase<AccessTokenData>>(request);

                        access_token = response.Data.Data.AccessToken;
                        cache.SetString(access_token_cache_key, access_token, new DistributedCacheEntryOptions()
                        {
                            AbsoluteExpiration = new DateTimeOffset(response.Data.Data.ExpiresTime)
                        });
                    }
                }
            }
            return access_token;
        }

        public class AccessTokenData
        {
            [JsonProperty("expires")]
            public long? Expires { get; set; }

            [JsonProperty("access_token")]
            public string AccessToken { get; set; }

            [JsonProperty("authority_id")]
            public string Authority { get; set; }

            [JsonProperty("refresh_token")]
            public string RefreshToken { get; set; }

            public string Message { get; set; }

            [JsonIgnore]
            public DateTime ExpiresTime
            {
                get
                {
                    if (this.Expires == null)
                        return new DateTime(2099, 12, 31, 23, 59, 59);
                    var startTime = new DateTime(1970, 1, 1);
                    var ts = new TimeSpan(this.Expires.Value * 10000);
                    return startTime.Add(ts);
                }
            }
        }
    }
}

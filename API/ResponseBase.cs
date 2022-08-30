using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace YouZanYun
{
    public class ResponseBase
    {
        [JsonProperty("trace_id")]
        public string TraceId { get; set; }
        public int Code { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
        /// <summary>
        /// 错误响应
        /// </summary>
        [JsonProperty("gw_err_resp")]
        public ResponseError ResponseError { get; set; }
        /// <summary>
        /// 查询时使用的AccessToken，用于重新获取时判定是否一致
        /// </summary>
        public string AccessToken { get; set; }
    }

    public class ResponseBase<T> : ResponseBase
    {
        public T Data { get; set; }
        public T Response { get; set; }
    }

    public class ResponsePagedListBase<T> : ResponseBase
    {
        public List<T> Items { get; set; }
        public ResponsePagedListPaginator Paginator { get; set; }
    }

    public class ResponsePagedListPaginator
    {
        /// <summary>
        /// 总数据，最大10000条
        /// </summary>
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
        /// <summary>
        /// 每页条数。默认20条，最大不能超过100，建议使用默认分页
        /// </summary>
        [JsonProperty("page_size")]
        public int PageSize { get; set; }
        /// <summary>
        /// 页码，从1 ~100开始
        /// </summary>
        public int Page { get; set; }
    }

    public class ResponseError
    {
        [JsonProperty("err_msg")]
        public string ErrorMessage { get; set; }
        [JsonProperty("err_code")]
        public int ErrorCode { get; set; }
    }
}

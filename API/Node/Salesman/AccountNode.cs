using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YouZanYun.Infrastructure;
using YouZanYun.Salesman.Account;

namespace YouZanYun.Salesman
{
    public class AccountNode : NodeBase
    {
        public AccountNode(YouZanYunAPIClient client) : base(client)
        {
            Score = new ScoreNode(client);
        }

        public ScoreNode Score { get; private set; }
        /// <summary>
        /// 设置用户为销售员
        /// </summary>
        /// <param name="fans_id"></param>
        /// <param name="fans_type"></param>
        /// <param name="mobile">销售员手机号（不支持国外手机号，并且mobile或fans_id选其一，当fans_id和mobile都传时，优先按mobile查询）</param>
        /// <param name="version"></param>
        /// <returns></returns>
        public async Task<ResponseBase<SuccessData>> AddV3Async(long fans_id = 0
            , int fans_type = 0
            , string mobile = null)
        {
            var response = await PostAsync<SuccessData>("youzan.salesman.account.add", new
            {
                fans_id,
                fans_type,
                mobile
            }, "3.0.0");
            return response;
        }
        /// <summary>
        /// 设置用户为销售员
        /// </summary>
        /// <param name="fans_id"></param>
        /// <param name="mobile"></param>
        /// <param name="node_kdt_id"></param>
        /// <param name="level"></param>
        /// <param name="group_id"></param>
        /// <param name="fans_type"></param>
        /// <param name="from_mobile"></param>
        /// <returns></returns>
        public async Task<ResponseBase<SuccessData>> AddV3_0_1Async(long fans_id = 0
            , string mobile = null
            , int? node_kdt_id = null
            , int? level = null
            , long? group_id = null
            , int? fans_type = null
            , string from_mobile = null)
        {
            var response = await PostAsync<SuccessData>("youzan.salesman.account.add", new
            {
                fans_id,
                node_kdt_id,
                level,
                group_id,
                from_mobile,
                fans_type,
                mobile
            }, "3.0.1");
            return response;
        }

        public async Task<bool> FireV3Async(long fans_id = 0
            , int? fans_type = null
            , string mobile = null
            , string target_mobile = null)
        {
            var response = await PostAsync<bool>("youzan.salesman.account.fire", new
            {
                fans_id,
                fans_type,
                mobile,
                target_mobile
            }, "3.0.0");
            return response.Response;
        }

        /// <summary>
        ///  获取销售员账户信息
        /// </summary>
        /// <remarks>
        /// https://doc.youzanyun.com/detail/API/0/67
        /// </remarks>
        /// <param name="mobile">销售员手机号（不支持国外手机号，并且mobile或fans_id选其一，当fans_id和mobile都传时，优先按mobile查询）</param>
        /// <param name="fans_type">废弃字段，不影响接口调用</param>
        /// <param name="fans_id">粉丝id(有赞不同的合作渠道会生成不同渠道对应在有赞平台下的fans_id。fans_id和fans_type组成一个唯一的有赞用户标识。从浏览器过来的下单的是拿不到fans_id。 大账号fans_id：通过微信去访问有赞店铺的商品等，系统会给用户生成fansid。 用户自有fans_id（从三方过来的）：关注任意一个公众号(包括有赞大账号)后生成ID。 fans_type：1:代表微信自有粉丝；2：代表[微博平台]产生的粉丝；9：代表粉丝类型为微信大账号粉丝；188：代表[qq平台]产生的粉丝；736:代表[支付宝平台]产生的粉丝；1181:代表[今日头条]产生的粉丝；非上述fans_type其他：代表其他平台或小程序粉丝或者三方sdk产生的粉丝；)</param>
        /// <returns></returns>
        public async Task<ResponseBase<GetData>> GetV3_0_1Async(
            string mobile = null
            , int? fans_type = null
            , long? fans_id = null
        )
        {
            var response = await PostAsync<GetData>("youzan.salesman.account.get", new
            {
                mobile,
                fans_type,
                fans_id
            }, "3.0.1");
            return response;
        }


        /// <summary>
        /// 查询销售员信息
        /// </summary>
        /// <remarks>
        /// https://doc.youzanyun.com/detail/API/0/1321
        /// </remarks>
        /// <param name="request_data"></param>
        /// <returns></returns>
        public async Task<ResponseBase<GetbyyzopenidData>> GetbyyzopenidAsync(
            string yz_open_id
        )
        {
            var response = await PostAsync<GetbyyzopenidData>("youzan.salesman.account.getbyyzopenid", new
            {
                request_data = new {
                    yz_open_id
                }
            }, "1.0.0");
            return response;
        }

        /// <summary>
        /// 更新销售员信息
        /// </summary>
        /// <remarks>
        /// https://doc.youzanyun.com/detail/API/0/42
        /// </remarks>
        /// <param name="node_kdt_id">1、当前是总店token，使用网店店铺id，更新网点信息，传此id 2、非连锁或连锁分店，不需要传此id  有赞连锁网店店铺id，仅供有赞连锁场景下使用。有赞平台生成，在有赞平台唯一，用于判断信息属于哪一个网店。传了返回网店数据。</param>
        /// <param name="level">需要设置的等级</param>
        /// <param name="group_id">所属分组id，可不传以后会提供查询分销员分组的开放接口</param>
        /// <param name="mobile">销售员手机号（不支持国外手机号，并且mobile或fans_id选其一，当fans_id和mobile都传时，优先按mobile查询）</param>
        /// <param name="fans_type">粉丝类型（1:代表微信自有粉丝；2：代表[微博平台]产生的粉丝；9：代表粉丝类型为微信大账号粉丝；188：代表[qq平台]产生的粉丝；736:代表[支付宝平台]产生的粉丝；1181:代表[今日头条]产生的粉丝；非上述fans_type其他：代表其他平台或小程序粉丝或者三方sdk产生的粉丝；）</param>
        /// <param name="from_mobile">邀请方手机号；不传或为空，表示删除邀请人；传原来的手机号，表示不变</param>
        /// <param name="fans_id">粉丝id(有赞不同的合作渠道会生成不同渠道对应在有赞平台下的fans_id。fans_id和fans_type组成一个唯一的有赞用户标识。从浏览器过来的下单的是拿不到fans_id。 大账号fans_id：通过微信去访问有赞店铺的商品等，系统会给用户生成fansid。 用户自有fans_id（从三方过来的）：关注任意一个公众号(包括有赞大账号)后生成ID。 fans_type：1:代表微信自有粉丝；2：代表[微博平台]产生的粉丝；9：代表粉丝类型为微信大账号粉丝；188：代表[qq平台]产生的粉丝；736:代表[支付宝平台]产生的粉丝；1181:代表[今日头条]产生的粉丝；非上述fans_type其他：代表其他平台或小程序粉丝或者三方sdk产生的粉丝；)</param>
        /// <returns></returns>
        public async Task<ResponseBase<SuccessData>> UpdateV3Async(
            string mobile
            , long fans_id = 0
            , int? fans_type = null
            , long? node_kdt_id = null
            , int? level = null
            , long? group_id = null
            , string from_mobile = null
        )
        {
            var response = await PostAsync<SuccessData>("youzan.salesman.account.update", new
            {
                node_kdt_id,
                level,
                group_id,
                mobile,
                fans_type,
                from_mobile,
                fans_id
            }, "3.0.0");
            return response;
        }
    }
}

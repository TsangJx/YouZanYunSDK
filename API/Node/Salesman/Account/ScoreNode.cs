using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YouZanYun.Infrastructure;
using YouZanYun.Salesman.Account.Score;
using YouZanYun.Salesman.Account;

namespace YouZanYun.Salesman.Account
{
    public class ScoreNode : NodeBase
    {
        public ScoreNode(YouZanYunAPIClient client) : base(client)
        {

        }
        /// <summary>
        ///  获取销售员业绩统计
        /// </summary>
        /// <remarks>
        /// https://doc.youzanyun.com/detail/API/0/37
        /// </remarks>
        /// <param name="start_time">订单创建开始时间，Unix时间戳，单位：秒</param>
        /// <param name="mobile">销售员手机号（不支持国外手机号，当fans_id和mobile都传时，优先按mobile查询）</param>
        /// <param name="end_time">订单创建结束时间，Unix时间戳，单位：秒；如果开始时间和结束时间都传，则两个时间跨度不能超过90天</param>
        /// <param name="page_no">页码，从1~100开始，分页数不能超过100页。如果订单较多请使用时间参数分割。page_size 和page_no相乘总条数不能大于3200条</param>
        /// <param name="fans_id">粉丝id(有赞不同的合作渠道会生成不同渠道对应在有赞平台下的fans_id。fans_id和fans_type组成一个唯一的有赞用户标识。从浏览器过来的下单的是拿不到fans_id。 大账号fans_id：通过微信去访问有赞店铺的商品等，系统会给用户生成fansid。 用户自有fans_id（从三方过来的）：关注任意一个公众号(包括有赞大账号)后生成ID。 fans_type：1:代表微信自有粉丝；2：代表[微博平台]产生的粉丝；9：代表粉丝类型为微信大账号粉丝；188：代表[qq平台]产生的粉丝；736:代表[支付宝平台]产生的粉丝；1181:代表[今日头条]产生的粉丝；非上述fans_type其他：代表其他平台或小程序粉丝或者三方sdk产生的粉丝；)</param>
        /// <param name="page_size">每页条数。默认20条，最大不能超过100，建议使用默认分页。如果订单较多请使用时间参数分割。page_size 和page_no相乘总条数不能大于3200条</param>
        /// <returns></returns>
        public async Task<ResponseBase<SearchData>> SearchV3Async(
            DateTime start_time
            , DateTime end_time
            , int page_no = 1
            , int page_size = 20
            , string mobile = null
            , long? fans_id = null
        )
        {
            var response = await PostAsync<SearchData>("youzan.salesman.account.score.search", new
            {
                start_time = TimestampUtil.ToTimestampForSecond(start_time),
                mobile,
                end_time = TimestampUtil.ToTimestampForSecond(end_time),
                page_no,
                fans_id,
                page_size
            }, "3.0.0");
            return response;
        }


    }
}

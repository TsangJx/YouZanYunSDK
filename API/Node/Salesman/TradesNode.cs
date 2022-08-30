using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YouZanYun.Infrastructure;
using YouZanYun.Salesman.Trades;
namespace YouZanYun.Salesman
{
    public class TradesNode : NodeBase
    {
        public TradesNode(YouZanYunAPIClient client) : base(client)
        {
            Account = new YouZanYun.Salesman.Trades.AccountNode(client);
            Get = new YouZanYun.Salesman.Trades.GetNode(client);
        }

        public YouZanYun.Salesman.Trades.AccountNode Account { get; private set; }
        public YouZanYun.Salesman.Trades.GetNode Get { get; private set; }

        /// <summary>
        ///  获取推广订单列表
        /// </summary>
        /// <remarks>
        /// https://doc.youzanyun.com/detail/API/0/34
        /// </remarks>
        /// <param name="order_no">推广订单号即有赞订单号，E开头+年月日时分秒+随机数，长度24位字母和数字组合</param>
        /// <param name="start_time">开始时间，Unix时间戳，单位：秒</param>
        /// <param name="group_id">所属分组id</param>
        /// <param name="mobile">销售员手机号（不支持国外手机号，并且mobile或fans_id选其一，当fans_id和mobile都传时，优先按mobile查询）</param>
        /// <param name="end_time">结束时间，Unix时间戳，单位：秒. PS : 如果传了此字段，结束时间的查询范围会往后 + 24小时的时间戳。比如 endTime 是 2018/10/30 10:45:40的时间戳，endTime会以2018/10/31 10:45:40去查询</param>
        /// <param name="fans_type">粉丝类型（1:代表微信自有粉丝；2：代表[微博平台]产生的粉丝；9：代表粉丝类型为微信大账号粉丝；188：代表[qq平台]产生的粉丝；736:代表[支付宝平台]产生的粉丝；1181:代表[今日头条]产生的粉丝；非上述fans_type其他：代表其他平台或小程序粉丝或者三方sdk产生的粉丝；）</param>
        /// <param name="page_no">页码，从1~100开始，分页数不能超过100页。如果订单较多请使用时间参数分割。page_size 和page_no相乘总条数不能大于3200条</param>
        /// <param name="fans_id">粉丝id(有赞不同的合作渠道会生成不同渠道对应在有赞平台下的fans_id。fans_id和fans_type组成一个唯一的有赞用户标识。从浏览器过来的下单的是拿不到fans_id。 大账号fans_id：通过微信去访问有赞店铺的商品等，系统会给用户生成fansid。 用户自有fans_id（从三方过来的）：关注任意一个公众号(包括有赞大账号)后生成ID。 fans_type：1:代表微信自有粉丝；2：代表[微博平台]产生的粉丝；9：代表粉丝类型为微信大账号粉丝；188：代表[qq平台]产生的粉丝；736:代表[支付宝平台]产生的粉丝；1181:代表[今日头条]产生的粉丝；非上述fans_type其他：代表其他平台或小程序粉丝或者三方sdk产生的粉丝；)</param>
        /// <param name="page_size">每页条数。默认20条，最大不能超过100，建议使用默认分页。如果订单较多请使用时间参数分割。page_size 和page_no相乘总条数不能大于3200条</param>
        /// <returns></returns>
        public async Task<ResponseBase<GetData>> GetV3_0_1Async(
            string order_no = null
            , DateTime? start_time = null
            , DateTime? end_time = null
            , long? group_id = null
            , string mobile = null
            , int? fans_type = null
            , long? fans_id = null
            , int page_no = 1
            , int page_size = 20
        )
        {
            long? start_timeLong = null;
            if (start_time.HasValue)
            {
                start_timeLong = TimestampUtil.ToTimestampForSecond(start_time.Value);
            }
            long? end_timeLong = null;
            if (end_time.HasValue)
            {
                end_timeLong = TimestampUtil.ToTimestampForSecond(end_time.Value);
            }
            var response = await PostAsync<GetData>("youzan.salesman.trades.get", new
            {
                order_no,
                start_time = start_timeLong,
                end_time = end_timeLong,
                group_id,
                mobile,
                fans_type,
                page_no,
                fans_id,
                page_size
            }, "3.0.1");
            return response;
        }

        /// <summary>
        /// 查询推广订单列表
        /// </summary>
        /// <remarks>
        /// https://doc.youzanyun.com/detail/API/0/890
        /// </remarks>
        /// <param name="start_time">订单号生成开始时间。时间戳（秒）。注:有赞订单号生成规则为（E+单号生成时间+末尾)。前14位数字代表单号生成时间。例如单号：E20200722130649022204207，前14位为20200722130649，订单号生成时间则为2020-07-22 13:06:49。实际查询交易的订单创建时间可能与单号生成时间有略微误差（1-2秒），以单号生成时间为准。</param>
        /// <param name="mobile">分销员手机号 当yz_open_id与mobile都传时,优先按mobile查询</param>
        /// <param name="end_time">订单号生成结束时间;1.首次查询，该值可为空也可不为空，如果为空则默认用当前时间查询历史订单；如果不为空，则使用该时间查询历史订单;2.非首次查询，该值是用上一次分页查询得到的pageMinCreatedAt查询</param>
        /// <param name="yz_open_id">分销员yzopenid</param>
        /// <param name="id">1.当是第一次查询时，此参数不传，仅使用endTime作为游标;2.当不是第一次查询时，此参数必传，配合endTime一起作为游标</param>
        /// <param name="page_size">每页记录数，最大不能超过50条/页</param>
        /// <returns></returns>
        public async Task<ResponseBase<ExportData>> ExportAsync(
            int page_size = 20
            , DateTime? start_time = null
            , DateTime? end_time = null
            , string mobile = null
            , string yz_open_id = null
            , long? id = null
        )
        {
            long? start_timeLong = null;
            if (start_time.HasValue)
            {
                start_timeLong = TimestampUtil.ToTimestampForSecond(start_time.Value);
            }
            long? end_timeLong = null;
            if (end_time.HasValue)
            {
                end_timeLong = TimestampUtil.ToTimestampForSecond(end_time.Value);
            }
            var response = await PostAsync<ExportData>("youzan.salesman.trades.export", new
            {
                start_time = start_timeLong,
                end_time = end_timeLong,
                mobile,
                yz_open_id,
                id,
                page_size
            }, "1.0.0");
            return response;
        }

    }
}

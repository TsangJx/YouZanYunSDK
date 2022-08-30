using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YouZanYun.Scrm;
using YouZanYun.Users;

namespace YouZanYun.Trades
{
    public partial class SoldNode : NodeBase
    {
        public SoldNode(YouZanYunAPIClient client) : base(client)
        {
        }

        /// <summary>
        /// 订单搜索接口
        /// </summary>
        /// <remarks>
        /// https://doc.youzanyun.com/detail/API/0/157
        /// </remarks>
        /// <param name="end_created">订单创建结束时间，用于筛选某一段时间的订单，时间格式：yyyy-MM-dd HH:mm:ss。开始时间和结束时间必须成对出现，查询时间跨度不能大于3个月。</param>
        /// <param name="offline_id">多网点id</param>
        /// <param name="goods_id"> 商品id，有赞生成的商品唯一id</param>
        /// <param name="end_update">订单更新结束时间，用于筛选某一段时间的订单，时间格式：yyyy-MM-dd HH:mm:ss。开始时间和结束时间必须成对出现，查询时间跨度不能大于3个月。</param>
        /// <param name="fans_type">粉丝类型1:自有粉丝; 9:代销粉丝,2:微博,105:,知乎,128: 有赞精选app,188: QQ,312:腾讯云,736:支付宝,1180:百度,1181:今日头条,1590:微信广告,56473:陌陌 ,59011:线下微信支付产生的粉丝,59465:线下支付宝支付,4591:有人,16940: 快手 ,26879:上鱼,6227:精选小程序,61489:虎牙</param>
        /// <param name="page_no">页码，从1~100开始，分页数不能超过100页。如果订单较多请使用时间参数分割。page_size 和page_no相乘总条数不能大于1W条。</param>
        /// <param name="type">订单类型：NORMAL：普通订单，PEERPAY：代付，GIFT：我要送人，FX_CAIGOUDAN：分销采购单，PRESENT：赠品，WISH：心愿单，QRCODE：二维码订单，QRCODE_3RD：线下收银台订单，FX_MERGED：合并付货款，VERIFIED：1分钱实名认证，PINJIAN：品鉴，REBATE：返利，FX_QUANYUANDIAN：全员开店，FX_DEPOSIT：保证金，PF：批发你，GROUP：拼团，HOTEL：酒店，TAKE_AWAY：外卖，CATERING_OFFLINE：堂食点餐，CATERING_QRCODE：外卖买单，BEAUTY_APPOINTMENT：美业预约单，BEAUTY_SERVICE：美业服务单，KNOWLEDGE_PAY：知识付费，GIFT_CARD：礼品卡（参照微商城模块）</param>
        /// <param name="buyer_id">买家id</param>
        /// <param name="need_order_url">是否需要返回订单url</param>
        /// <param name="tid">订单号</param>
        /// <param name="node_kdt_id">网店kdtId</param>
        /// <param name="start_update">订单更新开始时间，用于筛选某一段时间的订单，时间格式：yyyy-MM-dd HH:mm:ss。开始时间和结束时间必须成对出现，查询时间跨度不能大于3个月。</param>
        /// <param name="receiver_name">收货人昵称</param>
        /// <param name="start_created">订单创建开始时间，用于筛选某一段时间的订单，时间格式：yyyy-MM-dd HH:mm:ss。开始时间和结束时间必须成对出现，查询时间跨度不能大于3个月。</param>
        /// <param name="receiver_phone">收货人手机号</param>
        /// <param name="status">订单状态：一次只能查询一种状态。待付款：WAIT_BUYER_PAY，待发货：WAIT_SELLER_SEND_GOODS，等待买家确认：WAIT_BUYER_CONFIRM_GOODS，订单完成：TRADE_SUCCESS，订单关闭：TRADE_CLOSE（新增-参照微商城模块）退款中：TRADE_REFUND</param>
        /// <param name="fans_id">粉丝id</param>
        /// <param name="page_size">每页条数。默认20条，最大不能超过100，建议使用默认分页。如果订单较多请使用时间参数分割。page_size 和page_no相乘总条数不能大于1W条。</param>
        /// <param name="express_type">物流类型:同城送订单：LOCAL_DELIVERY,自提订单：SELF_FETCH,快递配送：EXPRESS</param>
        /// <returns></returns>
        public async Task<ResponseBase<YouZanYun.Trades.Sold.GetData>> GetV4Async(
            int page_no = 1
            , int page_size = 20
            , DateTime? start_created = null
            , DateTime? end_created = null
            , long? offline_id = null
            , long? goods_id = null
            , DateTime? start_update = null
            , DateTime? end_update = null
            , int? fans_type = null
            , string type = null
            , long? buyer_id = null
            , bool? need_order_url = null
            , string tid = null
            , long? node_kdt_id = null
            , string receiver_name = null
            , string receiver_phone = null
            , string status = null
            , long? fans_id = null
            , string express_type = null
        )
        {
            string start_createdString = null;
            if (start_created.HasValue)
            {
                start_createdString = start_created.Value.ToString("yyyy-MM-dd HH:mm:ss");
            }
            string end_createdString = null;
            if (end_created.HasValue)
            {
                end_createdString = end_created.Value.ToString("yyyy-MM-dd HH:mm:ss");
            }

            string start_updateString = null;
            if (start_update.HasValue)
            {
                start_updateString = start_update.Value.ToString("yyyy-MM-dd HH:mm:ss");
            }
            string end_updateString = null;
            if (end_update.HasValue)
            {
                end_updateString = end_update.Value.ToString("yyyy-MM-dd HH:mm:ss");
            }

            var response = await PostAsync<YouZanYun.Trades.Sold.GetData>("youzan.trades.sold.get", new
            {
                end_created = end_createdString,
                offline_id,
                goods_id,
                end_update = end_updateString,
                fans_type,
                page_no,
                type,
                buyer_id,
                need_order_url,
                tid,
                node_kdt_id,
                start_update = start_updateString,
                receiver_name,
                start_created = start_createdString,
                receiver_phone,
                status,
                fans_id,
                page_size,
                express_type
            }, "4.0.0");
            return response;
        }
    }
}

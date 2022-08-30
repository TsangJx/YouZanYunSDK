using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using YouZanYun.Trade.Refund;
using YouZanYun.Infrastructure;

namespace YouZanYun.Trade
{
    public partial class RefundNode : NodeBase
    {
        public RefundNode(YouZanYunAPIClient client) : base(client)
        {

        }

        /// <summary>
        /// 查看退款列表
        /// </summary>
        /// <remarks>
        /// https://doc.youzanyun.com/detail/API/0/131
        /// </remarks>
        /// <param name="operator_id">操作人id</param>
        /// <param name="type">退款流程类型：1（退款-买家申请退款),2（退款-商家主动退款),3（退款-一键退款),4（换货-零售门店换货)。5(换货-微商城)</param>
        /// <param name="buyer_id">买家id</param>
        /// <param name="tid">有赞订单号，E开头+年月日时分秒+随机数，长度24位字母和数字组合	</param>
        /// <param name="pay_way">支付方式：0, "默认值,未支付"; 1, “微信自有支付"; 2, “支付宝wap"; 3, “支付宝wap"; 4, “"; 5, “财付通"; 6, “"; 7, “代付"; 8, “联动优势"; 9, “货到付款"; 10, “大账号代销"; 11, “受理模式"; 12, “百付宝"; 13, “sdk支付"; 14, “合并付货款"; 15, “领取赠品"; 16, “优惠兑换"; 17, “自动付货款"; 18, “爱学贷"; 19, “微信wap"; 20, “微信红包支付"; 21, “返利"; 22, “ump红包"; 23, “"; 24, “易宝支付"; 25, “储值卡"; 26, “"; 27, “qq支付"; 28, “有赞E卡支付; 29, “微信条码"; 30, “支付宝条码"; 33, “礼品卡支付"; 35, “会员余额"; 36, “信用卡银联支付"; 37, “储蓄卡银联支付"; 40, “分期支付"; 72, “微信扫码二维码支付"; 80, “待结算&余额支付"; 90, “礼品卡支付"; 100, “代收账户"; 300, “储值账户"; 400, “保证金账户"; 101, “收款码"; 102, "微信";  103, “支付宝"; 104, “刷卡"; 105, “二维码台卡"; 106, “储值卡"; 107, “有赞E卡"; 110, “标记收款-自有微信支付"; 111, “标记收款-自有支付宝"; 112, “标记收款-自有POS刷卡"; 113, “通联刷卡支付"; 114, “标记收款-自定义"; 115, “有赞零钱支付"; 116, “优惠全额抵扣"; 117, “商米支付"; 118, “商米支付-支付宝"; 119, “商米pos"; 200, “记账账户"; 201, “现金"; 202, “组合支付"; 203, “外部支付”.</param>
        /// <param name="node_kdt_id">分店店铺ID</param>
        /// <param name="pay_type">支付类型：0（老的方式,支付方式与支付渠道组合在一起),1（无需支付),2（现付),3（部分支付),4（货到付款),5（线下收银),6（单次支付),7（阶段支付),8（外部支付)。</param>
        /// <param name="create_time_start">时间范围查询退款创建起始时间时间戳(单位为秒)例如:1513785600；不传该值则默认只查最近三个月的</param>
        /// <param name="sale_way">销售渠道1:门店2:网店</param>
        /// <param name="create_time_end">时时间范围查询退款创建截止时间时间戳(单位为秒)例如:1513868400</param>
        /// <param name="update_time_start">时间范围查询退款更新起始时间时间戳（单位为秒）例如:1513785600</param>
        /// <param name="update_time_end">时间范围查询退款更新截止时间时间戳（单位为秒）例如:1513868400</param>
        /// <param name="page_size">每页显示个数，pageNo * pageSize > 3000会提示“超过ES搜索最大深度”</param>
        /// <param name="phase">退款阶段： 1, "售中";2, "售后";</param>
        /// <param name="return_stock_status">退货场景 退货归还库存状态： 0, “无需入库"; 10, “待入库"; 20, "归还库存成功";</param>
        /// <param name="buyer_phone">买家电话</param>
        /// <param name="page_no">分页数，pageNo >100会提示“查询页数超过100”</param>
        /// <param name="refund_id">退款号</param>
        /// <param name="demand">退款诉求： 1, "仅退款"; 2, “退货退款"; 3,"换货");</param>
        /// <param name="delivery_no">物流单号</param>
        /// <param name="search_tag">退款单列表查询tag ： 0, “待商家处理"; 1, “待买家处理"; 2, "客服介入中";</param>
        /// <param name="shop_id">网点Id。可以从youzan.multistore.offline.search.3.0.0获取</param>
        /// <param name="sku_no">商品条码号</param>
        /// <param name="refund_mode">退款资金类型： 0, “原路退"; 1, “现金退"; 2, "标记退";</param>
        /// <param name="goods_title">商品名称</param>
        /// <param name="shop_type">多网点类型。3-多网点下单类型。不填表示非多网点下单</param>
        /// <param name="invalid">是否为无效的退款单true是无效数据库是1，false是有效数据库是0</param>
        /// <param name="cs_status">客服介入状态: 1, “不需要客服介入"; 2, “需要客服介入"; 3, "介入结束";</param>
        /// <param name="delivery_status">发货状态，1未发货，2已发货</param>
        /// <param name="status">退款状态:WAIT_SELLER_AGREE(买家已经申请退款，等待卖家同意)，WAIT_BUYER_RETURN_GOODS(卖家已经同意退款，等待买家退货)，WAIT_SELLER_CONFIRM_GOODS(买家已经退货，等待卖家确认收货)，SELLER_REFUSE_BUYER(卖家拒绝退款)，CLOSED(退款关闭)，SUCCESS(退款成功),CUSTOMER_SERVICE_IN(客满介入),SELLER_REFUSE_BUYER_RETURN_GOODS(卖家拒绝收货，等待买家处理),SELLER_RETURN_GOODS(卖家拒绝收货，等待买家处理)</param>
        /// <returns></returns>
        public async Task<ResponseBase<YouZanYun.Trade.Refund.SearchV3Data>> SearchV3Async(
                    long? operator_id = null
            , int? type = null
            , long? buyer_id = null
            , string tid = null
            , int? pay_way = null
            , long? node_kdt_id = null
            , int? pay_type = null
            , int? sale_way = null
            , DateTime? create_time_start = null
            , DateTime? create_time_end = null
            , DateTime? update_time_start = null
            , DateTime? update_time_end = null
            , int page_no = 1
            , int page_size = 20
            , int? phase = null
            , int? return_stock_status = null
            , string buyer_phone = null
            , string refund_id = null
            , int? demand = null
            , string delivery_no = null
            , int? search_tag = null
            , long? shop_id = null
            , string sku_no = null
            , int? refund_mode = null
            , string goods_title = null
            , int? shop_type = null
            , int? invalid = null
            , int? cs_status = null
            , int? delivery_status = null
            , string status = null
        )
        {
            long? create_time_startLong = null;
            if (create_time_start.HasValue)
            {
                create_time_startLong = TimestampUtil.ToTimestampForSecond(create_time_start.Value);
            }
            long? create_time_endLong = null;
            if (create_time_end.HasValue)
            {
                create_time_endLong = TimestampUtil.ToTimestampForSecond(create_time_end.Value);
            }

            long? update_time_startLong = null;
            if (update_time_start.HasValue)
            {
                update_time_startLong = TimestampUtil.ToTimestampForSecond(update_time_start.Value);
            }
            long? update_time_endLong = null;
            if (update_time_end.HasValue)
            {
                update_time_endLong = TimestampUtil.ToTimestampForSecond(update_time_end.Value);
            }

            var response = await PostAsync<YouZanYun.Trade.Refund.SearchV3Data>("youzan.trade.refund.search", new
            {
                operator_id,
                type,
                buyer_id,
                tid,
                pay_way,
                node_kdt_id,
                pay_type,
                create_time_start = create_time_startLong,
                sale_way,
                create_time_end = create_time_endLong,
                update_time_start = update_time_startLong,
                update_time_end = update_time_endLong,
                page_size,
                phase,
                return_stock_status,
                buyer_phone,
                page_no,
                refund_id,
                demand,
                delivery_no,
                search_tag,
                shop_id,
                sku_no,
                refund_mode,
                goods_title,
                shop_type,
                invalid,
                cs_status,
                delivery_status,
                status
            }, "3.0.0");
            return response;
        }

        /// <summary>
        /// 单个售后单详情查询接口
        /// </summary>
        /// <remarks>
        /// https://doc.youzanyun.com/detail/API/0/135
        /// </remarks>
        /// <param name="refund_id">维权ID（售后单编号），售后申请时有赞系统自动生成一串数字组合，生成规则：年月日时分秒+10位随机数，用于确认售后详情，使用【youzan.trade.refund.search】【youzan.trade.get】接口可以获取。	</param>
        /// <returns></returns>
        public async Task<ResponseBase<YouZanYun.Trade.Refund.GetV3Data>> GetV3Async(
                    string refund_id
        )
        {
            var response = await PostAsync<YouZanYun.Trade.Refund.GetV3Data>("youzan.trade.refund.get", new
            {
                refund_id
            }, "3.0.0");
            return response;
        }
    }
}

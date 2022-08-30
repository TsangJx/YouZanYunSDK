using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using YouZanYun.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace YouZanYun.Trade
{
    public class GetV4_0_1Data
    {
        /// <summary>
        /// 交易基础信息结构体
        /// </summary>
        [Required]
        [JsonProperty("full_order_info")]
        public FullOrderInfoModel FullOrderInfo { get; set; }
        /// <summary>
        /// 订单发货详情结构体
        /// </summary>
        [JsonProperty("delivery_order")]
        public List<DeliveryOrderModel> DeliveryOrder { get; set; }
        /// <summary>
        /// 订单优惠详情结构体
        /// </summary>
        [Required]
        [JsonProperty("order_promotion")]
        public OrderPromotionModel OrderPromotion { get; set; }
        /// <summary>
        /// 订单退款信息结构体
        /// </summary>
        [JsonProperty("refund_order")]
        public List<RefundOrderModel> RefundOrder { get; set; }
        public class FullOrderInfoModel
        {
            /// <summary>
            /// 交易明细结
            /// </summary>
            [JsonProperty("orders")]
            public List<OrdersModel> Orders { get; set; }
            /// <summary>
            /// 订单支付信息
            /// </summary>
            [Required]
            [JsonProperty("pay_info")]
            public PayInfoModel PayInfo { get; set; }
            /// <summary>
            /// 收货地址信息
            /// </summary>
            [JsonProperty("address_info")]
            public AddressInfoModel AddressInfo { get; set; }
            /// <summary>
            /// 交易基础信息
            /// </summary>
            [JsonProperty("order_info")]
            public OrderInfoModel OrderInfo { get; set; }
            /// <summary>
            /// 送礼订单子单
            /// </summary>
            [JsonProperty("child_info")]
            public ChildInfoModel ChildInfo { get; set; }
            /// <summary>
            /// 酒店pro信息
            /// </summary>
            [Required]
            [JsonProperty("hotel_info")]
            public HotelInfoModel HotelInfo { get; set; }
            /// <summary>
            /// 交易来源信息
            /// </summary>
            [JsonProperty("source_info")]
            public SourceInfoModel SourceInfo { get; set; }
            /// <summary>
            /// 订单买家信息
            /// </summary>
            [JsonProperty("buyer_info")]
            public BuyerInfoModel BuyerInfo { get; set; }
            /// <summary>
            /// 标记信息
            /// </summary>
            [JsonProperty("remark_info")]
            public RemarkInfoModel RemarkInfo { get; set; }
            /// <summary>
            /// 电子发票信息
            /// </summary>
            [JsonProperty("invoice_info")]
            public InvoiceInfoModel InvoiceInfo { get; set; }
            /// <summary>
            /// 收款码信息
            /// </summary>
            [Required]
            [JsonProperty("qrcode_info")]
            public QrcodeInfoModel QrcodeInfo { get; set; }
            public class OrdersModel
            {
                /// <summary>
                /// 商品id，有赞生成的商品唯一值。
                /// </summary>
                /// <example>
                /// 500818021
                /// </example>
                [Required]
                [JsonProperty("item_id")]
                public long ItemId { get; set; }
                /// <summary>
                /// 仅订单是价格日历电子卡券或酒店商品类型时返回，酒店商品订单对应客户入住时间，价格日历电子卡券场景是客户游玩时间。时间格式：yyyy-MM-dd
                /// </summary>
                /// <example>
                /// 2021-08-02
                /// </example>
                [Required]
                [JsonProperty("goods_date")]
                public string GoodsDate { get; set; }
                /// <summary>
                /// 跨境商品仓库id（仅限大客使用，标准开发者无需关注）
                /// </summary>
                /// <example>
                /// 0111
                /// </example>
                [Required]
                [JsonProperty("warehouse_code")]
                public string WarehouseCode { get; set; }
                /// <summary>
                /// 商品导购员工编号
                /// </summary>
                /// <example>
                /// ["xiaohua"]
                /// </example>
                [Required]
                [JsonProperty("item_sales_staff")]
                public List<string> ItemSalesStaff { get; set; }
                /// <summary>
                /// 使用youzan.trade.order.out.create.1.0.0导入外部订单时，传入的子订单id。用于将有赞内部生成的子订单与外部导入的子订单关联。未传入时，返回空字符串
                /// </summary>
                /// <example>
                /// 12333343
                /// </example>
                [Required]
                [JsonProperty("outer_oid")]
                public string OuterOid { get; set; }
                /// <summary>
                /// 分销单实付金额 ，单位元
                /// </summary>
                /// <example>
                /// 0.01
                /// </example>
                [JsonProperty("fenxiao_payment")]
                public string FenxiaoPayment { get; set; }
                /// <summary>
                /// 海淘-申报单价（完税价格）,单位：元
                /// </summary>
                /// <example>
                /// 1
                /// </example>
                [JsonProperty("goods_dutiable_price")]
                public string GoodsDutiablePrice { get; set; }
                /// <summary>
                /// 销售方案退款配置
                /// </summary>
                [Required]
                [JsonProperty("sale_plan")]
                public SalePlanModel SalePlan { get; set; }
                /// <summary>
                /// 税费，单位：元
                /// </summary>
                /// <example>
                /// 0.01
                /// </example>
                [JsonProperty("tax_total")]
                public string TaxTotal { get; set; }
                /// <summary>
                /// 是否为预售商品，是：返回为1，否返回为空
                /// </summary>
                /// <example>
                /// 1
                /// </example>
                [JsonProperty("is_pre_sale")]
                public string IsPreSale { get; set; }
                /// <summary>
                /// 商品成本价，单位：元
                /// </summary>
                /// <example>
                /// 1.00
                /// </example>
                [Required]
                [JsonProperty("goods_cost_price")]
                public string GoodsCostPrice { get; set; }
                /// <summary>
                /// 商品留言
                /// </summary>
                /// <example>
                /// {\"我是商品留言\":\"商品留言\"}
                /// </example>
                [JsonProperty("buyer_messages")]
                public string BuyerMessages { get; set; }
                /// <summary>
                /// 单商品原价，单位：元
                /// </summary>
                /// <example>
                /// 1.00
                /// </example>
                [JsonProperty("price")]
                public string Price { get; set; }
                /// <summary>
                /// 商品名称
                /// </summary>
                /// <example>
                /// 测试商品1
                /// </example>
                [JsonProperty("title")]
                public string Title { get; set; }
                /// <summary>
                /// 海淘商品贸易模式，BC直邮：9610，BBC保税进口：1210
                /// </summary>
                /// <example>
                /// 9610
                /// </example>
                [JsonProperty("cross_border_trade_mode")]
                public string CrossBorderTradeMode { get; set; }
                /// <summary>
                /// 运杂费(仅海淘订单有该字段返回)，单位：元
                /// </summary>
                /// <example>
                /// 0.01
                /// </example>
                [JsonProperty("freight")]
                public string Freight { get; set; }
                /// <summary>
                /// 订单明细id
                /// </summary>
                /// <example>
                /// 1539322365320644179
                /// </example>
                [JsonProperty("oid")]
                public string Oid { get; set; }
                /// <summary>
                /// 预售(全款预售或定金预售)商品的发货时间，单位：秒
                /// </summary>
                /// <example>
                /// 1628685895
                /// </example>
                [Required]
                [JsonProperty("expect_delivery_time")]
                public long ExpectDeliveryTime { get; set; }
                /// <summary>
                /// 商品税费模式："1":含税模式、"0":税费分离
                /// </summary>
                /// <example>
                /// "1"
                /// </example>
                [Required]
                [JsonProperty("tariff_rule")]
                public string TariffRule { get; set; }
                /// <summary>
                /// 订单明细应付金额，订单上每个商品最终均摊价，单位：元
                /// </summary>
                /// <example>
                /// 0.80
                /// </example>
                [JsonProperty("payment")]
                public string Payment { get; set; }
                /// <summary>
                /// 分销商品金额,单位：元
                /// </summary>
                /// <example>
                /// 0.5
                /// </example>
                [JsonProperty("fenxiao_discount_price")]
                public string FenxiaoDiscountPrice { get; set; }
                /// <summary>
                /// 网店商品-茶饮烘焙类型商品的商品属性，name为属性名称，value_name为属性值
                /// </summary>
                /// <example>
                /// "[{\"name\":\"温度\",\"value_name\":\"1\"}]"
                /// </example>
                [Required]
                [JsonProperty("item_props")]
                public string ItemProps { get; set; }
                /// <summary>
                /// 是否赠品，是：true，否：false
                /// </summary>
                /// <example>
                /// false
                /// </example>
                [JsonProperty("is_present")]
                public bool? IsPresent { get; set; }
                /// <summary>
                /// 商品快照地址（定制字段，开发者无需使用）
                /// </summary>
                /// <example>
                /// https://h5.youzan.com/wscgoods/detail-snapshot?alias=277t5y458fddz&pageType=wsc-goods-snapshot&kdtId=41981655&orderNo=E20190822173545091700047&goodsId=491613579&snapKey=672f0b3170e5cf87f54c89f8f63035b4&itemId=1535089724457765447
                /// </example>
                [Required]
                [JsonProperty("goods_snapshot")]
                public string GoodsSnapshot { get; set; }
                /// <summary>
                /// 是否是跨境海淘订单，是：返回为1，否返回为空
                /// </summary>
                /// <example>
                /// 1
                /// </example>
                [JsonProperty("is_cross_border")]
                public string IsCrossBorder { get; set; }
                /// <summary>
                /// 分销海淘-商品总货值（完税价格*商品数量），单位：元
                /// </summary>
                /// <example>
                /// 100
                /// </example>
                [JsonProperty("fenxiao_goods_total_dutiable_price")]
                public string FenxiaoGoodsTotalDutiablePrice { get; set; }
                /// <summary>
                /// 商品类型，0:普通商品; 1:拍卖商品; 5:餐饮商品; 10:分销商品; 20:会员卡商品; 21:礼品卡商品; 23:有赞会议商品; 24:周期购; 30:收银台商品; 31:知识付费商品; 35:酒店商品; 40:普通服务类商品; 71:卡项商品;182:普通虚拟商品; 183:电子卡券商品; 201:外部会员卡商品; 202:外部直接收款商品; 203:外部普通商品; 204:外部服务商品;205:mock不存在商品; 206:小程序二维码;207:积分充值商品;208:付费优惠券商品
                /// </summary>
                /// <example>
                /// 0
                /// </example>
                [JsonProperty("item_type")]
                public int? ItemType { get; set; }
                /// <summary>
                /// 商品编码，商家自定义编码，可用于和其他系统之间商品的外部id的标识。
                /// </summary>
                /// <example>
                /// spbm001
                /// </example>
                [JsonProperty("outer_item_id")]
                public string OuterItemId { get; set; }
                /// <summary>
                /// 微商城店铺类型：outer_sku_id 对应的是规格编码；在零售店铺类型场景下outer_sku_id 对应的是规格条码；商品规格编码，sku_id值不为0时：返回商品规格编码；sku_id值为0时：当设置商品编码后且开启多网点功能，返回值为商品编码，否则返回空。
                /// </summary>
                /// <example>
                /// spbm001
                /// </example>
                [JsonProperty("outer_sku_id")]
                public string OuterSkuId { get; set; }
                /// <summary>
                /// 商品总价（扣除商品级优惠） 单位：元
                /// </summary>
                /// <example>
                /// 0.80
                /// </example>
                [JsonProperty("total_fee")]
                public string TotalFee { get; set; }
                /// <summary>
                ///  海淘订单子订单号
                /// </summary>
                /// <example>
                /// E20190313111941080300017SH
                /// </example>
                [JsonProperty("sub_order_no")]
                public string SubOrderNo { get; set; }
                /// <summary>
                /// 商品规格id，有赞生成的规格id。无规格商品返回0
                /// </summary>
                /// <example>
                /// 400818034
                /// </example>
                [Required]
                [JsonProperty("sku_id")]
                public long SkuId { get; set; }
                /// <summary>
                /// 分销税费,单位：元
                /// </summary>
                /// <example>
                /// 0.01
                /// </example>
                [JsonProperty("fenxiao_tax_total")]
                public string FenxiaoTaxTotal { get; set; }
                /// <summary>
                /// 海淘-商品总货值（完税价格*商品数量），单位：元
                /// </summary>
                /// <example>
                /// 10
                /// </example>
                [JsonProperty("goods_total_dutiable_price")]
                public string GoodsTotalDutiablePrice { get; set; }
                /// <summary>
                /// 海淘-虚拟货币优惠金额（积分、优惠券），单位：元
                /// </summary>
                /// <example>
                /// 1.00
                /// </example>
                [JsonProperty("virtual_currency")]
                public string VirtualCurrency { get; set; }
                /// <summary>
                /// 海淘-促销优惠金额（不含虚拟货币优惠金额），单位：元
                /// </summary>
                /// <example>
                /// 0.09
                /// </example>
                [JsonProperty("promotion_discount")]
                public string PromotionDiscount { get; set; }
                /// <summary>
                /// 商品唯一编码
                /// </summary>
                /// <example>
                /// 312321
                /// </example>
                [JsonProperty("sku_unique_code")]
                public string SkuUniqueCode { get; set; }
                /// <summary>
                /// 分销非现金抵扣金额,单位：元
                /// </summary>
                /// <example>
                /// 0.03
                /// </example>
                [JsonProperty("fenxiao_discount")]
                public string FenxiaoDiscount { get; set; }
                /// <summary>
                /// 商品数量
                /// </summary>
                /// <example>
                /// 2
                /// </example>
                [JsonProperty("num")]
                public int? Num { get; set; }
                /// <summary>
                /// 是否为价格日历商品，是：返回为1，否返回为空
                /// </summary>
                /// <example>
                /// 1
                /// </example>
                [Required]
                [JsonProperty("is_price_calendar")]
                public string IsPriceCalendar { get; set; }
                /// <summary>
                /// 商品图片地址
                /// </summary>
                /// <example>
                /// https://img.yzcdn.cn/upload_files/2019/08/30/FiaHY0DewCTyROywOgigS7WaXQBg.jpg
                /// </example>
                [JsonProperty("pic_path")]
                public string PicPath { get; set; }
                /// <summary>
                /// 0 全款预售，1 定金预售
                /// </summary>
                /// <example>
                /// 0
                /// </example>
                [JsonProperty("pre_sale_type")]
                public string PreSaleType { get; set; }
                /// <summary>
                /// 海关编号，更多海关编码请访问：https://doc.youzanyun.com/doc#/content/27031/27100
                /// </summary>
                /// <example>
                /// SH
                /// </example>
                [JsonProperty("customs_code")]
                public string CustomsCode { get; set; }
                /// <summary>
                /// 分销运费,单位：元
                /// </summary>
                /// <example>
                /// 0.01
                /// </example>
                [JsonProperty("fenxiao_freight")]
                public string FenxiaoFreight { get; set; }
                /// <summary>
                /// 商品别名
                /// </summary>
                /// <example>
                /// 26vavj3339p1x
                /// </example>
                [JsonProperty("alias")]
                public string Alias { get; set; }
                /// <summary>
                /// 总部商品id（零售连锁版本特有字段）
                /// </summary>
                /// <example>
                /// 1500818021
                /// </example>
                [Required]
                [JsonProperty("root_item_id")]
                public long RootItemId { get; set; }
                /// <summary>
                /// 商品详情链接
                /// </summary>
                /// <example>
                /// https://h5.youzan.com/v2/showcase/goods?alias=26vavj3339p1x
                /// </example>
                [JsonProperty("goods_url")]
                public string GoodsUrl { get; set; }
                /// <summary>
                /// 单商品现价，减去了商品的优惠金额。单位：元
                /// </summary>
                /// <example>
                /// 5.00
                /// </example>
                [JsonProperty("discount_price")]
                public string DiscountPrice { get; set; }
                /// <summary>
                /// 商品积分价（非积分商品则为0），如返回值是100则表示100积分。
                /// </summary>
                /// <example>
                /// 100
                /// </example>
                [JsonProperty("points_price")]
                public string PointsPrice { get; set; }
                /// <summary>
                /// 商品规格信息（无规格商品为空）
                /// </summary>
                /// <example>
                /// [{\"k\":\"蓝色\",\"k_id\":3,\"v\":\"1号\",\"v_id\":7443}]
                /// </example>
                [JsonProperty("sku_properties_name")]
                public string SkuPropertiesName { get; set; }
                /// <summary>
                /// 商品重量 单位是 g
                /// </summary>
                /// <example>
                /// 1000
                /// </example>
                [JsonProperty("weight")]
                public string Weight { get; set; }
                /// <summary>
                /// 总部商品规格id（零售连锁版本特有字段）
                /// </summary>
                /// <example>
                /// 1400818034
                /// </example>
                [Required]
                [JsonProperty("root_sku_id")]
                public long? RootSkuId { get; set; }
                /// <summary>
                /// 海淘-非现金抵扣金额（元）
                /// </summary>
                /// <example>
                /// 1.00
                /// </example>
                [Required]
                [JsonProperty("haitao_discount")]
                public string HaitaoDiscount { get; set; }
                /// <summary>
                /// 分销单金额 ，单位元
                /// </summary>
                /// <example>
                /// 0.02
                /// </example>
                [JsonProperty("fenxiao_price")]
                public string FenxiaoPrice { get; set; }
                public class SalePlanModel
                {
                    /// <summary>
                    /// 取消策略时间
                    /// </summary>
                    [Required]
                    [JsonProperty("cancel_rule_time")]
                    public CancelRuleTimeModel CancelRuleTime { get; set; }
                    /// <summary>
                    /// 取消策略;0: 默认不支持买家取消（酒店pro老功能）  1：支持卖家取消（酒店pro老功能）  2：一经确认，不可取消修改  3：入住日X天前X点前支持免费取消，后不可修改  4：入住日X天前X点前支持免费取消，后收取违约金
                    /// </summary>
                    /// <example>
                    /// 1
                    /// </example>
                    [Required]
                    [JsonProperty("cancel_rule")]
                    public string CancelRule { get; set; }
                    /// <summary>
                    /// 违约金
                    /// </summary>
                    [Required]
                    [JsonProperty("penalty")]
                    public PenaltyModel Penalty { get; set; }
                    public class CancelRuleTimeModel
                    {
                        /// <summary>
                        /// 在此时间前免费取消
                        /// </summary>
                        /// <example>
                        /// 17:45:00
                        /// </example>
                        [Required]
                        [JsonProperty("before_time")]
                        public string BeforeTime { get; set; }
                        /// <summary>
                        /// 在入住日前X天前免费取消
                        /// </summary>
                        /// <example>
                        /// 1
                        /// </example>
                        [Required]
                        [JsonProperty("before_day")]
                        public string BeforeDay { get; set; }

                    }
                    public class PenaltyModel
                    {
                        /// <summary>
                        /// 违约金比率
                        /// </summary>
                        /// <example>
                        /// 50%
                        /// </example>
                        [Required]
                        [JsonProperty("percent")]
                        public string Percent { get; set; }
                        /// <summary>
                        /// 违约金类型 1：首夜房费 2：全部房费
                        /// </summary>
                        /// <example>
                        /// 1
                        /// </example>
                        [Required]
                        [JsonProperty("type")]
                        public string Type { get; set; }

                    }

                }

            }
            public class PayInfoModel
            {
                /// <summary>
                /// 多阶段支付信息
                /// </summary>
                [JsonProperty("phase_payments")]
                public List<PhasePaymentsModel> PhasePayments { get; set; }
                /// <summary>
                /// 订单整单实付价格  单位：元
                /// </summary>
                /// <example>
                /// "1.00"
                /// </example>
                [JsonProperty("real_payment")]
                public string RealPayment { get; set; }
                /// <summary>
                /// 商品总价，单位元
                /// </summary>
                /// <example>
                /// "1.01"
                /// </example>
                [JsonProperty("total_fee")]
                public string TotalFee { get; set; }
                /// <summary>
                /// 订单整单应付金额，单位：元
                /// </summary>
                /// <example>
                /// "1.01"
                /// </example>
                [JsonProperty("payment")]
                public string Payment { get; set; }
                /// <summary>
                /// 支付流水号（即微信端商户单号）
                /// </summary>
                /// <example>
                /// 190813155336000038
                /// </example>
                [JsonProperty("transaction")]
                public List<string> Transaction { get; set; }
                /// <summary>
                /// 邮费，单位元
                /// </summary>
                /// <example>
                /// "0.00"
                /// </example>
                [JsonProperty("post_fee")]
                public string PostFee { get; set; }
                /// <summary>
                /// 外部订单号（即微信端交易单号）
                /// </summary>
                /// <example>
                /// 4200000381201908138173551027
                /// </example>
                [JsonProperty("outer_transactions")]
                public List<string> OuterTransactions { get; set; }
                /// <summary>
                /// 礼品卡/储值卡抵扣之后的订单实付金额  单位：分
                /// </summary>
                /// <example>
                /// 1
                /// </example>
                [JsonProperty("deduction_real_pay")]
                public long? DeductionRealPay { get; set; }
                /// <summary>
                /// 礼品卡/储值卡具体抵扣的金额，单位：分
                /// </summary>
                /// <example>
                /// 1
                /// </example>
                [JsonProperty("deduction_pay")]
                public long? DeductionPay { get; set; }
                public class PhasePaymentsModel
                {
                    /// <summary>
                    /// 订单支付时间，时间格式为yyyy年-MM月-dd日 HH时:mm分:ss秒
                    /// </summary>
                    /// <example>
                    /// 2020-02-17 12:00:00
                    /// </example>
                    [Required]
                    [JsonProperty("pay_time")]
                    public DateTime PayTime { get; set; }
                    /// <summary>
                    /// 内部支付流水号
                    /// </summary>
                    /// <example>
                    /// 1343214321324423
                    /// </example>
                    [JsonProperty("inner_transaction_no")]
                    public string InnerTransactionNo { get; set; }
                    /// <summary>
                    /// 支付开始时间，时间格式为yyyy年-MM月-dd日 HH时:mm分:ss秒
                    /// </summary>
                    /// <example>
                    /// 2020-02-17 08:00:00
                    /// </example>
                    [JsonProperty("pay_start_time")]
                    public DateTime? PayStartTime { get; set; }
                    /// <summary>
                    /// 支付类型。取值范围： WEIXIN (微信自有支付) WEIXIN_DAIXIAO (微信代销支付) ALIPAY (支付宝支付) BANKCARDPAY (银行卡支付) PEERPAY (代付) CODPAY (货到付款) BAIDUPAY (百度钱包支付) PRESENTTAKE (直接领取赠品) COUPONPAY(优惠券/码全额抵扣) BULKPURCHASE(来自分销商的采购) MERGEDPAY(合并付货款) ECARD(有赞E卡支付) PURCHASE_PAY (采购单支付) MARKPAY (标记收款) OFCASH (现金支付) PREPAIDCARD (储值卡余额支付)ENCHASHMENT_GIFT_CARD(礼品卡支付)
                    /// </summary>
                    /// <example>
                    /// 1
                    /// </example>
                    [JsonProperty("pay_way_str")]
                    public string PayWayStr { get; set; }
                    /// <summary>
                    /// 支付阶段；1表示第一支付阶段，如定金预售的付定金阶段，2表示第二支付阶段，如定金预售的付尾款
                    /// </summary>
                    /// <example>
                    /// 1
                    /// </example>
                    [JsonProperty("phase")]
                    public int? Phase { get; set; }
                    /// <summary>
                    /// 阶段支付应付金额，单位元
                    /// </summary>
                    /// <example>
                    /// ”1.01“
                    /// </example>
                    [JsonProperty("real_price")]
                    public string RealPrice { get; set; }
                    /// <summary>
                    /// 支付结束时间，时间格式为yyyy年-MM月-dd日 HH时:mm分:ss秒
                    /// </summary>
                    /// <example>
                    /// 2020-02-17 12:00:00
                    /// </example>
                    [JsonProperty("pay_end_time")]
                    public DateTime? PayEndTime { get; set; }
                    /// <summary>
                    /// 支付类型说明
                    /// </summary>
                    /// <example>
                    /// 标记付款-支付宝
                    /// </example>
                    [Required]
                    [JsonProperty("pay_way_desc")]
                    public string PayWayDesc { get; set; }
                    /// <summary>
                    /// 外部支付流水号
                    /// </summary>
                    /// <example>
                    /// 12321342331424132
                    /// </example>
                    [JsonProperty("outer_transaction_no")]
                    public string OuterTransactionNo { get; set; }

                }

            }
            public class AddressInfoModel
            {
                /// <summary>
                /// 市
                /// </summary>
                /// <example>
                /// 杭州市
                /// </example>
                [JsonProperty("delivery_city")]
                public string DeliveryCity { get; set; }
                /// <summary>
                /// 到店自提信息 json格式，字段说明请参考：https://developers.youzanyun.com/article/1556781783745
                /// </summary>
                /// <example>
                /// {\"address_detail\":\"文三路与工专路交口西南角\",\"city\":\"杭州市\",\"county\":\"西湖区\",\"id\":58039430,\"is_optional_self_fetch_time\":1,\"is_super_store\":0,\"kdt_id\":42587152,\"lat\":30.281547,\"lon\":120.132598,\"name\":\"黄龙万科\",\"province\":\"浙江省\",\"tel\":\"13700000000\",\"user_name\":\"导演\",\"user_tel\":\"13700000000\",\"user_time\":\"09月18日 08:01-09:01\"}
                /// </example>
                [JsonProperty("self_fetch_info")]
                public string SelfFetchInfo { get; set; }
                /// <summary>
                /// 字段为json格式，需要开发者自行解析 lng、lon（经纬度，百度坐标系）； checkOutTime（酒店退房时间）； recipients（入住人）； checkInTime（酒店入住时间）； idCardNumber（海淘身份证信息）； areaCode（行政编码）
                /// </summary>
                /// <example>
                /// {\"areaCode\":\"330106\",\"lon\":120.13278695112612,\"lat\":30.2811003548167}
                /// </example>
                [JsonProperty("address_extra")]
                public string AddressExtra { get; set; }
                /// <summary>
                /// 同城送预计送达时间-结束时间 非同城送以及没有开启定时达的订单不返回，时间格式为yyyy年-MM月-dd日 HH时:mm分:ss秒
                /// </summary>
                /// <example>
                /// 2019-09-15 01:00:00
                /// </example>
                [JsonProperty("delivery_end_time")]
                public DateTime? DeliveryEndTime { get; set; }
                /// <summary>
                /// 省
                /// </summary>
                /// <example>
                /// 浙江省
                /// </example>
                [JsonProperty("delivery_province")]
                public string DeliveryProvince { get; set; }
                /// <summary>
                /// 收货人姓名
                /// </summary>
                /// <example>
                /// 赞宝
                /// </example>
                [JsonProperty("receiver_name")]
                public string ReceiverName { get; set; }
                /// <summary>
                /// 同城送预计送达时间-开始时间 非同城送以及没有开启定时达的订单不返回，时间格式为yyyy年-MM月-dd日 HH时:mm分:ss秒
                /// </summary>
                /// <example>
                /// 2019-09-15 00:00:00
                /// </example>
                [JsonProperty("delivery_start_time")]
                public DateTime? DeliveryStartTime { get; set; }
                /// <summary>
                /// 收货人手机号
                /// </summary>
                /// <example>
                /// 13700000000
                /// </example>
                [JsonProperty("receiver_tel")]
                public string ReceiverTel { get; set; }
                /// <summary>
                /// 邮政编码，邮政编码，当买家使用微信地址时会有值，其它场景可能没有该值，建议不做强依赖。
                /// </summary>
                /// <example>
                /// 330106
                /// </example>
                [JsonProperty("delivery_postal_code")]
                public string DeliveryPostalCode { get; set; }
                /// <summary>
                /// 详细地址
                /// </summary>
                /// <example>
                /// 翠苑街道黄龙万科中心18楼
                /// </example>
                [JsonProperty("delivery_address")]
                public string DeliveryAddress { get; set; }
                /// <summary>
                /// 区
                /// </summary>
                /// <example>
                /// 西湖区
                /// </example>
                [JsonProperty("delivery_district")]
                public string DeliveryDistrict { get; set; }

            }
            public class OrderInfoModel
            {
                /// <summary>
                /// 订单扩展信息
                /// </summary>
                [JsonProperty("order_extra")]
                public OrderExtraModel OrderExtra { get; set; }
                /// <summary>
                /// 订单打标
                /// </summary>
                [JsonProperty("order_tags")]
                public OrderTagsModel OrderTags { get; set; }
                /// <summary>
                /// 门店编码
                /// </summary>
                /// <example>
                /// offline001
                /// </example>
                [Required]
                [JsonProperty("shop_display_no")]
                public string ShopDisplayNo { get; set; }
                /// <summary>
                /// 配送方式（物流类型）， 0:快递发货; 1:到店自提; 2:同城配送; 9:无需发货（虚拟商品订单）
                /// </summary>
                /// <example>
                /// 1
                /// </example>
                [JsonProperty("express_type")]
                public int? ExpressType { get; set; }
                /// <summary>
                /// 交易完成时间，时间格式为yyyy年-MM月-dd日 HH时:mm分:ss秒
                /// </summary>
                /// <example>
                /// 2019-08-20 17:20:28
                /// </example>
                [JsonProperty("success_time")]
                public DateTime? SuccessTime { get; set; }
                /// <summary>
                /// 店铺名称
                /// </summary>
                /// <example>
                /// 店铺名
                /// </example>
                [Required]
                [JsonProperty("shop_name")]
                public string ShopName { get; set; }
                /// <summary>
                /// 主订单状态描述，和status对应关系。WAIT_BUYER_PAY：待支付，TRADE_PAID：已支付，WAIT_CONFIRM：待接单， WAIT_SELLER_SEND_GOODS：待发货，WAIT_BUYER_CONFIRM_GOODS：已发货，TRADE_SUCCESS：已完成，TRADE_CLOSED：已关闭
                /// </summary>
                /// <example>
                /// 待发货
                /// </example>
                [JsonProperty("status_str")]
                public string StatusStr { get; set; }
                /// <summary>
                /// 主订单状态： WAIT_BUYER_PAY：等待买家付款，定金预售描述：定金待付、等待尾款支付开始、尾款待付， TRADE_PAID：订单已支付 ，该状态仅代表当前订单已支付成功，表示瞬时状态，稍后会自动修改成后面的状态。如果不关心此状态请再次请求详情接口获取下一个状态， WAIT_CONFIRM：待确认，包含待成团、待接单等等。即：买家已付款，等待成团或等待接单， WAIT_SELLER_SEND_GOODS：等待卖家发货，即：买家已付款， WAIT_BUYER_CONFIRM_GOODS 等待买家确认收货，即：卖家已发货， TRADE_SUCCESS：买家已签收以及订单成功， TRADE_CLOSED：交易关闭
                /// </summary>
                /// <example>
                /// WAIT_SELLER_SEND_GOODS
                /// </example>
                [JsonProperty("status")]
                public string Status { get; set; }
                /// <summary>
                /// 有赞订单号，E开头长度24位字母和数字组合
                /// </summary>
                /// <example>
                /// E20190312105415047400001
                /// </example>
                [JsonProperty("tid")]
                public string Tid { get; set; }
                /// <summary>
                /// 单店店铺类型返回当前订单的店铺id，连锁店铺返回网店或门店店铺id
                /// </summary>
                /// <example>
                /// 52323
                /// </example>
                [JsonProperty("node_kdt_id")]
                public long? NodeKdtId { get; set; }
                /// <summary>
                /// 订单创建时间，时间格式为yyyy年-MM月-dd日 HH时:mm分:ss秒
                /// </summary>
                /// <example>
                /// 2019-08-20 10:19:43
                /// </example>
                [JsonProperty("created")]
                public DateTime? Created { get; set; }
                /// <summary>
                /// 是否零售订单，true：是，false：否
                /// </summary>
                /// <example>
                /// false
                /// </example>
                [JsonProperty("is_retail_order")]
                public bool? IsRetailOrder { get; set; }
                /// <summary>
                /// 订单渠道来源；0:有赞内部系统,10:饿了么餐饮系统,20:美团餐饮系统,30:餐道,40:管易,41:宠物家,50:微信小商店,60:伯俊,70:好福兜,80:美创,90:王府井,91:腾讯慧聚,100:CRM 订单导入后不在有赞商城里面展示，也不能对其进行操作，只在CRM里面展示,110:通用三方 适用于大客、ERP等导入，订单导入后会在有赞商城后台展示，商家能够操作发、退款等,120:饿了么餐饮系统"
                /// </summary>
                /// <example>
                /// 41
                /// </example>
                [Required]
                [JsonProperty("channel_type")]
                public int ChannelType { get; set; }
                /// <summary>
                /// 订单退款状态； 0:未退款， 2:部分退款成功，  12:全额退款成功。瞬时状态1:部分退款中，11:全额退款中；当查询接口返回1或11状态时，建议重试查询直到出现0、2、12状态为止
                /// </summary>
                /// <example>
                /// 0
                /// </example>
                [JsonProperty("refund_state")]
                public int? RefundState { get; set; }
                /// <summary>
                /// 单店店铺类型返回当前订单的店铺id，连锁店铺返回总部店铺id
                /// </summary>
                /// <example>
                /// 435462
                /// </example>
                [JsonProperty("root_kdt_id")]
                public long? RootKdtId { get; set; }
                /// <summary>
                /// 订单更新时间，时间格式为yyyy年-MM月-dd日 HH时:mm分:ss秒
                /// </summary>
                /// <example>
                /// 2019-08-20 10:19:52
                /// </example>
                [JsonProperty("update_time")]
                public DateTime? UpdateTime
                { get; set; }
                /// <summary>
                /// 支付类型; 0:默认值,未支付; 1:微信自有支付; 2:支付宝wap; 3:支付宝wap; 5:财付通; 7:代付; 8:联动优势; 9:货到付款; 10:大账号代销; 11:受理模式; 12:百付宝; 13:sdk支付; 14:合并付货款; 15:赠品; 16:优惠兑换; 17:自动付货款; 18:爱学贷; 19:微信wap; 20:微信红包支付; 21:返利; 22:ump红包; 24:易宝支付; 25:储值卡; 27:qq支付; 28:有赞E卡支付; 29:微信条码; 30:支付宝条码; 33:礼品卡支付; 35:会员余额;37:储蓄卡银联支付;40:分期支付;49:先用后付; 53:支付宝花呗分期支付；72:微信扫码二维码支付; 80:待结算&余额支付;90:礼品卡支付;100:代收账户; 300:储值账户; 400:保证金账户; 101:收款码; 102:微信; 103:支付宝; 104:刷卡; 105:二维码台卡; 106:储值卡; 107:有赞E卡; 110:标记收款-自有微信支付; 111:标记收款-自有支付宝; 112:标记收款-自有POS刷卡; 113:通联刷卡支付;114:标记收款-自定义;115:有赞零钱支付;116:优惠全额抵扣;117:商米支付118:商米支付-支付宝;119:商米pos;200:记账账户;201:现金;202:组合支付;203:外部支付;204:汇款支付;205:标记收款-挂账支付;206:对公转账;300:储值账户;400:保证金账户;4093:农行商E付;4095:花呗支付;4096, "支付宝免密支付;4097:支付宝-用户付;4101:银联网银支付;
                /// </summary>
                /// <example>
                /// 10
                /// </example>
                [JsonProperty("pay_type")]
                public int? PayType { get; set; }
                /// <summary>
                /// 多人拼团成功时间（仅限多人拼团使用），其他类型返回为空，时间格式为yyyy年-MM月-dd日 HH时:mm分:ss秒
                /// </summary>
                /// <example>
                /// 2019-08-21 20:09:37
                /// </example>
                [JsonProperty("confirm_time")]
                public DateTime? ConfirmTime { get; set; }
                /// <summary>
                /// 主订单类型；0:普通订单; 1:送礼订单; 2:代付; 3:供货商查询时返回表示为分销供货单。; 4:赠品; 5:心愿单; 6:二维码订单; 7:合并付货款; 8:1分钱实名认证; 9:品鉴; 10:拼团; 15:返利; 35:酒店; 40:外卖; 41:堂食点餐; 46:外卖买单; 51:全员开店; 61:线下收银台订单; 71:美业预约单; 72:美业服务单; 75:知识付费; 81:礼品卡;85：直播带货订单（仅指爱逛平台产生的订单）;89-样品订单;100:批发
                /// </summary>
                /// <example>
                /// 0
                /// </example>
                [JsonProperty("type")]
                public int? Type { get; set; }
                /// <summary>
                /// 订单支付时间，时间格式为yyyy年-MM月-dd日 HH时:mm分:ss秒
                /// </summary>
                /// <example>
                /// 2019-08-20 19:09:37
                /// </example>
                [JsonProperty("pay_time")]
                public DateTime? PayTime { get; set; }
                /// <summary>
                /// 订单关闭类型 0:未关闭; 1:过期关闭; 2:标记退款; 3:订单取消; 4:买家取消; 5:卖家取消; 6:部分退款; 10:无法联系上买家; 11:买家误拍或重拍了; 12:买家无诚意完成交易; 13:已通过银行线下汇款; 14:已通过同城见面交易; 15:已通过货到付款交易; 16:已通过网上银行直接汇款; 17:已经缺货无法交易; 18:扣款失败; 19:0元关单; 20:社区团购活动结束未付款; 21:0元抽奖订单未中一等奖; 22:拒单退款;
                /// </summary>
                /// <example>
                /// 0
                /// </example>
                [JsonProperty("close_type")]
                public int? CloseType { get; set; }
                /// <summary>
                /// 支付渠道。取值范围，DEFAULT-默认值,未支付； WXPAY-微信自有支付； ALIWAP-支付宝wap； ALIPAY-支付宝wap； TENPAY-财付通； PEERPAY-代付； UMPAY-联动优势； CODPAY-货到付款； WXPAY_DAIXIAO-大账号代销； WXPAY_SHOULI-受理模式； BAIDUWAP-百付宝； WX_APPPAY-sdk支付； FX_MERGED-合并付货款； UMP_PRESENT-领取赠品； UMP_COUPON-优惠兑换； FX_SPLITTING-自动付货款； AIXUEDAI-爱学贷； WX_WAPPAY-微信wap； WX_HB-微信红包支付； UMP_REBATE-返利； UMP_HB-ump红包； YZPAY-易宝支付； PREPAID_CARD-储值卡； QQPAY-qq支付； ECARD-有赞E卡支付； BARCODE_WX-微信条码； BARCODE_ALIPAY-支付宝条码； GIFT_CARD-礼品卡支付； UNIFIED_PREPAID_CARD-会员余额； CREDIT_CARD_UNIONPAY-信用卡银联支付”； DEBIT_CARD_UNIONPAY-储蓄卡银联支付； INSTALMENT-分期支付； PRIOR_USE-先用后付； ALIPAY_HBFQ-支付宝花呗分期支付； WX_NATIVE-微信扫码二维码支付； UN_SETTLED_AMOUNT_PAY-待结算&余额支付； ENCHASHMENT_GIFT_CARD-礼品卡支付； OF_ONLINE_ACCOUNT-代收账户； OF_ONLINE_PREPAID_ACCOUNT-储值账户； OF_ONLINE_DEPOSIT_ACCOUNT-保证金账户； OF_YOUZAN_QR-收款码； OF_WEIXIN-微信； OF_ALIPAY-支付宝； OF_POS-刷卡； OF_TABLE_CARD-二维码台卡； OF_PREPAID_CARD-储值卡； OF_E_CARD-有赞E卡； MARK_PAY_WXPAY-标记收款-自有微信支付； MARK_PAY_ALIPAY-标记收款-自有支付宝； MARK_PAY_POS-标记收款-自有POS刷卡； ALLIN_SWIPECARD-通联刷卡支付； MARK_PAY_DIY-标记收款-自定义； CHANGE_PAY-有赞零钱支付； UMP_PAY-优惠全额抵扣； SUNMI_WX-商米支付； SUNMI_ALIPAY-商米支付-支付宝； SUNMI_SWIPECARD-商米pos； OF_OFFLINE_ACCOUNT-记账账户； OF_CASH-现金； MIXED_PAYMENT-组合支付； OUTSIDE_PAYMENT-外部支付； TRANSFER_VOUCHER-汇款支付； MARK_PAY_CREDIT_PAY-标记收款-挂账支付； TRANSFER_TO_PUBLIC-对公转账； ABC_EPAY-农行商E付； ALIPAY_FLOWER-花呗支付； ALIPAY_AGREEMENT-支付宝免密支付； ALIPAY_APPLET-支付宝-用户付； ELECTRONIC_BANK_PAY-银联网银支付；
                /// </summary>
                /// <example>
                /// WEIXIN_DAIXIAO
                /// </example>
                [JsonProperty("pay_type_str")]
                public string PayTypeStr { get; set; }
                /// <summary>
                /// 多网点id，非多网点订单，该字段不返回。
                /// </summary>
                /// <example>
                /// 58826303
                /// </example>
                [JsonProperty("offline_id")]
                public long? OfflineId { get; set; }
                /// <summary>
                /// 订单过期时间（未付款订单关闭时间），时间格式为yyyy年-MM月-dd日 HH时:mm分:ss秒
                /// </summary>
                /// <example>
                /// 2019-08-20 19:09:37
                /// </example>
                [JsonProperty("expired_time")]
                public DateTime? ExpiredTime { get; set; }
                /// <summary>
                /// 订单发货时间（当所有商品发货后才会更新），时间格式为yyyy年-MM月-dd日 HH时:mm分:ss秒
                /// </summary>
                /// <example>
                /// 2019-08-20 20:09:37
                /// </example>
                [JsonProperty("consign_time")]
                public DateTime? ConsignTime { get; set; }
                /// <summary>
                /// 店铺类型 0:微商城; 1:微小店; 2:爱学贷微商城; 3:批发店铺; 4:批发商城; 5:外卖; 6:美业; 7:超级门店; 8:收银; 9:收银加微商城; 10:零售总部; 99:有赞开放平台平台型应用创建的店铺
                /// </summary>
                /// <example>
                /// 0
                /// </example>
                [JsonProperty("team_type")]
                public int? TeamType { get; set; }
                public class OrderExtraModel
                {
                    /// <summary>
                    /// 团购返现最大返现金额，单位：分
                    /// </summary>
                    /// <example>
                    /// 500
                    /// </example>
                    [JsonProperty("tm_cash")]
                    public int? TmCash { get; set; }
                    /// <summary>
                    /// 专属导购
                    /// </summary>
                    [Required]
                    [JsonProperty("service_guide")]
                    public ServiceGuideModel ServiceGuide { get; set; }
                    /// <summary>
                    /// 反面身份证图片
                    /// </summary>
                    /// <example>
                    /// https://img.yzcdn.cn/upload_files/2020/11/21/FneXsf5F897HoaiFQ9D-2.jpg
                    /// </example>
                    [Required]
                    [JsonProperty("id_card_back_photo")]
                    public string IdCardBackPhoto { get; set; }
                    /// <summary>
                    /// 是否来自购物车 是：true 不是：false
                    /// </summary>
                    /// <example>
                    /// false
                    /// </example>
                    [JsonProperty("is_from_cart")]
                    public string IsFromCart { get; set; }
                    /// <summary>
                    /// 订单返现金额，单位：分
                    /// </summary>
                    /// <example>
                    /// 500
                    /// </example>
                    [JsonProperty("cash")]
                    public int? Cash { get; set; }
                    /// <summary>
                    /// 是否父单(分销合并订单) 是：1 其他：null
                    /// </summary>
                    /// <example>
                    /// 1
                    /// </example>
                    [JsonProperty("is_parent_order")]
                    public string IsParentOrder { get; set; }
                    /// <summary>
                    /// 订单来源  DYPOI:抖音POI 
                    /// </summary>
                    /// <example>
                    /// DYPOI
                    /// </example>
                    [Required]
                    [JsonProperty("open_source")]
                    public string OpenSource { get; set; }
                    /// <summary>
                    /// 订单销售导购
                    /// </summary>
                    [Required]
                    [JsonProperty("sales_guide")]
                    public SalesGuideModel SalesGuide { get; set; }
                    /// <summary>
                    /// 收银员id，没有值返回为null
                    /// </summary>
                    /// <example>
                    /// 32325
                    /// </example>
                    [JsonProperty("cashier_id")]
                    public string CashierId { get; set; }
                    /// <summary>
                    /// 下单人昵称
                    /// </summary>
                    /// <example>
                    /// 赞宝
                    /// </example>
                    [JsonProperty("buyer_name")]
                    public string BuyerName { get; set; }
                    /// <summary>
                    /// 是否子单(分销买家订单) 是：1 其他：null
                    /// </summary>
                    /// <example>
                    /// 1
                    /// </example>
                    [JsonProperty("is_sub_order")]
                    public string IsSubOrder { get; set; }
                    /// <summary>
                    /// 虚拟总单号：一次下单发生拆单时，会生成一个虚拟总单号
                    /// </summary>
                    /// <example>
                    /// V20190815220517067000087
                    /// </example>
                    [JsonProperty("orders_combine_id")]
                    public string OrdersCombineId { get; set; }
                    /// <summary>
                    /// 推广渠道；快手: KUAI_SHOU, 虎牙: H_Y, 陌陌: MO_MO, 喜马拉雅： XIMA, 国通星驿星: GTXYX, 酷狗: KUGOU, 映客: YING_KE, LesPark: LES_PARK 
                    /// </summary>
                    /// <example>
                    /// KUAI_SHOU
                    /// </example>
                    [JsonProperty("marketing_order_source")]
                    public string MarketingOrderSource { get; set; }
                    /// <summary>
                    /// 发票抬头
                    /// </summary>
                    /// <example>
                    /// 杭州有赞
                    /// </example>
                    [JsonProperty("invoice_title")]
                    public string InvoiceTitle { get; set; }
                    /// <summary>
                    /// 分销店铺id，当订单是分销供货单时，返回分销店铺的id
                    /// </summary>
                    /// <example>
                    /// 有赞的店
                    /// </example>
                    [JsonProperty("fx_kdt_id")]
                    public string FxKdtId { get; set; }
                    /// <summary>
                    /// 仅返回销售导购信息；ch：渠道，目前默认为offline，多网点id，开启多网点后返回；name：导购昵称；storeKdtId：销售导购所在门店；serviceSalesmanId：专属导购ID；serviceSalesmanKdtId：专属导购所在店铺；serviceSalesmanName：专属导购员名称；返回示例如下： {"ch":"offline","id":"13574500955","name":"小暖","storeKdtId":"42655549","serviceSalesmanId":"13574500956","serviceSalesmanKdtId":"42655549","serviceSalesmanName":"专属导购-1"}
                    /// </summary>
                    /// <example>
                    /// {\"ch\":\"offline\",\"id\":\"13574500955\",\"name\":\"小暖\",\"storeKdtId\":\"42655549\",\"serviceSalesmanId\":\"13574500956\",\"serviceSalesmanKdtId\":\"42655549\",\"serviceSalesmanName\":\"专属导购-1\"}
                    /// </example>
                    [JsonProperty("daogou")]
                    public string Daogou { get; set; }
                    /// <summary>
                    /// 海淘买家身份证号
                    /// </summary>
                    /// <example>
                    /// 341202202008151234
                    /// </example>
                    [JsonProperty("id_card_number")]
                    public string IdCardNumber { get; set; }
                    /// <summary>
                    /// 是否是积分订单：1：是  0：不是
                    /// </summary>
                    /// <example>
                    /// 0
                    /// </example>
                    [JsonProperty("is_points_order")]
                    public string IsPointsOrder { get; set; }
                    /// <summary>
                    /// 订单附加费用信息，使用了附加费用计算扩展点该字段才会返回
                    /// </summary>
                    /// <example>
                    /// “[{\"realPay\":40,\"name\":\"包装费\",\"pay\":40,\"refundable\":true,\"originPay\":40,\"desc\":\"包装费\"}]”
                    /// </example>
                    [Required]
                    [JsonProperty("extra_prices")]
                    public string ExtraPrices { get; set; }
                    /// <summary>
                    /// 分销单外部支付流水号
                    /// </summary>
                    /// <example>
                    /// 190813155336000038
                    /// </example>
                    [JsonProperty("fx_outer_transaction_no")]
                    public string FxOuterTransactionNo { get; set; }
                    /// <summary>
                    /// 仅有赞零售门店会返回，1-表示为预约订单， 为空表示普通订单
                    /// </summary>
                    /// <example>
                    /// 1
                    /// </example>
                    [Required]
                    [JsonProperty("is_reservation_order")]
                    public string IsReservationOrder { get; set; }
                    /// <summary>
                    /// 下单设备号
                    /// </summary>
                    /// <example>
                    /// 5170670
                    /// </example>
                    [JsonProperty("create_device_id")]
                    public string CreateDeviceId { get; set; }
                    /// <summary>
                    /// CHEAT:异常砍价订单；SECKILL_CHEAT:异常秒杀订单;VOUCHER_CHEAT:异常优惠券订单;RISK_CHEAT:异常订单;RISK_ORDER:风险订单;SCALPER_RISK_ORDER:黄牛风险订单;QUOTA_RISK_ORDER:异常限购订单
                    /// </summary>
                    /// <example>
                    /// "CHEAT"
                    /// </example>
                    [Required]
                    [JsonProperty("risk_control_mark")]
                    public string RiskControlMark { get; set; }
                    /// <summary>
                    /// 正面身份证图片
                    /// </summary>
                    /// <example>
                    /// https://img.yzcdn.cn/upload_files/2020/11/21/FneXsf5F897HoaiFQ9D-2.jpg
                    /// </example>
                    [Required]
                    [JsonProperty("id_card_front_photo")]
                    public string IdCardFrontPhoto { get; set; }
                    /// <summary>
                    /// 推广方式；CPS表示分佣推广模式； GMV表示自营模式； directSeller表示分销员模式（异步传输，存在一定延时，一般毫秒级就能拿到结果）
                    /// </summary>
                    /// <example>
                    /// GMV
                    /// </example>
                    [JsonProperty("marketing_channel")]
                    public string MarketingChannel { get; set; }
                    /// <summary>
                    /// 身份证姓名  （订购人的身份证号字段可通过订单详情4.0接口“id_card_number ”获取）
                    /// </summary>
                    /// <example>
                    /// 赞小宝
                    /// </example>
                    [JsonProperty("id_card_name")]
                    public string IdCardName { get; set; }
                    /// <summary>
                    /// 分销订单父单号。分销采购单号，即供货商看到的订单号
                    /// </summary>
                    /// <example>
                    /// E20190815220517067000087
                    /// </example>
                    [JsonProperty("purchase_order_no")]
                    public string PurchaseOrderNo { get; set; }
                    /// <summary>
                    /// 收银员名字，没有值返回为null
                    /// </summary>
                    /// <example>
                    /// 小明
                    /// </example>
                    [JsonProperty("cashier_name")]
                    public string CashierName { get; set; }
                    /// <summary>
                    /// 支付营销信息(使用爱逛津贴订单需要关注) 收单号 : String tradeNo; 优惠金额(总) : Long discountMoney; 优惠入账金额 : Long discountAccountMoney; 业务扩展信息 : Map<String, String> bizExtra; 优惠明细 :List<PayUmpDiscountDetailDTO> detailInfos; 优惠类型 :Long type;  PayUmpDiscountDetailDTO :  优惠金额 :Long discountMoney; 优惠充值类型(0:预充值优惠券 ,1: 免充值优惠券) :Integer chargeType; 优惠名称 :String name; 活动id :String activityId; 活动名 :String activityName; 渠道码 :String channel;(json 格式：[   {     "tradeNo": "收单号 : String",     "discountMoney": "优惠金额(总) : Long",     "discountAccountMoney": "优惠入账金额 : Long",     "bizExtra": {       "WX_FREE_CHARGE": "100"     },     "detailInfos": [       {         "discountMoney": 100,         "chargeType": "优惠充值类型(0:预充值优惠券 ,1: 免充值优惠券)",         "name": "优惠名称 :String",         "activityId": "活动id :String",         "activityName": "活动名 :String",         "channel": "渠道码 :String"       }     ],     "type": "优惠类型 :Long"   } ])
                    /// </summary>
                    /// <example>
                    /// [{\"tradeNo\":\"1911271505020000049\",\"discountMoney\":100,\"discountAccountMoney\":0,\"bizExtra\":{\"WX_FREE_CHARGE\":\"100\"},\"detailInfos\":[{\"discountMoney\":100,\"chargeType\":1,\"name\":\"WX_FREE_CHARGE\",\"activityId\":\"0\",\"activityName\":\"微信支付立减金(免充值)\",\"channel\":\"\"}],\"type\":4}]
                    /// </example>
                    [JsonProperty("pay_ump_detail")]
                    public string PayUmpDetail { get; set; }
                    /// <summary>
                    /// 分销单内部支付流水号
                    /// </summary>
                    /// <example>
                    /// 190813155336000038
                    /// </example>
                    [JsonProperty("fx_inner_transaction_no")]
                    public string FxInnerTransactionNo { get; set; }
                    /// <summary>
                    /// 分销单订单号，即买家订单
                    /// </summary>
                    /// <example>
                    /// E20190820094520057400012
                    /// </example>
                    [JsonProperty("fx_order_no")]
                    public string FxOrderNo { get; set; }
                    /// <summary>
                    /// 订单销售员
                    /// </summary>
                    [Required]
                    [JsonProperty("salesman")]
                    public SalesmanModel Salesman { get; set; }
                    /// <summary>
                    /// 美业分店id
                    /// </summary>
                    /// <example>
                    /// 323553
                    /// </example>
                    [JsonProperty("dept_id")]
                    public string DeptId { get; set; }
                    /// <summary>
                    /// 拆单时店铺维度的虚拟总单号：发生拆单时，单个店铺生成了多笔订单会生成一个店铺维度的虚拟总单号
                    /// </summary>
                    /// <example>
                    /// V20190815220517067000087
                    /// </example>
                    [JsonProperty("kdt_dimension_combine_id")]
                    public string KdtDimensionCombineId { get; set; }
                    /// <summary>
                    /// 酒店订单类型 1-日历房订单 2-预约单 3-预售单
                    /// </summary>
                    /// <example>
                    /// 1
                    /// </example>
                    [Required]
                    [JsonProperty("hotel_order_type")]
                    public string HotelOrderType { get; set; }
                    /// <summary>
                    /// 使用了同一张优惠券&优惠码的多笔订单对应的虚拟总单号
                    /// </summary>
                    /// <example>
                    /// V20190815220517067000087
                    /// </example>
                    [JsonProperty("promotion_combine_id")]
                    public string PromotionCombineId { get; set; }
                    /// <summary>
                    /// 团购返现实际返现金额,单位：分
                    /// </summary>
                    /// <example>
                    /// 600
                    /// </example>
                    [JsonProperty("t_cash")]
                    public int? TCash { get; set; }
                    public class ServiceGuideModel
                    {
                        /// <summary>
                        /// 导购名称
                        /// </summary>
                        /// <example>
                        /// 小花
                        /// </example>
                        [Required]
                        [JsonProperty("service_guide_name")]
                        public string ServiceGuideName { get; set; }
                        /// <summary>
                        /// 导购所在门店编码
                        /// </summary>
                        /// <example>
                        /// offline001
                        /// </example>
                        [Required]
                        [JsonProperty("service_guide_shop_no")]
                        public string ServiceGuideShopNo { get; set; }
                        /// <summary>
                        /// 导购员工编码
                        /// </summary>
                        /// <example>
                        /// ["xiaohua"]
                        /// </example>
                        [Required]
                        [JsonProperty("service_guide_staff")]
                        public string ServiceGuideStaff { get; set; }

                    }
                    public class SalesGuideModel
                    {
                        /// <summary>
                        /// 订单销售导购所在门店编码
                        /// </summary>
                        /// <example>
                        /// offline001
                        /// </example>
                        [Required]
                        [JsonProperty("order_sales_shop_no")]
                        public string OrderSalesShopNo { get; set; }
                        /// <summary>
                        /// 导购员工编码
                        /// </summary>
                        /// <example>
                        /// xiaohua
                        /// </example>
                        [Required]
                        [JsonProperty("order_sales_staff")]
                        public string OrderSalesStaff { get; set; }
                        /// <summary>
                        /// 导购名称
                        /// </summary>
                        /// <example>
                        /// 小花
                        /// </example>
                        [Required]
                        [JsonProperty("order_sales_name")]
                        public string OrderSalesName { get; set; }

                    }
                    public class SalesmanModel
                    {
                        /// <summary>
                        /// 销售员昵称
                        /// </summary>
                        /// <example>
                        /// 小张
                        /// </example>
                        [Required]
                        [JsonProperty("salesman_nick_name")]
                        public string SalesmanNickName { get; set; }
                        /// <summary>
                        /// 销售员手机号码
                        /// </summary>
                        /// <example>
                        /// 13133333333
                        /// </example>
                        [Required]
                        [JsonProperty("salesman_mobile")]
                        public string SalesmanMobile { get; set; }

                    }

                }
                public class OrderTagsModel
                {
                    /// <summary>
                    /// 是否支付
                    /// </summary>
                    /// <example>
                    /// true
                    /// </example>
                    [JsonProperty("is_payed")]
                    public bool? IsPayed { get; set; }
                    /// <summary>
                    /// 是否结算
                    /// </summary>
                    /// <example>
                    /// true
                    /// </example>
                    [JsonProperty("is_settle")]
                    public bool? IsSettle { get; set; }
                    /// <summary>
                    /// 是否担保交易
                    /// </summary>
                    /// <example>
                    /// true
                    /// </example>
                    [JsonProperty("is_secured_transactions")]
                    public bool? IsSecuredTransactions { get; set; }
                    /// <summary>
                    /// 是否采购单
                    /// </summary>
                    /// <example>
                    /// true
                    /// </example>
                    [JsonProperty("is_purchase_order")]
                    public bool? IsPurchaseOrder { get; set; }
                    /// <summary>
                    /// 是否分销单
                    /// </summary>
                    /// <example>
                    /// true
                    /// </example>
                    [JsonProperty("is_fenxiao_order")]
                    public bool? IsFenxiaoOrder { get; set; }
                    /// <summary>
                    /// 是否多门店订单
                    /// </summary>
                    /// <example>
                    /// true
                    /// </example>
                    [JsonProperty("is_multi_store")]
                    public bool? IsMultiStore { get; set; }
                    /// <summary>
                    /// 是否虚拟订单。true：是，false：否。
                    /// </summary>
                    /// <example>
                    /// true
                    /// </example>
                    [JsonProperty("is_virtual")]
                    public bool? IsVirtual { get; set; }
                    /// <summary>
                    /// 是否有维权
                    /// </summary>
                    /// <example>
                    /// true
                    /// </example>
                    [JsonProperty("is_feedback")]
                    public bool? IsFeedback { get; set; }
                    /// <summary>
                    /// 是否定金预售
                    /// </summary>
                    /// <example>
                    /// true
                    /// </example>
                    [JsonProperty("is_down_payment_pre")]
                    public bool? IsDownPaymentPre { get; set; }
                    /// <summary>
                    /// 是否会员订单
                    /// </summary>
                    /// <example>
                    /// true
                    /// </example>
                    [JsonProperty("is_member")]
                    public bool? IsMember { get; set; }
                    /// <summary>
                    /// 是否线下订单
                    /// </summary>
                    /// <example>
                    /// true
                    /// </example>
                    [JsonProperty("is_offline_order")]
                    public bool? IsOfflineOrder { get; set; }
                    /// <summary>
                    /// 是否享受免邮
                    /// </summary>
                    /// <example>
                    /// true
                    /// </example>
                    [JsonProperty("is_postage_free")]
                    public bool? IsPostageFree { get; set; }
                    /// <summary>
                    /// 是否有退款
                    /// </summary>
                    /// <example>
                    /// true
                    /// </example>
                    [JsonProperty("is_refund")]
                    public bool? IsRefund { get; set; }

                }

            }
            public class ChildInfoModel
            {
                /// <summary>
                /// 子单详情
                /// </summary>
                [JsonProperty("child_orders")]
                public List<ChildOrdersModel> ChildOrders { get; set; }
                /// <summary>
                /// 送礼编号
                /// </summary>
                /// <example>
                /// 20190912164813535039
                /// </example>
                [JsonProperty("gift_no")]
                public string GiftNo { get; set; }
                /// <summary>
                /// 送礼标记
                /// </summary>
                /// <example>
                /// a3d87223
                /// </example>
                [JsonProperty("gift_sign")]
                public string GiftSign { get; set; }
                public class ChildOrdersModel
                {
                    /// <summary>
                    /// 收货地址详情
                    /// </summary>
                    /// <example>
                    /// 星星SPA时雨巷北侧40米 益展商务大厦
                    /// </example>
                    [JsonProperty("address_detail")]
                    public string AddressDetail { get; set; }
                    /// <summary>
                    /// 区
                    /// </summary>
                    /// <example>
                    /// 西湖区
                    /// </example>
                    [JsonProperty("county")]
                    public string County { get; set; }
                    /// <summary>
                    /// 领取人电话
                    /// </summary>
                    /// <example>
                    /// 18300000000
                    /// </example>
                    [JsonProperty("user_tel")]
                    public string UserTel { get; set; }
                    /// <summary>
                    /// 市
                    /// </summary>
                    /// <example>
                    /// 杭州市
                    /// </example>
                    [JsonProperty("city")]
                    public string City { get; set; }
                    /// <summary>
                    /// 子订单编号
                    /// </summary>
                    /// <example>
                    /// C20190729143007187567
                    /// </example>
                    [JsonProperty("tid")]
                    public string Tid { get; set; }
                    /// <summary>
                    /// 领取人姓名
                    /// </summary>
                    /// <example>
                    /// 小明
                    /// </example>
                    [JsonProperty("user_name")]
                    public string UserName { get; set; }
                    /// <summary>
                    /// 省
                    /// </summary>
                    /// <example>
                    /// 浙江省
                    /// </example>
                    [JsonProperty("province")]
                    public string Province { get; set; }
                    /// <summary>
                    /// 老送礼订单状态：WAIT_EXPRESS(5, "待发货"), EXPRESS(6, "已发货"), SUCCESS(100, "成功")
                    /// </summary>
                    /// <example>
                    /// 5
                    /// </example>
                    [JsonProperty("order_state")]
                    public string OrderState { get; set; }

                }

            }
            public class HotelInfoModel
            {
                /// <summary>
                /// 销售方案id
                /// </summary>
                /// <example>
                /// 561
                /// </example>
                [Required]
                [JsonProperty("sell_case_id")]
                public long SellCaseId { get; set; }

            }
            public class SourceInfoModel
            {
                /// <summary>
                /// 是否来自线下订单
                /// </summary>
                /// <example>
                /// true
                /// </example>
                [JsonProperty("is_offline_order")]
                public bool? IsOfflineOrder { get; set; }
                /// <summary>
                /// 订单唯一识别码
                /// </summary>
                /// <example>
                /// 7fb60857-07df-40b5-be21-0a1d1f5947d8
                /// </example>
                [JsonProperty("book_key")]
                public string BookKey { get; set; }
                /// <summary>
                /// 订单来源平台 wx:微信，merchant_3rd:商家自有app, buyer_v:买家版, browser:系统浏览器, alipay:支付宝,qq:腾讯QQ, wb:微博, other:其他
                /// </summary>
                [JsonProperty("source")]
                public SourceModel Source { get; set; }
                /// <summary>
                /// 订单标记 wx_apps:微信小程序买家版 wx_shop:微信小程序商家版 wx_wm:微信小程序外卖 wap_wm:移动端外卖 super_store:超级门店 weapp_spotlight:新微信小程序买家版 wx_meiye:美业小程序 wx_apps_maidan:小程序餐饮买单 wx_apps_diancan:小程序堂食 weapp_youzan:有赞小程序 retail_free_buy:零售自由购 weapp_owl:知识付费小程序 app_spotlight:有赞精选app retail_scan_buy:零售扫码购 weapp_plugin:小程序插件 eleme:饿了么 meituan:美团;alipay_mini_program-支付宝-商家小程序;   除以上之外为其他
                /// </summary>
                /// <example>
                /// wx_apps
                /// </example>
                [JsonProperty("order_mark")]
                public string OrderMark { get; set; }
                /// <summary>
                /// 活动类型：社群团购：”mall_group_buy“
                /// </summary>
                /// <example>
                /// mall_group_buy
                /// </example>
                [JsonProperty("biz_source")]
                public string BizSource { get; set; }
                public class SourceModel
                {
                    /// <summary>
                    /// wx_gzh:微信公众号; merchant_xcx:商家小程序 表示订单来自微信的商家小程序 yzdh_xcx:有赞大号小程序 表示订单来自微信的有赞精选 direct_buy:直接购买 表示除了以上两种之外的其他微信来源，比如微信网页等； 注意：yzdh:有赞大号规则已经废弃
                    /// </summary>
                    /// <example>
                    /// direct_buy
                    /// </example>
                    [JsonProperty("wx_entrance")]
                    public string WxEntrance { get; set; }
                    /// <summary>
                    /// 平台枚举。wx：微信"，merchant_3rd：商家自有app，buyer_v：买家版，browser：系统浏览器，alipay：支付宝，alipay_mini_program：支付宝小程序，qq：腾讯QQ，wb：微博，bd：百度，bankabc：农行掌银App，dy：T项目，other：其他
                    /// </summary>
                    /// <example>
                    /// wx
                    /// </example>
                    [JsonProperty("platform")]
                    public string Platform { get; set; }

                }

            }
            public class BuyerInfoModel
            {
                /// <summary>
                /// 买家在有赞的唯一id，即客户id
                /// </summary>
                /// <example>
                /// LnhGm4rh576452722916618240
                /// </example>
                [JsonProperty("yz_open_id")]
                public string YzOpenId { get; set; }
                /// <summary>
                /// 微信H5和微信小程序（有赞小程序和小程序插件）的订单会返回微信weixin_openid，三方App（有赞APP开店）的订单会返回open_user_id，2019年1月30号后的订单支持返回该参数
                /// </summary>
                /// <example>
                /// oHIuujmVb-Rl-jrGsrSqSNPTAP-A
                /// </example>
                [JsonProperty("outer_user_id")]
                public string OuterUserId { get; set; }
                /// <summary>
                /// 买家手机号，买家在个人中心绑定手机号才会返回。否则为空。
                /// </summary>
                /// <example>
                /// 13700000000
                /// </example>
                [JsonProperty("buyer_phone")]
                public string BuyerPhone { get; set; }
                /// <summary>
                /// 【已废弃，推荐使用yz_open_id字段，使用youzan.users.info.query接口买家信息查询有赞粉丝id，有赞自动生成。
                /// </summary>
                /// <example>
                /// 3303656575
                /// </example>
                [JsonProperty("fans_id")]
                public long? FansId { get; set; }
                /// <summary>
                /// 【已废弃，推荐使用yz_open_id字段，使用youzan.users.info.query接口买家信息查询粉丝类型， 1:自有粉丝（商家店铺后台绑定的公众号粉丝），9:代销粉丝（有赞大账号粉丝）
                /// </summary>
                /// <example>
                /// 9
                /// </example>
                [JsonProperty("fans_type")]
                public int? FansType { get; set; }
                /// <summary>
                /// 【已废弃，推荐使用yz_open_id字段，使用youzan.users.info.query接口买家信息查询粉丝昵称
                /// </summary>
                /// <example>
                /// 赞宝
                /// </example>
                [JsonProperty("fans_nickname")]
                public string FansNickname { get; set; }

            }
            public class RemarkInfoModel
            {
                /// <summary>
                /// 订单卖家备注
                /// </summary>
                /// <example>
                /// 1级客户
                /// </example>
                [JsonProperty("trade_memo")]
                public string TradeMemo { get; set; }
                /// <summary>
                /// 订单标星等级： 0~5分别表示不同星级。
                /// </summary>
                /// <example>
                /// 3
                /// </example>
                [JsonProperty("star")]
                public int? Star { get; set; }
                /// <summary>
                /// 订单买家留言
                /// </summary>
                /// <example>
                /// 我是卖家留言
                /// </example>
                [JsonProperty("buyer_message")]
                public string BuyerMessage { get; set; }

            }
            public class InvoiceInfoModel
            {
                /// <summary>
                /// 买家税号
                /// </summary>
                /// <example>
                /// 91310116607310355U
                /// </example>
                [JsonProperty("taxpayer_id")]
                public string TaxpayerId { get; set; }
                /// <summary>
                /// 抬头类型:personal 个人,enterprise 企业
                /// </summary>
                /// <example>
                /// personal
                /// </example>
                [JsonProperty("raise_type")]
                public string RaiseType { get; set; }
                /// <summary>
                /// 抬头
                /// </summary>
                /// <example>
                /// 杭州有赞
                /// </example>
                [JsonProperty("user_name")]
                public string UserName { get; set; }
                /// <summary>
                /// 发票详情类型:itemCategory 商品类别,itemDetail 商品明细
                /// </summary>
                /// <example>
                /// itemCategory
                /// </example>
                [JsonProperty("invoice_detail_type")]
                public string InvoiceDetailType { get; set; }
                /// <summary>
                /// 买家邮箱
                /// </summary>
                /// <example>
                /// 123@gmai.com
                /// </example>
                [JsonProperty("email")]
                public string Email { get; set; }

            }
            public class QrcodeInfoModel
            {
                /// <summary>
                /// 二维码标识id
                /// </summary>
                /// <example>
                /// 5420212
                /// </example>
                [Required]
                [JsonProperty("qrcode_id")]
                public long QrcodeId { get; set; }
                /// <summary>
                /// 收款码名称
                /// </summary>
                /// <example>
                /// 有赞官方收款
                /// </example>
                [Required]
                [JsonProperty("qrcode_name")]
                public string QrcodeName { get; set; }
                /// <summary>
                /// 二维码支付标识id
                /// </summary>
                /// <example>
                /// 41788306
                /// </example>
                [Required]
                [JsonProperty("qrcode_pay_id")]
                public long QrcodePayId { get; set; }

            }

        }
        public class DeliveryOrderModel
        {
            /// <summary>
            /// 物流状态 0:待发货; 1:已发货
            /// </summary>
            /// <example>
            /// 0
            /// </example>
            [JsonProperty("express_state")]
            public int? ExpressState { get; set; }
            /// <summary>
            /// 包裹信息
            /// </summary>
            [JsonProperty("dists")]
            public List<DistsModel> Dists { get; set; }
            /// <summary>
            /// 发货方式。 0:手动发货（商城后台人工发货），1:接口发货（有赞云发货API发货）
            /// </summary>
            /// <example>
            /// 1
            /// </example>
            [JsonProperty("express_type")]
            public int? ExpressType { get; set; }
            /// <summary>
            /// 发货明细
            /// </summary>
            [JsonProperty("oids")]
            public List<OidsModel> Oids { get; set; }
            public class DistsModel
            {
                /// <summary>
                /// 包裹详情
                /// </summary>
                [JsonProperty("express_info")]
                public ExpressInfoModel ExpressInfo { get; set; }
                /// <summary>
                /// 包裹id，由物流生成，用于唯一标识包裹
                /// </summary>
                /// <example>
                /// 201909091810000000220803
                /// </example>
                [JsonProperty("dist_id")]
                public string DistId { get; set; }
                /// <summary>
                /// 包裹中的商品列表
                /// </summary>
                [JsonProperty("dist_items")]
                public List<DistItemsModel> DistItems { get; set; }
                public class ExpressInfoModel
                {
                    /// <summary>
                    /// 快递单号
                    /// </summary>
                    /// <example>
                    /// 12132324123435
                    /// </example>
                    [JsonProperty("express_no")]
                    public string ExpressNo { get; set; }
                    /// <summary>
                    /// 物流公司编号，详情请参考该链接（https://developers.youzanyun.com/article/1556781458693）
                    /// </summary>
                    /// <example>
                    /// 1
                    /// </example>
                    [JsonProperty("express_id")]
                    public int? ExpressId { get; set; }

                }
                public class DistItemsModel
                {
                    /// <summary>
                    /// 交易明细id
                    /// </summary>
                    /// <example>
                    /// 1533766114261606211
                    /// </example>
                    [JsonProperty("oid")]
                    public string Oid { get; set; }

                }

            }
            public class OidsModel
            {
                /// <summary>
                /// 交易明细id
                /// </summary>
                /// <example>
                /// 1533766114261606211
                /// </example>
                [JsonProperty("oid")]
                public string Oid { get; set; }

            }

        }
        public class OrderPromotionModel
        {
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("order_paid_promotion")]
            public List<OrderPaidPromotionModel> OrderPaidPromotion { get; set; }
            /// <summary>
            /// 商品级优惠明细
            /// </summary>
            [JsonProperty("item")]
            public List<ItemModel> Item { get; set; }
            /// <summary>
            /// 订单级优惠明细
            /// </summary>
            [JsonProperty("order")]
            public List<OrderModel> Order { get; set; }
            /// <summary>
            /// 订单级优惠总金额，单位：元
            /// </summary>
            /// <example>
            /// 1
            /// </example>
            [JsonProperty("order_discount_fee")]
            public string OrderDiscountFee { get; set; }
            /// <summary>
            /// 商品级优惠总金额，单位：元
            /// </summary>
            /// <example>
            /// 1.8
            /// </example>
            [JsonProperty("item_discount_fee")]
            public string ItemDiscountFee { get; set; }
            /// <summary>
            /// 订单改价金额，单位：元。带“-”负数表示涨价金额，不带“-”表示减价金额。例如：返回值：-0.01-表示涨价0.01元，0.01-表示减价0.01元。
            /// </summary>
            /// <example>
            /// 0.01
            /// </example>
            [JsonProperty("adjust_fee")]
            public string AdjustFee { get; set; }
            public class ItemModel
            {
                /// <summary>
                /// 规格id，有赞生成的商品规格唯一id
                /// </summary>
                /// <example>
                /// 36356847
                /// </example>
                [JsonProperty("sku_id")]
                public long? SkuId { get; set; }
                /// <summary>
                /// 是否是赠品，false：不是，true：是
                /// </summary>
                /// <example>
                /// false
                /// </example>
                [JsonProperty("is_present")]
                public bool? IsPresent { get; set; }
                /// <summary>
                /// 交易明细id
                /// </summary>
                /// <example>
                /// 1534740285858791064
                /// </example>
                [JsonProperty("oid")]
                public string Oid { get; set; }
                /// <summary>
                /// 商品级优惠明细结构体
                /// </summary>
                [JsonProperty("promotions")]
                public List<PromotionsModel> Promotions { get; set; }
                /// <summary>
                /// 商品id，有赞生成的商品唯一id
                /// </summary>
                /// <example>
                /// 495112276
                /// </example>
                [JsonProperty("item_id")]
                public long? ItemId { get; set; }
                public class PromotionsModel
                {
                    /// <summary>
                    /// 活动类型: none:无优惠;tuan:团购返现;auction:降价拍;groupOn:多人拼团;pointsExchange:积分兑换;seckill:秒杀;packageBuy:优惠套餐;presentExchange:赠品领取;goodsScan:商品扫码;customerDiscount:会员折扣;timelimitedDiscount:限时折扣;paidPromotion:支付有礼;periodBuy:周期购;scanReduce:收款码优惠;sellerDiscount:分销商等级折扣;supplierTimeLimitedDiscount:供货商限时折扣;shareCut:享立减;fCode:F码;helpCut:助力砍价;recommendGift:推荐有礼（老带新）;luckyDrawGroup:抽奖拼团;plusBuy:加价购;plusBuyGoods:加价购换购商品;ladderGroupOn:阶梯拼团;multiGoodsGroupOn:多商品伙拼团;meetReduce:满减送;cashBack:订单返现;supplierMeetReduce:供货商满包邮;bale:打包一口价;coupon:优惠卡券;entireDiscount:整单优惠;groupOnHeaderDiscount:团长优惠;customerPostageFree:会员包邮;periodBuyPostageFree:周期购包邮;ignoreOddChange:抹零;operation:订单改价;carriageDiscount:同城送运费优惠;postFree:快递包邮工具;depositExpansion:定金膨胀;secondHalfDiscount:第2件半价;helpDepositExpansion:助力定金膨胀;fansBenefit:让利涨粉;pfGuideMarketing:引导促销;cashbackPro:订单返现Pro;luckyDrawCode:0元抽奖码;inSourcingFission:内购裂变;knowLedgeMjs:知识付费买赠;pointDeduction:积分抵现;guangCoin-爱逛币抵现
                    /// </summary>
                    /// <example>
                    /// pointsExchange
                    /// </example>
                    [JsonProperty("promotion_type")]
                    public string PromotionType { get; set; }
                    /// <summary>
                    /// 优惠别名
                    /// </summary>
                    /// <example>
                    /// 积分兑换
                    /// </example>
                    [JsonProperty("promotion_title")]
                    public string PromotionTitle { get; set; }
                    /// <summary>
                    /// 会员卡号，如果订单使用了权益卡优惠
                    /// </summary>
                    /// <example>
                    /// 3831165825
                    /// </example>
                    [JsonProperty("card_no")]
                    public string CardNo { get; set; }
                    /// <summary>
                    /// 优惠券/码编号
                    /// </summary>
                    /// <example>
                    /// 2592102628
                    /// </example>
                    [JsonProperty("coupon_id")]
                    public string CouponId { get; set; }
                    /// <summary>
                    /// 优惠子类型， card:优惠券 code:优惠码thirdparty:三方券
                    /// </summary>
                    /// <example>
                    /// card
                    /// </example>
                    [JsonProperty("sub_promotion_type")]
                    public string SubPromotionType { get; set; }
                    /// <summary>
                    /// 优惠类型描述
                    /// </summary>
                    /// <example>
                    /// 积分兑换
                    /// </example>
                    [JsonProperty("promotion_type_name")]
                    public string PromotionTypeName { get; set; }
                    /// <summary>
                    /// 优惠id,即商家端店铺后台该优惠活动id。
                    /// </summary>
                    /// <example>
                    /// 6138916
                    /// </example>
                    [JsonProperty("promotion_id")]
                    public long? PromotionId { get; set; }
                    /// <summary>
                    /// 优惠金额，单位：元
                    /// </summary>
                    /// <example>
                    /// 0.1
                    /// </example>
                    [JsonProperty("discount_fee")]
                    public string DiscountFee { get; set; }
                    /// <summary>
                    /// 活动类型id；1-无优惠；2-团购返现；3-降价拍；4-多人拼团；5-积分兑换；6-秒杀；7-优惠套餐；8-赠品领取；9-商品扫码；10-会员折扣；11-限时折扣；12-支付有礼；13-周期购，16-收款码优惠；17-分销商等级折扣；18-供货商限时折扣；19-享立减；20-F码；21-助力砍价；22-推荐有礼（老带新)；23-抽奖拼团；24-加价购；25-加价购换购商品；26-阶梯拼团；27-多商品伙拼团；28-新品发售；29-秒杀问题；30-推荐办卡（展示卡）；101-满减送； 102-订单返现；103-供货商满包邮；104-打包一口价；105-优惠卡券；106-整单优惠；107-团长优惠；108-会员包邮；109-周期购包邮；110-抹零；111-订单改价；112-同城送运费优惠；113-快递包邮工具；114-定金膨胀；115-第2件半价；116-助力定金膨胀；118-让利涨粉；119-企业微信让利涨粉；201-引导促销；203-订单返现Pro；204-0元抽奖码；205-内购裂变；206-分享有礼；207-优惠套餐搭配主商品（仅商品选择组件用）；208-组合套餐；209-限时佣金；210-定向佣金；211-平台优惠券；225-知识付费买赠；256-积分抵现；257-集点卡；258-集点兑换物品；259-攒学费；260-导购扫码；301-主图水印；302-电子发票；401-盲盒获取；402-盲盒核销；403-限时秒杀；501-公众号海报；502-好友助力；503-社群接龙；504-预付卡；505-SKU级预付卡；506-储值专享折扣；507-会员场景营销；508-社群接龙；509-限时到店优惠；510-发红包；511-红包优惠；513-平台补贴；514-普惠秒杀；601-兑换券；10000-发券宝(裂变优惠券)；10001-刮刮卡；10002-疯狂猜；10003-生肖翻翻看；10004-幸运大抽奖；10005-摇一摇；10006-好友瓜分券；10007-发券宝(新客进店有礼)；10008-发券宝(老客进店有礼)；10008-发券宝(老客进店有礼)；10020-投票调查；
                    /// </summary>
                    /// <example>
                    /// 5
                    /// </example>
                    [JsonProperty("promotion_type_id")]
                    public int? PromotionTypeId { get; set; }
                    /// <summary>
                    /// 优惠别名；无实际意义，仅用于区分优惠券。
                    /// </summary>
                    /// <example>
                    /// vpfpfadx
                    /// </example>
                    [JsonProperty("promotion_alias")]
                    public string PromotionAlias { get; set; }
                    /// <summary>
                    /// 优惠描述
                    /// </summary>
                    /// <example>
                    /// 无门槛,减5
                    /// </example>
                    [JsonProperty("promotion_condition")]
                    public string PromotionCondition { get; set; }
                    /// <summary>
                    /// 优惠活动别名
                    /// </summary>
                    /// <example>
                    /// 优惠卡券
                    /// </example>
                    [JsonProperty("promotion_content")]
                    public string PromotionContent { get; set; }

                }

            }
            public class OrderModel
            {
                /// <summary>
                /// 优惠别名；有实际含义，如积分兑换就表示该优惠是积分兑换。
                /// </summary>
                /// <example>
                /// 积分兑换
                /// </example>
                [JsonProperty("promotion_title")]
                public string PromotionTitle { get; set; }
                /// <summary>
                /// 优惠金额，单位：元
                /// </summary>
                /// <example>
                /// 0.1
                /// </example>
                [JsonProperty("discount_fee")]
                public string DiscountFee { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("item_info")]
                public List<ItemInfoModel> ItemInfo { get; set; }

                public class ItemInfoModel
                {
                    /// <summary>
                    /// 优惠金额，表示这个oid对应的商品，在该订单级优惠下享受的优惠；单位：元
                    /// </summary>
                    [JsonProperty("discount_fee")]
                    public string discount_fee { get; set; }

                    /// <summary>
                    /// 交易明细id
                    /// </summary>
                    [JsonProperty("oid")]
                    public string OId { get; set; }
                }


                /// <summary>
                /// 优惠类型描述
                /// </summary>
                /// <example>
                /// 积分兑换
                /// </example>
                [JsonProperty("promotion_type_name")]
                public string PromotionTypeName { get; set; }
                /// <summary>
                /// 优惠子类型， card:优惠券 code:优惠码thirdparty:三方券
                /// </summary>
                /// <example>
                /// code
                /// </example>
                [JsonProperty("sub_promotion_type")]
                public string SubPromotionType { get; set; }
                /// <summary>
                /// 活动类型: none:无优惠;tuan:团购返现;auction:降价拍;groupOn:多人拼团;pointsExchange:积分兑换;seckill:秒杀;packageBuy:优惠套餐;presentExchange:赠品领取;goodsScan:商品扫码;customerDiscount:会员折扣;timelimitedDiscount:限时折扣;paidPromotion:支付有礼;periodBuy:周期购;scanReduce:收款码优惠;sellerDiscount:分销商等级折扣;supplierTimeLimitedDiscount:供货商限时折扣;shareCut:享立减;fCode:F码;helpCut:助力砍价;recommendGift:推荐有礼（老带新）;luckyDrawGroup:抽奖拼团;plusBuy:加价购;plusBuyGoods:加价购换购商品;ladderGroupOn:阶梯拼团;multiGoodsGroupOn:多商品伙拼团;meetReduce:满减送;cashBack:订单返现;supplierMeetReduce:供货商满包邮;bale:打包一口价;coupon:优惠卡券;entireDiscount:整单优惠;groupOnHeaderDiscount:团长优惠;customerPostageFree:会员包邮;periodBuyPostageFree:周期购包邮;ignoreOddChange:抹零;operation:订单改价;carriageDiscount:同城送运费优惠;postFree:快递包邮工具;depositExpansion:定金膨胀;secondHalfDiscount:第2件半价;helpDepositExpansion:助力定金膨胀;fansBenefit:让利涨粉;pfGuideMarketing:引导促销;cashbackPro:订单返现Pro;luckyDrawCode:0元抽奖码;inSourcingFission:内购裂变;knowLedgeMjs:知识付费买赠;pointDeduction:积分抵现;guangCoin-爱逛币抵现
                /// </summary>
                /// <example>
                /// tuan
                /// </example>
                [JsonProperty("promotion_type")]
                public string PromotionType { get; set; }
                /// <summary>
                /// 优惠券/码编号
                /// </summary>
                /// <example>
                /// 2592102628
                /// </example>
                [JsonProperty("coupon_id")]
                public string CouponId { get; set; }
                /// <summary>
                /// 优惠活动别名
                /// </summary>
                /// <example>
                /// 优惠卡券
                /// </example>
                [JsonProperty("promotion_content")]
                public string PromotionContent { get; set; }
                /// <summary>
                /// 优惠描述
                /// </summary>
                /// <example>
                /// 无门槛,减5
                /// </example>
                [JsonProperty("promotion_condition")]
                public string PromotionCondition { get; set; }
                /// <summary>
                /// 活动类型id；1-无优惠；2-团购返现；3-降价拍；4-多人拼团；5-积分兑换；6-秒杀；7-优惠套餐；8-赠品领取；9-商品扫码；10-会员折扣；11-限时折扣；12-支付有礼；13-周期购，16-收款码优惠；17-分销商等级折扣；18-供货商限时折扣；19-享立减；20-F码；21-助力砍价；22-推荐有礼（老带新)；23-抽奖拼团；24-加价购；25-加价购换购商品；26-阶梯拼团；27-多商品伙拼团；28-新品发售；29-秒杀问题；30-推荐办卡（展示卡）；101-满减送； 102-订单返现；103-供货商满包邮；104-打包一口价；105-优惠卡券；106-整单优惠；107-团长优惠；108-会员包邮；109-周期购包邮；110-抹零；111-订单改价；112-同城送运费优惠；113-快递包邮工具；114-定金膨胀；115-第2件半价；116-助力定金膨胀；118-让利涨粉；119-企业微信让利涨粉；201-引导促销；203-订单返现Pro；204-0元抽奖码；205-内购裂变；206-分享有礼；207-优惠套餐搭配主商品（仅商品选择组件用）；208-组合套餐；209-限时佣金；210-定向佣金；211-平台优惠券；225-知识付费买赠；256-积分抵现；257-集点卡；258-集点兑换物品；259-攒学费；260-导购扫码；301-主图水印；302-电子发票；401-盲盒获取；402-盲盒核销；403-限时秒杀；501-公众号海报；502-好友助力；503-社群接龙；504-预付卡；505-SKU级预付卡；506-储值专享折扣；507-会员场景营销；508-社群接龙；509-限时到店优惠；510-发红包；511-红包优惠；513-平台补贴；514-普惠秒杀；601-兑换券；10000-发券宝(裂变优惠券)；10001-刮刮卡；10002-疯狂猜；10003-生肖翻翻看；10004-幸运大抽奖；10005-摇一摇；10006-好友瓜分券；10007-发券宝(新客进店有礼)；10008-发券宝(老客进店有礼)；10008-发券宝(老客进店有礼)；10020-投票调查；
                /// </summary>
                /// <example>
                /// 105
                /// </example>
                [JsonProperty("promotion_type_id")]
                public long? PromotionTypeId { get; set; }
                /// <summary>
                /// 优惠id,即商家端店铺后台该优惠活动id。
                /// </summary>
                /// <example>
                /// 6138916
                /// </example>
                [JsonProperty("promotion_id")]
                public long? PromotionId { get; set; }

            }
            public class OrderPaidPromotionModel
            {
                /// <summary>
                /// 活动类型id；1-无优惠；2-团购返现；3-降价拍；4-多人拼团；5-积分兑换；6-秒杀；7-优惠套餐；8-赠品领取；9-商品扫码；10-会员折扣；11-限时折扣；12-支付有礼；13-周期购，16-收款码优惠；17-分销商等级折扣；18-供货商限时折扣；19-享立减；20-F码；21-助力砍价；22-推荐有礼（老带新)；23-抽奖拼团；24-加价购；25-加价购换购商品；26-阶梯拼团；27-多商品伙拼团；28-新品发售；29-秒杀问题；30-推荐办卡（展示卡）；101-满减送； 102-订单返现；103-供货商满包邮；104-打包一口价；105-优惠卡券；106-整单优惠；107-团长优惠；108-会员包邮；109-周期购包邮；110-抹零；111-订单改价；112-同城送运费优惠；113-快递包邮工具；114-定金膨胀；115-第2件半价；116-助力定金膨胀；118-让利涨粉；119-企业微信让利涨粉；201-引导促销；203-订单返现Pro；204-0元抽奖码；205-内购裂变；206-分享有礼；207-优惠套餐搭配主商品（仅商品选择组件用）；208-组合套餐；209-限时佣金；210-定向佣金；211-平台优惠券；225-知识付费买赠；256-积分抵现；257-集点卡；258-集点兑换物品；259-攒学费；260-导购扫码；301-主图水印；302-电子发票；401-盲盒获取；402-盲盒核销；403-限时秒杀；501-公众号海报；502-好友助力；503-社群接龙；504-预付卡；505-SKU级预付卡；506-储值专享折扣；507-会员场景营销；508-社群接龙；509-限时到店优惠；510-发红包；511-红包优惠；513-平台补贴；514-普惠秒杀；601-兑换券；10000-发券宝(裂变优惠券)；10001-刮刮卡；10002-疯狂猜；10003-生肖翻翻看；10004-幸运大抽奖；10005-摇一摇；10006-好友瓜分券；10007-发券宝(新客进店有礼)；10008-发券宝(老客进店有礼)；10008-发券宝(老客进店有礼)；10020-投票调查；
                /// </summary>
                [JsonProperty("promotion_type_id")]
                public int PromotionTypeId { get; set; }

                [JsonProperty("coupons")]
                public List<CouponModel> Coupons { get; set; }

                [JsonProperty("oids")]
                public List<OIdModel> OIds { get; set; }

                [JsonProperty("promotion_id")]
                public long PromotionId { get; set; }

                public class CouponModel
                {
                    [JsonProperty("coupon_id")]
                    public long coupon_id { get; set; }

                    [JsonProperty("buyer_coupon_id")]
                    public long buyer_coupon_id { get; set; }
                }

                public class OIdModel
                {
                    [JsonProperty("oid")]
                    public string OId { get; set; }
                }
            }

        }
        public class RefundOrderModel
        {
            /// <summary>
            /// 用户申请退款时间，时间格式为yyyy年-MM月-dd日 HH时:mm分:ss秒
            /// </summary>
            /// <example>
            /// 2019-08-20 17:20:28
            /// </example>
            [JsonProperty("refund_time")]
            public DateTime? RefundTime { get; set; }
            /// <summary>
            ///  有赞生成的退款id
            /// </summary>
            /// <example>
            /// 201908211503250000020803
            /// </example>
            [JsonProperty("refund_id")]
            public string RefundId { get; set; }
            /// <summary>
            /// 退款流水
            /// </summary>
            [JsonProperty("refund_fund")]
            public List<RefundFundModel> RefundFund { get; set; }
            /// <summary>
            /// 退款交易明细
            /// </summary>
            [JsonProperty("oids")]
            public List<OidsModel> Oids { get; set; }
            /// <summary>
            ///  退款金额，单位：元
            /// </summary>
            /// <example>
            /// 0.01
            /// </example>
            [JsonProperty("refund_fee")]
            public string RefundFee { get; set; }
            /// <summary>
            /// 退款状态 1:买家已经申请退款，等待卖家同意， 10:卖家拒绝退款， 20:卖家已经同意退货，等待买家退货， 30:买家已经退货，等待卖家确认收货， 40:卖家未收到货,拒绝退款，45：商家已经发货，等待买家确认收货， 50:退款关闭， 60:退款成功
            /// </summary>
            /// <example>
            /// 60
            /// </example>
            [JsonProperty("refund_state")]
            public int? RefundState { get; set; }
            /// <summary>
            /// 退款类型 1:退款-买家申请退款，2:退款-商家主动退款， 3:退款-一键退款，4:换货-零售门店换货，5:网店换货。 以下场景会触发一键退款（一键退款主要是由有赞服务器基于以下条件自动触发）订单关闭退款，拼团未成团退款，返现退款，团购返现退款，小程序拼团退款，送礼子订单未被领取退款，送礼社群版到期自动退款，美业退款，订单少付退款，酒店拒单，拼团扣库存失败，代付过期退款，代付超付退款，外卖拒单退，超付+本金组合退款，上云商家一键退款类型，会员卡发卡失败退款。
            /// </summary>
            /// <example>
            /// 1
            /// </example>
            [JsonProperty("refund_type")]
            public int? RefundType { get; set; }
            public class RefundFundModel
            {
                /// <summary>
                /// 当status=2 refund_account_time是退款到账时间 否则是创建时间
                /// </summary>
                /// <example>
                /// 2021-03-03 09:30:05
                /// </example>
                [Required]
                [JsonProperty("refund_account_time")]
                public string RefundAccountTime { get; set; }
                /// <summary>
                /// 退款金额，单位：元
                /// </summary>
                /// <example>
                /// "99.00"
                /// </example>
                [JsonProperty("refund_fee")]
                public string RefundFee { get; set; }
                /// <summary>
                /// 退款流水号
                /// </summary>
                /// <example>
                /// "201909172334000000010961"
                /// </example>
                [JsonProperty("refund_no")]
                public string RefundNo { get; set; }
                /// <summary>
                /// 退款状态 0.退款中 2.退款成功
                /// </summary>
                /// <example>
                /// 2
                /// </example>
                [JsonProperty("status")]
                public int? Status { get; set; }
                /// <summary>
                /// 创建时间，时间格式为yyyy年-MM月-dd日 HH时:mm分:ss秒
                /// </summary>
                /// <example>
                /// "2019-09-17 23:34:00"
                /// </example>
                [JsonProperty("create_time")]
                public string CreateTime { get; set; }

            }
            public class OidsModel
            {
                /// <summary>
                /// 订单交易明细id
                /// </summary>
                /// <example>
                /// 1534884519450530315
                /// </example>
                [JsonProperty("oid")]
                public string Oid { get; set; }

            }

        }

    }
}
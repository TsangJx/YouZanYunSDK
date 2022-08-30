using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using YouZanYun.Infrastructure;

namespace YouZanYun.Trades.Sold
{
    public class GetData
    {
        /// <summary>
        /// 交易基础信息结构体
        /// </summary>
        [JsonProperty("full_order_info_list")]
        public List<FullOrderInfoListModel> FullOrderInfoList { get; set; }
        /// <summary>
        /// 搜索订单总条数
        /// </summary>
        /// <example>
        /// 100
        /// </example>
        [JsonProperty("total_results")]
        public long? TotalResults { get; set; }
        public class FullOrderInfoListModel
        {
            /// <summary>
            /// 交易基础信息结构体
            /// </summary>
            [JsonProperty("full_order_info")]
            public FullOrderInfoModel FullOrderInfo { get; set; }
            public class FullOrderInfoModel
            {
                /// <summary>
                /// 收货地址信息
                /// </summary>
                [JsonProperty("address_info")]
                public AddressInfoModel AddressInfo { get; set; }
                /// <summary>
                /// 交易明细结
                /// </summary>
                [JsonProperty("orders")]
                public List<OrdersModel> Orders { get; set; }
                /// <summary>
                /// 交易基础信息
                /// </summary>
                [JsonProperty("order_info")]
                public OrderInfoModel OrderInfo { get; set; }
                /// <summary>
                /// 订单买家信息
                /// </summary>
                [JsonProperty("buyer_info")]
                public BuyerInfoModel BuyerInfo { get; set; }
                /// <summary>
                /// 交易来源信息
                /// </summary>
                [JsonProperty("source_info")]
                public SourceInfoModel SourceInfo { get; set; }
                /// <summary>
                /// 订单支付信息
                /// </summary>
                [JsonProperty("pay_info")]
                public PayInfoModel PayInfo { get; set; }
                /// <summary>
                /// 送礼订单子单
                /// </summary>
                [JsonProperty("child_info")]
                public ChildInfoModel ChildInfo { get; set; }
                /// <summary>
                /// 标记信息
                /// </summary>
                [JsonProperty("remark_info")]
                public RemarkInfoModel RemarkInfo { get; set; }
                public class AddressInfoModel
                {
                    /// <summary>
                    /// 同城送预计送达时间-结束时间 非同城送以及没有开启定时达的订单不返回
                    /// </summary>
                    /// <example>
                    /// 2019-09-15 01:00:00
                    /// </example>
                    [JsonProperty("delivery_end_time")]
                    public DateTime? DeliveryEndTime { get; set; }
                    /// <summary>
                    ///  同城送预计送达时间-开始时间 非同城送以及没有开启定时达的订单不返回
                    /// </summary>
                    /// <example>
                    /// 2019-09-15 00:00:00
                    /// </example>
                    [JsonProperty("delivery_start_time")]
                    public DateTime? DeliveryStartTime { get; set; }
                    /// <summary>
                    /// 省
                    /// </summary>
                    /// <example>
                    /// 浙江省
                    /// </example>
                    [JsonProperty("delivery_province")]
                    public string DeliveryProvince { get; set; }
                    /// <summary>
                    /// 市
                    /// </summary>
                    /// <example>
                    /// 杭州市
                    /// </example>
                    [JsonProperty("delivery_city")]
                    public string DeliveryCity { get; set; }
                    /// <summary>
                    /// 邮政编码
                    /// </summary>
                    /// <example>
                    /// 330106
                    /// </example>
                    [JsonProperty("delivery_postal_code")]
                    public string DeliveryPostalCode { get; set; }
                    /// <summary>
                    /// 收货人手机号
                    /// </summary>
                    /// <example>
                    /// 13700000000
                    /// </example>
                    [JsonProperty("receiver_tel")]
                    public string ReceiverTel { get; set; }
                    /// <summary>
                    /// 区
                    /// </summary>
                    /// <example>
                    /// 西湖区
                    /// </example>
                    [JsonProperty("delivery_district")]
                    public string DeliveryDistrict { get; set; }
                    /// <summary>
                    /// 字段为json格式，需要开发者自行解析 lng、lon（经纬度）； checkOutTime（酒店退房时间）； recipients（入住人）； checkInTime（酒店入住时间）； areaCode（邮政编码）
                    /// </summary>
                    /// <example>
                    /// {\"areaCode\":\"330106\",\"lon\":120.13278695112612,\"lat\":30.2811003548167}
                    /// </example>
                    [JsonProperty("address_extra")]
                    public string AddressExtra { get; set; }
                    /// <summary>
                    ///  到店自提信息 json格式，字段说明请参考：https://developers.youzanyun.com/article/1556781783745
                    /// </summary>
                    /// <example>
                    /// {\"address_detail\":\"文三路与工专路交口西南角\",\"city\":\"杭州市\",\"county\":\"西湖区\",\"id\":58039430,\"is_optional_self_fetch_time\":1,\"is_super_store\":0,\"kdt_id\":42587152,\"lat\":30.281547,\"lon\":120.132598,\"name\":\"黄龙万科\",\"province\":\"浙江省\",\"tel\":\"13700000000\",\"user_name\":\"导演\",\"user_tel\":\"13700000000\",\"user_time\":\"09月18日 08:01-09:01\"}
                    /// </example>
                    [JsonProperty("self_fetch_info")]
                    public string SelfFetchInfo { get; set; }
                    /// <summary>
                    /// 详细地址
                    /// </summary>
                    /// <example>
                    /// 翠苑街道黄龙万科中心18楼
                    /// </example>
                    [JsonProperty("delivery_address")]
                    public string DeliveryAddress { get; set; }
                    /// <summary>
                    /// 收货人姓名
                    /// </summary>
                    /// <example>
                    /// 赞宝
                    /// </example>
                    [JsonProperty("receiver_name")]
                    public string ReceiverName { get; set; }

                }
                public class OrdersModel
                {
                    /// <summary>
                    /// 商品图片地址
                    /// </summary>
                    /// <example>
                    /// https://img.yzcdn.cn/upload_files/2019/03/25/FqMXNLvzdruTrK9VRqjxg_N14chC.jpg
                    /// </example>
                    [JsonProperty("pic_path")]
                    public string PicPath { get; set; }
                    /// <summary>
                    ///  单商品原价，单位：元
                    /// </summary>
                    /// <example>
                    /// 1
                    /// </example>
                    [JsonProperty("price")]
                    public string Price { get; set; }
                    /// <summary>
                    /// 税费
                    /// </summary>
                    /// <example>
                    /// "0.07"
                    /// </example>
                    [JsonProperty("tax_total")]
                    public string TaxTotal { get; set; }
                    /// <summary>
                    ///  商品规格id，有赞生成的规格id。无规格商品返回0
                    /// </summary>
                    /// <example>
                    /// 400818034
                    /// </example>
                    [JsonProperty("sku_id")]
                    public long? SkuId { get; set; }
                    /// <summary>
                    /// 商品别名
                    /// </summary>
                    /// <example>
                    /// 2fz29mulo249s
                    /// </example>
                    [JsonProperty("alias")]
                    public string Alias { get; set; }
                    /// <summary>
                    ///  海淘订单子订单号
                    /// </summary>
                    /// <example>
                    /// E20190313111941080300017SH
                    /// </example>
                    [JsonProperty("sub_order_no")]
                    public string SubOrderNo { get; set; }
                    /// <summary>
                    /// 运杂费
                    /// </summary>
                    /// <example>
                    /// "0.00"
                    /// </example>
                    [JsonProperty("freight")]
                    public string Freight { get; set; }
                    /// <summary>
                    /// 分销税费
                    /// </summary>
                    /// <example>
                    /// "0.00"
                    /// </example>
                    [JsonProperty("fenxiao_tax_total")]
                    public string FenxiaoTaxTotal { get; set; }
                    /// <summary>
                    /// 商品规格编码，sku_id值不为0时：返回商品规格编码；sku_id值为0时：当设置商品编码后且开启多网点功能，返回值为商品编码，否则返回空。
                    /// </summary>
                    /// <example>
                    /// spbm001
                    /// </example>
                    [JsonProperty("outer_sku_id")]
                    public string OuterSkuId { get; set; }
                    /// <summary>
                    /// 海淘-申报单价（完税价格）
                    /// </summary>
                    /// <example>
                    /// 1
                    /// </example>
                    [JsonProperty("goods_dutiable_price")]
                    public string GoodsDutiablePrice { get; set; }
                    /// <summary>
                    ///  海关编号，更多海关编码请访问：https://doc.youzanyun.com/doc#/content/27031/27100
                    /// </summary>
                    /// <example>
                    /// HZ
                    /// </example>
                    [JsonProperty("customs_code")]
                    public string CustomsCode { get; set; }
                    /// <summary>
                    /// 0 全款预售，1 定金预售
                    /// </summary>
                    /// <example>
                    /// 0
                    /// </example>
                    [JsonProperty("pre_sale_type")]
                    public string PreSaleType { get; set; }
                    /// <summary>
                    ///  订单类型 0:普通类型商品; 1:拍卖商品; 5:餐饮商品; 10:分销商品; 20:会员卡商品; 21:礼品卡商品; 23:有赞会议商品; 24:周期购; 30:收银台商品; 31:知识付费商品; 35:酒店商品; 40:普通服务类商品; 182:普通虚拟商品; 183:电子卡券商品; 201:外部会员卡商品; 202:外部直接收款商品; 203:外部普通商品; 205:mock不存在商品; 206:小程序二维码
                    /// </summary>
                    /// <example>
                    /// 0
                    /// </example>
                    [JsonProperty("item_type")]
                    public long? ItemType { get; set; }
                    /// <summary>
                    /// 商品数量
                    /// </summary>
                    /// <example>
                    /// 1
                    /// </example>
                    [JsonProperty("num")]
                    public long? Num { get; set; }
                    /// <summary>
                    /// 分销商品单价
                    /// </summary>
                    /// <example>
                    /// "0.00"
                    /// </example>
                    [JsonProperty("fenxiao_discount_price")]
                    public string FenxiaoDiscountPrice { get; set; }
                    /// <summary>
                    /// 商品详情链接
                    /// </summary>
                    /// <example>
                    /// https://h5.youzan.com/v2/showcase/goods?alias=2fz29mulo249s
                    /// </example>
                    [JsonProperty("goods_url")]
                    public string GoodsUrl { get; set; }
                    /// <summary>
                    /// 分销单金额 ，单位元
                    /// </summary>
                    /// <example>
                    /// "0.00"
                    /// </example>
                    [JsonProperty("fenxiao_price")]
                    public string FenxiaoPrice { get; set; }
                    /// <summary>
                    /// 商品名称
                    /// </summary>
                    /// <example>
                    /// 可乐
                    /// </example>
                    [JsonProperty("title")]
                    public string Title { get; set; }
                    /// <summary>
                    /// 海淘-商品总货值（完税价格*商品数量）
                    /// </summary>
                    /// <example>
                    /// 10
                    /// </example>
                    [JsonProperty("goods_total_dutiable_price")]
                    public string GoodsTotalDutiablePrice { get; set; }
                    /// <summary>
                    /// 分销非现金抵扣金额
                    /// </summary>
                    /// <example>
                    /// "0.00"
                    /// </example>
                    [JsonProperty("fenxiao_discount")]
                    public string FenxiaoDiscount { get; set; }
                    /// <summary>
                    /// 分销运杂费
                    /// </summary>
                    /// <example>
                    /// "0.00"
                    /// </example>
                    [JsonProperty("fenxiao_freight")]
                    public string FenxiaoFreight { get; set; }
                    /// <summary>
                    /// 是否为预售商品，是：返回为1，否返回为空
                    /// </summary>
                    /// <example>
                    /// 1
                    /// </example>
                    [JsonProperty("is_pre_sale")]
                    public string IsPreSale { get; set; }
                    /// <summary>
                    /// 海淘商品贸易模式，BC直邮：9610，BBC保税进口：1210
                    /// </summary>
                    /// <example>
                    /// 1210
                    /// </example>
                    [JsonProperty("cross_border_trade_mode")]
                    public string CrossBorderTradeMode { get; set; }
                    /// <summary>
                    ///  商品规格信息（无规格商品为空）
                    /// </summary>
                    /// <example>
                    /// [{\"k\":\"蓝色\",\"k_id\":3,\"v\":\"1号\",\"v_id\":7443}]
                    /// </example>
                    [JsonProperty("sku_properties_name")]
                    public string SkuPropertiesName { get; set; }
                    /// <summary>
                    /// 订单明细id
                    /// </summary>
                    /// <example>
                    /// 1533766114261606211
                    /// </example>
                    [JsonProperty("oid")]
                    public string Oid { get; set; }
                    /// <summary>
                    ///  商品最终均摊价，单位：元
                    /// </summary>
                    /// <example>
                    /// 2
                    /// </example>
                    [JsonProperty("payment")]
                    public string Payment { get; set; }
                    /// <summary>
                    /// 分销海淘-申报单价（完税价格）
                    /// </summary>
                    /// <example>
                    /// 1
                    /// </example>
                    [JsonProperty("fenxiao_goods_dutiable_price")]
                    public string FenxiaoGoodsDutiablePrice { get; set; }
                    /// <summary>
                    /// 非现金抵扣金额
                    /// </summary>
                    /// <example>
                    /// "2.00"
                    /// </example>
                    [JsonProperty("discount")]
                    public string Discount { get; set; }
                    /// <summary>
                    ///  是否是跨境海淘订单，是：返回为1，否返回为空
                    /// </summary>
                    /// <example>
                    /// 1
                    /// </example>
                    [JsonProperty("is_cross_border")]
                    public string IsCrossBorder { get; set; }
                    /// <summary>
                    ///  商品积分价（非积分商品则为0），如返回值是100则表示100积分。
                    /// </summary>
                    /// <example>
                    /// 100
                    /// </example>
                    [JsonProperty("points_price")]
                    public string PointsPrice { get; set; }
                    /// <summary>
                    ///  是否赠品，是：true，否：false
                    /// </summary>
                    /// <example>
                    /// false
                    /// </example>
                    [JsonProperty("is_present")]
                    public bool? IsPresent { get; set; }
                    /// <summary>
                    /// 分销海淘-商品总货值（完税价格*商品数量）
                    /// </summary>
                    /// <example>
                    /// 10
                    /// </example>
                    [JsonProperty("fenxiao_goods_total_dutiable_price")]
                    public string FenxiaoGoodsTotalDutiablePrice { get; set; }
                    /// <summary>
                    /// 商品唯一编码
                    /// </summary>
                    /// <example>
                    /// 12234
                    /// </example>
                    [JsonProperty("sku_unique_code")]
                    public string SkuUniqueCode { get; set; }
                    /// <summary>
                    ///  商品编码，商家自定义编码，可用于和其他系统之间商品的外部id的标识。
                    /// </summary>
                    /// <example>
                    /// spbm001
                    /// </example>
                    [JsonProperty("outer_item_id")]
                    public string OuterItemId { get; set; }
                    /// <summary>
                    ///  商品id，有赞生成的商品唯一id
                    /// </summary>
                    /// <example>
                    /// 495112276
                    /// </example>
                    [JsonProperty("item_id")]
                    public long? ItemId { get; set; }
                    /// <summary>
                    /// 单商品现价，减去了商品的优惠金额。单位：元
                    /// </summary>
                    /// <example>
                    /// 5.00
                    /// </example>
                    [JsonProperty("discount_price")]
                    public string DiscountPrice { get; set; }
                    /// <summary>
                    ///  商品留言
                    /// </summary>
                    /// <example>
                    ///  {\"我是商品留言\":\"商品留言\"}
                    /// </example>
                    [JsonProperty("buyer_messages")]
                    public string BuyerMessages { get; set; }
                    /// <summary>
                    /// 分销单实付金额，单位元
                    /// </summary>
                    /// <example>
                    /// "0.00"
                    /// </example>
                    [JsonProperty("fenxiao_payment")]
                    public string FenxiaoPayment { get; set; }
                    /// <summary>
                    ///  商品优惠前总价,单位：元
                    /// </summary>
                    /// <example>
                    /// 3
                    /// </example>
                    [JsonProperty("total_fee")]
                    public string TotalFee { get; set; }

                }
                public class OrderInfoModel
                {
                    /// <summary>
                    /// 订单打标
                    /// </summary>
                    [JsonProperty("order_tags")]
                    public OrderTagsModel OrderTags { get; set; }
                    /// <summary>
                    /// 是否零售订单，是：true，否：false
                    /// </summary>
                    /// <example>
                    /// false
                    /// </example>
                    [JsonProperty("is_retail_order")]
                    public bool? IsRetailOrder { get; set; }
                    /// <summary>
                    /// 订单支付类型 0:默认值,未支付; 1:微信自有支付; 2:支付宝wap; 3:支付宝wap; 5:财付通; 7:代付; 8:联动优势; 9:货到付款; 10:大账号代销; 11:受理模式; 12:百付宝; 13:sdk支付; 14:合并付货款; 15:赠品; 16:优惠兑换; 17:自动付货款; 18:爱学贷; 19:微信wap; 20:微信红包支付; 21:返利; 22:ump红包; 24:易宝支付; 25:储值卡; 27:qq支付; 28:有赞E卡支付; 29:微信条码; 30:支付宝条码; 33:礼品卡支付; 35:会员余额; 72:微信扫码二维码支付; 100:代收账户; 300:储值账户; 400:保证金账户; 101:收款码; 102:微信; 103:支付宝; 104:刷卡; 105:二维码台卡; 106:储值卡; 107:有赞E卡; 110:标记收款-自有微信支付; 111:标记收款-自有支付宝; 112:标记收款-自有POS刷卡; 113:通联刷卡支付; 200:记账账户; 201:现金
                    /// </summary>
                    /// <example>
                    /// 10
                    /// </example>
                    [JsonProperty("pay_type")]
                    public long? PayType { get; set; }
                    /// <summary>
                    /// 订单更新时间
                    /// </summary>
                    /// <example>
                    /// 2019-09-09 16:08:34
                    /// </example>
                    [JsonProperty("update_time")]
                    public DateTime? UpdateTime { get; set; }
                    /// <summary>
                    /// 多网点id，非多网点订单，返回为空。
                    /// </summary>
                    /// <example>
                    /// 58826303
                    /// </example>
                    [JsonProperty("offline_id")]
                    public long? OfflineId { get; set; }
                    /// <summary>
                    /// 订单发货时间（当所有商品发货后才会更新）
                    /// </summary>
                    /// <example>
                    /// 2019-09-17 15:44:58
                    /// </example>
                    [JsonProperty("consign_time")]
                    public DateTime? ConsignTime { get; set; }
                    /// <summary>
                    /// 有赞订单号，E开头长度24位字母和数字组合
                    /// </summary>
                    /// <example>
                    /// E20190312105415047400001
                    /// </example>
                    [JsonProperty("tid")]
                    public string Tid { get; set; }
                    /// <summary>
                    /// 订单扩展信息
                    /// </summary>
                    [JsonProperty("order_extra")]
                    public OrderExtraModel OrderExtra { get; set; }
                    /// <summary>
                    /// 订单创建时间
                    /// </summary>
                    /// <example>
                    /// 2019-09-09 16:05:52
                    /// </example>
                    [JsonProperty("created")]
                    public DateTime? Created { get; set; }
                    /// <summary>
                    /// 主订单状态： WAIT_BUYER_PAY：等待买家付款，定金预售描述：定金待付、等待尾款支付开始、尾款待付， TRADE_PAID：订单已支付 ，该状态仅代表当前订单已支付成功，表示瞬时状态，稍后会自动修改成后面的状态。如果不关心此状态请再次请求详情接口获取下一个状态， WAIT_CONFIRM：待确认，包含待成团、待接单等等。即：买家已付款，等待成团或等待接单， WAIT_SELLER_SEND_GOODS：等待卖家发货，即：买家已付款， WAIT_BUYER_CONFIRM_GOODS 等待买家确认收货，即：卖家已发货， TRADE_SUCCESS：买家已签收以及订单成功， TRADE_CLOSED：交易关闭
                    /// </summary>
                    /// <example>
                    /// WAIT_BUYER_PAY
                    /// </example>
                    [JsonProperty("status")]
                    public string Status { get; set; }
                    /// <summary>
                    /// 总店kdtId
                    /// </summary>
                    /// <example>
                    /// 985332
                    /// </example>
                    [JsonProperty("root_kdt_id")]
                    public long? RootKdtId { get; set; }
                    /// <summary>
                    /// 店铺类型0:微商城; 1:微小店; 2:爱学贷微商城; 3:批发店铺; 4:批发商城; 5:外卖; 6:美业; 7:超级门店; 8:收银; 9:收银加微商城; 10:零售总部; 99:有赞开放平台平台型应用创建的店铺
                    /// </summary>
                    /// <example>
                    /// 0
                    /// </example>
                    [JsonProperty("team_type")]
                    public long? TeamType { get; set; }
                    /// <summary>
                    /// 订单过期时间（未付款将自动关单）
                    /// </summary>
                    /// <example>
                    /// 2019-09-16 17:44:57
                    /// </example>
                    [JsonProperty("expired_time")]
                    public DateTime? ExpiredTime { get; set; }
                    /// <summary>
                    /// 退款状态: 0:未退款， 2:部分退款成功， 12:全额退款成功
                    /// </summary>
                    /// <example>
                    /// 0
                    /// </example>
                    [JsonProperty("refund_state")]
                    public long? RefundState { get; set; }
                    /// <summary>
                    /// 配送方式（物流类型）， 0:快递发货; 1:到店自提; 2:同城配送; 9:无需发货（虚拟商品订单）
                    /// </summary>
                    /// <example>
                    /// 1
                    /// </example>
                    [JsonProperty("express_type")]
                    public long? ExpressType { get; set; }
                    /// <summary>
                    /// 主订单类型 0:普通订单; 1:送礼订单; 2:代付; 3:分销采购单; 4:赠品; 5:心愿单; 6:二维码订单; 7:合并付货款; 8:1分钱实名认证; 9:品鉴; 10:拼团; 15:返利; 35:酒店; 40:外卖; 41:堂食点餐; 46:外卖买单; 51:全员开店; 61:线下收银台订单; 71:美业预约单; 72:美业服务单; 75:知识付费; 81:礼品卡; 100:批发
                    /// </summary>
                    /// <example>
                    /// 0
                    /// </example>
                    [JsonProperty("type")]
                    public long? Type { get; set; }
                    /// <summary>
                    /// 订单支付时间
                    /// </summary>
                    /// <example>
                    /// 2019-09-16 16:44:58
                    /// </example>
                    [JsonProperty("pay_time")]
                    public DateTime? PayTime { get; set; }
                    /// <summary>
                    ///  活动类型:0: "没有活动",1: "没有活动", 2: "团购返现",3: "降价拍",4: "拼团",5: "积分兑换",6: "秒杀",7: "优惠套餐",8: "赠品",9: "商品扫码",10: "会员折扣",11: "限时折扣",12: "众筹",13:"周期购",14: "送礼",15: "随机点餐",16: "扫码优惠",19: "享立减",20: "F码",21: "助力砍价",22: "推荐有奖",23: "抽奖拼团",24: "加价购",63: "送礼社区版",101: "满减送",102: "订单返现",103: "供货商满包邮",114: "定金膨胀",115: "第二件半价",256:"积分抵现"
                    /// </summary>
                    /// <example>
                    /// 0
                    /// </example>
                    [JsonProperty("activity_type")]
                    public int? ActivityType { get; set; }
                    /// <summary>
                    ///  支付渠道。取值范围： WEIXIN:微信自有支付, WEIXIN_DAIXIAO :微信代销支付, ALIPAY :支付宝支付, BANKCARDPAY:银行卡支付,PEERPAY :代付,CODPAY :货到付款),BAIDUPAY :百度钱包支付, PRESENTTAKE :直接领取赠品, COUPONPAY:优惠券/码全额抵扣, BULKPURCHASE:来自分销商的采购, MERGEDPAY:合并付货款, ECARD:有赞E卡支付, PURCHASE_PAY :采购单支付, MARKPAY :标记收款, OFCASH :现金支付, PREPAIDCARD :储值卡余额支付，ENCHASHMENT_GIFT_CARD:礼品卡支付
                    /// </summary>
                    /// <example>
                    /// WEIXIN_DAIXIAO
                    /// </example>
                    [JsonProperty("pay_type_str")]
                    public string PayTypeStr { get; set; }
                    /// <summary>
                    /// 关闭类型0:未关闭; 1:过期关闭; 2:标记退款; 3:订单取消; 4:买家取消; 5:卖家取消; 6:部分退款; 10:无法联系上买家; 11:买家误拍或重拍了; 12:买家无诚意完成交易; 13:已通过银行线下汇款; 14:已通过同城见面交易; 15:已通过货到付款交易; 16:已通过网上银行直接汇款; 17:已经缺货无法交易；31-买家不想购买了
                    /// </summary>
                    /// <example>
                    /// 0
                    /// </example>
                    [JsonProperty("close_type")]
                    public long? CloseType { get; set; }
                    /// <summary>
                    /// 门店kdtId
                    /// </summary>
                    /// <example>
                    /// 456732
                    /// </example>
                    [JsonProperty("node_kdt_id")]
                    public long? NodeKdtId { get; set; }
                    /// <summary>
                    /// 交易完成时间
                    /// </summary>
                    /// <example>
                    /// 2019-08-20 17:20:28
                    /// </example>
                    [JsonProperty("success_time")]
                    public DateTime? SuccessTime { get; set; }
                    /// <summary>
                    /// 订单确认时间（多人拼团成团返回）
                    /// </summary>
                    /// <example>
                    /// 2019-09-15 15:01:58
                    /// </example>
                    [JsonProperty("confirm_time")]
                    public DateTime? ConfirmTime { get; set; }
                    /// <summary>
                    /// 详情url
                    /// </summary>
                    /// <example>
                    /// https://h5.youzan.com/wsctrade/order/detail?order_no=E20200319100017065800001&kdt_id=63077
                    /// </example>
                    [JsonProperty("order_url")]
                    public string OrderUrl { get; set; }
                    /// <summary>
                    /// 主订单状态描述，和status对应关系。WAIT_BUYER_PAY：待支付，TRADE_PAID：已支付，WAIT_CONFIRM：待接单， WAIT_SELLER_SEND_GOODS：待发货，WAIT_BUYER_CONFIRM_GOODS：已发货，TRADE_SUCCESS：已完成，TRADE_CLOSED：已关闭
                    /// </summary>
                    /// <example>
                    /// 待发货
                    /// </example>
                    [JsonProperty("status_str")]
                    public string StatusStr { get; set; }
                    public class OrderTagsModel
                    {
                        /// <summary>
                        /// 是否分销单
                        /// </summary>
                        /// <example>
                        /// true
                        /// </example>
                        [JsonProperty("is_fenxiao_order")]
                        public bool? IsFenxiaoOrder { get; set; }
                        /// <summary>
                        /// 是否支付
                        /// </summary>
                        /// <example>
                        /// true
                        /// </example>
                        [JsonProperty("is_payed")]
                        public bool? IsPayed { get; set; }
                        /// <summary>
                        /// 是否线下订单
                        /// </summary>
                        /// <example>
                        /// true
                        /// </example>
                        [JsonProperty("is_offline_order")]
                        public bool? IsOfflineOrder { get; set; }
                        /// <summary>
                        /// 是否定金预售
                        /// </summary>
                        /// <example>
                        /// true
                        /// </example>
                        [JsonProperty("is_down_payment_pre")]
                        public bool? IsDownPaymentPre { get; set; }
                        /// <summary>
                        /// 是否预订单
                        /// </summary>
                        /// <example>
                        /// true
                        /// </example>
                        [JsonProperty("is_preorder")]
                        public bool? IsPreorder { get; set; }
                        /// <summary>
                        /// 是否会员订单
                        /// </summary>
                        /// <example>
                        /// true
                        /// </example>
                        [JsonProperty("is_member")]
                        public bool? IsMember { get; set; }
                        /// <summary>
                        /// 是否担保交易
                        /// </summary>
                        /// <example>
                        /// true
                        /// </example>
                        [JsonProperty("is_secured_transactions")]
                        public bool? IsSecuredTransactions { get; set; }
                        /// <summary>
                        /// 是否有退款
                        /// </summary>
                        /// <example>
                        /// true
                        /// </example>
                        [JsonProperty("is_refund")]
                        public bool? IsRefund { get; set; }
                        /// <summary>
                        /// 是否虚拟订单。true：是，false：否。
                        /// </summary>
                        /// <example>
                        /// true
                        /// </example>
                        [JsonProperty("is_virtual")]
                        public bool? IsVirtual { get; set; }
                        /// <summary>
                        /// 是否享受免邮
                        /// </summary>
                        /// <example>
                        /// true
                        /// </example>
                        [JsonProperty("is_postage_free")]
                        public bool? IsPostageFree { get; set; }
                        /// <summary>
                        /// 是否结算
                        /// </summary>
                        /// <example>
                        /// true
                        /// </example>
                        [JsonProperty("is_settle")]
                        public bool? IsSettle { get; set; }
                        /// <summary>
                        /// 是否有维权
                        /// </summary>
                        /// <example>
                        /// true
                        /// </example>
                        [JsonProperty("is_feedback")]
                        public bool? IsFeedback { get; set; }
                        /// <summary>
                        /// 是否采购单
                        /// </summary>
                        /// <example>
                        /// true
                        /// </example>
                        [JsonProperty("is_purchase_order")]
                        public bool? IsPurchaseOrder { get; set; }
                        /// <summary>
                        /// 是否多门店订单
                        /// </summary>
                        /// <example>
                        /// true
                        /// </example>
                        [JsonProperty("is_multi_store")]
                        public bool? IsMultiStore { get; set; }

                    }
                    public class OrderExtraModel
                    {
                        /// <summary>
                        /// 下单设备号
                        /// </summary>
                        /// <example>
                        /// 7654234
                        /// </example>
                        [JsonProperty("create_device_id")]
                        public string CreateDeviceId { get; set; }
                        /// <summary>
                        ///  是否子单(分销买家订单) 是：1 其他：null
                        /// </summary>
                        /// <example>
                        /// 1
                        /// </example>
                        [JsonProperty("is_sub_order")]
                        public string IsSubOrder { get; set; }
                        /// <summary>
                        /// 分销单外部支付流水号
                        /// </summary>
                        /// <example>
                        /// 20190815220517067000087
                        /// </example>
                        [JsonProperty("fx_outer_transaction_no")]
                        public string FxOuterTransactionNo { get; set; }
                        /// <summary>
                        /// 收银员id，没有值返回为null
                        /// </summary>
                        /// <example>
                        /// 123452
                        /// </example>
                        [JsonProperty("cashier_id")]
                        public string CashierId { get; set; }
                        /// <summary>
                        /// 发票抬头
                        /// </summary>
                        /// <example>
                        /// 有赞
                        /// </example>
                        [JsonProperty("invoice_title")]
                        public string InvoiceTitle { get; set; }
                        /// <summary>
                        ///  海淘买家身份证号
                        /// </summary>
                        /// <example>
                        /// 341202202008151234
                        /// </example>
                        [JsonProperty("id_card_number")]
                        public string IdCardNumber { get; set; }
                        /// <summary>
                        /// 是否会员订单
                        /// </summary>
                        /// <example>
                        /// true
                        /// </example>
                        [JsonProperty("is_member")]
                        public string IsMember { get; set; }
                        /// <summary>
                        /// 分销单订单号，即买家订单
                        /// </summary>
                        /// <example>
                        /// E20190820094520057400012
                        /// </example>
                        [JsonProperty("fx_order_no")]
                        public string FxOrderNo { get; set; }
                        /// <summary>
                        /// 使用了同一张优惠券&优惠码的多笔订单对应的虚拟总单号
                        /// </summary>
                        /// <example>
                        /// V20190815220517067000087
                        /// </example>
                        [JsonProperty("promotion_combine_id")]
                        public string PromotionCombineId { get; set; }
                        /// <summary>
                        /// 美业分店id
                        /// </summary>
                        /// <example>
                        /// 4565432
                        /// </example>
                        [JsonProperty("dept_id")]
                        public string DeptId { get; set; }
                        /// <summary>
                        /// 身份证姓名信息  （订购人的身份证号字段可通过订单详情4.0接口“id_card_number ”获取）
                        /// </summary>
                        /// <example>
                        /// 赞小宝
                        /// </example>
                        [JsonProperty("id_card_name")]
                        public string IdCardName { get; set; }
                        /// <summary>
                        /// 团购返现优惠金额
                        /// </summary>
                        /// <example>
                        /// "0.00"
                        /// </example>
                        [JsonProperty("tm_cash")]
                        public long? TmCash { get; set; }
                        /// <summary>
                        ///  是否是积分订单：1：是 0：不是
                        /// </summary>
                        /// <example>
                        /// 0
                        /// </example>
                        [JsonProperty("is_points_order")]
                        public string IsPointsOrder { get; set; }
                        /// <summary>
                        /// 收银员名字
                        /// </summary>
                        /// <example>
                        /// 小明
                        /// </example>
                        [JsonProperty("cashier_name")]
                        public string CashierName { get; set; }
                        /// <summary>
                        /// 分销单内部支付流水号
                        /// </summary>
                        /// <example>
                        /// 20190815220517067000087
                        /// </example>
                        [JsonProperty("fx_inner_transaction_no")]
                        public string FxInnerTransactionNo { get; set; }
                        /// <summary>
                        /// 导购信息
                        /// </summary>
                        /// <example>
                        /// dg
                        /// </example>
                        [JsonProperty("daogou")]
                        public string Daogou { get; set; }
                        /// <summary>
                        /// 废弃字段，开发者无需关注（18年4月废弃）
                        /// </summary>
                        /// <example>
                        /// 废弃字段
                        /// </example>
                        [JsonProperty("parent_order_no")]
                        public string ParentOrderNo { get; set; }
                        /// <summary>
                        /// 字段废弃
                        /// </summary>
                        /// <example>
                        /// 2019-08-20 10:19:43
                        /// </example>
                        [JsonProperty("settle_time")]
                        public string SettleTime { get; set; }
                        /// <summary>
                        ///  是否来自购物车 是：true 不是：false
                        /// </summary>
                        /// <example>
                        /// false
                        /// </example>
                        [JsonProperty("is_from_cart")]
                        public string IsFromCart { get; set; }
                        /// <summary>
                        /// 分销订单父单号。分销采购单号，即供货商看到的订单号
                        /// </summary>
                        /// <example>
                        /// E20190815220517067000087
                        /// </example>
                        [JsonProperty("purchase_order_no")]
                        public string PurchaseOrderNo { get; set; }
                        /// <summary>
                        /// 下单人昵称
                        /// </summary>
                        /// <example>
                        /// 小明
                        /// </example>
                        [JsonProperty("buyer_name")]
                        public string BuyerName { get; set; }
                        /// <summary>
                        /// 推广方式
                        /// </summary>
                        /// <example>
                        /// 取值CPS|GMV
                        /// </example>
                        [JsonProperty("marketing_channel")]
                        public string MarketingChannel { get; set; }
                        /// <summary>
                        ///  是否父单(分销合并订单) 是：1 其他：null
                        /// </summary>
                        /// <example>
                        /// 1
                        /// </example>
                        [JsonProperty("is_parent_order")]
                        public string IsParentOrder { get; set; }
                        /// <summary>
                        ///  虚拟总单号：一次下单发生拆单时，会生成一个虚拟总单号
                        /// </summary>
                        /// <example>
                        /// V20190815220517067000087
                        /// </example>
                        [JsonProperty("orders_combine_id")]
                        public string OrdersCombineId { get; set; }
                        /// <summary>
                        ///  订单返现金额，单位：分
                        /// </summary>
                        /// <example>
                        /// 300
                        /// </example>
                        [JsonProperty("cash")]
                        public long? Cash { get; set; }
                        /// <summary>
                        /// 拆单时店铺维度的虚拟总单号：发生拆单时，单个店铺生成了多笔订单会生成一个店铺维度的虚拟总单号
                        /// </summary>
                        /// <example>
                        /// V20190815220517067000087
                        /// </example>
                        [JsonProperty("kdt_dimension_combine_id")]
                        public string KdtDimensionCombineId { get; set; }
                        /// <summary>
                        /// 团购返现最大返现金额
                        /// </summary>
                        /// <example>
                        /// "0.00"
                        /// </example>
                        [JsonProperty("t_cash")]
                        public long? TCash { get; set; }
                        /// <summary>
                        /// 分销店铺id
                        /// </summary>
                        /// <example>
                        /// 12355621
                        /// </example>
                        [JsonProperty("fx_kdt_id")]
                        public string FxKdtId { get; set; }

                    }

                }
                public class BuyerInfoModel
                {
                    /// <summary>
                    /// 粉丝昵称
                    /// </summary>
                    /// <example>
                    /// 小明
                    /// </example>
                    [JsonProperty("fans_nickname")]
                    public string FansNickname { get; set; }
                    /// <summary>
                    /// 有赞粉丝id，有赞自动生成。
                    /// </summary>
                    /// <example>
                    /// 3303656575
                    /// </example>
                    [JsonProperty("fans_id")]
                    public long? FansId { get; set; }
                    /// <summary>
                    /// 粉丝类型0:未知、1:微信自有粉丝; 9:代销粉丝,2:微博,105:,知乎,128: 有赞精选app,188: QQ,312:腾讯云,736:支付宝,1180:百度,1181:今日头条,1590:微信广告,56473:陌陌 ,59011:线下微信支付产生的粉丝,59465:线下支付宝支付,4591:有人,16940: 快手 ,26879:上鱼,6227:精选小程序,61489:虎牙
                    /// </summary>
                    /// <example>
                    /// 1
                    /// </example>
                    [JsonProperty("fans_type")]
                    public long? FansType { get; set; }
                    /// <summary>
                    /// 买家手机号，买家在个人中心绑定手机号才会返回。否则为空。
                    /// </summary>
                    /// <example>
                    /// 13700000000
                    /// </example>
                    [JsonProperty("buyer_phone")]
                    public string BuyerPhone { get; set; }
                    /// <summary>
                    /// 买家id
                    /// </summary>
                    /// <example>
                    /// 865115939
                    /// </example>
                    [JsonProperty("buyer_id")]
                    public long? BuyerId { get; set; }
                    /// <summary>
                    /// 微信H5和微信小程序（有赞小程序和小程序插件）的订单会返回微信weixin_openid，三方App（有赞APP开店）的订单会返回open_user_id，2019年1月30号后的订单支持返回该参数
                    /// </summary>
                    /// <example>
                    /// oDpvq0N1rr0NjE9FmeFXFDWEH9zs
                    /// </example>
                    [JsonProperty("outer_user_id")]
                    public string OuterUserId { get; set; }

                }
                public class SourceInfoModel
                {
                    /// <summary>
                    /// 订单唯一识别码
                    /// </summary>
                    /// <example>
                    /// 7fb60857-07df-40b5-be21-0a1d1f5947d8
                    /// </example>
                    [JsonProperty("book_key")]
                    public string BookKey { get; set; }
                    /// <summary>
                    /// 订单标记 wx_apps:微信小程序买家版 wx_shop:微信小程序商家版 wx_wm:微信小程序外卖 wap_wm:移动端外卖 super_store:超级门店 weapp_spotlight:新微信小程序买家版 wx_meiye:美业小程序 wx_apps_maidan:小程序餐饮买单 wx_apps_diancan:小程序堂食 weapp_youzan:有赞小程序 retail_free_buy:零售自由购 weapp_owl:知识付费小程序 app_spotlight:有赞精选app retail_scan_buy:零售扫码购 weapp_plugin:小程序插件 除以上之外为其他
                    /// </summary>
                    /// <example>
                    /// wx_apps
                    /// </example>
                    [JsonProperty("order_mark")]
                    public string OrderMark { get; set; }
                    /// <summary>
                    /// 平台
                    /// </summary>
                    [JsonProperty("source")]
                    public SourceModel Source { get; set; }
                    /// <summary>
                    /// 是否来自线下订单
                    /// </summary>
                    /// <example>
                    /// true
                    /// </example>
                    [JsonProperty("is_offline_order")]
                    public bool? IsOfflineOrder { get; set; }
                    /// <summary>
                    ///  活动类型：群团购：”mall_group_buy“
                    /// </summary>
                    /// <example>
                    /// mall_group_buy
                    /// </example>
                    [JsonProperty("biz_source")]
                    public string BizSource { get; set; }
                    public class SourceModel
                    {
                        /// <summary>
                        ///  微信平台细分。 wx_gzh:微信公众号; yzdh:有赞大号; merchant_xcx:商家小程序; yzdh_xcx:有赞大号小程序; direct_buy:直接购买
                        /// </summary>
                        /// <example>
                        /// direct_buy
                        /// </example>
                        [JsonProperty("wx_entrance")]
                        public string WxEntrance { get; set; }
                        /// <summary>
                        ///  平台 wx:微信; merchant_3rd:商家自有app; buyer_v:买家版; browser:系统浏览器; alipay:支付宝;qq:腾讯QQ; wb:微博; other:其他
                        /// </summary>
                        /// <example>
                        /// wx
                        /// </example>
                        [JsonProperty("platform")]
                        public string Platform { get; set; }

                    }

                }
                public class PayInfoModel
                {
                    /// <summary>
                    /// 应付价格
                    /// </summary>
                    /// <example>
                    /// "1.01"
                    /// </example>
                    [JsonProperty("payment")]
                    public string Payment { get; set; }
                    /// <summary>
                    /// 邮费
                    /// </summary>
                    /// <example>
                    /// "0.00"
                    /// </example>
                    [JsonProperty("post_fee")]
                    public string PostFee { get; set; }
                    /// <summary>
                    /// 礼品卡/储值卡具体抵扣的金额，单位：分
                    /// </summary>
                    /// <example>
                    /// 2
                    /// </example>
                    [JsonProperty("deduction_pay")]
                    public long? DeductionPay { get; set; }
                    /// <summary>
                    /// 多阶段支付信息
                    /// </summary>
                    [JsonProperty("phase_payments")]
                    public List<PhasePaymentsModel> PhasePayments { get; set; }
                    /// <summary>
                    /// 实付价格.单位：元
                    /// </summary>
                    /// <example>
                    /// 1
                    /// </example>
                    [JsonProperty("real_payment")]
                    public string RealPayment { get; set; }
                    /// <summary>
                    /// 礼品卡/储值卡抵扣之后的订单实付金额，单位：分
                    /// </summary>
                    /// <example>
                    /// 1
                    /// </example>
                    [JsonProperty("deduction_real_pay")]
                    public long? DeductionRealPay { get; set; }
                    /// <summary>
                    /// 优惠前商品总价
                    /// </summary>
                    /// <example>
                    /// "1.01"
                    /// </example>
                    [JsonProperty("total_fee")]
                    public string TotalFee { get; set; }
                    /// <summary>
                    /// 外部订单号（即微信端交易单号）
                    /// </summary>
                    /// <example>
                    /// 4200000381201908138173551027
                    /// </example>
                    [JsonProperty("outer_transactions")]
                    public List<string> OuterTransactions { get; set; }
                    /// <summary>
                    ///  支付流水号（即微信端商户单号）
                    /// </summary>
                    /// <example>
                    /// 190813155336000038
                    /// </example>
                    [JsonProperty("transaction")]
                    public List<string> Transaction { get; set; }
                    public class PhasePaymentsModel
                    {
                        /// <summary>
                        /// 支付结束时间
                        /// </summary>
                        /// <example>
                        /// 2020-02-12 10:54:48
                        /// </example>
                        [JsonProperty("pay_end_time")]
                        public DateTime? PayEndTime { get; set; }
                        /// <summary>
                        /// 外部支付流水号
                        /// </summary>
                        /// <example>
                        /// 4200000381201908138173551027
                        /// </example>
                        [JsonProperty("outer_transaction_no")]
                        public string OuterTransactionNo { get; set; }
                        /// <summary>
                        /// 支付阶段:定金1,尾款2
                        /// </summary>
                        /// <example>
                        /// 1
                        /// </example>
                        [JsonProperty("phase")]
                        public long? Phase { get; set; }
                        /// <summary>
                        /// 阶段支付金额
                        /// </summary>
                        /// <example>
                        /// "0.01"
                        /// </example>
                        [JsonProperty("real_price")]
                        public string RealPrice { get; set; }
                        /// <summary>
                        /// 支付开始时间
                        /// </summary>
                        /// <example>
                        /// 2020-02-11 10:54:48
                        /// </example>
                        [JsonProperty("pay_start_time")]
                        public DateTime? PayStartTime { get; set; }
                        /// <summary>
                        /// 内部支付流水号
                        /// </summary>
                        /// <example>
                        /// 190813155336000038
                        /// </example>
                        [JsonProperty("inner_transaction_no")]
                        public string InnerTransactionNo { get; set; }

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
                    /// 20180628134127771495
                    /// </example>
                    [JsonProperty("gift_no")]
                    public string GiftNo { get; set; }
                    /// <summary>
                    /// 送礼标记
                    /// </summary>
                    /// <example>
                    /// 0d6da180
                    /// </example>
                    [JsonProperty("gift_sign")]
                    public string GiftSign { get; set; }
                    public class ChildOrdersModel
                    {
                        /// <summary>
                        /// 订单号
                        /// </summary>
                        /// <example>
                        /// C20180628134156425220
                        /// </example>
                        [JsonProperty("tid")]
                        public string Tid { get; set; }
                        /// <summary>
                        /// 收货地址详情
                        /// </summary>
                        /// <example>
                        /// 有赞科技
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
                        /// 15258870000
                        /// </example>
                        [JsonProperty("user_tel")]
                        public string UserTel { get; set; }
                        /// <summary>
                        /// 老送礼订单状态：WAIT_EXPRESS(5, "待发货"), EXPRESS(6, "已发货"), SUCCESS(100, "成功")
                        /// </summary>
                        /// <example>
                        /// WAIT_EXPRESS
                        /// </example>
                        [JsonProperty("order_state")]
                        public string OrderState { get; set; }
                        /// <summary>
                        /// 市
                        /// </summary>
                        /// <example>
                        /// 杭州市
                        /// </example>
                        [JsonProperty("city")]
                        public string City { get; set; }
                        /// <summary>
                        /// 领取人姓名
                        /// </summary>
                        /// <example>
                        /// 人潮
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

                    }

                }
                public class RemarkInfoModel
                {
                    /// <summary>
                    /// 订单买家留言
                    /// </summary>
                    /// <example>
                    /// 我是卖家留言
                    /// </example>
                    [JsonProperty("buyer_message")]
                    public string BuyerMessage { get; set; }
                    /// <summary>
                    /// 订单标星等级 0-5
                    /// </summary>
                    /// <example>
                    /// 5
                    /// </example>
                    [JsonProperty("star")]
                    public long? Star { get; set; }
                    /// <summary>
                    /// 订单商家备注
                    /// </summary>
                    /// <example>
                    /// 我是卖家备注
                    /// </example>
                    [JsonProperty("trade_memo")]
                    public string TradeMemo { get; set; }

                }

            }

        }

    }
}
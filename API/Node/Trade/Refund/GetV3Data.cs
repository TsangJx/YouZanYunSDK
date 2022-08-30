using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using YouZanYun.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace YouZanYun.Trade.Refund
{
    public class GetV3Data
    {
        /// <summary>
        /// 退款金额详情
        /// </summary>
        [JsonProperty("refund_fund_list")]
        public List<RefundFundListModel> RefundFundList { get; set; }
        /// <summary>
        /// 售后申请修改时间，时间格式：yyyy-MM-dd-HH-mm-ss
        /// </summary>
        /// <example>
        /// 2017-01-01 00:00:01
        /// </example>
        [JsonProperty("modified")]
        public DateTime? Modified { get; set; }
        /// <summary>
        /// 退款 item 列表
        /// </summary>
        [JsonProperty("refund_order_item")]
        public List<RefundOrderItemModel> RefundOrderItem { get; set; }
        /// <summary>
        /// 售后说明
        /// </summary>
        /// <example>
        /// “我”
        /// </example>
        [JsonProperty("desc")]
        public string Desc { get; set; }
        /// <summary>
        /// 退款协商记录
        /// </summary>
        [JsonProperty("consult_message")]
        public List<ConsultMessageModel> ConsultMessage { get; set; }
        /// <summary>
        /// 店铺在有赞的id标识，有赞平台生成，在有赞平台唯一，用于判断信息属于哪一个店铺
        /// </summary>
        /// <example>
        /// 42905421
        /// </example>
        [JsonProperty("kdt_id")]
        public long? KdtId { get; set; }
        /// <summary>
        /// 退款诉求。1.仅退款；2.退货退款；3.换货
        /// </summary>
        /// <example>
        /// 1
        /// </example>
        [JsonProperty("demand")]
        public int Demand { get; set; }
        /// <summary>
        /// 退款金额，单位：元，最大支持小数点两位。金额包含邮费
        /// </summary>
        /// <example>
        /// 0.01
        /// </example>
        [JsonProperty("refund_fee")]
        public string RefundFee { get; set; }
        /// <summary>
        /// 退还的邮费，单位:元
        /// </summary>
        /// <example>
        /// 10.00
        /// </example>
        [JsonProperty("refund_postage")]
        public string RefundPostage { get; set; }
        /// <summary>
        /// 第一个退款商品的订单明细ID，即子订单号，19位随机数字组合，用于判断判断子订单是否发货，退款场景等。对应父级字段tid。一笔订单多种商品对应多个子订单号，按照订单中商品种类生成，不根据商品数量生成（例：一笔订单有3种商品数量6个分别是：香蕉1个，苹果2个，橙子3个，会生成3个子订单号），用于判断判断子订单是否发货，退款场景等。请使用订单api【youzan.trades.sold.get】【youzan.trade.get.4.0.0】获取该字段。如果有多个退款商品，要获取对应商品的oid，可以通过refund_order_item中的oid来获取
        /// </summary>
        /// <example>
        /// 1526023707817967902
        /// </example>
        [JsonProperty("oid")]
        public string Oid { get; set; }
        /// <summary>
        /// 订单明细ID。由于系统升级，该字段已不再生效，建议不要继续使用。已废弃，请改用oid
        /// </summary>
        /// <example>
        /// 18434958
        /// </example>
        [JsonProperty("item_id")]
        public long? ItemId { get; set; }
        /// <summary>
        /// 有赞订单号，E开头+年月日时分秒+随机数，长度24位字母和数字组合	
        /// </summary>
        /// <example>
        /// E20190704205412100200949
        /// </example>
        [JsonProperty("tid")]
        public string Tid { get; set; }
        /// <summary>
        /// 退货物流信息
        /// </summary>
        [JsonProperty("logistics")]
        public LogisticsModel Logistics { get; set; }
        /// <summary>
        /// 售后状态: WAIT_SELLER_AGREE-买家已经申请退款，等待卖家同意;  WAIT_BUYER_RETURN_GOODS-卖家已经同意退款，等待买家退货; WAIT_SELLER_CONFIRM_GOODS-买家已经退货，等待卖家确认收货; SELLER_REFUSE_BUYER-卖家拒绝退款; SELLER_REFUSE_BUYER_RETURN_GOODS-卖家未收到货,拒绝退款 ; SELLER_RETURN_GOODS-商家确认收货并发送换货;CLOSED-退款关闭;SUCCESS-退款成功;
        /// </summary>
        /// <example>
        /// WAIT_SELLER_AGREE
        /// </example>
        [JsonProperty("status")]
        public string Status { get; set; }
        /// <summary>
        /// 退款卡券数量。仅在卡券订单退款时有值
        /// </summary>
        /// <example>
        /// 2
        /// </example>
        [JsonProperty("refund_ticket_num")]
        public int? RefundTicketNum { get; set; }
        /// <summary>
        /// 客满介入状态： 1（客满未介入），2（客满介入中）。
        /// </summary>
        /// <example>
        /// 1
        /// </example>
        [JsonProperty("cs_status")]
        public int? CsStatus { get; set; }
        /// <summary>
        /// 售后申请时间，时间格式：yyyy-MM-dd-HH-mm-ss
        /// </summary>
        /// <example>
        /// 2017-01-01 00:00:00
        /// </example>
        [JsonProperty("created")]
        public DateTime Created { get; set; }
        /// <summary>
        /// 当status=SUCCESS时 refund_account_time是退款到账时间 否则是售后申请时间
        /// </summary>
        /// <example>
        /// 2021-03-03 12:01:30
        /// </example>
        [Required]
        [JsonProperty("refund_account_time")]
        public DateTime RefundAccountTime { get; set; }
        /// <summary>
        /// 退款资金说明
        /// </summary>
        /// <example>
        /// 根据买家的支付方式，资金将原路退回到买家的支付账户
        /// </example>
        [JsonProperty("refund_fund_desc")]
        public string RefundFundDesc { get; set; }
        /// <summary>
        ///  售后申请原因，(仅退款-已收到货申请原因) 0:商家主动退款;1: 买/卖双方协商一致;2: 买错/多买/不想要;3: 商品质量问题;4: 未收到货品';5: 做工粗糙/有瑕疵;11: 质量问题;12: 拍错/多拍/不喜欢;13: 商品描述不符;14: 假货;15: 商家发错货;16: 商品破损/少件;17: 其他;18: 仅退款;19: 协商一致退款;20: 快递一直未送达;21: 未按约定时间发货;22: 拍错/不想要;23: 计划有变无法使用;24: 商家降价; (仅退款-未收到货申请原因) 25:非正品 51: 买错/多买/不想要;52: 快递无记录;53: 少货/空包裹;54: 未按约定时间发货;55: 快递一直未送达;56: 其他;57: 拍错/多拍/不喜欢;58: (退货退款-申请原因)协商一致退款; 59: 同城订单商家手动拒单;101: 商品破损/少件;102: 商家发错货;103: 商品描述不符;104: 拍错/多拍/不喜欢;105: 质量问题;106: 假货;107: 其他;108: 做工粗糙/有瑕疵;109: 非正品;110: (系统退款原因) 未按约定时间发货;111:退货退款;112:7天无理由退货;201: 返现退款;202:203:拼团订单扣库存失败退款; 酒店拒单退款;204: 订单关闭退款;205: 代付过期退款;206: 超付退款;207: 外卖拒单退款;208: 拼团未成团退款;209: 团购返现退款;210:美业退款;211: 订单少付退款;212: 小程序拼团退款;213:送礼子订单未被领取退款;214:超付+本金组合退款;215:送礼社群版到期自动退款;216:上云商家一键退款类型;217:群团购团长审核不通过退款;218:群团购未成团退款;219:会员卡发卡失败退款;220:同城订单超时未接单自动关单;221:差价退款;222:重复购买退款;223:教育线上重复购买退款;
        /// </summary>
        /// <example>
        /// 54
        /// </example>
        [JsonProperty("reason")]
        public int? Reason { get; set; }
        /// <summary>
        /// 退款类型： BUYER_APPLY_REFUND(买家申请退款)，SELLER_REFUND（商家主动退款），EXCHANGE_GOODS(买家申请换货)，SYSTEM_REFUND（一键退款，特殊类型退款。如超卖，支付回调超时）
        /// </summary>
        /// <example>
        /// BUYER_APPLY_REFUND
        /// </example>
        [JsonProperty("refund_type")]
        public string RefundType { get; set; }
        /// <summary>
        /// 第一个退款商品的数量，整数，单位：个，如果要获取所有的退款商品数量，可以获取到refund_order_item中的item_num进行求和计算。注意：在退货退款的情况下，返回值未退款商品数量，在仅退款状态下返回值为0；称重商品订单该值返回为0
        /// </summary>
        /// <example>
        /// 1
        /// </example>
        [JsonProperty("item_num")]
        public int? ItemNum { get; set; }
        /// <summary>
        /// 维权ID（售后单编号），售后申请时有赞系统自动生成一串数字组合，生成规则：年月日时分秒+10位随机数，用于确认售后详情，使用【youzan.trade.refund.search】【youzan.trade.get】接口可以获取。
        /// </summary>
        /// <example>
        /// 201907042058500000031002
        /// </example>
        [JsonProperty("refund_id")]
        public string RefundId { get; set; }
        /// <summary>
        /// 退款诉求对应文本
        /// </summary>
        /// <example>
        /// 仅退款
        /// </example>
        [JsonProperty("demand_desc")]
        public string DemandDesc { get; set; }
        /// <summary>
        /// 退款卡券ID列表
        /// </summary>
        /// <example>
        /// ["1234","9876"]
        /// </example>
        [JsonProperty("refund_ticket_list")]
        public List<String> RefundTicketList { get; set; }
        /// <summary>
        /// 售后版本号，用于售后单相关操接口的入参传入。（version由售后单创建时有赞自动生成）
        /// </summary>
        /// <example>
        /// 1493968316537
        /// </example>
        [JsonProperty("version")]
        public long? Version { get; set; }
        /// <summary>
        /// 是否有退货，true：是，false：否。如果没有退货返回是false
        /// </summary>
        /// <example>
        /// true
        /// </example>
        [JsonProperty("return_goods")]
        public bool? ReturnGoods { get; set; }
        public class RefundFundListModel
        {
            /// <summary>
            /// 退款资金状态。0:退款中,1:退款失败,2:退款成功
            /// </summary>
            /// <example>
            /// 2
            /// </example>
            [JsonProperty("status")]
            public int? Status { get; set; }
            /// <summary>
            /// 退款ID
            /// </summary>
            /// <example>
            /// 201709282209550100010758
            /// </example>
            [JsonProperty("refund_id")]
            public string RefundId { get; set; }
            /// <summary>
            /// 支付渠道。0:默认值,未支付,1:微信自有支付,2:支付宝wap,3:支付宝wap,5:财付通,7:代付,8:联动优势,9:货到付款,10:大账号代销,11:受理模式,12:百付宝,13:sdk支付,14:合并付货款,15:领取赠品,16:优惠兑换,17:自动付货款,18:爱学贷,19:微信wap,20:微信红包支付,21:返利,22:ump红包,24:易宝支付,25:储值卡,27:qq支付,28:有赞E卡支付,29:微信条码,30:支付宝条码,33:礼品卡支付,35:会员余额,36:信用卡银联支付,37:储蓄卡银联支付,40:分期支付,72:微信扫码二维码支付,80:待结算&余额支付,90:礼品卡支付,100:代收账户,300:储值账户,400:保证金账户,101:收款码,102:微信,103:支付宝,104:刷卡,105:二维码台卡,106:储值卡,107:有赞E卡,110:标记收款-自有微信支付,111:标记收款-自有支付宝,112:标记收款-自有POS刷卡,113:通联刷卡支付,114:标记收款-自定义,115:有赞零钱支付,116:优惠全额抵扣,117:商米支付,118:商米支付-支付宝,119:商米pos,200:记账账户,201:现金,202:组合支付,203:外部支付,204:汇款支付
            /// </summary>
            /// <example>
            /// 2
            /// </example>
            [JsonProperty("pay_way")]
            public int? PayWay { get; set; }
            /// <summary>
            /// 错误信息
            /// </summary>
            /// <example>
            /// 退款成功
            /// </example>
            [JsonProperty("message")]
            public string Message { get; set; }
            /// <summary>
            /// 退款模式。0:原路退,1:现金退,2:标记退
            /// </summary>
            /// <example>
            /// 3
            /// </example>
            [JsonProperty("refund_mode")]
            public int? RefundMode { get; set; }
            /// <summary>
            /// 退款流水号
            /// </summary>
            /// <example>
            /// 201709282209550100010711
            /// </example>
            [Required]
            [JsonProperty("refund_no")]
            public string RefundNo { get; set; }
            /// <summary>
            /// 退款金额，单位：分；金额包含邮费
            /// </summary>
            /// <example>
            /// 10
            /// </example>
            [JsonProperty("refund_fee")]
            public long? RefundFee { get; set; }

        }
        public class RefundOrderItemModel
        {
            /// <summary>
            /// 店铺id
            /// </summary>
            /// <example>
            /// 12
            /// </example>
            [JsonProperty("kdt_id")]
            public long? KdtId { get; set; }
            /// <summary>
            /// 退款明细id
            /// </summary>
            /// <example>
            /// 100
            /// </example>
            [JsonProperty("oid")]
            public string Oid { get; set; }
            /// <summary>
            /// 退款金额 单位：分；金额包含邮费
            /// </summary>
            /// <example>
            /// 100
            /// </example>
            [JsonProperty("refund_fee")]
            public long? RefundFee { get; set; }
            /// <summary>
            /// 退款商品数量
            /// </summary>
            /// <example>
            /// 1
            /// </example>
            [Required]
            [JsonProperty("item_num")]
            public int ItemNum { get; set; }

        }
        public class ConsultMessageModel
        {
            /// <summary>
            /// 店铺id
            /// </summary>
            /// <example>
            /// 12
            /// </example>
            [JsonProperty("kdt_id")]
            public long? KdtId { get; set; }
            /// <summary>
            /// 订单号
            /// </summary>
            /// <example>
            /// E2020
            /// </example>
            [JsonProperty("order_no")]
            public string OrderNo { get; set; }
            /// <summary>
            /// 凭证
            /// </summary>
            /// <example>
            /// ["https://www.baidu.com"]
            /// </example>
            [JsonProperty("attachment")]
            public List<String> Attachment { get; set; }

        }
        public class LogisticsModel
        {
            /// <summary>
            /// 物流id，物流公司在有赞入驻后，有赞生成的唯一物流公司id，请访问https://developers.youzanyun.com/article/1556781458693
            /// </summary>
            /// <example>
            /// 1
            /// </example>
            [JsonProperty("company_code")]
            public string CompanyCode { get; set; }
            /// <summary>
            /// 收件人地址
            /// </summary>
            /// <example>
            /// 浙江省杭州市西湖区有赞科技大楼
            /// </example>
            [JsonProperty("address")]
            public string Address { get; set; }
            /// <summary>
            /// 物流单号，即物流公司的快递单号，请填写准确，真实的快递单号。	
            /// </summary>
            /// <example>
            /// 3456789
            /// </example>
            [JsonProperty("logistics_no")]
            public string LogisticsNo { get; set; }
            /// <summary>
            /// 收件人电话
            /// </summary>
            /// <example>
            /// 15002201000
            /// </example>
            [JsonProperty("mobile")]
            public string Mobile { get; set; }
            /// <summary>
            /// 收件人
            /// </summary>
            /// <example>
            /// 张三
            /// </example>
            [JsonProperty("receiver")]
            public string Receiver { get; set; }

        }

    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using YouZanYun.Infrastructure;

namespace YouZanYun.Salesman.Trades
{
    public class GetData
    {
        /// <summary>
        /// 推广订单列表
        /// </summary>
        [JsonProperty("list")]
        public List<ListModel> List { get; set; }
        /// <summary>
        /// 记录总数
        /// </summary>
        /// <example>
        /// 2
        /// </example>
        [JsonProperty("total")]
        public long? Total { get; set; }
        public class ListModel
        {
            /// <summary>
            /// 推广订单详细商品提成信息数据结构
            /// </summary>
            [JsonProperty("items")]
            public List<ItemsModel> Items { get; set; }
            /// <summary>
            /// 下单时分销员所属分组名称
            /// </summary>
            /// <example>
            /// A组
            /// </example>
            [JsonProperty("group_name")]
            public string GroupName { get; set; }
            /// <summary>
            /// 是否自动结算，0是FALSE 1是TRUE
            /// </summary>
            /// <example>
            /// 1
            /// </example>
            [JsonProperty("auto_settle")]
            public short? AutoSettle { get; set; }
            /// <summary>
            /// 结算时间
            /// </summary>
            /// <example>
            /// 2019-03-18 13:50:14
            /// </example>
            [JsonProperty("settled_at")]
            public string SettledAt { get; set; }
            /// <summary>
            /// 推广订单号即有赞订单号，E开头+年月日时分秒+随机数，长度24位字母和数字组合
            /// </summary>
            /// <example>
            /// E20190318135014056100001
            /// </example>
            [JsonProperty("order_no")]
            public string OrderNo { get; set; }
            /// <summary>
            /// 邀请方邀请奖励（元)
            /// </summary>
            /// <example>
            /// 10
            /// </example>
            [JsonProperty("ii_cps_money")]
            public string IiCpsMoney { get; set; }
            /// <summary>
            /// 最终实付金额。
            /// </summary>
            /// <example>
            /// 12.00
            /// </example>
            [JsonProperty("money")]
            public string Money { get; set; }
            /// <summary>
            /// 结算状态描述: 0 未完成付款或者订单关闭 ; 1 待自动结算; 2 已自动结算 ; 3 余额不足 ; 4 结算异常，等待重试;  5 货到付款（货到付款的推广订单无佣金）;7 销售员已注销或未绑定手机号，不结算;11 待人工结算; 12 已人工结算
            /// </summary>
            /// <example>
            /// 0
            /// </example>
            [JsonProperty("settle_state")]
            public short? SettleState { get; set; }
            /// <summary>
            /// 销售员有赞客户id，客户在有赞的唯一id
            /// </summary>
            /// <example>
            /// 3hf8Fb8I596768747084054528
            /// </example>
            [JsonProperty("yz_open_id")]
            public string YzOpenId { get; set; }
            /// <summary>
            /// 邀请方手机号
            /// </summary>
            /// <example>
            /// 13334232211
            /// </example>
            [JsonProperty("from_buyer_phone")]
            public string FromBuyerPhone { get; set; }
            /// <summary>
            /// 下单时间
            /// </summary>
            /// <example>
            /// 2019-03-18 13:50:14
            /// </example>
            [JsonProperty("created_at")]
            public string CreatedAt { get; set; }
            /// <summary>
            /// 店铺在有赞的id标识，有赞平台生成，在有赞平台唯一，用于判断信息属于哪一个店铺
            /// </summary>
            /// <example>
            /// 88888
            /// </example>
            [JsonProperty("kdt_id")]
            public long? KdtId { get; set; }
            /// <summary>
            /// 订单所属店铺名称
            /// </summary>
            /// <example>
            /// 有赞的店
            /// </example>
            [JsonProperty("shop_name")]
            public string ShopName { get; set; }
            /// <summary>
            /// 销售员手机号
            /// </summary>
            /// <example>
            /// 13507878761
            /// </example>
            [JsonProperty("phone")]
            public string Phone { get; set; }
            /// <summary>
            /// 订单状态：3：待付款，5：已付款，100：交易完成。此处订单状态仅返回与资金变动相关的状态，与订单本身状态可能不同。
            /// </summary>
            /// <example>
            /// 3
            /// </example>
            [JsonProperty("state")]
            public short? State { get; set; }
            /// <summary>
            /// 销售员唯一标识符，有赞平台唯一值，大小写是不同的销售员（例：o21Zag和O21zAg这是两个不同的销售员）
            /// </summary>
            /// <example>
            /// o21Zag
            /// </example>
            [JsonProperty("seller")]
            public string Seller { get; set; }
            /// <summary>
            /// 提成金额(元)
            /// </summary>
            /// <example>
            /// 0.0
            /// </example>
            [JsonProperty("cps_money")]
            public string CpsMoney { get; set; }
            public class ItemsModel
            {
                /// <summary>
                /// 商品名称
                /// </summary>
                /// <example>
                /// 测试
                /// </example>
                [JsonProperty("title")]
                public string Title { get; set; }
                /// <summary>
                ///     唯一编码，订单号和商品oid组合，格式为"订单号,商品oid"可用于判断商品唯一性。
                /// </summary>
                /// <example>
                /// E20190909102506067000079,1538374002067649233
                /// </example>
                [JsonProperty("item_key")]
                public string ItemKey { get; set; }
                /// <summary>
                /// 商品提成比例(%)
                /// </summary>
                /// <example>
                /// 10
                /// </example>
                [JsonProperty("i_rate")]
                public string IRate { get; set; }
                /// <summary>
                /// 商品价格（元）
                /// </summary>
                /// <example>
                /// 12.00
                /// </example>
                [JsonProperty("price")]
                public string Price { get; set; }
                /// <summary>
                /// 商品提成奖励(元)
                /// </summary>
                /// <example>
                /// 0.00
                /// </example>
                [JsonProperty("i_cps_money")]
                public string ICpsMoney { get; set; }
                /// <summary>
                /// 商品邀请奖励提成比例(%)
                /// </summary>
                /// <example>
                /// 10
                /// </example>
                [JsonProperty("ii_rate")]
                public string IiRate { get; set; }
                /// <summary>
                /// 商品Id，有赞生成的店铺下商品唯一id，平台唯一。可以通过列表接口如youzan.items.onsale.get （查询出售中商品）和 youzan.items.inventory.get （查询仓库中商品）获取
                /// </summary>
                /// <example>
                /// 443875419
                /// </example>
                [JsonProperty("num_iid")]
                public string NumIid { get; set; }
                /// <summary>
                /// 商品邀请奖励提成奖励(元)
                /// </summary>
                /// <example>
                /// 0.00
                /// </example>
                [JsonProperty("ii_cps_money")]
                public string IiCpsMoney { get; set; }
                /// <summary>
                /// 是否参与推广，0：不参与，1：参与
                /// </summary>
                /// <example>
                /// 1
                /// </example>
                [JsonProperty("is_join")]
                public int? IsJoin { get; set; }
                /// <summary>
                /// 商品数量
                /// </summary>
                /// <example>
                /// 2
                /// </example>
                [JsonProperty("num")]
                public int? Num { get; set; }

            }

        }

    }
}
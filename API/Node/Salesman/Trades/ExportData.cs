using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using YouZanYun.Infrastructure;

namespace YouZanYun.Salesman.Trades
{
    public class ExportData
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("trades")]
        public List<TradesModel> Trades { get; set; }
        /// <summary>
        /// 当前页订单最小的创建时间，用于下一次翻页，对应下一次翻页的入参end_time
        /// </summary>
        /// <example>
        /// 1522205532
        /// </example>
        [JsonProperty("page_min_created_at")]
        public long? PageMinCreatedAt { get; set; }
        /// <summary>
        /// 当前页订单最小的id，用于下一次翻页，对应下一次翻页的入参id
        /// </summary>
        /// <example>
        /// 4527
        /// </example>
        [JsonProperty("page_min_id")]
        public long? PageMinId { get; set; }
        /// <summary>
        /// 是否有下一页，如果查询的数量小于当前查询的记录，则为false，调用方取消调用，无需再调用
        /// </summary>
        /// <example>
        /// true
        /// </example>
        [JsonProperty("has_next_page")]
        public bool HasNextPage { get; set; }
        public class TradesModel
        {
            /// <summary>
            /// 邀请方邀请奖励比例
            /// </summary>
            /// <example>
            /// 0
            /// </example>
            [JsonProperty("ii_rate")]
            public string IiRate { get; set; }
            /// <summary>
            /// 推广订单商品
            /// </summary>
            [JsonProperty("items")]
            public List<ItemsModel> Items { get; set; }
            /// <summary>
            /// 所属分组名称
            /// </summary>
            /// <example>
            /// null
            /// </example>
            [JsonProperty("group_name")]
            public string GroupName { get; set; }
            /// <summary>
            /// 结算时间
            /// </summary>
            /// <example>
            /// null
            /// </example>
            [JsonProperty("settled_at")]
            public string SettledAt { get; set; }
            /// <summary>
            /// 销售员手机号
            /// </summary>
            /// <example>
            /// null
            /// </example>
            [JsonProperty("phone")]
            public string Phone { get; set; }
            /// <summary>
            /// 所属店铺kdtid
            /// </summary>
            /// <example>
            /// 160
            /// </example>
            [JsonProperty("kdt_id")]
            public long? KdtId { get; set; }
            /// <summary>
            /// 邀请订单佣金结算状态，枚举：-1：未知；0：默认；1：待自动结算；2：已自动结算；3：余额不足；4：结算异常，等待重试；5：货到付款；6：使用会员折扣；7：销售员已注销；11：待人工结算；12：已人工结算；18：结算中心结算中
            /// </summary>
            /// <example>
            /// null
            /// </example>
            [JsonProperty("ii_settle_state")]
            public short IiSettleState { get; set; }
            /// <summary>
            /// 邀请方邀请奖励（元)
            /// </summary>
            /// <example>
            /// null
            /// </example>
            [JsonProperty("ii_cps_money")]
            public string IiCpsMoney { get; set; }
            /// <summary>
            /// 订单总额(元),扣除运费
            /// </summary>
            /// <example>
            /// 0.01
            /// </example>
            [JsonProperty("money")]
            public string Money { get; set; }
            /// <summary>
            /// 下单时间
            /// </summary>
            /// <example>
            /// 2019-09-02 20:12:40
            /// </example>
            [JsonProperty("created_at")]
            public string CreatedAt { get; set; }
            /// <summary>
            /// 是否自动结算
            /// </summary>
            /// <example>
            /// 1
            /// </example>
            [JsonProperty("auto_settle")]
            public short AutoSettle { get; set; }
            /// <summary>
            /// 邀请方手机号
            /// </summary>
            /// <example>
            /// null
            /// </example>
            [JsonProperty("from_buyer_phone")]
            public string FromBuyerPhone { get; set; }
            /// <summary>
            /// 所属店铺名称
            /// </summary>
            /// <example>
            /// 起码克隆
            /// </example>
            [JsonProperty("shop_name")]
            public string ShopName { get; set; }
            /// <summary>
            /// 提成金额(元)
            /// </summary>
            /// <example>
            /// 0.00
            /// </example>
            [JsonProperty("cps_money")]
            public string CpsMoney { get; set; }
            /// <summary>
            /// 邀请方昵称
            /// </summary>
            /// <example>
            /// null
            /// </example>
            [JsonProperty("from_buyer_nick_name")]
            public string FromBuyerNickName { get; set; }
            /// <summary>
            /// 推广订单佣金结算状态；枚举：-1：未知；0：默认；1：待自动结算；2：已自动结算；3：余额不足；4：结算异常，等待重试；5：货到付款；6：使用会员折扣；7：销售员已注销；11：待人工结算；12：已人工结算；18：结算中心结算中
            /// </summary>
            /// <example>
            /// 2
            /// </example>
            [JsonProperty("settle_state")]
            public short SettleState { get; set; }
            /// <summary>
            /// 销售员id
            /// </summary>
            /// <example>
            /// 4669033
            /// </example>
            [JsonProperty("buyer_id")]
            public long? BuyerId { get; set; }
            /// <summary>
            /// 销售员推广佣金比例
            /// </summary>
            /// <example>
            /// 35
            /// </example>
            [JsonProperty("cps_rate")]
            public string CpsRate { get; set; }
            /// <summary>
            /// 订单状态:3:待付款,5:已付款,6:已发货,100:交易完成
            /// </summary>
            /// <example>
            /// 5
            /// </example>
            [JsonProperty("state")]
            public short State { get; set; }
            /// <summary>
            /// 销售员昵称
            /// </summary>
            /// <example>
            /// wt
            /// </example>
            [JsonProperty("buyer_nick_name")]
            public string BuyerNickName { get; set; }
            /// <summary>
            /// 销售员标识
            /// </summary>
            /// <example>
            /// ooMmFI
            /// </example>
            [JsonProperty("seller")]
            public string Seller { get; set; }
            /// <summary>
            /// 推广订单号
            /// </summary>
            /// <example>
            /// E20190902201240017400001
            /// </example>
            [JsonProperty("order_no")]
            public string OrderNo { get; set; }
            public class ItemsModel
            {
                /// <summary>
                /// 商品数量
                /// </summary>
                /// <example>
                /// 1
                /// </example>
                [JsonProperty("num")]
                public int? Num { get; set; }
                /// <summary>
                /// 商品邀请奖励提成比例(%)
                /// </summary>
                /// <example>
                /// 8.00
                /// </example>
                [JsonProperty("ii_rate")]
                public string IiRate { get; set; }
                /// <summary>
                /// 商品id
                /// </summary>
                /// <example>
                /// null
                /// </example>
                [JsonProperty("num_iid")]
                public string NumIid { get; set; }
                /// <summary>
                /// 商品价格
                /// </summary>
                /// <example>
                /// 0.01
                /// </example>
                [JsonProperty("price")]
                public string Price { get; set; }
                /// <summary>
                /// 商品提成比例(%)
                /// </summary>
                /// <example>
                /// 35.00
                /// </example>
                [JsonProperty("i_rate")]
                public string IRate { get; set; }
                /// <summary>
                /// itemKey
                /// </summary>
                /// <example>
                /// null
                /// </example>
                [JsonProperty("item_key")]
                public string ItemKey { get; set; }
                /// <summary>
                /// 商品标题
                /// </summary>
                /// <example>
                /// 翻滚吧黄桃
                /// </example>
                [JsonProperty("title")]
                public string Title { get; set; }
                /// <summary>
                /// 商品提成奖励(元)
                /// </summary>
                /// <example>
                /// 0.00
                /// </example>
                [JsonProperty("i_cps_money")]
                public string ICpsMoney { get; set; }
                /// <summary>
                /// 是否参与推广
                /// </summary>
                /// <example>
                /// 1
                /// </example>
                [JsonProperty("is_join")]
                public int? IsJoin { get; set; }
                /// <summary>
                /// 商品邀请奖励提成奖励(元)
                /// </summary>
                /// <example>
                /// 0.00
                /// </example>
                [JsonProperty("ii_cps_money")]
                public string IiCpsMoney { get; set; }

            }

        }

    }
}


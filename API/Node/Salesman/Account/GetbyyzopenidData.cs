using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using YouZanYun.Infrastructure;

namespace YouZanYun.Salesman.Account
{
    public class GetbyyzopenidData
    {
        /// <summary>
        /// 邀请方手机号
        /// </summary>
        /// <example>
        /// 1234566776
        /// </example>
        [JsonProperty("from_buyer_mobile")]
        public string FromBuyerMobile { get; set; }
        /// <summary>
        /// 销售员手机号
        /// </summary>
        /// <example>
        /// 12345677876
        /// </example>
        [JsonProperty("mobile")]
        public string Mobile { get; set; }
        /// <summary>
        /// 销售员等级
        /// </summary>
        /// <example>
        /// 1
        /// </example>
        [JsonProperty("level")]
        public int? Level { get; set; }
        /// <summary>
        /// 昵称
        /// </summary>
        /// <example>
        /// 测试
        /// </example>
        [JsonProperty("nickname")]
        public string Nickname { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        /// <example>
        /// 2019-03-21 17:00:11
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
        /// 店铺在有赞的当前中文名称，有赞平台唯一
        /// </summary>
        /// <example>
        /// 我的小店
        /// </example>
        [JsonProperty("shop_name")]
        public string ShopName { get; set; }
        /// <summary>
        /// 订单总额(元),扣除运费和退货费等扣减费用后的实付金额。
        /// </summary>
        /// <example>
        /// 0.00
        /// </example>
        [JsonProperty("money")]
        public string Money { get; set; }
        /// <summary>
        /// 销售员分组ID
        /// </summary>
        /// <example>
        /// 1
        /// </example>
        [JsonProperty("group_id")]
        public long? GroupId { get; set; }
        /// <summary>
        /// 销售员唯一标识符，有赞平台唯一值，大小写是不同的销售员（例：o21Zag和O21zAg这是两个不同的销售员）
        /// </summary>
        /// <example>
        /// 3cHyRh
        /// </example>
        [JsonProperty("seller")]
        public string Seller { get; set; }
        /// <summary>
        /// 销售员分组名称
        /// </summary>
        /// <example>
        /// 分组1
        /// </example>
        [JsonProperty("group_name")]
        public string GroupName { get; set; }
        /// <summary>
        /// 累计成交笔数
        /// </summary>
        /// <example>
        /// 1
        /// </example>
        [JsonProperty("order_num")]
        public int? OrderNum { get; set; }

    }
}
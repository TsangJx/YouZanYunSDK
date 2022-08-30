using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using YouZanYun.Infrastructure;

namespace YouZanYun.Salesman.Account
{
    public class GetData
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
        /// 创建时间。时间格式：yyyy-MM-dd-HH-mm-ss
        /// </summary>
        /// <example>
        /// 2019-03-21 17:00:11
        /// </example>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
        /// <summary>
        /// 销售员所属店铺kdtId
        /// </summary>
        /// <example>
        /// 123
        /// </example>
        [JsonProperty("kdt_id")]
        public long? KdtId { get; set; }
        /// <summary>
        /// 销售员所属店铺名称
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
        /// 粉丝id(有赞不同的合作渠道会生成不同渠道对应在有赞平台下的fans_id。fans_id和fans_type组成一个唯一的有赞用户标识。从浏览器过来的下单的是拿不到fans_id。 大账号fans_id：通过微信去访问有赞店铺的商品等，系统会给用户生成fansid。 用户自有fans_id（从三方过来的）：关注任意一个公众号(包括有赞大账号)后生成ID。 fans_type：1:代表微信自有粉丝；2：代表[微博平台]产生的粉丝；9：代表粉丝类型为微信大账号粉丝；188：代表[qq平台]产生的粉丝；736:代表[支付宝平台]产生的粉丝；1181:代表[今日头条]产生的粉丝；非上述fans_type其他：代表其他平台或小程序粉丝或者三方sdk产生的粉丝；)
        /// </summary>
        /// <example>
        /// 12345
        /// </example>
        [JsonProperty("fans_id")]
        public long? FansId { get; set; }
        /// <summary>
        /// 有赞用户id，用户在有赞的唯一id。推荐使用。
        /// </summary>
        /// <example>
        /// dnfjskghfkjsjdhgjdsk
        /// </example>
        [JsonProperty("yz_open_id")]
        public string YzOpenId { get; set; }
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

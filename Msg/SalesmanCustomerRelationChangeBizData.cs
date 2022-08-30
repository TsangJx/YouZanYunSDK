using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using YouZanYun.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace YouZanYun.Msg
{
    /// <summary>
    /// 分销员数据变更日志
    /// </summary>
    /// <remarks>
    ///  salesman_customer_relation_change_biz
    /// </remarks>
    public class SalesmanCustomerRelationChangeBizData
    {
        /// <summary>
        /// 业务ID
        /// </summary>
        /// <example>
        /// 55_123_456_213123
        /// </example>
        [JsonProperty("bizId")]
        public string BizId { get; set; }
        /// <summary>
        /// 现有的可支持的渠道
        /// </summary>
        /// <example>
        /// 微信
        /// </example>
        [JsonProperty("channel")]
        public string Channel { get; set; }
        /// <summary>
        /// 用户最新uid
        /// </summary>
        /// <example>
        /// 123
        /// </example>
        [JsonProperty("ctUid")]
        public long CtUid { get; set; }
        /// <summary>
        /// 用户最新的yz_open_id（string类型）
        /// </summary>
        /// <example>
        /// lTlnUndq791762100953361694
        /// </example>
        [JsonProperty("ctYzOpenID")]
        public string CtYzOpenID { get; set; }
        /// <summary>
        /// 失效的分销员id
        /// </summary>
        /// <example>
        /// 222
        /// </example>
        [JsonProperty("inValidDsUid")]
        public long InValidDsUid { get; set; }
        /// <summary>
        /// 失效的分销员yz_open_id（string类型）
        /// </summary>
        /// <example>
        /// lTlnUndq791762100953361694
        /// </example>
        [JsonProperty("inValidDsYzOpenID")]
        public string InValidDsYzOpenID { get; set; }
        /// <summary>
        /// 店铺ID
        /// </summary>
        /// <example>
        /// 55
        /// </example>
        [JsonProperty("kdtId")]
        public long KdtId { get; set; }
        /// <summary>
        /// 之前支持的渠道
        /// </summary>
        /// <example>
        /// 小程序
        /// </example>
        [JsonProperty("oldChannel")]
        public string OldChannel { get; set; }
        /// <summary>
        /// 变更前用户的uid
        /// </summary>
        /// <example>
        /// 111
        /// </example>
        [JsonProperty("oldCtUid")]
        public long OldCtUid { get; set; }
        /// <summary>
        /// 变更前用户的yz_open_id（string类型）
        /// </summary>
        /// <example>
        /// lTlnUndq711762100953361694
        /// </example>
        [JsonProperty("oldYzOpenID")]
        public string OldYzOpenID { get; set; }
        /// <summary>
        /// 1.新增客户关系； 2.合并客户关系；3.解除客户关系（不包含有效期过期而失效）; 4.更新客户关系
        /// </summary>
        /// <example>
        /// 1
        /// </example>
        [JsonProperty("stateAction")]
        public SalesmanCustomerRelationChangeBizStateAction StateAction { get; set; }
        /// <summary>
        /// 描述详情
        /// </summary>
        /// <example>
        /// 客户点击商品链接和分销员绑定关系
        /// </example>
        [JsonProperty("stateDesc")]
        public string StateDesc { get; set; }
        /// <summary>
        /// 有效的分销员所属的店铺id
        /// </summary>
        /// <example>
        /// 55
        /// </example>
        [JsonProperty("validDsKdtId")]
        public long ValidDsKdtId { get; set; }
        /// <summary>
        /// 有效的分销员id
        /// </summary>
        /// <example>
        /// 456
        /// </example>
        [JsonProperty("validDsUid")]
        public long ValidDsUid { get; set; }
        /// <summary>
        /// 有效的分销员yz_open_id（string类型）
        /// </summary>
        /// <example>
        /// lTlnUndq791762100933361694	
        /// </example>
        [JsonProperty("validDsYzOpenID")]
        public string ValidDsYzOpenID { get; set; }
    }

    public enum SalesmanCustomerRelationChangeBizStateAction
    {
        新增客户关系 = 1,
        合并客户关系 = 2,
        解除客户关系 = 3,
        更新客户关系 = 4
    }
}
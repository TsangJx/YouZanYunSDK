using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using YouZanYun.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace YouZanYun.Msg
{
    /// <summary>
    /// salesman_order_settle_state_update
    /// </summary>
    /// <remarks>
    ///  分销员订单结算状态变更消息<br/>
    ///  https://doc.youzanyun.com/detail/MSG/350
    /// </remarks>
    public class SalesmanOrderSettleStateUpdateData
    {
        /// <summary>
        /// 订单佣金，分
        /// </summary>
        /// <example>
        /// 1000
        /// </example>
        [JsonProperty("cpsMoney")]
        public long CpsMoney { get; set; }
        /// <summary>
        /// 店铺标识
        /// </summary>
        /// <example>
        /// 423522
        /// </example>
        [JsonProperty("kdtId")]
        public long KdtId { get; set; }
        /// <summary>
        /// 订单号
        /// </summary>
        /// <example>
        /// E20191011114049018700003
        /// </example>
        [JsonProperty("tid")]
        public String Tid { get; set; }
        /// <summary>
        /// 订单结算状态 -1 错误状态   0 人工结算 1 待自动结算  2 已自动结算 3 未结算,余额不足 4 分润失败，系统次日结算 5 货到付款订单不参与结算 6 使用会员折扣,不结算 11 待人工结算 12 已人工结算
        /// </summary>
        /// <example>
        /// 1
        /// </example>
        [JsonProperty("settleState")]
        public int SettleState { get; set; }
        /// <summary>
        /// 校验字段
        /// </summary>
        /// <example>
        /// 0a4550c002d5d05246d1
        /// </example>
        [JsonProperty("sign")]
        public string Sign { get; set; }
        /// <summary>
        /// 更新时间，时间戳
        /// </summary>
        /// <example>
        /// 1584670069
        /// </example>
        [JsonProperty("updateTime")]
        public long UpdateTime { get; set; }

    }
}


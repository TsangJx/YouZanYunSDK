using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using YouZanYun.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace YouZanYun.Crm.Customer.Points.Changelog
{
    public class SearchV4_0_2Data
    {
        /// <summary>
        /// 返回页数和条数
        /// </summary>
        [JsonProperty("paginator")]
        public PaginatorModel Paginator { get; set; }
        /// <summary>
        /// 积分日志集合
        /// </summary>
        [JsonProperty("items")]
        public List<ItemsModel> Items { get; set; }
        public class PaginatorModel
        {
            /// <summary>
            /// 页码
            /// </summary>
            /// <example>
            /// 1
            /// </example>
            [JsonProperty("page")]
            public int Page { get; set; }
            /// <summary>
            /// 分页大小
            /// </summary>
            /// <example>
            /// 20
            /// </example>
            [JsonProperty("page_size")]
            public int PageSize { get; set; }
            /// <summary>
            /// 总条数
            /// </summary>
            /// <example>
            /// 32
            /// </example>
            [JsonProperty("total_count")]
            public int TotalCount { get; set; }

        }
        public class ItemsModel
        {
            /// <summary>
            /// 创建时间（秒级时间戳）
            /// </summary>
            /// <example>
            /// 1584525600
            /// </example>
            [JsonProperty("created_at")]
            public long? CreatedAt { get; set; }
            /// <summary>
            /// 过期时间（秒级时间戳）
            /// </summary>
            /// <example>
            /// 1584525600
            /// </example>
            [JsonProperty("expired_at")]
            public long? ExpiredAt { get; set; }
            /// <summary>
            /// 操作之后的最新积分数值
            /// </summary>
            /// <example>
            /// 23
            /// </example>
            [JsonProperty("current")]
            public long? Current { get; set; }
            /// <summary>
            /// 描述
            /// </summary>
            /// <example>
            /// 删帖扣除积分[第三方应用]
            /// </example>
            [JsonProperty("description")]
            public string Description { get; set; }
            /// <summary>
            /// 积分值（负数为扣积分）
            /// </summary>
            /// <example>
            /// 11
            /// </example>
            [JsonProperty("amount")]
            public long? Amount { get; set; }
            /// <summary>
            /// 三方调用加/减积分接口传入的biz_value, 三方未传入则不会返回
            /// </summary>
            /// <example>
            /// DE20190820002
            /// </example>
            [JsonProperty("biz_value")]
            public string BizValue { get; set; }

        }

    }
}
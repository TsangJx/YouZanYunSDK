using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using YouZanYun.Infrastructure;

namespace YouZanYun.Salesman.Relation
{
    public class GetData
    {
        /// <summary>
        /// 销售员手机号
        /// </summary>
        /// <example>
        /// 13587849852
        /// </example>
        [JsonProperty("ds_mobile")]
        public string DsMobile { get; set; }
        /// <summary>
        /// 销售员所属分组ID，可以使用【youzan.salesman.groups.get】接口获取
        /// </summary>
        /// <example>
        /// 1234
        /// </example>
        [JsonProperty("group_id")]
        public long? GroupId { get; set; }
        /// <summary>
        /// 客户和销售员绑定状态，0：失效，1：有效
        /// </summary>
        /// <example>
        /// 1
        /// </example>
        [JsonProperty("valid")]
        public int Valid { get; set; }
        /// <summary>
        /// 客户和销售员绑定状态失效原因描述。仅valid=0时有值，枚举值包括：1.关系过期、2.客户与其他分销员绑定了关系、3.客户关系合并后导致失效、4.商家手动操作客户关系转移导致失效、5.商家关闭分销员自购分佣、6.商家不允许分销员间建立客户关系、7.客户成为分销员后被清退，但仍与自己绑定客户关系、8.已成为连锁体系下其它店铺的分销员、9.商家打开分销员自购分佣，分销员与自己绑定客户关系。
        /// </summary>
        [JsonProperty("invalid_reason")]
        public string InvalidReason { get; set; }
        /// <summary>
        /// 店铺在有赞的id标识，有赞平台生成，在有赞平台唯一，用于判断信息属于哪一个店铺
        /// </summary>
        /// <example>
        /// 54309274
        /// </example>
        [JsonProperty("kdt_id")]
        public long? KdtId { get; set; }
        /// <summary>
        /// 客户和销售员绑定关系刷新时间，Unix时间戳，单位：秒。仅绑定时时间会更新，多次绑定记录最后一次更新时间。客户和销售员绑定状态失效是不影响该刷新时间。
        /// </summary>
        /// <example>
        /// 1579415469
        /// </example>
        [JsonProperty("refresh_time")]
        public int RefreshTime { get; set; }
        /// <summary>
        /// 销售员所属分组名称，可以使用【youzan.salesman.groups.get】接口获取
        /// </summary>
        /// <example>
        /// group
        /// </example>
        [JsonProperty("group_name")]
        public string GroupName { get; set; }
        /// <summary>
        /// 销售员的yz_open_id，有赞用户id，用户在有赞的唯一id。推荐使用
        /// </summary>
        /// <example>
        /// kmiyS3Qz660160349349089280
        /// </example>
        [JsonProperty("ds_yz_open_id")]
        public string DsYzOpenId { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YouZanYun.Salesman.Customer;
using YouZanYun.Salesman.Relation;

namespace YouZanYun.Salesman
{

    public class RelationNode : NodeBase
    {
        public RelationNode(YouZanYunAPIClient client) : base(client)
        {

        }
        /// <summary>
        /// 查询客户所属销售员
        /// </summary>
        /// <remarks>
        /// https://doc.youzanyun.com/detail/API/0/907
        /// </remarks>
        /// <param name="kdt_id">店铺在有赞的id标识，有赞平台生成，在有赞平台唯一，用于判断信息属于哪一个店铺</param>
        /// <param name="ct_yz_open_id">有赞用户id，用户在有赞的唯一id。推荐使用。yz_open_id和mobile二选一，两个都传优先查询yz_open_id，其次是mobile。</param>
        /// <param name="mobile">用户手机号</param>
        /// <param name="version"></param>
        /// <returns></returns>
        public async Task<ResponseBase<GetData>> GetAsync(long kdt_id
            , string ct_yz_open_id = null
            , string mobile = null
            , string version = "1.0.0")
        {
            var response = await PostAsync<GetData>("youzan.salesman.relation.get", new
            {
                kdt_id,
                ct_yz_open_id,
                mobile
            }, version);
            return response;
        }

        /// <summary>
        /// 调整或绑定客户关系
        /// </summary>
        /// <remarks>
        /// https://doc.youzanyun.com/detail/API/0/797
        /// </remarks>
        /// <param name="operator_yz_open_id">操作人yzopenid</param>
        /// <param name="operator_name">操作人姓名</param>
        /// <param name="operator_phone">操作人手机号</param>
        /// <param name="ds_yz_open_id">绑定的销售员yzopenid</param>
        /// <param name="ct_yz_open_id">绑定的客户yzopenid</param>
        /// <param name="transfer_when_exit_relation">是否转移客户关系当客户已经绑定了有效客户关系，当为true是表示强制转移客户关系，当为false会遵循保护期，无法修改。</param>
        /// <param name="ct_fans_type">客户粉丝渠道，不传默认为浏览器渠道，常见的渠道：0：浏览器1：自有公众号9：大账号</param>
        /// <returns></returns>
        public async Task<ResponseBase<bool>> AdjustAsync(
            string operator_yz_open_id
            , string operator_name
            , string operator_phone
            , string ds_yz_open_id
            , string ct_yz_open_id
            , bool? transfer_when_exit_relation = null
            , int? ct_fans_type = null
        )
        {
            var response = await PostAsync<bool>("youzan.salesman.relation.adjust", new
            {
                ct_yz_open_id,
                ds_yz_open_id,
                operator_name,
                operator_phone,
                transfer_when_exit_relation,
                ct_fans_type,
                operator_yz_open_id
            }, "1.0.0");
            return response;
        }

        /// <summary>
        /// 通过客户关系id列表，批量转移客户关系
        /// </summary>
        /// <remarks>
        /// https://doc.youzanyun.com/detail/API/0/642
        /// </remarks>
        /// <param name="relation_ids">客户关系id列表</param>
        /// <param name="operator_id">操作人userId</param>
        /// <param name="operator_name">操作人名称</param>
        /// <param name="operator_phone">操作人手机</param>
        /// <param name="current_ds_mobile">当前分销员手机号，用于判断是否是还是当前分销员</param>
        /// <param name="target_ds_mobile">目标分销员手机号</param>
        /// <returns>
        /// <para>当自己转移给自己的时候，提示：指定的分销员不能是分销员自己</para>
        /// <para>当客户是自己，并且设置为不允许自己是自己的分销是，提示：商家关闭自购分佣,无法转移客户关系给自己</para>
        /// </returns>
        public async Task<ResponseBase<bool>> TransferAsync(List<long> relation_ids
            , long operator_id
            , string operator_name
            , string operator_phone
            , string target_ds_mobile
            , string current_ds_mobile
            , string version = "1.0.1")
        {
            var response = await PostAsync<bool>("youzan.salesman.relation.transfer", new Dictionary<string, object>
            {
                { "relation_ids", relation_ids},
                { "operator",new
                         {
                             operator_id,
                             operator_name,
                             operator_phone
                         }},
                { "target_ds_mobile",target_ds_mobile},
                { "current_ds_mobile",current_ds_mobile},
            }, version);
            return response;
        }

    }
}

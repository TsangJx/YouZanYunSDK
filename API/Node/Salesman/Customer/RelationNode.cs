using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YouZanYun.Salesman.Customer;
using YouZanYun.Salesman.Customer.Relation;

namespace YouZanYun.Salesman.Customer
{
    [Obsolete("请使用Salesman.Relation", false)]
    public class RelationNode : NodeBase
    {
        public RelationNode(YouZanYunAPIClient client) : base(client)
        {

        }

        /// <summary>
        /// 客户和导购关系绑定接口
        /// </summary>
        /// <remarks>
        /// https://doc.youzanyun.com/detail/API/0/1196
        /// </remarks>
        /// <param name="force_modify">是否需要强制绑定，强制绑定则会跳过保护期，默认跳过保护期。是：true， 否：false</param>
        /// <param name="new_salesman_node_kdt_id">新绑定导购所属店铺ID</param>
        /// <param name="salesman_yz_open_id">原导购员唯一ID;创建可以不传</param>
        /// <param name="new_salesman_yz_open_id">新导购员唯一ID</param>
        /// <param name="yz_open_id">有赞用户id，用户在有赞的唯一id</param>
        /// <param name="salesman_node_kdt_id">原导购员所属店铺ID</param>
        /// <returns></returns>
        [Obsolete("请使用Salesman.Relation.AdjustAsync", false)]
        public async Task<bool> ModifyAsync(
            string yz_open_id
            , long new_salesman_node_kdt_id
            , string new_salesman_yz_open_id
            , bool force_modify
            , string salesman_yz_open_id = null
            , long? salesman_node_kdt_id = null
        )
        {
            var response = await PostAsync<bool>("youzan.salesman.customer.relation.modify", new
            {
                force_modify,
                new_salesman_node_kdt_id,
                salesman_yz_open_id,
                new_salesman_yz_open_id,
                yz_open_id,
                salesman_node_kdt_id
            }, "1.0.0");

            return response.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="yz_open_id">有赞用户ID，在有赞平台账号平台下唯一</param>
        /// <param name="version"></param>
        /// <returns></returns>
        [Obsolete("请使用Salesman.Relation.AdjustAsync", false)]
        public async Task<QueryData> QueryAsync(string yz_open_id
            , string version = "1.0.0")
        {
            var response = await PostAsync<QueryData>("youzan.salesman.customer.relation.query", new
            {
                yz_open_id
            }, version);
            return response.Data;
        }
    }
}

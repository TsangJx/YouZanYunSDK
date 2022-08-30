using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YouZanYun.Salesman.Customer;

namespace YouZanYun.Salesman
{

    public class CustomerNode : NodeBase
    {
        public CustomerNode(YouZanYunAPIClient client) : base(client)
        {
            Relation = new Customer.RelationNode(client);
        }

        public Customer.RelationNode Relation { get; set; }

        /// <summary>
        /// 查询导购员列表
        /// </summary>
        /// <param name="page_size"></param>
        /// <param name="page_no"></param>
        /// <param name="keyword"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        [Obsolete("请使用Salesman.Accounts.GetAsync", false)]
        public async Task<ResponsePagedListBase<QueryRowItem>> QueryAsync(int page_size = 20
        , int page_no = 1
        , string keyword = null
        , string version = "1.0.0")
        {
            var response = await PostPagedListAsync<QueryRowItem>("youzan.salesman.customer.query", new
            {
                page_size,
                page_no,
                keyword
            },version);
            return response;
        }
    }
}

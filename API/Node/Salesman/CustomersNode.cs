using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YouZanYun.Salesman.Customers;

namespace YouZanYun.Salesman
{

    public class CustomersNode : NodeBase
    {
        public CustomersNode(YouZanYunAPIClient client) : base(client)
        {
        }

        public async Task<ResponseBase<GetData>> GetAsync(int page_size = 20
        , int page_no = 1
        , int? ds_uid = null
        , string mobile = null
        , int? type = null
        , string version = "3.0.1")
        {
            var response = await PostAsync<GetData>("youzan.salesman.customers.get", new
            {
                account_relation_list_query_open_d_t_o =
                new
                {
                    page_size,
                    page_no,
                    ds_uid,
                    mobile,
                    type
                }
            }, version);
            return response;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YouZanYun.Salesman.Groups;

namespace YouZanYun.Salesman
{
    public class GroupsNode : NodeBase
    {
        public GroupsNode(YouZanYunAPIClient client) : base(client)
        {

        }

        public async Task<ResponseBase<GetData>> GetAsync(int page_size = 10
        , int page_no = 1
        , long? node_kdt_id = null
        , string version = "3.0.0")
        {
            var response = await PostAsync<GetData>("youzan.salesman.groups.get", new
            {
                page_size,
                page_no,
                node_kdt_id
            }, version);
            return response;
        }
    }
}

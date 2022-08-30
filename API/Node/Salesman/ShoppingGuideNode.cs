using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YouZanYun.Salesman.Customer;
using YouZanYun.Salesman.Relation;

namespace YouZanYun.Salesman
{

    public class ShoppingGuideNode : NodeBase
    {
        public ShoppingGuideNode(YouZanYunAPIClient client) : base(client)
        {
            Query = new QueryNode(client);
        }

        public QueryNode Query { get; set; }
    }
}

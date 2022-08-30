using System;
using YouZanYun.Crm;

namespace YouZanYun
{
    public partial class CrmNode : NodeBase
    {
        public CrmNode(YouZanYunAPIClient client) : base(client)
        {

            Customer = new CustomerNode(client);
        }


        public CustomerNode Customer { get; private set; }
    }
}
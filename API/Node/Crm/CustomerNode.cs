using System;
using YouZanYun.Crm.Customer;

namespace YouZanYun.Crm
{
    public partial class CustomerNode : NodeBase
    {
        public CustomerNode(YouZanYunAPIClient client) : base(client)
        {

            Points = new PointsNode(client);
        }


        public PointsNode Points { get; private set; }
    }
}
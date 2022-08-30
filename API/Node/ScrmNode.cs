using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YouZanYun.Scrm;
using YouZanYun.Users;

namespace YouZanYun
{
    public partial class ScrmNode : NodeBase
    {
        public ScrmNode(YouZanYunAPIClient client) : base(client)
        {
            Customer = new CustomerNode(client);
        }

        public CustomerNode Customer { get; private set; }
    }
}

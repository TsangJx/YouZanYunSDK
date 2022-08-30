using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using YouZanYun.User;

namespace YouZanYun
{
    public partial class UserNode : NodeBase
    {
        public UserNode(YouZanYunAPIClient client) : base(client)
        {

            Openid = new OpenidNode(client);
        }


        public OpenidNode Openid { get; private set; }
    }
}

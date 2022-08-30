using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YouZanYun.Users;

namespace YouZanYun
{
    public partial class UsersNode : NodeBase
    {
        public UsersNode(YouZanYunAPIClient client) : base(client)
        {
            Info = new InfoNode(client);
        }

        public InfoNode Info { get; private set; }
    }
}

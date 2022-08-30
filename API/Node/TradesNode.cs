using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YouZanYun.Trades;

namespace YouZanYun
{
    public partial class TradesNode : NodeBase
    {
        public TradesNode(YouZanYunAPIClient client) : base(client)
        {
            Sold = new SoldNode(client);
        }

        public SoldNode Sold { get; private set; }
    }
}

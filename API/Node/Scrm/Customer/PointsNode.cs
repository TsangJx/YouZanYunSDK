using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using YouZanYun.Scrm.Customer.Points;

namespace YouZanYun.Scrm.Customer
{
    public partial class PointsNode : NodeBase
    {
        public PointsNode(YouZanYunAPIClient client) : base(client)
        {

            Operate = new OperateNode(client);
            Rule = new RuleNode(client);
        }



        public OperateNode Operate { get; private set; }
        public RuleNode Rule { get; private set; }

    }

}
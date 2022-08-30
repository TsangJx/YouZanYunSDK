using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using YouZanYun.Guide;

namespace YouZanYun
{
    public partial class GuideNode : NodeBase
    {
        public GuideNode(YouZanYunAPIClient client) : base(client)
        {

            Relation = new RelationNode(client);
        }


        public RelationNode Relation { get; private set; }
    }
}
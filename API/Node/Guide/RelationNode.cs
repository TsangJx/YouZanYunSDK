using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using YouZanYun.Guide.Relation;

namespace YouZanYun.Guide
{
    public partial class RelationNode : NodeBase
    {
        public RelationNode(YouZanYunAPIClient client) : base(client)
        {

            Query = new QueryNode(client);
        }


        public QueryNode Query { get; private set; }
    }
}
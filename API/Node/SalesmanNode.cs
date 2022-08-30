using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YouZanYun.Salesman;

namespace YouZanYun
{
    public partial class SalesmanNode : NodeBase
    {
        public SalesmanNode(YouZanYunAPIClient client) : base(client)
        {
            Customer = new CustomerNode(client);
            Customers = new CustomersNode(client);
            Groups = new GroupsNode(client);
            Account = new AccountNode(client);
            Accounts = new AccountsNode(client);
            Relation = new RelationNode(client);
            ShoppingGuide = new ShoppingGuideNode(client);
            Trades = new YouZanYun.Salesman.TradesNode(client);
        }

        public CustomerNode Customer { get; private set; }
        public CustomersNode Customers { get; private set; }
        public GroupsNode Groups { get; private set; }
        public AccountNode Account { get; private set; }
        public AccountsNode Accounts { get; private set; }
        public RelationNode Relation { get; private set; }
        public ShoppingGuideNode ShoppingGuide { get; private set; }
        public YouZanYun.Salesman.TradesNode Trades { get; private set; }

    }
}

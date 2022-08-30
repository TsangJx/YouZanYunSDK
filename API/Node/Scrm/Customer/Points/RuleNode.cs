using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace YouZanYun.Scrm.Customer.Points
{
    public partial class RuleNode : NodeBase
    {
        public RuleNode(YouZanYunAPIClient client) : base(client)
        {

        }

        /// <summary>
        /// 获取商家积分规则
        /// </summary>
        /// <remarks>
        /// https://doc.youzanyun.com/detail/API/0/2846
        /// </remarks>
        /// <returns></returns>
        public async Task<ResponseBase<YouZanYun.Scrm.Customer.Points.Rule.ListData>> ListAsync(
        )
        {
            var response = await PostAsync<YouZanYun.Scrm.Customer.Points.Rule.ListData>("youzan.scrm.customer.points.rule.list", new
            {
            }, "1.0.0");
            return response;
        }

    }
}

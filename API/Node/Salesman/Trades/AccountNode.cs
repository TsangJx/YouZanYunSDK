using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YouZanYun.Infrastructure;
using YouZanYun.Salesman.Trades.Account;

namespace YouZanYun.Salesman.Trades
{
    public class AccountNode : NodeBase
    {
        public AccountNode(YouZanYunAPIClient client) : base(client)
        {

        }
        /// <summary>
        /// 查询订单归属的销售员
        /// </summary>
        /// <remarks>
        /// https://doc.youzanyun.com/detail/API/0/36
        /// </remarks>
        /// <param name="order_no">推广订单号即有赞订单号，E开头+年月日时分秒+随机数，长度24位字母和数字组合</param>
        /// <returns>返回的是销售员的手机号</returns>
        public async Task<ResponseBase<YouZanYun.Salesman.Trades.Account.GetData>> GetV3Async(
            string order_no
        )
        {
            var response = await PostAsync<YouZanYun.Salesman.Trades.Account.GetData>("youzan.salesman.trades.account.get", new
            {
                order_no
            }, "3.0.0");
            return response;
        }
    }
}

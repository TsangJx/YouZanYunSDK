using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YouZanYun.Infrastructure;
using YouZanYun.Salesman.Trades.Account;

namespace YouZanYun.Salesman.Trades
{
    public class GetNode : NodeBase
    {
        public GetNode(YouZanYunAPIClient client) : base(client)
        {

        }

        /// <summary>
        /// 查询分销采购订单详情接口
        /// </summary>
        /// <remarks>
        /// https://doc.youzanyun.com/detail/API/0/2952
        /// </remarks>
        /// <param name="tid">买家订单号，E开头+年月日时分秒+随机数，长度24位字母和数字组合</param>
        /// <returns></returns>
        public async Task<ResponseBase<YouZanYun.Salesman.Trades.Get.PaymentData>> PaymentAsync(
            string tid
        )
        {
            var response = await PostAsync<YouZanYun.Salesman.Trades.Get.PaymentData>("youzan.salesman.trades.get.payment", new
            {
                tid
            }, "1.0.0");
            return response;
        }
    }
}

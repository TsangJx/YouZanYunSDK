using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using YouZanYun.Trade;

namespace YouZanYun
{
    public partial class TradeNode : NodeBase
    {
        public TradeNode(YouZanYunAPIClient client) : base(client)
        {
            Refund = new RefundNode(client);
        }
        public RefundNode Refund { get; private set; }

        /// <summary>
        /// 查询单笔交易详情接口
        /// </summary>
        /// <remarks>
        /// https://doc.youzanyun.com/detail/API/0/3400
        /// </remarks>
        /// <param name="tid">有赞订单号，E开头长度24位字母和数字组合，也支持了C开头的送礼子订单</param>
        /// <returns></returns>
        public async Task<ResponseBase<YouZanYun.Trade.GetV4_0_1Data>> GetV4_0_1Async(
                    string tid
        )
        {
            var response = await PostAsync<YouZanYun.Trade.GetV4_0_1Data>("youzan.trade.get", new
            {
                tid
            }, "4.0.1");
            return response;
        }

    }
}

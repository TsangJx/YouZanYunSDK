using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using YouZanYun.Scrm.Customer.Points.Operate;

namespace YouZanYun.Scrm.Customer.Points
{
    public partial class OperateNode : NodeBase
    {
        public OperateNode(YouZanYunAPIClient client) : base(client)
        {

        }

        /// <summary>
        /// 解冻用户积分
        /// </summary>
        /// <remarks>
        /// https://doc.youzanyun.com/detail/API/0/2673
        /// </remarks>
        /// <param name="params">解冻用户积分请求参数</param>
        /// <returns></returns>
        public async Task<ResponseBase<SuccessData>> UnfreezeAsync(
                    YouZanYun.Scrm.Customer.Points.Operate.UnfreezeArgsModels.ParamsModel params_
        )
        {
            var response = await PostAsync<SuccessData>("youzan.scrm.customer.points.operate.unfreeze", new Dictionary<string, object>
            {
                { "params",params_ }
            }, "1.0.0");
            return response;
        }

        /// <summary>
        /// 冻结用户积分
        /// </summary>
        /// <remarks>
        /// https://doc.youzanyun.com/detail/API/0/2672
        /// </remarks>
        /// <param name="params">冻结用户积分请求参数</param>
        /// <returns></returns>
        public async Task<ResponseBase<SuccessData>> FreezeAsync(
                    YouZanYun.Scrm.Customer.Points.Operate.FreezeArgsModels.ParamsModel params_
        )
        {
            var response = await PostAsync<SuccessData>("youzan.scrm.customer.points.operate.freeze", new Dictionary<string, object>
            {
                { "params",params_ }
            }, "1.0.0");
            return response;
        }

        /// <summary>
        /// 用户积分消耗
        /// </summary>
        /// <remarks>
        /// https://doc.youzanyun.com/detail/API/0/2674
        /// </remarks>
        /// <param name="params">消耗用户积分请求参数</param>
        /// <returns></returns>
        public async Task<ResponseBase<SuccessData>> ConsumeAsync(
                    YouZanYun.Scrm.Customer.Points.Operate.ConsumeArgsModels.ParamsModel params_
        )
        {
            var response = await PostAsync<SuccessData>("youzan.scrm.customer.points.operate.consume", new Dictionary<string, object>
            {
                { "params",params_ }
            }, "1.0.0");
            return response;
        }



    }
}

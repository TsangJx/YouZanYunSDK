using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using YouZanYun.Crm.Customer.Points;

namespace YouZanYun.Crm.Customer
{
    public partial class PointsNode : NodeBase
    {
        public PointsNode(YouZanYunAPIClient client) : base(client)
        {
            Changelog = new ChangelogNode(client);
        }
        public ChangelogNode Changelog { get; private set; }
        /// <summary>
        /// 给用户加积分
        /// </summary>
        /// <remarks>
        /// https://doc.youzanyun.com/detail/API/0/872
        /// </remarks>
        /// <param name="params"> 请求参数</param>
        /// <returns></returns>
        public async Task<ResponseBase<SuccessData>> IncreaseV4Async(
                    YouZanYun.Crm.Customer.Points.IncreaseV4ArgsModels.ParamsModel params_
        )
        {
            var response = await PostAsync<SuccessData>("youzan.crm.customer.points.increase", new Dictionary<string, object>
            {
                { "params",params_ }
            }, "4.0.0");
            return response;
        }

        /// <summary>
        /// 给用户减积分
        /// </summary>
        /// <remarks>
        /// https://doc.youzanyun.com/detail/API/0/873
        /// </remarks>
        /// <param name="params">请求参数</param>
        /// <returns></returns>
        public async Task<ResponseBase<SuccessData>> DecreaseV4Async(
                    YouZanYun.Crm.Customer.Points.DecreaseV4ArgsModels.ParamsModel params_
        )
        {
            var response = await PostAsync<SuccessData>("youzan.crm.customer.points.decrease", new Dictionary<string, object>
            {
                { "params",params_ }
            }, "4.0.0");
            return response;
        }


        /// <summary>
        /// 查询用户当前积分
        /// </summary>
        /// <remarks>
        /// https://doc.youzanyun.com/detail/API/0/884
        /// </remarks>
        /// <param name="is_do_extpoint">是否需要走扩展点，默认：true（扩展点：https://doc.youzanyun.com/detail/EXT/35）</param>
        /// <param name="user">用户</param>
        /// <returns></returns>
        public async Task<ResponseBase<YouZanYun.Crm.Customer.Points.GetData>> GetAsync(
            YouZanYun.Crm.Customer.Points.GetArgsModels.UserModel user
            , bool? is_do_extpoint = null
        )
        {
            var response = await PostAsync<YouZanYun.Crm.Customer.Points.GetData>("youzan.crm.customer.points.get", new
            {
                is_do_extpoint,
                user
            }, "1.0.0");
            return response;
        }


        /// <summary>
        /// 同步客户积分
        /// </summary>
        /// <remarks>
        /// https://doc.youzanyun.com/detail/API/0/883
        /// </remarks>
        /// <param name="reason">积分变动原因</param>
        /// <param name="is_do_extpoint">是否需要走扩展点，默认：true（涉及到的扩展点：https://doc.youzanyun.com/detail/EXT/35，https://doc.youzanyun.com/detail/EXT/19，https://doc.youzanyun.com/detail/EXT/40）</param>
        /// <param name="biz_value">外部业务标识；用于幂等支持（幂等时效三个月, 超过三个月的相同值调用不保证幂等）[即相同帐号、业务标识字段的重复调用在三个月内不会重复发放积分]</param>
        /// <param name="user">用户信息</param>
        /// <param name="points">积分变动值</param>
        /// <returns></returns>
        public async Task<ResponseBase<SuccessData>> SyncV4Async(
            int points
            , string reason
            , YouZanYun.Crm.Customer.Points.SyncV4ArgsModels.UserModel user
            , bool? is_do_extpoint = null
            , string biz_value = null
        )
        {
            var response = await PostAsync<SuccessData>("youzan.crm.customer.points.sync", new
            {
                reason,
                is_do_extpoint,
                biz_value,
                user,
                points
            }, "4.0.0");
            return response;
        }

    }
}
using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace YouZanYun.Crm.Customer.Points
{
    public partial class ChangelogNode : NodeBase
    {
        public ChangelogNode(YouZanYunAPIClient client) : base(client)
        {

        }


        /// <summary>
        /// 查询用户积分日志
        /// </summary>
        /// <remarks>
        /// https://doc.youzanyun.com/detail/API/0/3410
        /// </remarks>
        /// <param name="end_time">结束时间（以起始时间开始的7天内的时间点）</param>
        /// <param name="begin_time">起始时间（仅支持当前时间30天内的时间点。如果开始时间为空，则默认取当前时间开始最近7天内的记录）</param>
        /// <param name="is_do_ext_point">是否需要走扩展点，默认：true （扩展点名称：查看用户积分变动日志）</param>
        /// <param name="page">分页数</param>
        /// <param name="user">用户</param>
        /// <param name="page_size">分页大小（最多每页50条）</param>
        /// <returns></returns>
        public async Task<ResponseBase<YouZanYun.Crm.Customer.Points.Changelog.SearchV4_0_2Data>> SearchV4_0_2Async(
              DateTime begin_time
            , DateTime end_time
            , YouZanYun.Crm.Customer.Points.Changelog.SearchV4_0_2ArgsModels.UserModel user
            , int page = 1
            , int page_size = 20
            , bool? is_do_ext_point = null
        )
        {
            var response = await PostAsync<YouZanYun.Crm.Customer.Points.Changelog.SearchV4_0_2Data>("youzan.crm.customer.points.changelog.search", new
            {
                end_time = end_time.ToString("yyyy-MM-dd HH:mm:ss"),
                begin_time = begin_time.ToString("yyyy-MM-dd HH:mm:ss"),
                is_do_ext_point,
                page,
                user,
                page_size
            }, "4.0.2");
            return response;
        }

    }
}
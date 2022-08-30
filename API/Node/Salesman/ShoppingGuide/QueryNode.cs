using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YouZanYun.Salesman.ShoppingGuide.Query;
using YouZanYun.Salesman.Customer;
using YouZanYun.Salesman.Relation;

namespace YouZanYun.Salesman
{

    public class QueryNode : NodeBase
    {
        public QueryNode(YouZanYunAPIClient client) : base(client)
        {

        }

        /// <summary>
        /// 查询导购员业绩信息
        /// </summary>
        /// <remarks>
        /// https://doc.youzanyun.com/detail/API/0/2818
        /// </remarks>
        /// <param name="start_time">订单开始时间，时间格式：yyyy-MM-dd</param>
        /// <param name="mobile">导购手机号</param>
        /// <param name="end_time">订单结束时间，时间格式：yyyy-MM-dd</param>
        /// <param name="yz_open_id">导购有赞用户id，用户在有赞的唯一id。</param>
        /// <param name="page_no">页码，从1~100开始，分页数不能超过100页。如果订单较多请使用时间参数分割。page_size 和page_no相乘总条数不能大于3200条。</param>
        /// <param name="page_size">每页条数。默认20条，最大不能超过100，建议使用默认分页。如果订单较多请使用时间参数分割。page_size 和page_no相乘总条数不能大于3200条。</param>
        /// <returns></returns>
        public async Task<ResponseBase<AchievementsData>> AchievementsAsync(
            DateTime start_time
            , DateTime end_time
            , string mobile = null
            , string yz_open_id = null
            , int? page_no = null
            , int? page_size = null
        )
        {
            var response = await PostAsync<AchievementsData>("youzan.salesman.shoppingguide.query.achievements", new
            {
                start_time = start_time.ToString("yyyy-MM-dd"),
                mobile,
                end_time = end_time.ToString("yyyy-MM-dd"),
                yz_open_id,
                page_no,
                page_size
            }, "1.0.0");
            return response;
        }

    }
}


using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using YouZanYun.Guide.Relation.Query;

namespace YouZanYun.Guide.Relation
{
    public partial class QueryNode : NodeBase
    {
        public QueryNode(YouZanYunAPIClient client) : base(client)
        {


        }

        /// <summary>
        /// 根据客户查询导购专属关系
        /// </summary>
        /// <remarks>
        /// https://doc.youzanyun.com/detail/API/0/3736
        /// </remarks>
        /// <param name="request">请求体</param>
        /// <returns></returns>
        public async Task<ResponseBase<YouZanYun.Guide.Relation.Query.UseridV2Data>> UseridV2Async(
                    YouZanYun.Guide.Relation.Query.UseridV2ArgsModels.RequestModel request
        )
        {
            var response = await PostAsync<YouZanYun.Guide.Relation.Query.UseridV2Data>("youzan.guide.relation.query.userId", new
            {
                request
            }, "2.0.0");
            return response;
        }


    }
}


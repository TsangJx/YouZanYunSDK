using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using YouZanYun.User.Openid;

namespace YouZanYun.User
{
    public partial class OpenidNode : NodeBase
    {
        public OpenidNode(YouZanYunAPIClient client) : base(client)
        {

        }

        /// <summary>
        /// 获取有赞openId
        /// </summary>
        /// <remarks>
        /// https://doc.youzanyun.com/detail/API/0/323
        /// </remarks>
        /// <param name="user_id">有赞用户Id，在有赞平台账号平台下唯一。user_id，yz_uid，account_id都是账号id（后续会废弃推荐使用yz_open_id）</param>
        /// <returns></returns>
        public async Task<ResponseBase<YouZanYun.User.Openid.GetData>> GetAsync(
                    long user_id
        )
        {
            var response = await PostAsync<YouZanYun.User.Openid.GetData>("youzan.user.openid.get", new
            {
                user_id
            }, "1.0.0");
            return response;
        }

    }
}

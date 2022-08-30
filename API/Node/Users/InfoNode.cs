using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YouZanYun.Users.Info;

namespace YouZanYun.Users
{
    public partial class InfoNode : NodeBase
    {
        public InfoNode(YouZanYunAPIClient client) : base(client)
        {

        }
        /// <summary>
        /// 用户查询接口
        /// </summary>
        /// <remarks>
        /// https://doc.youzanyun.com/detail/API/0/2193
        /// </remarks>
        /// <param name="open_id_type">weixin_open_id类型，1-微信公众号，2-微信小程序，9-微信大账号，weixin_open_id不为空时该参数必填</param>
        /// <param name="weixin_open_id">微信体系的openId；和yz_open_id、mobile、weixin_union_id至少传一个</param>
        /// <param name="mobile">手机号，只支持+86；和yz_open_id、weixin_union_id、weixin_open_id至少传一个</param>
        /// <param name="yz_open_id">有赞用户id，用户在有赞的唯一id。推荐使用；和mobile、weixin_union_id、weixin_open_id至少传一个</param>
        /// <param name="weixin_union_id">微信体系的unionId；和yz_open_id、mobile、weixin_open_id至少传一个</param>
        /// <param name="result_type_list">返回结果类型列表，0-手机帐号；1-微信公众号；2-微信小程序；9-微信大账号；默认0。开发者可以根据自己需要的选择传入。补充说明：；在微信公众号场景下，正常会进行两次授权，一次通过商家公众号授权，一次通过有赞公众号授权，分别产生不同的用户数据： 1）1-微信公众号：通过商家的公众号授权产生的用户 2）9-微信大账号：通过”有赞“公众号授权产生的用户</param>
        /// <returns></returns>
        public async Task<ResponseBase<QueryData>> QueryAsync(
            int? open_id_type = null
            , string weixin_open_id = null
            , string mobile = null
            , string yz_open_id = null
            , string weixin_union_id = null
            , List<int> result_type_list = null
        )
        {
            var response = await PostAsync<QueryData>("youzan.users.info.query", new
            {
                open_id_type,
                weixin_open_id,
                mobile,
                yz_open_id,
                weixin_union_id,
                result_type_list
            }, "1.0.0");
            return response;
        }
    }
}

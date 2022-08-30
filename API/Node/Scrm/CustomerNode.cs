using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YouZanYun.Scrm.Customer;

namespace YouZanYun.Scrm
{
    public partial class CustomerNode : NodeBase
    {
        public CustomerNode(YouZanYunAPIClient client) : base(client)
        {
            Points = new PointsNode(client);
        }
        public PointsNode Points { get; private set; }
        /// <summary>
        /// 创建客户到店铺
        /// </summary>
        /// <remarks>
        /// https://doc.youzanyun.com/detail/API/0/92
        /// </remarks>
        /// <param name="mobile">注册手机号（仅支持中国大陆地区手机号码）</param>
        /// <param name="scrm_channel_type">scrm渠道类型（2：伯俊），其他开发者无需使用该字段</param>
        /// <param name="label_info">客户标识信息</param>
        /// <param name="is_do_ext_point">是否需要走扩展点，不传参数默认为true，true-走扩展点 false-不走扩展点 （其中扩展点为第三方创建客户）</param>
        /// <param name="create_date">用户创建时间(日期格式:yyyy-MM-dd HH:mm:ss)</param>
        /// <returns></returns>
        public async Task<ResponseBase<CreateData>> CreateV3Async(
            string mobile
            , string wei_xin = null
            , short? gender = null
            , int? area_code = null
            , string remark = null
            , DateTime? birthday = null
            , string name = null
            , long? ascription_kdt_id = null
            , int? scrm_channel_type = null
            , int? src_way = null
            , int? src_channel = null
            , bool? is_do_ext_point = null
            , DateTime? create_date = null
        )
        {
            var response = await PostAsync<CreateData>("youzan.scrm.customer.create", new
            {
                mobile,
                customer_create = new
                {
                    wei_xin,
                    gender,
                    contact_address = new
                    {
                        area_code
                    },
                    remark,
                    birthday = birthday?.ToString("yyyy-MM-dd HH:mm:ss"),
                    name,
                    ascription_kdt_id
                },
                scrm_channel_type,
                label_info = new
                {
                    src_way,
                    src_channel
                },
                is_do_ext_point,
                create_date = create_date?.ToString("yyyy-MM-dd HH:mm:ss"),
            }, "3.0.0");
            return response;
        }
    }
}

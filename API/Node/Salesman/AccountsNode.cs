using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YouZanYun.Infrastructure;
using YouZanYun.Salesman.Accounts;

namespace YouZanYun.Salesman
{
    public class AccountsNode : NodeBase
    {
        public AccountsNode(YouZanYunAPIClient client) : base(client)
        {

        }

        public async Task<GetData> GetAsync(int page_size = 10
        , int page_no = 1
        , long? group_id = null
        , DateTime? StartTime = null
        , DateTime? EndTime = null
        , string version = "3.0.0")
        {
            long? start_time = null;
            long? end_time = null;
            if (StartTime.HasValue)
            {
                start_time = TimestampUtil.ToTimestamp(StartTime.Value);
            }

            if (EndTime.HasValue)
            {
                end_time = TimestampUtil.ToTimestamp(EndTime.Value);
            }
            var response = await PostAsync<GetData>("youzan.salesman.accounts.get", new
            {
                page_size,
                page_no,
                group_id,
                start_time,
                end_time
            }, version);
            return response.Data;
        }
    }
}

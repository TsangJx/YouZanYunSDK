using System;
using System.Collections.Generic;
using System.Text;

namespace YouZanYun
{
    public class NodeBase
    {
        protected YouZanYunAPIClient Client { get; set; }
        public NodeBase(YouZanYunAPIClient client)
        {
            this.Client = client;
        }

        protected async System.Threading.Tasks.Task<ResponseBase<T>> PostAsync<T>(string name, object args, string version = "1.0.0")
        {
            return await Client.PostAsync<T>(name, args, version);
        }

        protected async System.Threading.Tasks.Task<ResponsePagedListBase<T>> PostPagedListAsync<T>(string name, object args, string version = "1.0.0")
        {
            return await Client.PostPagedListAsync<T>(name, args, version);
        }
    }
}

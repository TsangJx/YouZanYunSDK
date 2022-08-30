using System;
using System.Collections.Generic;
using System.Text;

namespace YouZanYun.Infrastructure
{
    public abstract class EntityOperateTime
    {
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }
}

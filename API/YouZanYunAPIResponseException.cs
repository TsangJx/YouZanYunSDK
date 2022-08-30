using System;
using System.Collections.Generic;
using System.Text;

namespace YouZanYun
{
    public class YouZanYunAPIResponseException : Exception
    {
        public YouZanYunAPIResponseException(ResponseError error) : base(error.ErrorMessage)
        {

        }
    }
}

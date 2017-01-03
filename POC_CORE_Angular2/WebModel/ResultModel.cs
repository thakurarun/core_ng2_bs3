using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC_CORE_Angular2.WebModel
{
    public class ResultModel
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public object PreserveData { get; set; }
    }
}

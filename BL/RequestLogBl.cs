using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    class RequestLogBl : BllBase<RequestLog>
    {
        public RequestLogBl()
        {
            this.dal = new RequestLogRepository();
        }
    }
}

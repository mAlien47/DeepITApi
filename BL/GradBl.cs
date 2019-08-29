using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class GradBl : BllBase<Grad>
    {
        public GradBl()
        {
            this.dal = new GradRepository();
        }
    }
}

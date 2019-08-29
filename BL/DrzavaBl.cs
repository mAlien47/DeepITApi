using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class DrzavaBl : BllBase<Drzava>
    {
        public DrzavaBl()
        {
            this.dal = new DrzavaRepository();
        }
    }
}

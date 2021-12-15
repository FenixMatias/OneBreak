using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnBreak.Data;

namespace OnBreak.Bussines
{
    internal class Connection
    {
        private static OnBreakEntities1 _onBreak;

        public static OnBreakEntities1 _ONBREAK
        {
            get
            {
                if (_onBreak == null)
                {
                    _onBreak = new OnBreakEntities1();
                }
                return _onBreak;
            }
        }
    }
}

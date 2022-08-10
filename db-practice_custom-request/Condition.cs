using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nstd
{
    class Condition
    {
        public Condition(Column clmn, string criteria, object expression, string joint)
        {
            Clmn = clmn;
            Criteria = criteria;
            Expression = expression;
            Joint = joint;
        }

        public Column Clmn { get; set; }
        public string Criteria { get; set; }
        public object Expression { get; set; }
        public string Joint { get; set; }
    }
}

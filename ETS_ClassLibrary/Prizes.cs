using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS_ClassLibrary
{
    class Prizes : CollectionBase
    {
        public void add(Prize pri)
        {
            List.Add(pri);
        }

        public Prize this[int index]
        {
            get { return (Prize)List[index]; }
            set { List[index] = value; }
        }
    }
}

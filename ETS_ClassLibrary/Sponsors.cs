using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS_ClassLibrary
{
    class Sponsors : CollectionBase
    {
        public void add(Sponsor spo)
        {
            List.Add(spo);
        }

        public Sponsor this[int index]
        {
            get { return (Sponsor)List[index]; }
            set { List[index] = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrKhaled.Xmrizer
{
    public class Condition
    {
        public string Property { get; set; }
        public string Comparator { get; set; }
        public string Value { get; set; }

        public Condition(string prop , string cmp , string val)
        {
            Property = prop;
            Comparator = cmp;
            Value = val;
        }
    }
}

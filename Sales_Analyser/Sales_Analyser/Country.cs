using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modern_UI
{
    class Country
    {
        public string country_name { get; set; }
        public int country_id { get; set; }

        public override string ToString()
        {
            return country_name;
        }
    }
}

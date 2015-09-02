using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modern_UI
{
    class Region
    {
        public string region_name { get; set; }
        public int region_id { get; set; }

        public override string ToString()
        {
            return region_name;
        }
    }
}

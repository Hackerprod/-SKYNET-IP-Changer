using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKYNET.Models
{
    public class Profile
    {
        public string Name { get; set; }
        public string Adapter { get; set; }
        public NetworkSettings AdapterSettings { get; set; }
    }
}

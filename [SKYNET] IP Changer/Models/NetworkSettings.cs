using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKYNET.Models
{
    public class NetworkSettings
    {
        public string IP { get; set; }
        public string Mask { get; set; }
        public string Gateway { get; set; }
        public string DNS_1 { get; set; }
        public string DNS_2 { get; set; }
        public string IP_Secondary { get; set; }
        public string Mask_Secondary { get; set; }
    }
}

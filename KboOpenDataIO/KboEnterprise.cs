using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KboOpenDataIO
{
    class KboEnterprise
    {
        public string Id { get; set; } // string EnterpriseNumber
        public string Status { get; set; }
        public string JuridicalSituation { get; set; }
        public string TypeOfEnterprise { get; set; }
        public string JuridicalForm { get; set; }
        public DateTime StartDate { get; set; }
    }
}

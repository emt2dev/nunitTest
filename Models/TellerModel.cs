using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nunitTest.Models
{
    internal class TellerModel
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; }

        public TellerModel(string GivenEID)
        {
            EmployeeId = GivenEID;
        }
    }
}

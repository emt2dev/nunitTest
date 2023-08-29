using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nunitTest.Models
{
    internal class BranchModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public Boolean? IsATM { get; set; }
        public TellerModel? Teller { get; set; }
        public BranchModel(int GivenId)
        {
            Id = GivenId;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astellas_Pharma.Entities
{
    class Reviewer:User
    {
        private string[] specialisms;

        private double[] averages;
        public string[] Specialisms { get; set; }
        public double[] Averages { get; set; }

    }
}

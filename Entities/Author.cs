using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astellas_Pharma.Entities
{
    class Author:User
    {
        private RDoc rdoc;
        public RDoc Rdoc { get; set; }
    }
}

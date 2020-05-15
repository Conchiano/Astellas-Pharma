using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//importing Libraries
using MySql.Data;
using Astellas_Pharma.Entities;

namespace Astellas_Pharma
{
    class User:Database
    {
       
        public string Firstname { get; set; }

        public string Surname { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string[] SpecialismList { get; set; }
    }
}

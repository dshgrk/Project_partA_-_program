using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace partA
{
    public class BeautySpecialist : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; } 
        public Procedure Specialization { get; set; }
        public List<Booking> ListOfProcedures { get; set; }

        public BeautySpecialist(string name, int age, Procedure specialization, int salary)
        {
            throw new NotImplementedException();
        }

        public void DisplayInfo()
        {
            throw new NotImplementedException();
        }
    }
}

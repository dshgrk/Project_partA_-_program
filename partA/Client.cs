using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partA
{
    public class Client : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<Booking> listOfBooking { get; set; }

        public Client(string name, int age)
        {
            throw new NotImplementedException();
        }

        public void AddProcedure(Booking booking)
        {
            throw new NotImplementedException();
        }

        public void RemoveProcedure()
        {
            throw new NotImplementedException();
        }

        public void ClearProcedures()
        {
            throw new NotImplementedException();
        }

        public void DisplayInfo()
        {
            throw new NotImplementedException();
        }
    }
}

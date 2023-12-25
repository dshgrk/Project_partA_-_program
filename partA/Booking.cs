using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partA
{
    public class Booking : IPrint
    {
        public BeautySpecialist BeautySpecialist { get; set; }
        public Client Client { get; set; }
        public DateTime BookingTime { get; set; }
        public Procedure Procedure { get; set; }

        public Booking(Client client, Procedure procedure, DateTime bookingTime, BeautySpecialist beautySpecialist)
        {
            throw new NotImplementedException();
        }

        public Booking(Procedure procedure, BeautySpecialist beautySpecialist)
        {
            throw new NotImplementedException();
        }

        public void PrintToDisplay()
        {
            throw new NotImplementedException();
        }
    }
}

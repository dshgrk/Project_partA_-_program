using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace partA
{
    public class Procedure : IPrint
    {
        public int Price { get; set; }
        public ProcedureTypes Name { get; set; }
        public TimeSpan Duration { get; set; }
        public BeautySpecialist Specialist { get; set; }
        public Procedure(ProcedureTypes name, int price, TimeSpan duration) 
        {
            throw new NotImplementedException();
        }
        public void PrintToDisplay()
        {
            throw new NotImplementedException();
        }

        public Procedure()
        {
            throw new NotImplementedException();
        }
    }
}

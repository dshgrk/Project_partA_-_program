using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partA
{
    public class Procedure
    {
        public int Price { get; set; }
        public ProcedureTypes Name { get; set; }
        public TimeSpan Duration { get; set; }
        public Procedure(ProcedureTypes name, int price, duration TimeSpan) 
        {
            throw new NotImplementedException();
        }
        public void PrintToDisplay()
        {
            throw new NotImplementedException();
        }
    }
}

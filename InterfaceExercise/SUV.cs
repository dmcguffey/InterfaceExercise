using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public int wheels { get; set; }
        public string engine { get; set; }
        public int seats { get; set; }
        public bool Infotainment { get; set; }

        public bool thirdRow { get; set; }
        public bool fiveStarSafety { get; set; }
        public string logo { get; set; }
        public string fuel { get; set; }
    }
}

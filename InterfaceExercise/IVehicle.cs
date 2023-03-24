using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public int wheels { get; set; }
        public string engine { get; set; }
        public bool Infotainment { get; set; }

        public int seats { get; set; }

    }
}

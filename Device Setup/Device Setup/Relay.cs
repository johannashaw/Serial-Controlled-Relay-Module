using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Device_Setup
{ 
    /// <summary>
    /// Class to hold the info for each relay.
    /// </summary>
    internal class Relay
    {
        public int Number;
        public string Name;
        public int Delay;

        public Relay(string[] vals)
        {
            //make sure both val[0] and val[2] are ints
            if (!int.TryParse(vals[0], out Number))
                throw new ArgumentException($"value for Relay number at index 0 was not an int, therefore invalid. value = '{vals[0]}'");
            if (!int.TryParse(vals[1], out Delay))
                throw new ArgumentException($"value for Delay at index 2 was not an int, therefore invalid. value = '{vals[1]}'");

            Name = vals[2].Trim();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Relay))
                return false;

            Relay r = (Relay)obj;
            return Number.Equals(r.Number);
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public override string ToString()
        {
            return $"{Number},{Name},{Delay/10.0}"; 
            //return $"Relay {Number}, Name = {Name}, Delay = {Delay/10.0} seconds";
        }

    }
}

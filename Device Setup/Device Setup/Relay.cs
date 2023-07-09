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
    internal class Relay : IComparable
    {
        public int Number;
        public string Name;
        public int Delay;

        public Relay(string[] vals)
        {
            // make sure the relay Number is valid
            if (!int.TryParse(vals[0], out Number))
            {
                throw new ArgumentException($"Value for Relay number at index 0 was not an integer. Value = '{vals[0]}'");
            }
            else if (Number < 0 || Number >7 )
                throw new ArgumentOutOfRangeException($"Value for Relay number is out of range. Value = '{Number}'");
            // make sure the delay is valid
            if (!int.TryParse(vals[1], out Delay))
                throw new ArgumentException($"Value for Delay at index 2 was not an integer. Value = '{vals[1]}'");
            else if (Delay < 0 || Delay > 255)
                throw new ArgumentOutOfRangeException($"Value for Delay is out of range. Value = '{Delay}'");

            Name = vals[2].Trim();
        }

        public int CompareTo(object obj)
        {
            if (obj is int)
                return Number.CompareTo((int)obj);
            if (obj is Relay)
            {
                Relay r = (Relay)obj;
                return Number.CompareTo(r.Number);
            }

            throw new ArgumentException($"Cannot compare Relay to {obj.GetType()}");
        }

        public override bool Equals(object obj)
        {
            if (obj is int)
                return Number.Equals((int)obj);
            if (obj is Relay)
            {
                Relay r = (Relay)obj;
                return Number.Equals(r.Number);
            }

            return false;
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

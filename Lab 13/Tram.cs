using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class Tram
    {
        public TramId tramId;
        public int LineNumber { get; set; }
        public string Driver { get; set; }

        public Tram (int number)
        {
            tramId = new TramId (number);
        }

        public Tram ShallowCopy()
        {
            return (Tram)this.MemberwiseClone();
        }

        public Tram DeepCopy()
        {
            Tram clone = (Tram)this.MemberwiseClone();
            clone.tramId = new TramId(tramId.tramNumber);
            return clone;
        }
    }

    public class TramId
    {
        public int tramNumber;

        public TramId(int number)
        {
            this.tramNumber = number;
        }
    }
}

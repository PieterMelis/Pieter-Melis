 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
    public class YahtzeeModel
    {
        private int tijdelijkeMax = 3;
        private int aantalWorpen;
        private int aantal_worpen = 4;
        private int maxWorp = 3;



        public int AantalWorpen
        {
            get
            {
                return aantalWorpen;
            }
            set
            {
                aantalWorpen = value;
            }
        }

        public int TijdelijkeMax
        {
            get
            {
                return tijdelijkeMax;
            }

            set
            {
                tijdelijkeMax = value;
            }
        }

        public int Aantal_worpen
        {
            get
            {
                return aantal_worpen;
            }

            set
            {
                aantal_worpen = value;
            }
        }



        public int MaxWorp
        {
            get
            {
                return maxWorp;
            }

            set
            {
                maxWorp = value;
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    class HadaP1
    {
        public static double Seconds2Minutes(double s){

            if (s != 0){

                s = s / 60;

            }

            return s;
        }

        public static double Minutes2Seconds(double m){

            m = m * 60;

            return m;
        }

    }
}

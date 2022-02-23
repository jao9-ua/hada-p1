using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace hada_p1
{
    /// <summary>
    /// esa clase contiene métodos para convertir de
    /// segundos a minutos y viceversa
    /// </summary>
    class HadaP1
    {
        /// <summary>
        /// Este método convierte segundos a minutos
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static double Seconds2Minutes(double s){

            if (s != 0){

                s = s / 60;

            }

            return s;
        }

        /// <summary>
        /// Este método convierte minutos a segundos
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public static double Minutes2Seconds(double m){

            m = m * 60;

            return m;
        }

    }
}

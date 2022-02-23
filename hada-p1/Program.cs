using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    class Program
    {
        static void Main(string[] args)
        {
            string continuar;
            do
            {
                string respuesta;
                string numero;
                double valor;
                Console.WriteLine("Que unidad quieres convertir Segundos o Minutos o horas? (s/m/h)");
                respuesta = Console.ReadLine();
                if (respuesta=="s")
                {
                    Console.WriteLine("Ahora introduce el valor que deseas cambiar >=0");
                    numero = Console.ReadLine();
                    valor = double.Parse(numero);
                    Console.WriteLine(HadaP1.Seconds2Minutes(valor));
                }
                else
                {
                    if (respuesta=="m")
                    {
                        Console.WriteLine("Ahora introduce el valor que deseas cambiar >=0");
                        numero = Console.ReadLine();
                        valor = double.Parse(numero);
                        Console.WriteLine(HadaP1.Minutes2Seconds(valor));
                    }
                    else
                    {
                        if (respuesta == "h")
                        {
                            Console.WriteLine("Ahora introduce el valor que deseas cambiar >=0");
                            numero = Console.ReadLine();
                            valor = double.Parse(numero);
                            Console.WriteLine(HadaP1.Hours2Minutes (valor));
                        }
                        else 
                        {
                            Console.WriteLine("Entrad incorrecta");
                        }
                            
                    }
                }
                do
                {
                    Console.WriteLine("Quieres continuar?(s/n)");
                    continuar = Console.ReadLine();
                    if(continuar != "s" || continuar != "n")
                    {
                        Console.WriteLine("Entrada incorrecta");
                    }
                } while (continuar!="s" || continuar!="n");

            } while (continuar=="s");
        }
    }
}

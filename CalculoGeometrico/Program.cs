using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoGeometrico
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numero = 0, opcionRadio = 0, opcionBase = 0, opcionAltura = 0;
            double res = 0;
            string retorno = "";
            try
            {
                do
                {
                    Console.WriteLine("¿Que Figura Va A Calcular El Area ? Elige una opcion.");
                    Console.WriteLine("1.circulo");
                    Console.WriteLine("2.rectángulo");
                    numero = Convert.ToInt32(Console.ReadLine());
                    //toma la opcion indicada por el usuario y continua las preguntas de acuerdo a la operacion
                    if (numero == 1)
                    {
                        Console.WriteLine("indique el radio");
                        opcionRadio = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (numero == 2)
                    {
                        Console.WriteLine("indique la base");
                        opcionBase = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("indique la altura");
                        opcionAltura = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("la opción seleccionada no es valida");
                    }
                    //realiza la operacion indicada por el usuario 
                    switch (numero)
                    {
                        case 1:
                            var r = new Program();
                            res = r.calcularRadio(opcionRadio);
                            break;
                        case 2:
                            var b = new Program();
                            res = b.calcularBase(opcionBase, opcionAltura);
                            break;

                    }
                    //retornamos el recultado segun la operacion realizada
                    Console.WriteLine("el resultado es : " + res);
                    //pregunta si regresa nuevamente al menu 
                    Console.WriteLine("regresar al menu S o N");
                    retorno = Console.ReadLine();

                } while (retorno == "S" || retorno == "s");

            }
            catch (Exception ex)
            {
                //en caso de error mostramos en la consola
                Console.WriteLine("error al realizar el calculo : " + ex);
            }



        }

        /// <summary>
        /// metodo para calcular el radio
        /// </summary>
        /// <param name="opcionRadio"></param>
        /// <returns></returns>
        public double calcularRadio(int opcionRadio) { 
            return opcionRadio / (2 * 3.14);
        }

        /// <summary>
        /// metodo para calcular la base 
        /// </summary>
        /// <param name="opcionBase"></param>
        /// <param name="opcionAltura"></param>
        /// <returns></returns>
        public int calcularBase(int opcionBase, int opcionAltura) { 
            return opcionBase * opcionAltura; 
        }

    }
}

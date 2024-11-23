using System;

namespace ConversionDeMoneda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****¡Bienvenido al conversor de monedas!*****\n");

            //Aca se define el valor de la tasa de cambio deacuerdo a la moneda convertido en COP
            const double tasaCambioUSD = 4389;
            const double tasaCambioEUR = 4573;

            //Se define esta variable donde se alamcenara el valor ingresado por el usuario
            double valIngresado;
            
            //Aca se utiliza estos ciclo para despues de finalizar cada conversion y preguntarle al
            //usuario si quiere continuar o no convirtiendo
            while (true)
            {
                //En este ciclo se valida el valor ingresado, y se repetira infinitamente
                //hasta que el usuario ingrese un valor valido
                while (true)
                {
                    
                    Console.Write("\nPor favor ingresa el valor en COP a convertir: ");

                    //En esta variable se captura el valor ingresado por el usuario
                    string entrada = Console.ReadLine();

                    ///En este condicional validamos exactamente que tipo de dato ingresa
                    ///el usuario para mostrar el mensaje correspondiente en caso de ser invalido
                    if (!double.TryParse(entrada, out valIngresado))
                    {
                        Console.WriteLine("\nError! el valor ingresado no es valido, intentalo nuevamente\n");
                    }
                    else if (valIngresado < 0)
                    {
                        Console.WriteLine("\n¡Error! El número debe ser positivo, intentalo nuevamente.\n");
                    }
                    else if (valIngresado == 0)
                    {
                        Console.WriteLine("\n¡Error! El número debe ser mayor a 0, intentalo nuevamente.\n");
                    }
                    else
                    {
                        //Si todo es correcto salimos de este ciclo
                        break;
                    }
                }

                //Aca hacemos la conversion
                double valorUSD = valIngresado / tasaCambioUSD;
                double valorEUR = valIngresado / tasaCambioEUR;

                //Aca imprimimos en pantalla en valor que arrojo cada conversion
                Console.WriteLine($"\nEl valor en USD es: {valorUSD:F2}\n");
                Console.WriteLine($"El valor en EUR es: {valorEUR:F2}\n");

                //Ya en este ciclo se le pregunta al usuario si quiere continuar o no
                Console.Write("Deseas seguir convirtiendo?\n\nsi tu respuesta es si por favor ingresa S\nde lo contrario ingresa cualquier tecla: ");

                // Capturamos la respuesta del usuario y la convertimos a mayúsculas para 
                // validar si desea continuar o salir del programa.
                string respuesta = Console.ReadLine().ToUpper();

                //En este condicional se toma la desicion basada en lo que ingreso el usuario
                if (respuesta != "S")
                {
                    //Si el usuario desea finalizar se termina el programa
                    Console.WriteLine("Adios\n");
                    break;
                }
            }
            
        }
    }
}
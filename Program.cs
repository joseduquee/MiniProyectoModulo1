using System;

namespace MiniProyectoModulo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca su nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine($"Cliente {nombre}, bienvenido!");
            Console.WriteLine("¿Que edad tienes?");
            int edad = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Cliente {nombre} de {edad} años");
            Console.WriteLine("¿Tienes carnet de conducir? En caso si, escriba s, en caso de no, escriba n.");
            string carnet = Console.ReadLine().ToLower();


            bool tieneCarnet = false;
            if (carnet == "s")
            {
                tieneCarnet = true;
                string res = tieneCarnet ? "tiene carnet de conducir" : "no tiene carnet de conducir";

                Console.WriteLine($"Cliente {nombre}, de {edad} años, {res}");
            }
            else if (carnet == "n")
            {
                tieneCarnet = false;
                string res = tieneCarnet ? "tiene carnet de conducir" : "no tiene carnet de conducir";

                Console.WriteLine($"Cliente {nombre}, de {edad} años, {res}");
            }
            else
            {
                Console.WriteLine("Valor incorrecto marque; S o N");
            }


            if (edad < 18 || tieneCarnet == false)
            {
                Console.WriteLine("No puedes alquilar un coche: ");
                
            }
            else
            {
                Console.WriteLine("En que ciudad deseeas recoger el coche:\n Bilbao\n Madrid\n Santander\n Barcelona");
                Console.WriteLine("Escribe el nombre de la ciudad:");
                string ciudad = Console.ReadLine().ToLower();
                Console.WriteLine($"Has seleccionado la ciudad de {ciudad}");
                Console.WriteLine("¿Durante cuantos dias desea alquilar el coche?");
                int numDias = Int32.Parse(Console.ReadLine());

                PrecioCocheDias(numDias);
            }

            

        }

        private static void PrecioCocheDias(int numDias)
        {
            int semana = numDias / 7;
            int restoDias = semana % 7;

            if (numDias < 7)
            {
                Console.WriteLine($"Has elegido alquilar el coche por {numDias} dias");
            }
            else if (numDias >= 7)
            {
                Console.WriteLine($"Has elegido {semana} semanas y {restoDias} dias");
            }
            int precio = numDias * 10;
            int descuento = semana * 10;

            if (numDias < 6)
                Console.WriteLine($"El precio del alquiler son 10€ por dia por tanto por el tiempo seleccionado son {precio}euros");
            else
            {
                int precioDescuento = precio - descuento;
                Console.WriteLine($"El precio del alquiler son 10euros por dia, por tanto por el tiempo seleccionado son {precio}euros y tienes un descuento de 10euros por semana, asi que tendrias {descuento}euros de descuento, asi que tu precio final es de {precioDescuento}");
            }
        }
    }
}


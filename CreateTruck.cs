using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AutoTruck
{
    public static class CreateTruck
    {
        public static void RegisterTruck()
        {


            ConsoleKeyInfo keyPressed;
            bool invalidKeyPress = true;
            bool validBooking = false;

            do
            {

                Console.SetCursorPosition(5, 7);
                Console.WriteLine("Registreringsnummer: ");
                Console.SetCursorPosition(5, 9);
                Console.WriteLine("Märke: ");
                Console.SetCursorPosition(5, 11);
                Console.WriteLine("Model: ");
                Console.SetCursorPosition(5, 13);
                Console.WriteLine("Lastkapacitet (Kubik): ");
                Console.SetCursorPosition("Registreringsnummer: ".Length + 4, 7);
                string registrationNumber = Console.ReadLine();
                Console.SetCursorPosition("Märke: ".Length + 4, 9);
                string brand = Console.ReadLine();
                Console.SetCursorPosition("Model: ".Length + 4, 11);
                string model = Console.ReadLine();
                Console.SetCursorPosition("Lastkapacitet (Kubik): ".Length + 4, 13);
                int loadCapacity = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("\nÄr detta rätt? (J)a (N)ej");


                do
                {
                    keyPressed = Console.ReadKey(true);

                    invalidKeyPress = !(keyPressed.Key == ConsoleKey.J || keyPressed.Key == ConsoleKey.N);

                } while (invalidKeyPress);



                if (keyPressed.Key == ConsoleKey.J)
                {
                    //if (RegisterPerson.MyEmployees.ContainsKey(cargo) && RegisterPerson.MyPatients.ContainsKey(socialSecurityNumber))
                    //{
                    Trucks.AllTrucks.Add(new Truck(
                        registrationNumber: registrationNumber,
                        brand: brand,
                        model: model,
                        holdCapacity: loadCapacity
                        ));
                    Console.Clear();
                    Console.WriteLine("Lastbil registrerad");
                    validBooking = true;
                    Thread.Sleep(1000);

                    //}
                    //else
                    //{
                    //    Console.Clear();
                    //    Console.WriteLine("Ogiltig anställd eller personal");
                    //    validBooking = true;
                    //    Thread.Sleep(1000);
                    //}


                }
                if (keyPressed.Key == ConsoleKey.N)
                {
                    Console.Clear();

                }

            } while (!validBooking);




        }


    }
}

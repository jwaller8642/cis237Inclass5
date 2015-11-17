using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int count = 0;
            AdventureWorks2012Entities adventure = new AdventureWorks2012Entities();

            foreach( Person person in adventure.People)
            {
                if (count++ > 20)
                {
                    break;
                }
                Console.WriteLine(person.FirstName + " " + person.LastName + " " + person.rowguid);
              
            }
            
            foreach (EmailAddress email in adventure.EmailAddresses)
            {
                Console.WriteLine(email);
            }
            Console.ReadKey();
            */

            CarsJWallerEntities1 carsTest = new CarsJWallerEntities1();

            foreach (Car car in carsTest.Cars)
            {
                Console.WriteLine(car.id + " " + car.make + " " + car.model);
            }

            //Find by any property
            string userInput = string.Empty;
            Console.Write("Input ");
            userInput = Console.ReadLine();
           Car carToFind = carsTest.Cars.Where(car => car.id == userInput).First();
           // Car OtherCarToFind = carsTest.Cars.Where(car => car.make == "Challenger").First();
            
            Console.WriteLine(carToFind.id + " " + carToFind.make + " " + carToFind.model);
           // Console.WriteLine(OtherCarToFind.id + " " + OtherCarToFind.make + " " + OtherCarToFind.model);


            //Find Car Based on Primary ID

           // Car foundCar = carsTest.Cars.Find("V0LCD1814");
           // Console.WriteLine(foundCar.id + " " + foundCar.make + " " + foundCar.model);

            Console.ReadKey();

            // ADD new Car
            Car newCar = new Car();
            newCar.id = "00000";
            newCar.make = "Nissan";

            carsTest.Cars.Add(newCar);
            carsTest.SaveChanges();

            Car carToFindForUpdate = carsTest.Cars.Find(userInput);
        }
            
    }
}

using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Linq;

namespace A1MateoShkurti
{
    class Program
    {
        static List<Vehicles> vehicleList= new List<Vehicles>();
         

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mateo's Rentals!\n");

            createVehicleList();
            control();
            
           
            
           
        }
        public static void control()
        {
            int key = 0;

            while (key <= 0 || key > 6)
            {

                printMenu();
                key = int.Parse(Console.ReadLine());

            }

            if (key == 1)
                printVehicles();
            else if (key == 2)
                printAvailable();
            else if (key == 3)
                printReserved();
            else if (key == 4)
                reserve();
            else if (key == 5)
                cancelReservation();
            else if (key == 6)
                exit();
        }
        public static void printMenu()
        {
            Console.WriteLine("\nStarting Menu (choose an option)\n" +
                "1-View All Vehicles\n" +
                "2-View All Available Vehicles\n" +
                "3-view All Reserved Vehicles\n" +
                "4-Reserve a Vehicle\n" +
                "5-Cancel a Reservation\n" +
                "6-Exit\n"
                );
        }

        public static void createVehicleList()
        {
            Cars a = new Cars(1,"Honda Civic", 49.9, "Sedan","Standart");
            Cars b = new Cars(2, "Honda Accord", 49.9, "Sedan", "Standart");
            Cars c = new Cars(3, "Chevrolet Camaro", 79.9, "Sports", "Standart");
            Cars d = new Cars(4, "Dodge Challenger", 79.9, "Sedan", "Standart");
            Cars e = new Cars(5, "Mercedes Benz G-Class", 79.9, "SUV", "Standart");
            Cars f = new Cars(6, "Ferrari California", 89.9, "Sports", "Exotic");
            Motorcycles g= new Motorcycles(7, "Ducati Diavel 1260 S", 89.9,"Cruiser","Bike");
            Motorcycles h= new Motorcycles(8, "KTM 790 Adventure R", 99.9, "Dirt", "Bike");
            Motorcycles i= new Motorcycles(9, "Kawasaki Z400", 79.9, "Cruiser", "Bike");
            Motorcycles j= new Motorcycles(10, "Ducati V4 R", 109.9, "Sports", "Bike");
            Motorcycles k= new Motorcycles(11, "Harley-Davidson Tri Glide Ultra", 59.9, "Cruise", "Trike");
            Motorcycles l= new Motorcycles(12, "Honda Neowing", 54.9, "Cruise", "Trike");

            vehicleList.Add(a);
            vehicleList.Add(b);
            vehicleList.Add(c);
            vehicleList.Add(d);
            vehicleList.Add(e);
            vehicleList.Add(f);
            vehicleList.Add(g);
            vehicleList.Add(h);
            vehicleList.Add(i);
            vehicleList.Add(j);
            vehicleList.Add(k);
            vehicleList.Add(l);
        }
        static void printVehicles() {
            Console.Clear();
            Console.WriteLine("ALL VEHICLES\n");
            Console.WriteLine($"{"Vehicle ID", 10} || {"Vehicle Name",32} || {"Rental Price",21} || {"Category",11} || {"Type",11} || {"Is Available",10}");
            foreach (Vehicles v in vehicleList)
                Console.WriteLine(v);
            control();
        }
        static void printAvailable() {
            Console.Clear();
            Console.WriteLine("AVAILABLE VEHICLES\n");
            Console.WriteLine($"{"Vehicle ID",10} || {"Vehicle Name",32} || {"Rental Price",21} || {"Category",11} || {"Type",11} || {"Is Available",10}");
            var availableVehicles= from vehicle in vehicleList
                                   where vehicle.IsAvailable.Contains("YES")
                                   select vehicle;
            foreach (var v in availableVehicles)
                Console.WriteLine(v);
            control();
        }
        static void printReserved() {
            Console.Clear();
            Console.WriteLine("RESERVED VEHICLES\n");
            Console.WriteLine($"{"Vehicle ID",10} || {"Vehicle Name",32} || {"Rental Price",21} || {"Category",11} || {"Type",11} || {"Is Available",10}");
            var unavailableVehicles = from vehicle in vehicleList
                                    where vehicle.IsAvailable.Contains("NO")
                                    select vehicle;
            foreach (var v in unavailableVehicles)
                Console.WriteLine(v);
            if (unavailableVehicles.Count() <= 0)
                Console.WriteLine("No Data Found.\n");
            control();
            ;
        }
        static void reserve() {
            Console.Clear();
            Console.WriteLine("What is the ID of the vehicle you want to rent:");
            int reservedID=int.Parse(Console.ReadLine());

            var reservedCar = from vehicles in vehicleList
                              where vehicles.Id == reservedID
                              select vehicles;

            Console.WriteLine($"Are you sure you want to reserve : {reservedCar.ElementAt(0).Name} (Y/N):");
            string key = Console.ReadLine();

            if (key.StartsWith("Y")) 
            {
                reservedCar.ElementAt(0).IsAvailable = "NO";
                Console.WriteLine("Vehicle Reserved");
            }
            else
            {
                Console.WriteLine("Reservation Stopped");
            }
            control();

        }
        static void cancelReservation() {
            Console.Clear();
            Console.WriteLine("What is the ID of the vehicle you want to cancel the reservation:");
            int reservedID = int.Parse(Console.ReadLine());

            var reservedCar = from vehicles in vehicleList
                              where vehicles.Id == reservedID
                              select vehicles;

            Console.WriteLine($"Are you sure you want to cancel reservation for {reservedCar.ElementAt(0).Name} (Y/N):");
            string key = Console.ReadLine();

            if (key.StartsWith("Y"))
            {
                reservedCar.ElementAt(0).IsAvailable = "YES";
                Console.WriteLine("Reservation Canceled");
            }
            else
            {
                Console.WriteLine("Cancelation Stopped");
            }
            control();
        }

        static void exit() {
            Console.Clear();
            Console.WriteLine($"Are you sure you want to exit? (Y/N):");
            string key = Console.ReadLine();

            if (key.StartsWith("Y"))
            {
                
            }
            else
            {
                control();
            }
           
        }


    }
}

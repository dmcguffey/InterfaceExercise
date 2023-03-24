using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany DONE

            //Create 3 classes called Car , Truck , & SUV DONE

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            var Tesla = new Car()
            {
                wheels = 4,
                engine = "supercharged",
                seats = 5,
                Infotainment = true,
                hasTrunk = true,
                goodGasMileage = true,
                logo = "Tesla",
                fuel = "electric",
            };
            Console.WriteLine($"Get a load of this {Tesla.logo}! It comes with all {Tesla.wheels} mostly intact wheels along with minor stains in all {Tesla.seats} seats!");
            if (Tesla.hasTrunk == true )
            {
                Console.WriteLine($"If that doesn't interest you, pop open the hood, and for some reason there's a {Tesla.engine} engine in the back.");
            }
            if (Tesla.Infotainment == true)
            {
                Console.WriteLine($"Oh good! the infotainment is only slightly buggy. I don't recommend using the GPS...");
            }

            if (Tesla.goodGasMileage== true)
            {
                Console.WriteLine($"Don't worry about gas, cuz this thing doesn't even take it! All {Tesla.fuel} baby!");
            }

            Console.WriteLine("--------------------------------------------------------------");

            var RAV4 = new SUV()
            {
                wheels = 5,
                seats = 5,
                Infotainment = true,
                fiveStarSafety = true,
                logo = "Toyota",
                fuel = "gas"
            };

            Console.WriteLine("Take a look at this car! The logo looks like a bull... a RAV4? Who makes those again?");
            string myGuess = Console.ReadLine();
            myGuess.ToLower();
            
            if (myGuess != RAV4.logo)
            {
                Console.WriteLine("That's not it. Try again.");
                myGuess = Console.ReadLine();
                myGuess.ToLower();
            }

            bool isString = false;
            do
            {
                Console.WriteLine($"What kind of engine is in this car?");
                RAV4.engine = Console.ReadLine();
                int result;
                isString = !int.TryParse(RAV4.engine, out result);
            }
            while (!isString || string.IsNullOrEmpty(RAV4.engine));

            Console.WriteLine($"Excellent, so our {RAV4.engine} likely needs {RAV4.fuel} to run");

            if (RAV4.Infotainment== true)
            {
                Console.WriteLine($"Look at the infotainment! It's built really well and really userfriendly!");
            }

            Console.WriteLine($"The car seats {RAV4.seats} and has a total of {RAV4.wheels} wheels. Gotta have a spare in case!");

            if (RAV4.fiveStarSafety== true)
            {
                Console.WriteLine("Feel safe in this car, as it has a 5 star safety rating!.");
            }

            Console.WriteLine("-------------------------------------------------------------");


            var F150 = new Truck()
            {
                wheels = 4,
                engine = "V8",
                seats = 5,
                Infotainment = false,
                hasBed = true,
                runOnDiesel = false,
                logo = "Ford",
                fuel = "gas",
            };

            if (F150.runOnDiesel == false)
            {
                Console.WriteLine($"Take a look at this! It's a pretty old {F150.logo} This thing probably sucks up {F150.fuel}.");
            }
            Console.WriteLine($"The engine is impressive! Looks like a {F150.engine}! That'll helo with towing!");

            if (F150.hasBed== true)
            {
                Console.WriteLine($"You only have {F150.seats}, but there's plenty more room in the bed of the truck!");
            }

            Console.WriteLine($"Best part of this ole beauty is that it has {F150.wheels}-wheel drive!");
        }

    }
}

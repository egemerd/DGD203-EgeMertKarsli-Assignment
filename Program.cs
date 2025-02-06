using Car_Game;

internal class Program
{

    static Car chosenCar = null;
    static Location chosenLocation = null;
    static int money = 10000;
    static bool isCarChosen = false;
    static Item chosenItem = null;
    static bool canAfford;


    private static void Main(string[] args)
    {
        ChooseCar();
        MoneyManagement();

        if (isCarChosen == true)
        {
            ChooseLocation();
            FuelManagement();
        }


    }

    public static void ChooseCar(bool showInfo = true, bool enoughMoney = false)
    {
        Car car1 = new Car("BMW", 13000, 50, 150, 16);
        Car car2 = new Car("Tofaş", 1000, 80, 60, 8);
        Car car3 = new Car("Fiat", 9000, 70, 90, 12);
        Car car4 = new Car("Renault", 3000, 70, 70, 6);

        Car[] cars = new Car[]
            {
                new Car("BMW", 15000, 50, 150, 16),
                new Car("Tofaş", 1000, 80, 60,8),
                new Car("Fiat", 9000, 70, 90,12),
                new Car("Renault", 3000, 70, 70,6)
            };

        if (showInfo == true)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"Car {i + 1}: {cars[i]}");
            }
        }
        Console.WriteLine("\n You have " + money + "$. You can choose a car to buy. If you can't afford these cars, you can sell some of your items.");

        Console.WriteLine("\n Type 1 for BMW \n Type 2 for Tofaş \n Type 3 for Fiat \n Type 4 for Renault");
        string carName = Console.ReadLine();




        switch (carName)
        {
            case "1":
                chosenCar = car1;
                break;
            case "2":
                chosenCar = car2;
                break;
            case "3":
                chosenCar = car3;
                break;
            case "4":
                chosenCar = car4;
                break;
            default:
                Console.WriteLine("You made a invalid choose.");
                break;
        }



    }





    public static void ChooseLocation()
    {
        Location location1 = new Location(600, "Ankara");
        Location location2 = new Location(500, "İstanbul");
        Location location3 = new Location(1200, "Ordu");
        Location location4 = new Location(900, "Mersin");
        Location location5 = new Location(40, "Bursa");
        Location location6 = new Location(100, "Aydın");

        Console.WriteLine("Choose where you want to go \n Type 1 for Ankara \n Type 2 for İstanbul \n Type 3 for Ordu \n Type 4 for Mersin \n Type 5 for Bursa \n Type 6 for Aydın");
        string locationName = Console.ReadLine();





        switch (locationName)
        {
            case "1":
                chosenLocation = location1;
                break;
            case "2":
                chosenLocation = location2;
                break;
            case "3":
                chosenLocation = location3;
                break;
            case "4":
                chosenLocation = location4;
                break;
            case "5":
                chosenLocation = location5;
                break;
            case "6":
                chosenLocation = location6;
                break;
            default:
                Console.WriteLine("You entered invalid number");
                break;




        }


    }

    public static void FuelManagement()
    {
        if (chosenCar.fuelAmount - (chosenLocation.distance / chosenCar.fuelSpeed) > 0)
        {
            chosenCar.fuelAmount = chosenCar.fuelAmount - (chosenLocation.distance / chosenCar.fuelSpeed);
            Console.WriteLine("You have " + chosenCar.fuelAmount + " liters of fuel left");
            chosenLocation.timeOfReach = chosenLocation.distance / chosenCar.speed;
            Console.WriteLine("You reached here at " + chosenLocation.timeOfReach + " hours");
        }
        else
        {
            Console.WriteLine("Your fuel is not enough");

        }
    }


    public static void MoneyManagement()
    {
        Item item1 = new Item("Dyson Supersonic Hair Dryer", 3000);
        Item item2 = new Item("Watch", 5000);
        Item item3 = new Item("Motorcycle", 7000);



        static void ShowItems(int n, string name, int price)
        {
            Console.WriteLine("Item " + n + ": " + name + " Price: " + price);
        }


        if (money < chosenCar.price)
        {
            canAfford = false;
        }

        if (canAfford == false)
        {
            Console.WriteLine(" \nYou can't afford this car. Do you want to sell something?\n");

            ShowItems(1, "Dyson Supersonic Hair Dryer", 2000);
            ShowItems(2, "Watch", 5000);
            ShowItems(3, "Motorcycle", 7000);

            Console.WriteLine("\nType 1 for Dyson Supersonic Hair Dryer \nType 2 for Watch \nType 3 for Motorcycle");
            string itemNum = Console.ReadLine();

            switch (itemNum)
            {
                case "1":
                    chosenItem = item1;
                    Console.WriteLine("\nYour hair is going to be so upset even it want to fall off.");
                    break;
                case "2":
                    chosenItem = item2;
                    Console.WriteLine("\nYou can't tell time anymore.");
                    break;
                case "3":
                    chosenItem = item3;
                    Console.WriteLine("\nYour biker gang will be so sad after your left.");
                    break;
            }



            money += chosenItem.value;

            ChooseCar(false);
            money -= chosenCar.price;
            Console.WriteLine("You have " + money + "$ left");
            ChooseLocation();
            FuelManagement();


        }


        else
        {
            isCarChosen = true;

        }



    }
}
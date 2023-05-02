// See https://aka.ms/new-console-template for more information
using ParkingSystem.ParkingSys;
using ParkingSystem.Vehichles;
using System.Net.WebSockets;

//Vehicle vehicle1 = new Car();
//vehicle1.CarId = "1";
//Vehicle vehicle2 = new Bus();
//vehicle2.CarId = "2";
//Vehicle vehicle3 = new Lorry();
//vehicle3.CarId = "3";

//Parking parking=new Parking(1,0,"Sk","Sk",50, 0, Day.Sunday, new Company());
//parking.addVehicle(vehicle1,2);
//parking.addVehicle(vehicle2,3);
//parking.addVehicle(vehicle3,3);
//Console.WriteLine(parking.getTotalAmount("1"));
//Console.WriteLine(parking.getFreeSpaces());



//Person person = new Person("1111111111", "Gjorgji", "Sirakoski", "26", "Skopje");

//Car car = new Car("1", "Audi", 2009, person, 1000, Fuel.fuel, 80, 5, "common");

//Console.WriteLine("Weight: "+ car.GetWeight().ToString()+", Widht: "+ car.GetWidth());

//if(car.NoEconomicCar()==1)
//{
//    Console.WriteLine("Yes, it's economic");
//}else
//{
//    Console.WriteLine("No, it's not economic");
//}

ParkingSys parkings=new ParkingSys();

StartProgram();

void StartProgram()
{
    Console.WriteLine("Welcome to Parking System software");
    Console.WriteLine("Are you admin or client? For admin press A, for client press C");

    string typeClient = Console.ReadLine();
    if (typeClient.ToLower() == "a")
    {
        AdminResponsibilities();
        Console.WriteLine(parkings.Parkings[0].getFreeSpaces());

    }
    else if (typeClient.ToLower() == "c")
    {
        ClientResponsibilities();


    }
    else
    {
        Console.WriteLine("Invalid character, Please try again");
        StartProgram();
    }
}

void AdminResponsibilities()
{

    Console.WriteLine("Insert user name:");
    string username = Console.ReadLine();

    Console.WriteLine("Insert pass:");
    string password = Console.ReadLine();

    if (username == "admin" && password == "admin")
    {
        Console.WriteLine("How many parking do you want to insert?");
        int numberParkings = int.Parse(Console.ReadLine());

        ParkingSys parkingSys = new ParkingSys();
        for (int i = 0; i < numberParkings; i++)
        {
            Parking parking = new Parking();
            Console.WriteLine("Insert Id");
            parking.ParkingId = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert Address");
            parking.Address = Console.ReadLine();
            Console.WriteLine("Insert City");
            parking.City = Console.ReadLine();
            Console.WriteLine("Insert Price");
            parking.PricePerHour = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert Discount");
            parking.Discount = int.Parse(Console.ReadLine());
            parking.FreeDays = Day.Sunday;
            Company company = new Company();
            parking.OwnerCompany = company;
            parkingSys.Parkings.Add(parking);
        }

        Console.WriteLine("Successfuly inserted all parkings");
        parkings = parkingSys;
        StartProgram();
    }
    else
    {
        Console.WriteLine("Inccorect credentials");
        AdminResponsibilities();
    }
}

void ClientResponsibilities()
{
    Console.WriteLine("Insert Parking Id");
    int parkingId = int.Parse(Console.ReadLine());
    if (parkings.findParking(parkingId))
    {
        Vehicle vehicle = new Car("1", "g", 2005, new Person(), 5, Fuel.electricty, 5, 5, "sport");

        parkings.getParkingById(parkingId).addVehicle(vehicle, 2);

        Console.WriteLine(parkings.Parkings[0].getTotalAmount(vehicle.CarId));
        Console.WriteLine(parkings.Parkings[0].getTimeOfParking(vehicle.CarId));
        Console.WriteLine(parkings.Parkings[0].serachVehicleById(vehicle.CarId));
        Console.WriteLine(parkings.Parkings[0].serachVehicleById(vehicle.CarId).NoEconomicCar());
        Console.WriteLine(parkings.Parkings[0].totalVehicleInParking("car"));

        StartProgram();
    }
}
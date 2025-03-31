using Homework;

static void RaceCars(Car car1, Car car2)
{
    int speed1 = car1.CalculateSpeed();
    int speed2 = car2.CalculateSpeed();

    Console.WriteLine($"{car1.Driver.Name} in  {car1.Model} has speed: {speed1}");
    Console.WriteLine($"{car2.Driver.Name} in {car2.Model} has speed: {speed2}");

    if (speed1 > speed2)
    {
        Console.WriteLine($"{car1.Model} wins the race!");
    }
    else if (speed1 < speed2)
    {
        Console.WriteLine($"{car2.Model} wins the race!");
    }
    else
    {
        Console.WriteLine("It's a tie!");
    }
}



    Driver driver1 = new Driver("Angel", 8);
    Driver driver2 = new Driver("Bob", 6);
    Driver driver3 = new Driver("Sandra", 7);
    Driver driver4 = new Driver("David", 5);

    Car car1 = new Car(" Ferrari", 200, driver1);
    Car car2 = new Car("Lamborghini", 220, driver2);
    Car car3 = new Car("Porsche", 210, driver3);
    Car car4 = new Car("McLaren", 230, driver4);

    
    Console.WriteLine("Select a car: ");
    Console.WriteLine("1. Ferrari\n2. Lamborghini\n3. Porsche\n4. McLaren");
    int carChoice1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Select a driver: ");
    Console.WriteLine("1. Angel\n2. Bob\n3. Sandra\n4. David");
    int driverChoice1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Select another car: ");
    int carChoice2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Select another driver: ");
    int driverChoice2 = int.Parse(Console.ReadLine());


Car selectedCar1;
Car selectedCar2;

switch (carChoice1)
{
    case 1:
        selectedCar1 = car1 ;
        break;
    case 2:
        selectedCar1 = car2;
        break;
    case 3:
        selectedCar1 = car3;
        break;
    default:
        selectedCar1 = car4;
        break;
}

switch (carChoice2)
{
    case 1:
        selectedCar2 = car1;
        break;
    case 2:
        selectedCar2 = car2;
        break;
    case 3:
        selectedCar2 = car3;
        break;
    default:
        selectedCar2 = car4;
        break;
}


Driver selectedDriver1;

Driver selectedDriver2;

switch (driverChoice1)
{
    case 1:
        selectedDriver1 = driver1;
        break;
    case 2:
        selectedDriver1 = driver2;
        break;
    case 3:
        selectedDriver1 = driver3;
        break;
    default:
        selectedDriver1 = driver4;
        break;
}

switch (driverChoice2)
{
    case 1:
        selectedDriver2 = driver1;
        break;
    case 2:
        selectedDriver2 = driver2;
        break;
    case 3:
        selectedDriver2 = driver3;
        break;
    default:
        selectedDriver2 = driver4;
        break;
}


selectedCar1.Driver = selectedDriver1;


selectedCar2.Driver = selectedDriver2;





RaceCars(selectedCar1, selectedCar2);



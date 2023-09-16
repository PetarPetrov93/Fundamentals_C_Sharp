namespace _06.VehicleCatalogueEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Vehicle> vehicleList = new List<Vehicle>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputArr = input.Split();
                string type = inputArr[0];
                string model = inputArr[1];
                string color = inputArr[2];
                decimal horsePower = decimal.Parse(inputArr[3]);

                Vehicle currentVehicle = new Vehicle(type, model, color, horsePower);
                vehicleList.Add(currentVehicle);
            }

            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                Vehicle currentVehicle = vehicleList.Find(vehicle => vehicle.Model == input);
                if (currentVehicle != null)
                {
                    Console.WriteLine(currentVehicle.Print());
                }
            }

            decimal averageHPCars = vehicleList.Where(vehicle => vehicle.Type == "Car").Select(vehicle => vehicle.HorsePower).DefaultIfEmpty().Average();

            Console.WriteLine($"Cars have average horsepower of: {averageHPCars:f2}.");

            decimal averageHPTrucks = vehicleList.Where(vehicle => vehicle.Type == "Truck").Select(vehicle => vehicle.HorsePower).DefaultIfEmpty().Average();

            Console.WriteLine($"Trucks have average horsepower of: {averageHPTrucks:f2}.");
        }
    }
    public class Vehicle
    {
        public Vehicle(string type, string model, string color, decimal horsePower) 
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }
        
        private string type;
        public string Type 
        {
            get
            {
                return type;
            }
            set
            {
                type = Capitalize(value);
            } 
        
        }
        public string Model { get; set; }
        public string Color { get; set; }
        public decimal HorsePower { get; set; }

        public string Capitalize (string value)
        {
            char[] charArr = value.ToCharArray();
            if (char.IsLower(charArr[0]))
            {
                charArr[0] = char.ToUpper(charArr[0]);
            }
            return new string(charArr);
        }

        public string Print()
        {
            string result = string.Empty;
            result += $"Type: {Type}\n";
            result += $"Model: {Model}\n";
            result += $"Color: {Color}\n";
            result += $"Horsepower: {HorsePower}";
            return result;
        }
    }
}
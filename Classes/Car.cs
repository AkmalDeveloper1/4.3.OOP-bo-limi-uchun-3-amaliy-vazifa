using System.Runtime.Intrinsics.Arm;

namespace OOP_Car
{
    class MainCar
    {
        public MainCar()
        {
            MainCarMethod();
        }
        public void MainCarMethod()
        {
            Console.Write("1-narxni kiriting: ");
            decimal.TryParse(Console.ReadLine(), out decimal Narx1);
            Console.Write("1-narxni kiriting: ");
            decimal.TryParse(Console.ReadLine(), out decimal Narx2);
            int count = 1;

            List<Car> cars = new List<Car>
            {
                new Car(marka:"Mercedes",nomi:"W204",narx:255_650_000),
                new Car(marka:"Chevrolet",nomi:"Damas Van",narx:76_198_000),
                new Car(marka:"Chevrolet",nomi:"Damas Labo",narx:79_198_000m),
                new Car(marka:"Chevrolet",nomi:"Spark 2-paz",narx:73_262_000m),
                new Car(marka:"Chevrolet",nomi:"Spark 3-paz",narx:92_821_000m),
                new Car(marka:"Chevrolet",nomi:"Kobalt 2-paz",narx:95_768_000m),
                new Car(marka:"Chevrolet",nomi:"Kobalt 4-paz",narx:115_390_000m),
                new Car(marka:"Chevrolet",nomi:"Malibu 1.5",narx:115_390_000m),
                new Car(marka:"Chevrolet",nomi:"Malibu 2",narx:278_322_334m),
                new Car(marka:"Chevrolet",nomi:"Kobalt 4-paz",narx:311_124_067m),
                new Car(marka:"Chevrolet",nomi:"Lasetti 3-paz",narx:138_126_067m),
            };
            foreach (var car in cars)
            {
                if (Narx1 <= car.Narx && car.Narx <= Narx2 || Narx2 <= car.Narx && car.Narx <= Narx1)
                    Console.WriteLine($"{count++}. {car.Marka} {car.Nomi} - {car.Narx}");
            }
            Console.ReadKey();
        }

    }
    class Car
    {
        public Car() { }
        public Car(string marka, string nomi, decimal narx)
        {
            Marka = marka;
            Nomi = nomi;
            Narx = narx;
        }
        public string Marka { get; set; }
        public string Nomi { get; set; }
        public decimal Narx { get; set; }

    }
}
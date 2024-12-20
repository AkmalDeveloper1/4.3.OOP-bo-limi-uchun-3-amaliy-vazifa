namespace OOP_Boxer
{
    class MainBoxer
    {
        public MainBoxer()
        {
            MainBaxerMethod();
        }
        public void MainBaxerMethod()
        {
            int counter = 1;
            List<Boxer> boxerList = new List<Boxer>
                {
                    new Boxer(ism:"Akmal",familya:"Rakhmonov",yoshi:10,vazni:44),
                    new Boxer(ism:"Mardon",familya:"Rakhmonov",yoshi:8,vazni:60),
                    new Boxer(ism:"Maqsud",familya:"Niyozov",yoshi:11,vazni:68),
                    new Boxer(ism:"Zuhriddin",familya:"Salomov",yoshi:10,vazni:76),
                    new Boxer(ism:"Mahkam",familya:"To'raxojayer",yoshi:10,vazni:77),
                    new Boxer(ism:"Sardon",familya:"Jabbiyev",yoshi:9,vazni:105),
                    new Boxer(ism:"Ochil",familya:"Fozilov",yoshi:9,vazni:94),
                    new Boxer(ism:"Kamol",familya:"O'rinboyev",yoshi:9,vazni:93),
                    new Boxer(ism:"Hondamir",familya:"Komilov",yoshi:7,vazni:49),
                    new Boxer(ism:"Fayzulla",familya:"Karimov",yoshi:11,vazni:84),
                };
            Console.WriteLine("Yengil vazndagilar");
            foreach (var yengil in boxerList)
                if (yengil.Vazni < 50)
                    Console.WriteLine($"\t{counter++}. {yengil.Familya} {yengil.Ism}");
            counter = 1;
            Console.WriteLine("O'rta vazndagilar");
            foreach (var orta in boxerList)
                if (50 <= orta.Vazni && orta.Vazni <= 76)
                    Console.WriteLine($"\t{counter++}. {orta.Familya} {orta.Ism}");
            counter = 1;
            Console.WriteLine("Og'ir vazndagilar");
            foreach (var ogr in boxerList)
                if (ogr.Vazni >= 90)
                    Console.WriteLine($"\t{counter++}. {ogr.Familya} {ogr.Ism}");

            Console.ReadKey();
        }

    }
    class Boxer
    {
        public Boxer() { }
        public Boxer(string familya, string ism, sbyte yoshi, uint vazni)
        {
            Id = Guid.NewGuid();
            Familya = familya;
            Ism = ism;
            Yoshi = yoshi;
            Vazni = vazni;
        }
        public Guid Id { get; private set; }
        public string Familya { get; set; }
        public string Ism { get; set; }
        public sbyte Yoshi { get; set; }
        public uint Vazni { get; set; }
    }
}
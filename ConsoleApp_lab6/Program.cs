namespace ConsoleApp_lab6
{
    internal class Program
    {
        static void Main()
        {
            //1
            Builder john = new Builder();
            john.Name = "John";
            john.Age = 35;
            john.Gender = "Male";
            john.Trade = "Carpenter";
            john.YearsOfExperience = 10;
            john.Walk();
            john.Build();
            Console.WriteLine(john.Name+" "+john.Gender+ " Age "+john.Age + " "+john.Trade+" years work "+john.YearsOfExperience);

            Sailor sarah = new Sailor();
            sarah.Name = "Sarah";
            sarah.Age = 28;
            sarah.Gender = "Female";
            sarah.Rank = "Captain";
            sarah.Vessel = "Cargo ship";
            sarah.Walk();
            sarah.Sail();
            Console.WriteLine(sarah.Name+" age "+sarah.Age+" "+sarah.Gender+" "+sarah.Rank+" "+sarah.Vessel);

            Pilot david = new Pilot();
            david.Name = "David";
            david.Age = 42;
            david.Gender = "Male";
            david.LicenseNumber = "12345";
            david.AircraftType = "Boeing 747";
            david.Walk();
            david.Fly();
            Console.WriteLine(david.Name+" age "+david.Age+" "+david.Gender+" license= "+david.LicenseNumber+ " AircraftType "+david.AircraftType);

            //2
            Tiger tiger = new Tiger("Tony", 50);
            Console.WriteLine("tiger... ");
            Console.WriteLine("Tiger name: " + tiger.Name);
            Console.WriteLine("Tiger speed: " + tiger.Speed);
            tiger.Roar();
            tiger.Eat();
            tiger.Walk();
            Console.WriteLine();

            Crocodile crocodile = new Crocodile("Snappy", 10);
            Console.WriteLine("crocodile... ");
            Console.WriteLine("Crocodile name: " + crocodile.Name);
            Console.WriteLine("Crocodile length: " + crocodile.Length);
            crocodile.Swim();
            crocodile.Eat();
            crocodile.Walk();
            Console.WriteLine();

            Kangaroo kangaroo = new Kangaroo("Joey", 3);
            Console.WriteLine("kangaroo... ");
            Console.WriteLine("Kangaroo name: " + kangaroo.Name);
            Console.WriteLine("Kangaroo jump height: " + kangaroo.JumpHeight);
            kangaroo.Jump();
            kangaroo.Eat();
            kangaroo.Walk();
        }
    
}
}
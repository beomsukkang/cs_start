using System;

namespace BasicClass
{
    class cat
    {
        public string Name;
        public string Color;

        public void Meow()
        {
            Console.WriteLine($"{Name} :야옹");
        }
    }
    
    class MainApp
    {
        static void Main(string[] args)
        {
            cat kitty = new cat(); //생성자
            kitty.Color = "하얀색";
            kitty.Name = "키티";

            kitty.Meow();
            Console.WriteLine($"{kitty.Name} :{kitty.Color}");

            cat nero = new cat();
            nero.Color = "검은색";
            nero.Name = "네로";

            nero.Meow();
            Console.WriteLine($"{nero.Name} :{nero.Color}");
        }
    }
}
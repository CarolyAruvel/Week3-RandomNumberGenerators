using System;

namespace RandomNumberGenerators
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int myRandomNumber = rnd.Next(1, 11);//number 1 kuni 10

            Console.WriteLine($"Sinu juhuslik number on {myRandomNumber}");

            //programm kontrollib, kas genereeritud number on suurem kui 5
            //kui genereeritud number on suurem, kui 5, programm kuvab 
            //"juhuslik number on {myRandomNumber}, see on suurem kui 5"
            //kui genereeritud number on väiksem, kui 5, programm kuvab 
            //"juhuslik number on 5"
            //< - väiksem kui, > suurem kui, == - võrdne

            if (myRandomNumber > 5)
            {
                Console.WriteLine($"Sinu juhuslik number on {myRandomNumber} suurem kui 5");
            }
            else if (myRandomNumber < 5)
            {
                Console.WriteLine($"Sinu juhuslik number on {myRandomNumber} väiksem kui 5");
            }
            else
            {
                Console.WriteLine("Sinu juhuslik number on 5");
            }



        }  
    }
}

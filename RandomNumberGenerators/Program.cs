using System;

namespace RandomNumberGenerators
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int myRandomNumber = rnd.Next(1, 11);//nr 1 - 10

            Console.WriteLine($"Sinu juhuslik number on {myRandomNumber}");
            //programm kontrollib, kas genereeritud number on suurem kui 5
            //kui genereeritud number on suurem, kui 5, programm kuvab
            //"juhuslik number on {myRandomNumber}, see on suurem kui 5
            //kui genereeritud number on väiksem, kui 5, siis programm kuvab
            //"juhuslik number on {myRandomNumber}, see on väiksem kui 5
            //kui genereeritud number on 5, programm kuvab
            //"juhuslik number on 5."

            if (myRandomNumber < 5)
            {
                Console.WriteLine($"Teie valitud number {myRandomNumber} on väiksem kui 5.");
            }
            else if (myRandomNumber > 5)
            {
                Console.WriteLine($"teie valitud number {myRandomNumber} on suurem kui 5.");

            }
            else if (myRandomNumber == 5)
            {
                Console.WriteLine("juhuslik number on 5.");
            }
                



        }
    }
}

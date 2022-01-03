using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // programm küsib kasutajal sisestada eesnimi
            // programm küsib kasutajal sisestad numbrit 1 - 3
            // kui kasutaja sisestab 1, siis kuvatakse kasutaja eesnimi tagurpidi
            // kui kasutaja sisestab 2, siis kuvatakse kasutaja eesnime esimest tähte
            // kui kasutaja sisestab 3, siis kuvatakse kasutaja eesnime pikkust

            Console.WriteLine("Sisestage oma eesnimi:");
            string userName = Console.ReadLine();

            Console.WriteLine("Sisestage number 1 - 3:");
            char userNumber = Convert.ToChar(Console.ReadLine());

            switch(userNumber)
            {
                case '1':
                    UserNameReversed(userName);
                    break;
                case '2':
                    UserNameFirstLetter(userName);
                    break;
                case '3':
                    UserNameLenght(userName);
                    break;
                default:
                    Console.WriteLine("Kena päeva!");
                    break;
                    
            }


        }

        public static void UserNameReversed(string userName)
        {
            for (int i = userName.Length - 1; i >= 0; i--)
            {
                Console.Write(userName[i]);
               
                
            }
        }

        public static void UserNameFirstLetter(string userName)
        {
            Console.WriteLine($"Sinu nime esimene täht on {userName[0]}.");
        }

        public static void UserNameLenght(string userName)
        {
            Console.WriteLine($"Sinu nimi on {userName.Length} sümbolit pikk.");
        }
    }
}

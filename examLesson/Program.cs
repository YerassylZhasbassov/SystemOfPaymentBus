using System;

namespace examLesson
{
    public class PaymentByCard {
        private int balanceOfCard; 
        private int rechargeToTheCard; //пополнение карты
        private int priceOfPassege = 90;
        public int GetBalanceOfCard()
        {
            return balanceOfCard;
        }
        public void SetBalanceOfCard(int balanceOfCard) {
            this.balanceOfCard = balanceOfCard;
        }

        public int GetRechargeToTheCard()
        {
            return rechargeToTheCard;
        }
        public void SetRechargeToTheCard(int rechargeToTheCard)
        {
            this.rechargeToTheCard = rechargeToTheCard;
            if (balanceOfCard < priceOfPassege)
            {
                Console.WriteLine("You do not have enought money! You must to recharge your passege card!");
                Console.WriteLine("How many balance do you need to recharge?");
                rechargeToTheCard = Convert.ToInt32(Console.ReadLine());
                priceOfPassege = rechargeToTheCard + priceOfPassege;
            }
            else {
                balanceOfCard = balanceOfCard - priceOfPassege;
            }
            
        }

    }

    public class Bus
    {
        private string _BusNumber;
        private string _stop;
        private string _route;
        static void Main()
        {
            Random random = new Random();
            Console.Write("Enter the number of shifts: ");
            int count = int.Parse(Console.ReadLine());
            int AllPessegers = 0;


            for (int i = 0; i < count; i++)
            {
                int flight = random.Next(10, 16);

                for (int j = 0; j < flight; j++)
                {
                    AllPessegers += (int)(random.Next(130, 231) * 0.7);
                }
            }
            int priceOfPassege = 90;
            AllPessegers *= priceOfPassege;
            Console.WriteLine("Total earnings for all time: " + AllPessegers);

            Console.ReadKey();

            Console.WriteLine("Введите начальный маршрут: ");
            string route1 = Console.ReadLine();

            Console.WriteLine("Введите конечный маршрут: ");
            string route2 = Console.ReadLine();

            Console.WriteLine($"Начальный: {route1} Конечный: {route2}");

        }
        public string GetBusNumers()
        {
            return _BusNumber;
        }
        public string GetStops()
        {
            return _stop;
        }
        public string GetRoute()
        {
            return _route;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

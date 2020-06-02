using System;

namespace ClassMetanit
{
    class Program
    {/// <summary>
     /// Точка входа
     /// </summary>
     /// <param name="args"></param>
        static void Main(string[] args)
        {
            Account account = new Account(600,100);
            Account account1 = new Account(900, 5);
            Account.MinSum = 200;
           Console.WriteLine( Account.GetSum(100, 6, 5));
            Console.WriteLine(account.Sum);
            Console.WriteLine();

        }
    }
    class Account
    {   /// <summary>
    /// Минимальная  допустимая сумма для всех счетов
    /// </summary>
        private static decimal minSum = 100;
        public  Account (decimal sum,decimal rate)
        {
            if (sum < MinSum)
            {
                throw new Exception("Не допустимая сумма !");
            }else
            { Sum = sum; Rate = rate; }
            
        }
        public   static decimal MinSum
        {
            get { return minSum; }
            set {if (value > 0) minSum = value;}
        }
        /// <summary>
        /// Текущий остаток на счета
        /// </summary>
        public decimal Sum { get; private set; }
        /// <summary>
        /// Процентная ставка
        /// </summary>
        public decimal Rate { get; private set; }
        /// <summary>
        /// Подсчет Суммы на счете через определенный период по определенный ставке
        /// </summary>
        /// <param name="sum">Сумма</param>
        /// <param name="rate"> Процентая ставка</param>
        /// <param name="period">Период</param>
        /// <returns></returns>
        public static decimal GetSum(decimal sum,decimal rate,int period)
        {
            decimal result = sum;
            for(int i = 1; i <= period; i++)
             result = result + result * rate / 100;
             return result;
            
        }
    }
}

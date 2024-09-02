namespace Week1MainTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Islam's Carpet Cleaning Services
            int sRooms = 0;
            int lRooms = 0;

            //prices will put as a variables for compatibility if the code needs to be modified later
            //, but we can save memory space by using the values directly
            int sPrice = 25;
            int lPrice = 35;
            int eTime = 30;

            Console.WriteLine("Estimate for carpet cleaning service");

            Console.Write("number of small rooms: ");
            sRooms = int.Parse(Console.ReadLine());
            Console.Write("number of large rooms: ");
            lRooms = int.Parse(Console.ReadLine());

            //cost calculations
            int cost = (sRooms * sPrice) + (lRooms * lPrice);
            Double tax = 0.06 * cost;
            Double totalCost = cost + tax;

            Console.WriteLine($"Price of small room: ${sPrice}");
            Console.WriteLine($"Price of large room: ${lPrice}");
            Console.WriteLine($"Cost : ${cost}");
            Console.WriteLine($"Tax : ${tax}");
            Console.WriteLine("===============================");
            Console.WriteLine($"Total Estimate: ${totalCost}");
            Console.WriteLine($"This estimate is valid for {eTime} days");




        }
    }
}

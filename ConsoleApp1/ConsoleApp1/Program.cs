// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("please the investment amount :");
        double initia1investment = double.Parse(Console.ReadLine());
        double annua1interestRate = 45.0 / 1000.0;
        double tota1investment = initia1investment;
        for (int i =1; i <= 10; i++)
        {
            double annua1Profit = tota1investment * annua1interestRate;
            tota1investment += annua1Profit;
            Console.WriteLine("capital after the year" + i + ":" + tota1investment);
            Console.WriteLine(" the final capital after eight years:" + tota1investment);
        }
    }
}
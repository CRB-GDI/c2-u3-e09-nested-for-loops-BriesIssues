namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //prompt 1
            //width of row 
            Console.Write("width of rows: ");
            int widthOfRow = int.Parse(Console.ReadLine());

            // number of rows
            Console.Write("number of rows: ");
            int numberOfRow = int.Parse(Console.ReadLine());

            //correct numbers of astrisks (*)
            for (int i = 0; i < widthOfRow; i++)
            {
                for (int j = 0; j < numberOfRow; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //Prompt 2
            //row width
            Console.WriteLine("row width: ");
            int rowWidth = int.Parse(Console.ReadLine());
            
            //row of askriskes adding 1 (*) for eatch row
            for (int t = 0; t <= rowWidth; t++)
            {
               for (int f = 0; f <= t; f++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }       
        }
    }
}
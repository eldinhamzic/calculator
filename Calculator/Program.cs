using System;
using System.Data;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter a mathematical expression: ");
            string input = Console.ReadLine();

            if (input == null) continue;

            if (input.Trim().ToLower() == "red button")
            {
                Random random = new Random();
                int yijing = random.Next(1, 65);
                string hexagram = Char.ConvertFromUtf32(0x4DC0 + yijing - 1);
                Console.WriteLine($"Random hexagram : {hexagram} "  );
            }
            else
            {
                try
                {
                    DataTable table = new DataTable();
                    var result = table.Compute(input, null);

                    if (result != null && double.TryParse(result.ToString(), out double resultNum))
                    {
                        if (resultNum <= 4)
                        {
                            Console.WriteLine($"Result is : {resultNum}");
                        }
                        else
                        {
                            Console.WriteLine("A Suffusion of Yellow");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}

    


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter: ");
            Console.WriteLine(CountBits(10));
            Console.WriteLine(Persistence(9));
            Console.WriteLine(DigitalRoot(16));

            int CountBits(int num)
            {
                string n = Convert.ToString(num, 2);
                int count = 0;
                for(int i=0;i<n.Length;i++)
                {
                    if (n[i] == '1')
                        count++;
                }
                return count;
            }

            int Persistence(int num)
            {
                int count=0,n;
                while(num/10 > 0)
                {
                    n = 1;
                    while (num > 0)
                    {
                        n *= num % 10;
                        num /= 10;
                    }
                    count++;
                    num = n;
                }
                return count;
            }

            int DigitalRoot(int num)
            {
                if (num / 10 > 0)
                {
                    int n = 0;
                    while (num > 0)
                    {
                        n += num % 10;
                        num /= 10;
                    }
                    num = n;
                    return DigitalRoot(num);
                }
                return num;
            }


        }
    }
}

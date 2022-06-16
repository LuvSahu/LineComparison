namespace LineComprison
{
    class Program
    {
        public static void Main (String[] args)
        {
            UC1lc lc = new UC1lc();
            lc.findvalue();

            UC2lc lc1 = new UC2lc();
            double value1 = lc1.Lineone();
            double value2 = lc1.LineTwo();

            if(value1 == value2)
            {
                Console.WriteLine("Line is equal");
            }
            else if (value1 > value2)
            {
                Console.WriteLine("Lineone is greater");
            }
            else
            {
                Console.WriteLine("Line is not equal");
            }
            
            
            
            

        }
    }
}

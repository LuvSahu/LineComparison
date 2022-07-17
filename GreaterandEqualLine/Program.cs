namespace LineComprison
{
    class Program
    {
        public static void Main (String[] args)
        {
            //UC3
            CompareLines compareLines = new CompareLines();
            compareLines.CalculateLength(); //Call The Methods
            compareLines.CompareTwoLines();
            Console.ReadLine();
            
            
            
            

        }
    }
}

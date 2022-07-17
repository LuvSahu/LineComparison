namespace LineComprison
{
    class Program
    {
        public static void Main (String[] args)
        {
           //UC2
            LineLength1 length = new LineLength1();
            length.CalculateLength(); //Call The Methods
            length.CheckEquality();
            Console.ReadLine();
    }
}

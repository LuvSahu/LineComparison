namespace LineComprison
{
    class Program
    {
        public static void Main (String[] args)
        {
            Console.WriteLine("==========Welcome To Line Comparison Computation Program==========");
            
            //UC1
            //LineLength lc = new LineLength();
            //lc.CalculateLength();
            
            //UC2
            //LineLength1 length = new LineLength1();
            //length.CalculateLength(); //Call The Methods
            //length.CheckEquality();
            //Console.ReadLine();

            //UC3
            //CompareLines compareLines = new CompareLines();
            //compareLines.CalculateLength(); //Call The Methods
            //compareLines.CompareTwoLines();
            //Console.ReadLine();

            //UC5

            AddMultipleContact addMultipleContact = new AddMultipleContact();
            addMultipleContact.CalculateLength(); //Call The Methods
            addMultipleContact.CompareTwoLines();
            Console.ReadLine();





        }
    }
}

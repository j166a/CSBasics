namespace CSBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("My Book", 200);
            book1.CurrentPage = 50;
            book1.TurnPage();

            //Console.WriteLine("Book title: " + book1.Title);
            //Console.WriteLine("Current page: " + book1.CurrentPage);




            //double pi = 3.142;
            //Console.WriteLine(pi);

            //bool isLearningCs = true;
            //Console.WriteLine(isLearningCs);

            //string favouriteFilm = "Terminator 2";
            //Console.WriteLine("My favourite film is " + favouriteFilm);

            //string firstName = "Imad";
            //printGreeting(firstName);

            //Console.WriteLine(SubtractValue(10, 2));

            //Console.WriteLine(isStringLonger("Hello", 6));

            //int subtractionResult = SubtractValue(20, 8);
            //Console.WriteLine(subtractionResult);

        }

        //private static void printGreeting(string name)
        //{
        //    Console.WriteLine("Hello " + name);
        //}

        //private static int SubtractValue(int firstNumber, int secondumber)
        //{
        //    return firstNumber - secondumber;
        //}

        //private static bool isStringLonger(string word, int number)
        //{
        //    return word.Length > number;
        //}
}
}

namespace AccumulateMessagesFunction
{
    //Micah Spencer
    //RCET2265
    //Fall 25
    //Accumulate Messages Function
    //https://github.com/micahspencer-png/AccumulateMessagesFunction.git
    internal class Program
    {
        static void Main(string[] args)
        {
            string userMessages = "This is important";
            string allTheMessages = "";
            bool quit = false;

            Console.WriteLine("Type Data You Want Stored. Press Q to Show All Data");
            do
            {
                userMessages = Console.ReadLine();
                if (userMessages != "q" && userMessages != "Q")
                {
                    allTheMessages = Messages(userMessages);
                    Console.Clear();
                }
                else
                {
                    quit = true;
                }
            } while (quit == false);

            Console.Clear();
            Console.WriteLine("The Messages Typed Are:");
            Console.WriteLine(allTheMessages);

            //pause
            Console.WriteLine("Press Enter to Quit");
            Console.Read();
        }

        private static string messages_ = "";


    }
}

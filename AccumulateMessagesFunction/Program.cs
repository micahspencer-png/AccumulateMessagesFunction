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
                if (userMessages == "q" || userMessages == "Q")
                {
                    
                    quit = true;
                }

                else if (userMessages == "m"|| userMessages == "M")
                {
                    Console.Clear();
                    Console.WriteLine("The Messages Typed Are:");
                    Console.WriteLine(allTheMessages);
                }

                else
                {
                    allTheMessages = Messages(userMessages);
                    Console.Clear();
                }
            } while (quit == false);

            //pause
            Console.WriteLine("Press Enter to Quit");
            Console.Read();
        }

        private static string _messages = "";

        static string Messages(string userMessages)
        {
            userMessages = userMessages.Trim();
            //grabs global
            string messages = _messages;

            if (messages.Length == 0)
            {
                messages += userMessages;
            }

            //skips a blank input
            else if (userMessages != "")
            {
                //append the current message
                messages += "\n" + userMessages;
            }

            //clears data if c is typed
            else if (userMessages == "c" || userMessages == "C" )
            {
                messages = "";
            }

            //stores the updated data
            _messages = messages;

            //return the messages
            return messages;
        }


    }
}

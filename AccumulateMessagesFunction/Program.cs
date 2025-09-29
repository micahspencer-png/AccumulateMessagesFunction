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

            Console.WriteLine("Type Data You Want Stored.");
            do
            {
                Console.WriteLine("Press Q to Quit, M to Show Messages, or C to Clear Messages");

                userMessages = Console.ReadLine();
                if (userMessages == "q" || userMessages == "Q")
                {
                    quit = true;
                }

                //displays data when m is typed
                else if (userMessages == "m"|| userMessages == "M")
                {
                    Console.Clear();
                    Console.WriteLine("The Messages Typed Are:");
                    Console.WriteLine(allTheMessages);
                }

                //runs program when data is input
                else
                {
                    allTheMessages = Messages(userMessages);
                    Console.Clear();
                }
            } while (quit == false);

            //pause
            Console.Clear();
            Console.WriteLine("Press Enter to Quit");
            Console.Read();
        }

        private static string _messages = "";

        static string Messages(string userMessages)
        {
            //trims message
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
                //empties string when c is typed
                if (userMessages == "c" || userMessages == "C")
                {
                    messages = string.Empty;
                    messages = "";
                }

                else
                {
                    //append the current message
                    messages += "\n" + userMessages;                    
                }

            }

            //stores the updated data
            _messages = messages;

            //return the messages
            return messages;
        }


    }
}

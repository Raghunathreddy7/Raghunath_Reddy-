using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Message
    {
        List<string> data = new List<string>();                     //Chat Data storage........
        public void DisplayChat()                                 //Display method to print chat
        {
            foreach (string lo in data)
            {
                Console.WriteLine(lo);
            }
        }
        private long phono;               //private fields
        private string name;
        Message() { }
        public Message(long phono, string name)             //Constructor call receving from serverClass 
        {
            this.phono = phono;
            this.name = name;
        }

        public void MessageRecieve(string Chat)
        {
            data.Add(Chat);                              //Receving message stored in Data list
            Console.WriteLine("Send Reply Yes or No");   //Recevier options 
            string gg = Console.ReadLine();
            if (gg == "Yes")
            {
                SendReturnMessage();
            }
        }
        public void SendReturnMessage()                 //sending return Message and Storing data in list..
        {
            Console.WriteLine("Enter Message");
            string ll = "--------------------------------" + Console.ReadLine();
            data.Add(ll);
            DisplayChat();
        }
    }
}



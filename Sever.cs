using System;
using System.Collections.Generic;
using System.Linq;                                              //Raghunath
using System.Text;
using System.Threading.Tasks;
                                                                //ServerClass...........
namespace ConsoleApp3
{
    public class Server
    {
        public void StartMessging(long phno, string name)            //Call Receive from User To Chat and sending phone number and name
        {
            bool l = true;
            while (l)
            {
                Console.WriteLine("1. Send Message");
                Console.WriteLine("2. Exit");                        //User geting choice to send Or Exit
                int pp = Convert.ToInt32(Console.ReadLine());
                if (pp == 1)
                {
                    Message client = new Message(phno, name);
                    Console.WriteLine("Enter Message");
                    string abc = Console.ReadLine();

                    client.MessageRecieve(abc);                    //sending message to User wanted Number....(calling Meassage methods)  

                }

                else if (pp == 2)
                {
                    l = false;
                }

            }
            Dictionary<long, string> ServerAccount = new Dictionary<long, string>()   //Server Data
        {
            {8999989000,"krishna" },
            {9877899997,"Saikiran" },
            {7829199199,"Naveen" },
            {9949788923,"Nagesh" },                                //ServerDataBase.....
            {6789900233,"PavanKalayan" },
            {2334123889,"Girish" },
            {9973727829,"Dinesh" },
            {8812340980,"Harsha" }
        };


        }

    }

}

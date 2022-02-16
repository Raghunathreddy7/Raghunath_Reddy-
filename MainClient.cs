using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Client1 : Client                //interface Implemeted........
    {



        Dictionary<long, string> account = new Dictionary<long, string>()
        {
            {8999989000,"krishna" },
            {9877899997,"Saikiran" }
        };

        public void deletecontact(long phno)
        {
            account.Remove(phno);
            Console.WriteLine("Deleting message");
        }

        public void addContact(long phno, string name)
        {
            account[phno] = name;
            Console.WriteLine("Contact added");
        }

        public void createGroup(long phno, string name)
        {
            Dictionary<long, string> Group = new Dictionary<long, string>()
            {

            };
            Group[phno] = name;
            Console.WriteLine("Created Whatsup group");
        }
        static void Main(string[] args)                                                 //Main Method........
        {
            bool status = false;
            Dictionary<long, string> saccount = new Dictionary<long, string>()    //Login Database..
            {
                {7815862556,"Raghunath123" },
                {8965456999, "krishna123"}
            };
            Console.WriteLine("Already Account Created Yes or No");
            string inf = Console.ReadLine();
            if (inf == "Yes")                                                       //Login Verify..
            {
                Console.Write("Enter Phone No: ");
                long phno = Convert.ToInt64(Console.ReadLine());
                foreach (long s in saccount.Keys)
                {
                    if (s == phno)
                    {
                        Console.Write("Enter Password   : ");
                        string k = Console.ReadLine();
                        if (k == saccount[s])
                        {
                            Console.WriteLine("Account logined");
                            status = true;
                        }
                        else
                        {
                            Console.WriteLine("Try again ,Enter correct password");
                        }
                    }
                }
                if (status == false)
                {
                    Console.WriteLine("Account Not registerd,try again");
                }
            }
            else if (inf == "No")                                                          //AccountRegistration...
            {
                bool kk = true;
                Console.Write("Enter Phone No: ");
                long phno = Convert.ToInt64(Console.ReadLine());
                foreach (long s in saccount.Keys)
                {
                    if (s == phno)
                    {
                        Console.WriteLine("Account ALready existed");
                        kk = false;
                    }
                }
                if (kk == true)
                {
                    Console.Write("Enter Password   : ");
                    string passw = Console.ReadLine();
                    saccount.Add(phno, passw);
                    Console.WriteLine("Account Activated");
                    status = true;
                }
            }
            if (status == true)
            {
                Console.WriteLine("Successfully logined next steps");
                bool l = true;
                Client1 sb = new Client1();
                while (l)
                {                                                                        //This methods are Available to User.
                    Console.WriteLine("1. Add contact");
                    Console.WriteLine("2. Delete Contact");
                   
                    Console.WriteLine("3. Exit");
                    Console.WriteLine("4. Logout(or)DeleteAccount");
                    Console.WriteLine("5. StartMessaging");
                    int pp = Convert.ToInt32(Console.ReadLine());
                    if (pp == 1)
                    {
                        Console.Write("Enter phoneNo : ");
                        long ph = Convert.ToInt64(Console.ReadLine());
                        Console.Write("Enter Name : ");
                        string k = Console.ReadLine();
                        sb.addContact(ph, k);
                    }
                    else if (pp == 2)
                    {

                        Console.WriteLine("Enter PhoneNo : ");
                        long pk = Convert.ToInt64(Console.ReadLine());

                        sb.deletecontact(pk);
                    }
                    else if (pp == 3)
                    {
                        l = false;
                    }
                    else if (pp == 4)
                    {
                        Console.WriteLine("Enter Registerd Number");
                        long lo = Convert.ToInt64(Console.ReadLine());
                        saccount.Remove(lo);
                        break;
                    }
                    else if (pp == 5)
                    {
                        Console.WriteLine("Enter friend number and Name to chat....");
                        long ph = Convert.ToInt64(Console.ReadLine());
                        string k = Console.ReadLine();
                        Server az = new Server();
                        az.StartMessging(ph, k);



                    }
                    else
                    {
                        Console.WriteLine("Enter correcet number : ");
                    }
                }
            }
        }     //End of Main Method..............
    }
}





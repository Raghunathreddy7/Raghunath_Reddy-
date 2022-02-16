using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
                 //ClientInterface..............
    public interface Client
    {
        //ClientInterfaceMethods...............
        void deletecontact(long phno);
        void addContact(long phno, string name);
        void createGroup(long phno, string name);
        //End of methods....
    }
}

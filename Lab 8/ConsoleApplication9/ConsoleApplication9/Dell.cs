using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Dell
    {
        public delegate void Message(int x);

        private Message cookForAll;

        public Dell(Message messageForDiner)
        {
            cookForAll += messageForDiner;
        }
        public Dell(Message messageForDiner, Message messageForDiner2, Message messageForDiner3)
        {
            cookForAll += messageForDiner;
            cookForAll += messageForDiner2;
            cookForAll += messageForDiner3;
        }
        public Dell()
        {
                
        }
        public void DoSomethng()
        {
            cookForAll(22);
        }
    }
}

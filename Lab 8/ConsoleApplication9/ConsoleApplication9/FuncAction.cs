using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class FuncAction
    {
        public Action act;

        public void Act()
        {
            act?.Invoke();
        }


        public Func<int, int, int> fun;

        public FuncAction(Action inAct)
        {
            act += inAct;
        }
        public FuncAction(Func<int, int, int> inFun)
        {
            fun += inFun;
        }
        public FuncAction(Action inAct, Func<int, int, int> inFun)
        {
            fun += inFun;
            act += inAct;
        }

    }
}

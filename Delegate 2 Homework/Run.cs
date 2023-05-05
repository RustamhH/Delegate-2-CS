using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_2_Homework
{
    internal class Run
    {

        public void RunFunc(Func delegatefunc,string str)
        {
            try
            {
                delegatefunc.Invoke(str);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}

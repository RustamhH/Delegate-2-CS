using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_2_Homework
{
    internal class MyClass
    {
        public void Space(string str) // e_x_a_m_p_l_e -> bu metod sadece her herifin arasina _ atir.
        {
            string edited = "";
            foreach (var item in str)
            {
                edited += item;
                if(str.IndexOf(item)!=str.Length-1) edited += "_";
            }
            Console.WriteLine(edited);
        }
        public void Reverse(string str) // elpmaxe -> bu metod ise stringi tersine cevirir.
        {
            string reverse = "";
            for (int i = str.Length - 1; i > -1; i--)
            {
                reverse += str[i];
            }
            Console.WriteLine(reverse);
        }

        public MyClass() { }

    }
}

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpinDepth
{
    // StringCollection을 이용하여 이름을 저장하고 출력하는 예
    internal class _2_3NameWithCollection
    {
        static StringCollection GenerateNames()
        {
            StringCollection names = new StringCollection(); // ArrayList를 StringCollection으로 바꾼 것을 제외하면 완전히 동일하다.
            // StringCollection은 범용 컬렉션처럼 보이지만 실제로는 문자열만 저장할 수 있는 컬렉션이다.
            // string 타입만을 매개변수로 취하기 때문에 이외 타입의 객체를 삽입할 수 없다.
            names.Add("Gamma");
            names.Add("Vkussudes");
            names.Add("Johnson");
            names.Add("Helm");
            return names;
        }

        static void PrintNames(StringCollection names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}

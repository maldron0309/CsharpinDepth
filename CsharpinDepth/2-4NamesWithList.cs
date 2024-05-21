using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpinDepth
{
    // List<string>을 이용하요 이름을 저장하고 출력하는 예
    internal class _2_4NamesWithList
    {
        static List<string> GenerateNames() // List<T>는 T 타입의 요소를 저장할 수 있는 컬렉션이다.
        {
            List<string> names = new List<string>(); // 이제 StringCollection을 사용한 코드를 모두 List<string>으로 대체할 수 있다.
            // List<T>를 이용하면 앞서 알아봤던 모든 문제를 해결할 수 있다.
            // * 배열처럼 컬렉션을 초기화 할 때 크기를 미리 알아야 할 필요가 없다. - 2-1NamesWithArray
            // * 컬렉션에 저장할 요소의 타입은 T로 나타내며, 외부로 노출하는 API에서 요소의 타입을 참조할 때는 T를 사용하면 된다. 즉 List<string>의 경우
            // string 타입의 객체만을 저장할 수 있으며, ArrayList와는 달리 string이 아닌 다른 타입의 객체를 삽입하려고 하면 컴파일 오류가 발생한다. - 2-2NamesWithArrayList
            // * StringCollectin 등의 타입과는 달리 어떤 타입과도 함께 사용할 수 있다.
            names.Add("Gamma");
            names.Add("Vkussudes");
            names.Add("Johnson");
            names.Add("Helm");
            return names;
        }

        static void PrintNames(List<string> names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}

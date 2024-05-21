using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpinDepth
{
    // ArrayList를 이용하여 이름을 저장하고 출력하는 예
    internal class _2_2NamesWithArrayList
    {
        static ArrayList GenerateNames()
        {
            ArrayList names = new ArrayList();
            names.Add("Gamma");
            names.Add("Vkussudes");
            names.Add("Johnson");
            names.Add("Helm");
            // 컬렉션에 문자열이 아닌 다른 타입의 객체를 저장하는 것을 막을 방법이 없다
            // ArrayList의 Add 메서드가 Object 타입을 매개변수로 취하기 때문
            return names;
        }

        // 타입 안정적으로 작성된 것 처럼 보이지만 실제로는 그렇지 않다.
        // 사용하는 컬렉션에는 참조 타입이라면 어떤 객체라도 포함될 수 있디 때문이다.
        // 완전히 다른 타입의 객체가 포함되어 있고 이를 출력하려고 하면
        // forech는 컬렉션의 내용을 name 변수의 타입과 일치시키기 위해 내부적으로 object를 string으로 변환하는 암시적 타입 변환이 수행된다
        // InvalidCastExceptio이 발생된다.
        static void PrintNames(ArrayList names)
        {
            foreach (string name in names) // ArrayList에 문자열이 저장되어 있지 않다면 무슨 일이 일어날까?
            {
                Console.WriteLine(name);
            }
        }
    }
}

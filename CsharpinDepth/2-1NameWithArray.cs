using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpinDepth
{
    // 배열을 이용하여 이름을 저장하고 출력하는 예
    internal class _2_1NameWithArray
    {
        static string[] GenerateNames()
        {
            string[] names = new string[4]; // 배열을 생성할 때 크기를 미리 알아야 한다.
            // 배열 하나를 만들고 그 배열이 가득차면 그보다 좀 더 큰 배열을 할당한 후 이전 배열의 내용을 복사하는 방식을 반복한다.
            // 이름을 모두 읽었다면 저장된 이름의 개수보다 배열의 크기가 클 것이므로, 정확히 필요한 배열의 크기를 계산한 후
            // 이에 맞춰 새로운 배열을 생성하고 이름을 복사 후 생성된 배열을 반환한다.
            names[0] = "Gamma";
            names[1] = "Vlissides";
            names[2] = "Johnson";
            names[3] = "Helm";
            return names;
        }

        static void PrintNames(string[] names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}

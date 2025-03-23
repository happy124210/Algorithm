// 2438. 별 찍기 - 1

using System.Diagnostics;

int num = int.Parse(Console.ReadLine());

for (int i = 1 ; i <= num ; i++){
    Console.WriteLine(new string('*', i));
}
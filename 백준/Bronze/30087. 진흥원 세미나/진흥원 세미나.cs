// 30087. 진흥원 세미나

Dictionary<string, string> classes = new Dictionary<string, string>()
{
    {"Algorithm", "204"},
    {"DataAnalysis", "207"},
    {"ArtificialIntelligence", "302"},
    {"CyberSecurity", "B101"},
    {"Network", "303"},
    {"Startup", "501"},
    {"TestStrategy", "105"}
};

int N = int.Parse(Console.ReadLine());
while (N > 0)
{
    string input = Console.ReadLine();
    Console.WriteLine(classes[input]);
    N--;
}

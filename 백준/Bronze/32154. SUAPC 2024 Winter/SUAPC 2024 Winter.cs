// 32154. SUAPC 2024 Winter

string[,] board = {{"11", "A B C D E F G H J L M"},
					    {"9", "A C E F G H I L M"},
					    {"9", "A C E F G H I L M"},
					    {"9", "A B C E F G H L M"},
					    {"8", "A C E F G H L M"},
					    {"8", "A C E F G H L M"},
					    {"8", "A C E F G H L M"},
					    {"8", "A C E F G H L M"},
					    {"8", "A C E F G H L M"},
					    {"8", "A B C F G H L M"}};

int N = int.Parse(Console.ReadLine()) - 1;
Console.WriteLine(board[N,0]);
Console.WriteLine(board[N,1]);
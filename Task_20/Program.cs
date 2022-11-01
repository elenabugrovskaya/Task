// Известно, что на доске 8×8 можно расставить 8 ферзей так, чтобы они не били друг друга. Вам дана расстановка 8 ферзей на
// доске, определите, есть ли среди них пара бьющих друг друга.
// Программа получает на вход восемь пар чисел, каждое число от 1 до 8 — координаты 8 ферзей. Если ферзи не бьют друг друга,
// выведите слово NO, иначе выведите YES.

int main() {
    int temp;
    bool cross = false;
    vector <int> x, y;
    for (int i = 1; i <= 8; i++) {
        int temp = int.Parse(Console.ReadLine());
        x.push_back(temp);
        int temp = int.Parse(Console.ReadLine());
        y.push_back(temp);
    }
    for (int i = 0; i < x.size() - 1; i++) {
        for (int j = i + 1; j < x.size(); j++) {
            if (Math.Abs((x[i] - x[j]) == Math.Abs((y[i] - y[j]) || x[i] == x[j] || y[i] == y[j]) 
            {
                cross = true;
            }
        }
    }
    if (cross) Console.WriteLine("YES");
    else Console.WriteLine("NO");
    return 0;
}

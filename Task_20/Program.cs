// See https://aka.ms/new-console-template for more information

#include <iostream>
#include <vector>
#include <cmath>
using namespace std;

int main() {
    vector<int> vertical(8);
    vector<int> gorizontal(8);
    1 7
2 4
3 2
4 8
5 6
6 1
7 3
8 5

    int x[1]=1; int y[1]=7; 

    int b = 0;

    for (int i = 0; i < 8; i++) {
        if (x[i] == x[i + 1])
            b += 1;
        else if (y[i] == y[i + 1])
            b += 1;
        else if (abs(y[i] - y[i + 1]) == abs(y[i + 1] - y[i]))
            b += 1;
    }

    if (b != 0)
        Console.WriteLine("YES");
    else
        Console.WriteLine("NO");

    return 0;
}


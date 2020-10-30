
#include <iostream>
#include <ctime>
using namespace std;
void sort(int* a, int n)
{
    int j,t;
    for (int i = 1; i < n; i++)
    {
        t = a[i];
        for (j = i; j > 0; j--)
            if (a[j - 1] > t)
                a[j] = a[j - 1];
            else
                break;
        a[j] = t;
    }

}

int main()
{
    srand(time(NULL));
    int n;
    int a[100];
    cin >> n;
    for (int i = 0; i < n; i++)
    {
        a[i] = rand() % 51;
        cout << a[i] << " ";

    }
    sort(a, n);
    cout << endl;
    for (int i = 0; i < n; i++)
        cout << a[i] << " ";
}

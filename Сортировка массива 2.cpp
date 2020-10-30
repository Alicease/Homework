#include <iostream>
#include <cstdlib>
#include <ctime>
using namespace std;

void sort(int*a, int b)
{
    int j, c;
    int i_min;
    for (int i = 0; i<b-1;i++)                    // swap (a[i], a[i_min])
    {
        i_min = i;                     
        for (j = i + 1; j < b; j++) 
            if (a[i_min] > a[j])
                i_min = j;
        c = a[i];               
        a[i] = a[i_min];
        a[i_min] = c;
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
        cout << a[i] << " " ;
}

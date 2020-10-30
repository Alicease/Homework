#include <iostream>
using namespace std;

void sort (int *a, int n)
{
	bool f = true;
		int i, j, t;
	i = 0;
	while (f)
	{
		f = false;
		for (j = 0; j < n-1-i; j++)
		{
			if (a[j] > a[j + 1])
			{
				f = true;
					t = a[j];
				a[j] = a[j + 1];
				a[j + 1] = t;
			}
		}
		i++;
	}

}
int main()
{
	int a[100];
	int n;
	cin >> n;
	for (int c=0; c < n; c++)
	{
		cin >> a[c];
		cout << a[c]<<" "; 
	
	}
	cout << endl;
	
	sort(a, n);
	for (int c = 0; c < n; c++)
		cout<< a[c]<<" ";
}
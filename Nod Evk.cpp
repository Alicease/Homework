#include <iostream>
using namespace std;
int Swap(int a, int b)
{
	int d = 0;
	if (a < b)
	{
		d = a;
		a = b;
		b = d;
	}
	return 0;
}
int Evk(int a, int b)
{
	int d = (a % b);
	if (d == 0)
		return b;
	return Evk(b, d);
}
int main()
{
	int a = 1;
	int b = 0;
	while (a != 0)
	{
		cin >> a;
		cin >> b;
		cout << Evk(a, b) << endl;

	}
}

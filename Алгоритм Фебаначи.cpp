#include <iostream>
using namespace std;
 int Feb(int a)
{
	 if (a == 0)
		 return 0;
	 else
		 if (a == 1)
			 return 1;
		 else
			 return Feb(a - 1) + Feb(a - 2);
}
 int main()
 {
	 int t = 0;
	 cin >> t;
	 cout << Feb(t);
	 return 0;
 }

#include <iostream>
#include <string>
using namespace std;
void sub(char a, char b, string &val)
{
	for(int i = 0; i < val.length(); i++)
	{
		if(val[i] == a)
		{
			val[i] = b;
		}
	}
}
int main(char* argv[], int argc)
{
	string val = "hello world";
	cout << val << endl;
	sub('o', 'e', val);
	cout << val << endl;
}
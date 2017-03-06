#include <iostream>
#include <string>
using namespace std;
int main()
{
	cout << "Please enter a number: ";
	int num;
	cin >> num;
	cout << "First " + to_string(num) + " terms of fibonacci sequence:" << endl;
	auto old = 0, current = 0;
	for(auto i = 0; i < num; i++)
	{
		auto temp = old;
		old = current;
		if (current == 0)
			current++;
		else
			current += temp;
		cout << current << endl;
	}
}
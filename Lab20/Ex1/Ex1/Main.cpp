#include <iostream>
using namespace std;
void WasteFunction()
{
	// Allocates 10MB of memory.
	auto* waste = new char[10485760];
}
int main(int argc, char* argv[])
{
	for (auto i = 0; i < 10; i++)
	{
		WasteFunction();
		cout << ".";
		cin.get();
	}
	cout << "Program finishing..." << endl;
}
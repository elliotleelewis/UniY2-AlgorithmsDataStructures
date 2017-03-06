#include <iostream>
#include <string>
using namespace std;
void upperCase(char *ch)
{
	*ch = toupper(*ch);
}
int main(char* argv[], int argc)
{
	char quote[] = "Don't be too proud of this technological terror you've constructed. The ability to destroy a planet is insignificant next to the power of the Force.";
	auto i = 0;
	while(quote[i])
	{
		upperCase(&quote[i++]);
	}
	cout << quote << endl;
}
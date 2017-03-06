#include <iostream>
using namespace std;
const double DISCOUNT = 0.15;
void printPrice(double price)
{
	cout << "The price of the goods is " << price << endl;
}
void applyDiscount(double *price)
{
	*price *= (1 - DISCOUNT);
}
int main(char* argv[], int argc)
{
	const auto WIDGETPRICE = 12.0;
	double quantity = 5;
	auto orderPrice = quantity * WIDGETPRICE;
	printPrice(orderPrice);
	applyDiscount(&orderPrice);
	cout << "After discount " << endl;
	printPrice(orderPrice);
}
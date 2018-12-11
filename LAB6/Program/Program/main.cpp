#include <cmath>
#include <vector>
#include <iostream>
using namespace std;

unsigned long int factorial(size_t n)
{
	if (n == 1 || n == 0) return 1;
	return n * factorial(n - 1);
}

unsigned long int comb(size_t n, size_t k)
{
	return factorial(n) / (factorial(k) * factorial(n - k));
}

void binom()
{
	bool sign = true;
	int pow;
	char temp;

	cout << "(x ";
	cin >> temp;
	system("cls");
	cout << "(x " << temp;
	if (temp == '+')
		sign == true;
	else if (temp == '-')
		sign = false;
	else
		throw exception();
	cout << " y)^";
	cin >> pow;
	system("cls");
	cout << "(x " << temp << " y)^" << pow << " = ";

	for (size_t k = 0; k <= pow; k++)
	{
		cout << comb(pow, k) << '*';
		if (k != 0) cout << "(x^" << k << ")";
		if ((k != 0) && ((pow - k) != 0)) cout << '*';
		if ((pow - k) != 0) cout << "(y^" << pow - k << ")";
		if (k != pow) cout << (sign ? " + " : (
			(pow - k) % 2 ? " - " : " + "
			));
	}

	cout << endl;
}

int main()
{
	setlocale(LC_ALL, "Ukr");

	binom();

	system("pause");

	return 0;
}
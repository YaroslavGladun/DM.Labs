#include <iostream>
using namespace std;

void lexicoligic(size_t size)
{
	int bord = pow(size, size);

	for (size_t i = 0; i < bord; i++)
	{
		for (size_t j = 0; j < size; j++)
			cout << ((int)(i / pow(size, size - j - 1))) % size + 1;
		cout << endl;
	}
}

int main()
{
	size_t n;
	cout << "set n and press enter: ";
	cin >> n;
	lexicoligic(n);
	system("pause");
	return 0;
}
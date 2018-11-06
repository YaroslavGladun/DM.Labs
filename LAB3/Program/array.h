#include <iostream>
#include <vector>
#include <algorithm>
#include <Windows.h>

using namespace std;

class Array
{
public:
	void add_element(int el);
	void print_array();
	int get_power();
	Array section(Array array2);
	Array division(Array array2);
	Array unions(Array array2);
	int operator()(int i);


private:
	vector<int> arrayList;

	bool checkSameElement(int element);

};

void Array::add_element(int el)
{
	if (!checkSameElement(el))
	{
		arrayList.push_back(el);
		sort(arrayList.begin(), arrayList.end());
	}
}
Array Array::section(Array array2)
{
	unsigned short int i;
	Array resSel;

	for (i = 0; i < this->arrayList.size(); i++)
		if (array2.checkSameElement(this->arrayList[i])) resSel.add_element(this->arrayList[i]);

	return resSel;
}
Array Array::unions(Array array2)
{
	unsigned short int i;
	Array resUn;

	resUn = array2;

	for (i = 0; i < this->arrayList.size(); i++)
		resUn.add_element(this->arrayList[i]);

	return resUn;
}
int Array::operator()(int i)
{
	return arrayList[i];
}
Array Array::division(Array array2)
{
	unsigned short int i;
	Array resDiv;

	for (i = 0; i < this->arrayList.size(); i++)
		if (!array2.checkSameElement(this->arrayList[i])) resDiv.add_element(this->arrayList[i]);


	return resDiv;
}
void Array::print_array()
{
	int i;

	cout << "{ ";
	for (i = 0; i < arrayList.size(); i++)
	{
		cout << arrayList[i] << (i == (arrayList.size() - 1) ? " " : ", ");
	}
	cout << '}';
}

int Array::get_power()
{
	return this->arrayList.size();
}

bool Array::checkSameElement(int element)
{
	return (find(arrayList.begin(), arrayList.end(), element) != arrayList.end());
}
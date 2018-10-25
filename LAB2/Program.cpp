#include <iostream>
#include <vector>
#include <algorithm>
#include <Windows.h>

using namespace std;

namespace arrayList
{
	class Array
	{
	public:
		void AddElement(int el);
		void PrintArray();
		int GetPower();
		Array Section(arrayList::Array array2);
		Array Division(arrayList::Array array2);
		Array Union(arrayList::Array array2);


	private:
		vector<int> arrayList;

		bool checkSameElement(int element);

	};

	void Array::AddElement(int el)
	{
		if (!checkSameElement(el))
		{
			arrayList.push_back(el);
			sort(arrayList.begin(), arrayList.end());
		}
	}
	Array Array::Section(arrayList::Array array2)
	{
		unsigned short int i;
		Array resSel;

		for (i = 0; i < this->arrayList.size(); i++)
			if (array2.checkSameElement(this->arrayList[i])) resSel.AddElement(this->arrayList[i]);

		return resSel;
	}
	Array Array::Union(arrayList::Array array2)
	{
		unsigned short int i;
		Array resUn;

		resUn = array2;

		for (i = 0; i < this->arrayList.size(); i++)
			resUn.AddElement(this->arrayList[i]);

		return resUn;
	}
	Array Array::Division(arrayList::Array array2)
	{
		unsigned short int i;
		Array resDiv;

		for (i = 0; i < this->arrayList.size(); i++)
			if (!array2.checkSameElement(this->arrayList[i])) resDiv.AddElement(this->arrayList[i]);


		return resDiv;
	}
	void Array::PrintArray()
	{
		int i;

		cout << "{ ";
		for (i = 0; i < arrayList.size(); i++)
		{
			cout << arrayList[i] << (i == (arrayList.size() - 1) ? " " : ", ");
		}
		cout << '}';
	}

	int Array::GetPower()
	{
		return this->arrayList.size();
	}

	bool Array::checkSameElement(int element)
	{
		return (find(arrayList.begin(), arrayList.end(), element) != arrayList.end());
	}
}

int main()
{
	int i, val, sizeArray1, sizeArray2;
	arrayList::Array mass1, mass2, resSel, resDiv, resUn;

	setlocale(LC_ALL, "Ukrainian");

	cout << "¬ведiть розмiр множини 1: ";
	cin >> sizeArray1;
	cout << "¬ведiть розмiр множини 2: ";
	cin >> sizeArray2;


	cout << "¬ведiть через ентнер елементи множини 1:\n";
	for (i = 0; i < sizeArray1; i++)
	{
		cin >> val;
		mass1.AddElement(val);
	}
	cout << "¬ведiть через ентнер елементи множини 1:\n";
	for (i = 0; i < sizeArray2; i++)
	{
		cin >> val;
		mass2.AddElement(val);
	}

	system("cls");

	resSel = mass1.Section(mass2);
	resDiv = mass1.Division(mass2);
	resUn = mass1.Union(mass2);

	cout << "ћножина 1 (потужнiсть " << mass1.GetPower() << "): ";
	mass1.PrintArray();
	cout << "\nћножина 2 (потужнiсть " << mass2.GetPower() << "): ";;
	mass2.PrintArray();
	cout << "\nѕеретен множин (потужнiсть " << resSel.GetPower() << "): ";;
	resSel.PrintArray();
	cout << "\nќбЇднанн€ множин (потужнiсть " << resUn.GetPower() << "): ";;
	resUn.PrintArray();
	cout << "\n—иметрична рiзниц€ множин (потужнiсть " << resDiv.GetPower() << "): ";;
	resDiv.PrintArray();

	cout << endl;

	system("pause");
	return 0;
}
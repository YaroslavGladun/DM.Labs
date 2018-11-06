#include <iostream>

#include "matrix.cpp"
#include "array.h"

#define CONDITION(a, b) (a*a >= b)
#define CONDITION_STRING "a < b"

void printBinMatrix(matrix<bool> &mat, Array &arr1, Array &arr2);
void checkingTheBinaryRelation(matrix<bool> & mat);

enum matrix_type
{
	reflexive,
	antireflexive,
	symmetric,
	antisymmetric,
	transitive,
	antitransitive
};

int main()
{
	setlocale(LC_ALL, "Ukrainian");

	int sizeArray1, sizeArray2;
	Array array1, array2;
	matrix<bool> binMat;


	cout << "¬ведiть розмiр множини 1: ";
	cin >> sizeArray1;
	cout << "¬ведiть розмiр множини 2: ";
	cin >> sizeArray2;


	cout << "¬ведiть через ентнер елементи множини 1:\n";
	for (unsigned int i = 0; i < sizeArray1; i++)
	{
		int val;
		cin >> val;
		array1.add_element(val);
	}
	cout << "¬ведiть через ентнер елементи множини 1:\n";
	for (unsigned int i = 0; i < sizeArray2; i++)
	{
		int val;
		cin >> val;
		array2.add_element(val);
	}


	binMat.create(array1.get_power(), array2.get_power());
	binMat.zero();


	for (unsigned int i = 0; i < array1.get_power(); i++)
		for (unsigned int j = 0; j < array2.get_power(); j++)
			if (CONDITION(array1(i), array2(j))) binMat(i, j) = true;

	system("cls");

	cout << "ћножина 1 (потужнiсть " << array1.get_power() << "): ";
	array1.print_array();
	cout << "\nћножина 2 (потужнiсть " << array2.get_power() << "): ";
	array2.print_array();
	cout << "\n\nћатриц€ бiнарного вiдношенн€ " << CONDITION_STRING << endl;

	printBinMatrix(binMat, array1, array2);

	checkingTheBinaryRelation(binMat);

	system("pause");
	return 0;
}

void printBinMatrix(matrix<bool> &mat, Array &arr1, Array &arr2)
{
	cout << '\t' << '|';
	for (int j = 0; j < arr1.get_power(); j++)
	{
		cout << arr1(j) << "\t|";
	}
	cout << '\n';
	for (int i = 0; i < arr2.get_power(); i++)
	{
		for (int i = 0; i < arr1.get_power() + 1; i++)
		{
			cout << "________";
		}
		cout << '\n' << arr2(i) << '\t' << '|';
		for (int j = 0; j < arr1.get_power(); j++)
		{
			cout << mat(j, i) << '\t' << '|';
		}
		cout << '\n';

	}
}

void checkingTheBinaryRelation(matrix<bool>& mat)
{
	if (mat.get_size_m() != mat.get_size_n()) return;

	bool flags[6] = {};


	flags[reflexive] = true;
	for (int i = 0; i < mat.get_size_m() && flags[reflexive]; i++)
	{
		flags[reflexive] &= mat(i, i);
	}

	flags[antireflexive] = true;
	for (int i = 0; i < mat.get_size_m() && flags[antireflexive]; i++)
	{
		flags[antireflexive] &= !mat(i, i);
	}

	flags[symmetric] = true;
	for (int i = 0; i < mat.get_size_m(); i++)
	{
		for (int j = 0; j < mat.get_size_n(); j++)
		{
			if (i == j) continue;
			flags[symmetric] &= !mat(i, j) || mat(j, i);
		}
	}

	flags[antisymmetric] = true;
	for (int i = 0; i < mat.get_size_m(); i++)
	{
		for (int j = 0; j < mat.get_size_n(); j++)
		{
			if (i == j) continue;
			flags[antisymmetric] &= !mat(i, j) || !mat(j, i);
		}
	}

	flags[transitive] = true;
	for (int a = 0; a < mat.get_size_m(); a++)
	{
		for (int b = 0; b < mat.get_size_m(); b++)
		{
			for (int c = 0; c < mat.get_size_m(); c++)
			{
				flags[transitive] &= !mat(a, b) || !mat(b, c) || mat(a, c);
			}
		}
	}

	flags[antireflexive] = true;
	for (int a = 0; a < mat.get_size_m(); a++)
	{
		for (int b = 0; b < mat.get_size_m(); b++)
		{
			for (int c = 0; c < mat.get_size_m(); c++)
			{
				flags[antireflexive] &= !mat(a, b) || !mat(b, c) || !mat(a, c);
			}
		}
	}

	if (flags[reflexive]) cout << "Reflexive binary matrix\n";
	if (flags[antireflexive]) cout << "Antireflexive binary matrix\n";
	if (flags[symmetric]) cout << "Symetric binary matrix\n";
	if (flags[antisymmetric]) cout << "Antisymetric binary matrix\n";
	if (flags[transitive]) cout << "Transitive binary matrix\n";
	if (flags[antitransitive]) cout << "Antitransitive binary matrix\n";
}

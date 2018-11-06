#include <iostream>

#include "matrix.h"

template<typename T>
matrix<T>::matrix()
{
	mass = nullptr;
}

template<typename T>
matrix<T>::~matrix()
{
	if (!mass) this->clear();
}

template<typename T>
matrix<T>::matrix(int size_m, int size_n)
{
	create(size_m, size_n);
}

template<typename T>
void matrix<T>::print()
{
	for (unsigned int i = 0; i < size_m; i++)
	{
		for (unsigned int j = 0; j < size_n; j++)
		{
			cout << mass[i][j] << '\t';
		}
		cout << '\n';
	}
}

template<typename T>
void matrix<T>::create(int size_m, int size_n)
{
	unsigned int i;

	if (!mass) clear();

	mass = new T*[size_m];
	for (i = 0; i < size_m; i++)
		mass[i] = new T[size_n];

	this->size_m = size_m;
	this->size_n = size_n;
}

template<typename T>
void matrix<T>::clear()
{
	unsigned int i;

	for (i = 0; i < size_m; i++)
		delete[] mass[i];

	delete[] mass;
	mass = nullptr;
	size_m = size_n = 0;
}

template<typename T>
void matrix<T>::zero()
{
	unsigned int i, j;

	for (i = 0; i < size_m; i++)
		for (j = 0; j < size_n; j++)
			mass[i][j] = T();
}

template<typename T>
T & matrix<T>::operator()(int i, int j)
{
	if (i >= 0 && i <= size_n && j >= 0 && j <= size_m)
		return mass[i][j];
	else
		throw exception("Non - existent element");
}

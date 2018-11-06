#pragma once

using namespace std;

template <typename T>
class matrix
{
public:
	matrix();
	~matrix();
	matrix(int size_m, int size_n);
	void print();
	void create(int size_m, int size_n);
	void clear();
	void zero();
	T & operator()(int i, int j);
	int get_size_m() { return size_m; };
	int get_size_n() { return size_n; };

private:
	T **mass;
	int size_m, size_n;
};


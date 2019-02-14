#include "pch.h"
#include <iostream>
#include <sstream>
using namespace std;

int S(int f)
{
	int j = f;
	int w;
	for (int i = 1; i < f; i++)
	{
		w = f / j + j - 1;
		int s = f / i + i - 1;

		if (s < w) j = i;
		else if (s > w) break;
	}

	return j;
};

int main(int argc, char *argv[])
{
	int f = 0, b = 0, c = 0, j, y = 0, e = 0;

	stringstream s(argv[1]);
	s >> f;

	stringstream x(argv[2]);
	x >> b;
	
	cout << boolalpha;

	while (c <= f)
	{
		j = e > 0 ? 1 : S(f - c);
		c = c + j <= f ? c + j : f;
		if (y != 0 && c == y) break;
		bool d = c >= b;
		
		cout << c << "\n" << d << "\n";

		if (d)
		{
			e++;
			if (e == 2) break;
			y = c;
			c = c - j;
		}
	}

	cout << "Floor " << c;

	return 0;
}
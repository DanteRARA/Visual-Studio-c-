// test.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include<stdio.h>
#include <iostream>
using namespace std;

int test(int x) {
	if (x == 0) {
		return 0;
	}
	return x + test(x - 1);
}

int main(){
	
	
	cout << test(100) << endl;
	system("PAUSE");
    return 0;
}




// C++ PluralSight.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>
#include <string>
#include <iostream>
#include <iomanip>
#include <limits>
#include <vector>

using namespace std;

	void solve(double meal_cost, int tip_percent, int tax_percent) {

		double tip = meal_cost * tip_percent / 100;
		double tax = meal_cost * tax_percent / 100;

	 
		int totalCost = meal_cost + tip + tax;

		cout << totalCost;
	}


	int main()
	{
		/*double meal_cost;
		cin >> meal_cost;
		cin.ignore(numeric_limits<streamsize>::max(), '\n');

		int tip_percent;
		cin >> tip_percent;
		cin.ignore(numeric_limits<streamsize>::max(), '\n');

		int tax_percent;
		cin >> tax_percent;
		cin.ignore(numeric_limits<streamsize>::max(), '\n');

		solve(meal_cost, tip_percent, tax_percent);
		*/

		int sum;
		
		vector<int> vec = { -10, -20, -30, -40 };
		vector<int> list;

		for (TYPE element : COLLECTION)
		{
			
		}
		
		return 0;
	}
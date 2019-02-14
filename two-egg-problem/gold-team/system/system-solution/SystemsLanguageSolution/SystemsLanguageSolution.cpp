#include "pch.h"
#include <iostream>
#include <cstdlib>
#include <cstdio>
#include <string>
#include <cmath>

using namespace std;

void dropEgg(int &egg, int floor, int answer) {

	bool isBroken = false;

	if (floor >= answer){
		egg = floor;
		isBroken = true;
	}

	printf("%d\n%s\n", floor, isBroken ? "True" : "False");

}

int main(int argc, char **argv)
{
    
	int floors = 0, answer = 0, scale = 0, eggOne = -1, eggTwo = -1, currentFloor = 0;

	sscanf_s(argv[1], "%d", &floors);
	sscanf_s(argv[2], "%d", &answer);

	scale = round(sqrt(floors));

	if (floors < scale) {
		scale = floors;
	}

	while (eggOne == -1) {
		currentFloor += scale;
		if (currentFloor > floors) {
			scale = floors - (currentFloor - scale);
			currentFloor = floors;		
		}

		dropEgg(eggOne, currentFloor, answer);
	}

	currentFloor = currentFloor - scale + 1;

	for (currentFloor; currentFloor < eggOne && eggTwo == -1; currentFloor++) {
		dropEgg(eggTwo, currentFloor, answer);
	}

	printf("Floor %d", eggTwo == -1 ? eggOne : eggTwo);
	
	return 0;
}
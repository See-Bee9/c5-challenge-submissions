import sys
import math

def dropEgg(egg, floor, answer):
    ret = egg; 
    isBroken = False;

    if floor >= answer:
        ret = floor;
        isBroken = True;
    print(floor);
    print("True" if isBroken else "False");
    return ret;

eggOne = -1;
eggTwo = -1;
scale = 0;
floors = int(sys.argv[1]);
answer = int(sys.argv[2]);
currentFloor = 0;

scale = round(math.sqrt(floors));

if floors < scale:
    scale = floors;

while eggOne == -1:
    currentFloor += scale;
    if currentFloor > floors:
        scale = floors - (currentFloor - scale);
        currentFloor = floors;

    eggOne = dropEgg(eggOne, currentFloor, answer);

currentFloor = currentFloor - scale + 1;
for currentFloor in range(currentFloor, eggOne+1, 1):
    if eggTwo == -1:
        eggTwo = dropEgg(eggTwo, currentFloor, answer);

print("Floor", eggOne if eggTwo == -1 else eggTwo);


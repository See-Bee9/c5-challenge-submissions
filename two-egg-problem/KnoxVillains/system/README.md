This submission is a C++11 solution to the problem.

First ensure a *real* C++ compiler, like llvm, is installed.
```bash
choco install llvm
```
Second build the executable as follows
```bash
clang++ -std=c++11 EggDrop.cpp -mtune=native -march=native -O3 -Ofast -DF=false -DI=int -DT=true -DB=bool -DC=char -Dk=sprintf -Dp=printf -DU="unsigned long long" -Dg="atoll" -Dm="static_cast<unsigned long long>" -DX=for -DS=sqrt -DK=break -DO=return -DQ=if -o eggDrop.exe
```
Finally, run it:
```bash
eggDrop.exe [NumberOfFloors] [BreakFloor]
```
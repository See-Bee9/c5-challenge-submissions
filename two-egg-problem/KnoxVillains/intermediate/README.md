# The Golf Problem

## Conditions

- You are given two eggs and a building that is some number of stories tall.
- There is some floor that if an egg is dropped on or above that floor, it will break.
- If an egg is dropped below that floor it will NOT break.
- An egg can be dropped any number of times from any floor below the breaking floor.


## The Challenge

Find the lowest floor at which a dropped egg will break.


## Program format

Your program should take 2 integers as a command line arguments.

The first integer will be the number of floors of the building.

The Second integer will represents the lowest floor at which the egg will break.

Your program should then output which floor was tried to stdout.

After each floor, your program should output ‘True’ if the egg broke or ‘False’ otherwise.

Finally your program should output ‘Floor n’ where n is the lowest floor where a drop will result in the egg
breaking.



# How To Run The Solution

Requirements:

- [.NET Core](https://microsoft.com/net/core)

How to run:

`dotnet run [number of floors] [lowest floor egg breaks]`

Example

`dotnet run 20 12`

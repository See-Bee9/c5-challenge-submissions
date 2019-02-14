# Build
.NET Core 2.1

In the root directory of TwoEggs-CSharp run the following command
```
dotnet build TwoEggs-CSharp -c Release
```

# Run 
The build command will create a 'Release' folder with a TwoEggs-CSharp.dll file.

The path should be similar to "TwoEggs-CSharp\TwoEggs-CSharp\bin\Release\netcoreapp2.1"

From the directory containing the dll file run the following command with the Floors and BreakingFloor integers following to execute the program

```
dotnet TwoEggs-CSharp.dll <Floors> <BreakingFloor>
```
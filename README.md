# Integer Overflow Bug in C# Example
This repository demonstrates a common integer overflow bug in C#.  The `ExampleClass` contains a method `IncrementValue` which increments an integer field without checking for potential overflow.  This can lead to unexpected behavior and data corruption.

## Bug Description
The `IncrementValue` method in `ExampleClass.cs` does not handle integer overflow. When the `_value` field reaches its maximum value, incrementing it will cause an overflow, resulting in a negative value.

## Solution
The solution involves adding a check to prevent integer overflow before incrementing the value.  The corrected code is in `bugSolution.cs`

## How to Run
1. Clone the repository.
2. Open the solution in Visual Studio.
3. Build and run the project.

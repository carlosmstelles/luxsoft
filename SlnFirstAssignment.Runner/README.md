
# PrjFirstAssignment.Runner

This project it's a console application to solve problems part of a technical assignment of a job interview.

## Request

Create a VisualStudio solution that contains at least the following projects:
 - Executable called “Runner”. It will ask the user which of the problems below to solve.
 - A library called “SumOfMultiple” containing a solution for the following problem:
   Find the sum of all natural numbers that are a multiple of 3 or 5 below a limit provided as input.
 - A library called “SequenceAnalysis” containing a solution for the following problem: 
   Find the uppercase words in a string, provided as input, and order all characters in 
   these words alphabetically. Input: "This IS a STRING" Output: "GIINRSSTT"

## Public classes

### Limit
Class responsible to get and treat the informed limit.
```
Public Methods
 
GetLimit -  Method responsible to return a valid value bigger than 0.

```

### SumOfMultiple
Class responsible to get the sum of multiples of 3 and 5 until the informed limit

```
Public Methods
 
Resolve -  Method responsabile to sum the result of the sum of multiples of 3 and 5 until the informed limit. Since 15 it's common to both of them, was necessary to sum the 15 multiples too, and remove from the final result otherwise it would return duplicate values.

sumOfMultiples - Method responsabile to sum, the multiples of 3, 5 and 15 until the informed limit. The Math.Floor function its use to return the number of possible multiples of x, If the result it's bigger than 0 the operation x * n * (n + 1) / 2 it's executed so it can get the sum of this multiples numbers.

```
### UpperCharText
Class responsible to get and treat the informed text.

```
Public Methods
 
GetUpperCharText -  Method responsible to return a valid text without special characters.

```

### SequenceAnalysis
Class responsible to get the upper case letters of the typed text and sort alphabetically.

```
Public Methods
 
UpperString -  Method responsabile to return all the capital letters in a text,  using Linq it's check for every letter of the text, identifying which one it's uppercase and order alphabetically.

```

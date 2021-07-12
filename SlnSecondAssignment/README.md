
# PrjSecondAssignment

This project it's a console application to solve problems part of a technical assignment of a job interview.

## Request

Write a method:

public int IsXDivisibleByY(int X, int Y) { .. }

That meets the following conditions:

- Method returns 1, if X can be divided by Y without a remainder.
- Method returns 0, if X can't be divided by Y without a remainder.
- Solution MUSN'T include any conditional checks (if condition, .Equals call, the ternary and null-coalescing operators, etc...).
- Solution MUSN'T include any exception handling (try-catch-finally)
- It must be taken into account that both parameters could be given all range of the parameter type.

## Public Class

Class responsabile to receive X and Y and call the method that will do the division.

## Public Methods

### IsXDivisibleByY

 Method responsible for divide X by Y
- Using bitwise operators to determinated if it's 1 or 0.
- Was necessary to use cast on X and Y to avoid error when dividing by 0.
- First it's tested if Y it's 0, if yes return 0, 
- if not it's tested if the remainder it's 1 if yes, than invert the result (0 become 1),
- if not it's tested if the remainder it's 1 if yes, than invert the result (0 become 1). 
- Was necessary to use >>31 to roll all bits of the integer.
- I was going to use this solution: 
- Convert.ToInt32((((double)X % (double)Y) >= 0) ^ (((double)X % (double)Y) > 0) ^ (((double)X % (double)Y) < 0)) But I wasnt not sure if I could use Convert.




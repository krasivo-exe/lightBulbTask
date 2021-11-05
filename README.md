# lightBulbTask
Solution for the light bulb task
There are N bulbs, numbered from 1 to N, arranged in a row. The first bulb is plugged into the power socket and each successive bulb is connected to the previous one (the second bulb to the first, the third bulb to the second, etc.).

Initially, all the bulbs are turned off. At moment K (for K from 0 to N−1), we turn on the A[K]-th bulb. A bulb shines if it is on and all the previous bulbs are turned on too.

Write a function solution that, given an array A of N different integers from 1 to N, returns the number of moments for which every turned on bulb shines.

Examples:

1. Given A=[2, 1, 3, 5, 4], the function should return 3.
2. There are three moments (1st, 2nd and 4th) when every turned on bulb shines.

2. Given A=[2, 3, 4, 1, 5], the function should return 2 (at the 3rd and 4th moment every turned on bulb shines).

3. Given A=[1, 3, 4, 2, 5], the function should return 3 (at the 0th, 3rd and 4th moment every turned on bulb shines).

Write an efficient algorithm for the following assumptions:

N is an integer within the range [1..100,000];
the elements of A are all distinct;
each element of array A is an integer within the range [1..N].

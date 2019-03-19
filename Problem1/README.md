# Problem 1

The following problem is taken from [Project Euler](https://projecteuler.net/problem=1).

> If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
>
> Find the sum of all the multiples of 3 or 5 below 1000.

## Explanation

To get to the answer for this problem is pretty straight forward. We need to iterate from 1 to the Upper limit. (n) To help speed up the performance we can do two "for" loops. The first "for" loop will iterate from 3 to n and increment by 3 each time. The second "for" loop will iterate from 5 to n and increment by 5 each time. Since 3 and 5 can be factors for the same numbers we also need to put a check in the second "for" loop. Checking if the current number is divisible by 3. This way we are not adding the same number twice to the sum. Though this solution will still give use a runtime of O(n) we will reduce some unnecessary  processing for the computer.

## Sudo Code

``` Sudo Code
int Mult3n4 (int n) {
    int sum = 0

    For i = 3 while i < n and increment by 3 each time {
        add i to the sum
    }

    For i = 5 while i < n and increment by 5 each time {
        if i modulus 3 is not equal to 0 {
            add i to the sum
        }
    }

    return sum
}
```

## Complexity

| Language | Time Complexity | Space Complexity |
|----------|:---------------:|:----------------:|
| C#       | O(n)            | O(1)             |
| Python   | O(n)            | O(1)             |

Where n is the number provided to the function for the upper limit
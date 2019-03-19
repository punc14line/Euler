def SumSquareDiff (n):
    # The Summation Idenity for the sum of i^2 where n goes from 1 to n
    squareSum = (n * (n + 1) * (2 * n + 1)) / 6
    
    # The Summation Idenity for the sum of i where n goes from 1 to n
    sumSquare = (n * (n + 1)) / 2
    # Need to square the sum of i
    sumSquare = sumSquare * sumSquare

    return sumSquare - squareSum

print(SumSquareDiff(100))
def EvenFibonaccisSum (limit):
    nextNum = 2
    currentNum = 1
    evenSum = 0

    while (currentNum < limit):
        if (currentNum % 2 == 0):
            evenSum = evenSum + currentNum
    
        nextNum = nextNum + currentNum
        currentNum = nextNum - currentNum
    
    return evenSum

print(EvenFibonaccisSum(4000000))
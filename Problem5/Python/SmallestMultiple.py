import sys

def SmallestMultiple(lowerNum, upperNum):
    smallestNumber = -1
    if lowerNum == 1:
        lowerNum = lowerNum + 1

    for i in range(upperNum, sys.maxsize, upperNum):
        for j in range(lowerNum, upperNum + 1):
            if i % j == 0:
                smallestNumber = i
            else:
                smallestNumber = -1
                break
        
        if smallestNumber != -1:
            break
    
    return smallestNumber

print(SmallestMultiple(1, 20))


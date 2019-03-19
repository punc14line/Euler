import math

def IsPalindrome(test):
    if (test <= 0):
        return False

    numBreakdown = []

    while (int(test / 10) >= 1):
        numBreakdown.append(test % 10)
        test = int(math.floor(test / 10))

    numBreakdown.append(test)

    arraySize = int(len(numBreakdown))
    for i in range(0, int(arraySize / 2)):
        if (numBreakdown[i] != numBreakdown[arraySize - i - 1]):
            return False
    
    return True

def LargestPalindrom(numOfDigits):
    if numOfDigits < 2:
        return -1

    upperLimit = int(math.pow(10, numOfDigits))
    lowerLimit = int(math.pow(10, numOfDigits - 1))
    print ("Finding the largest Palindrom for the product of 2 \"" + str(numOfDigits) + "-digits\" numbers. Which gives a range from[" + 
            str(lowerLimit) + ", " + str(upperLimit - 1) + "]" )

    largePalindrom = -1
    product = 0

    for x1 in range(lowerLimit, upperLimit):
        for x2 in range(x1,upperLimit):
            product = x1 * x2

            if (IsPalindrome(product) and product > largePalindrom):
                largePalindrom = product

    return largePalindrom

print(LargestPalindrom(3))


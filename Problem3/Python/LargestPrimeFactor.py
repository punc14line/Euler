import math

def LargestPrimeFactor(num):
    largePrime = int(-1)

    if (num == 0 ):
        return largePrime

    # Get rid of the even numbers
    while (num % 2 == 0):
        largePrime = int(2)
        num = num / 2
    
    for i in range(int(3), int(math.sqrt(num)), int(2)):
        while ( num % i == 0):
            largePrime = i
            num = num / i
    
    return (largePrime, num)[num > 2]

print(LargestPrimeFactor(int(600851475143)))
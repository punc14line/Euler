def Sumof3n5(max):
    sum = 0
    i = 3
    
    while i < max:
        sum = sum + i
        i = i + 3
    
    i = 5
    while i < max:
        if i % 3 != 0:
            sum = sum + i
        i = i + 5
    
    return sum

print(Sumof3n5(1000))

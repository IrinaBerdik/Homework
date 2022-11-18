# Задайте натуральное число N. Напишите программу, 
# которая составит список простых множителей числа N.


num = int(input("enter number "))
i = 2
mnozh = []
while i <= num:
    if num % i == 0:
        mnozh.append(i)
        num //= i
    else:
        i += 1
print(mnozh)



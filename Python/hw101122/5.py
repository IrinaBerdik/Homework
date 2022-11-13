# Задайте число. Составьте список чисел Фибоначчи, 
# в том числе для отрицательных индексов.

b=int(input('enter number '))

if b<0: a=-b
else: a=b
fib=[0,1]
for i in range (2,a):
    num_fib=fib[i-1] + fib[i-2]
    fib.append(num_fib)
if b<0: 
    for i in range(2,a):
        fib[i]=(-1)**(i+1)*fib[i]     
print(fib)
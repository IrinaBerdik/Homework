# Напишите программу, которая будет преобразовывать десятичное число в двоичное.
# Пример:
# - 45 -> 101101
# - 3 -> 11
# - 2 -> 10
num=int(input('enter number '))
new_num=[]
while num>=2: 
    new_num.append(str(num%2))
    num//=2
if num==0: new_num.append(str(0))
if num==1: new_num.append(str(1))
print(''.join(new_num[::-1]))
 
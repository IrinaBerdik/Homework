# Задайте список из вещественных чисел. Напишите программу, 
# которая найдёт разницу между максимальным и минимальным значением дробной части элементов.
# Пример:
# - [1.1, 1.2, 3.1, 5, 10.01] => 0.19

b=[float(i) for i in input('enter numbers ').split()]

maxi=b[0] - int(b[0])
mini=b[0] - int(b[0])   
for num in b: 
    if maxi<num-int(num): maxi=num-int(num)  
    elif mini>num-int(num): mini=num-int(num)

print (maxi-mini)
 
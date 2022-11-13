# Задайте два числа. Напишите программу, которая найдет НОК 
#(наименьшее общее кратное) этих двух чисел

a=[int(i) for i in input('enter numbers ').split()]
a_1=a[0] 
a_2=a[1]

if a_1>a_2: 
    maxi=a_1
    mini=a_2
else:
    maxi=a_2
    mini=a_1  
nod=maxi   
while (True):
        if maxi%mini!=0:
         maxi+=maxi
        if maxi%mini==0: print(maxi)


     

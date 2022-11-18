# Даны два файла, в каждом из которых находится запись многочлена. 
# Задача - сформировать файл, содержащий сумму многочленов.


with open ('data1.txt', 'r') as data:
    first_mult=data.readline()
    first_mult = first_mult.split()
    print(first_mult)
    
with open ('data2.txt', 'r') as data:
    second_mult = data.readline()
    second_mult=second_mult.split() 
    print(second_mult)

if len(first_mult)>len(second_mult): 
    second=first_mult[::-1]
    first=second_mult[::-1]
else:  
    first=first_mult[::-1]
    second=second_mult[::-1]

sum=int(first[0])+int(second[0])

sum_mult=[]
for i in range (len(second)):
    if i<len(first):
        sum_mult.append(int(first[i])+int(second[i]))
    else:
        sum_mult.append(int(second[i]))

print(sum_mult)
with open ('data3.txt', 'a') as data:
    data.write(str(sum_mult))
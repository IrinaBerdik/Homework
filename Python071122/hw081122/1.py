


a = int(input("a= "))
b = int(input('b= '))
print(a+b)
print(a-b)
print(a*b)
print(a/b)
print(a**b)
print(a//b)
print(a%b)
print(a**b)



x = int(input('введите год: '))
if x % 12==0:
    print('Год обезьяны')
elif x % 12==1:
    print('Год петуха')
elif x % 12==2:
    print('Год собака')
elif x % 12==3:
    print('Год свиньи')
elif x % 12==4:
    print('Год крысы')
elif x % 12==5:
    print('Год быка')
elif x % 12==6:
    print('Год тигра')
elif x % 12==7:
    print('Год зайца')
elif x % 12==8:
    print('Год дракон')
elif x % 12==9:
    print('Год змея')
elif x % 12==10:
    print('Год лошади')
elif x % 12==11:
    print('Год овцы')


2. Для натурального n создать словарь индекс-значение, состоящий из элементов последовательности 3n + 1.
    
    *Пример:*
    
    - Для n = 6: {1: 4, 2: 7, 3: 10, 4: 13, 5: 16, 6: 19}
3. Напишите программу, в которой пользователь будет задавать две строки, а программа - определять количество вхождений одной строки в другой.
От liudmila всем 09:47 PM
number = int(input("Введите число: "))

d = {i : 3*i + 1 for i in range(1,number+1)}

print(f"Итоговая последовательность: {d}")


n=input('Введите строку n ')
m=input('Введите строку m ')

print(len([x for x in n.split(m)])-1)

def f(x):
    return x**2

g=f #переменная хранит значение функции
print(g(2))
print(f(2))
print(type(f)) #тип функции(не значения функции)

def math (op,x): #функция, принимающая на вход функцию и аргумент
    print(op(x))

math(f,10)    

def sum (x,y):
    return x+y

f=lambda x,y: x+y # то же самое    

def calc(op, a, b):
    print(op(a,b))
    return op(a,b)
calc(sum,4,5)    
calc (lambda x,y: x+y, 4, 5) #то же самое

#list comprehension:
list = []
for i in range (1,21):
    if (i%2==0):
        list.append(i)

print (list)

list = [i for i in range(1,21) if i%2==0]  #то же самое
print (list)

def func(x):
    return x**3

list = [func(i) for i in range(1,21) if i%2==0]  
print (list) # лист кубов четных чисел

list = [(i,func(i)) for i in range(1,21) if i%2==0] 
print (list) # кортеж четное число - его куб

lists=[2,8,15,22,14,3,5,7,9] 
print(lists)

new_list=[(i,func(i)) for i in lists if i%2!=0]
print(new_list) #кортеж нечентное число из списка - его куб


def select(f,col):
    return[f(x) for x in col]

def where (f,col):
    return [x for x in col if f(x)]

data = '1 2 3 4 5 6 15 23'.split()
res=select(int,data)
res=where(lambda x: not x%2, res )
print(res)
res=select(lambda x: (x,x**2),res)
print(res)

li = [x for x in range(1,20)]
li=list(map(lambda x:x+10, li))
print (li)

data1=list(map(int,input('1 2 3 45 6').split()))
print(data1)

data2 = [x for x in range(1,20)]

res2=list(filter(lambda x: not x%2 , data2))
print(res)

users =['user1', 'user2', 'user3']
ids=[4,2,5]
data3=list(zip(users,ids))
print (data3) # кортеж из элементов нескольких наборов, проходит по наименьшему набору

data4=list(enumerate(users))
print(data4)








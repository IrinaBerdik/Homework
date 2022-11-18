num=int(input())
list=[]
summa=0
for n in range (1,num+1):
    list.append((1+1/n)**n)
    summa+=((1+1/n)**n)
print(summa)


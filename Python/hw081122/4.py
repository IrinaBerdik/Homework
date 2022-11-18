num=int(input())
positions= [int(i) for i in input().split()]
num_list=[]
prod=1
for i in range(-num,num+1):
    num_list.append(i)
for num in positions:
    prod*=num_list[num]
print(prod)



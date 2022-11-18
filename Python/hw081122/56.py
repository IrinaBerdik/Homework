num=[int(x) for x in input().split()]
for i, j in enumerate (num):
    if j%2 == 0 and i>0:
        num[i], num[i-1] = num[i-1], num[i]
    elif j%2 != 0 and i<len(num)-1:
        num[i], num[i+1] = num[i+1], num[i]
print (*num,sep=' ', end='')



# last=num[0]
# for i in range(1,len(num)):
#     num[i-1]=num[i]
# num[-1]=last
# print(num)
# # print (*num,sep=' ', end='')


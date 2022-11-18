# Задайте последовательность чисел. Напишите программу, 
# которая выведет список неповторяющихся элементов исходной последовательности.

nums=[int(i) for i in input('enter numbers ').split()]

origins=[]
for i in range (len(nums)):
    target=nums[i]
    count=0
    for j in range  (len(nums)-1):
        if i==j: j+=1
        if not i==j:
            if target==nums[j]:
                count+=1
            
    if count==0: 
        origins.append(target)
print(origins)


      


# lst = list(map(int, input("Введите числа через пробел:\n").split()))
# print(f"Исходный список: {lst}")
# new_lst = []
# [new_lst.append(i) for i in lst if i not in new_lst]
# print(f"Список из неповторяющихся элементов: {new_lst}")
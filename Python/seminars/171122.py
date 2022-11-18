# 1. Напишите программу вычисления арифметического 
# выражения заданного строкой. Используйте операции
#  +,-,/,*. приоритет операций стандартный. 
    
#     *Пример:* 
    
#     2+2 => 4; 
    
#     1+2*3 => 7; 
    
#     1-2*3 => -5;


# понять какие делать операции [+(0) *(1)]
# оставшиеся цифры [1(0) 2(1) 3(2)]
# пройти по циклу операций 1 раз если есть умн дел [*]
# 
# 
# 
# str1 = '12+2*3'

# print(eval(input()))


str1 = '12+2*3'
helper = ['+', '-', '*', '/']
list_of_numbers = []
list_of_signs = []


for idx,x in enumerate(str1):

    if x in helper:
        list_of_signs.append(x)
    else:
        list_of_numbers.append(x)
        if idx != len(str1) -1 :
            if(str1[idx+1] in helper):
                list_of_numbers.append(' ')

s = ''.join(list_of_numbers)


print(list_of_numbers)
print(list_of_signs)
print(s)

new_lister = s.split(' ')

print(new_lister)

# j=0
# for idx,x in enumerate(list_of_signs):
#     if idx==0:
#         if  x=='+':
#             result = new_lister[j] + new_lister[j+1]
#         if  x=='-':
#             result = new_lister[j] - new_lister[j+1]
#         if  x=='*':
#             result = new_lister[j] * new_lister[j+1]
#         if  x=='/':
#             result = new_lister[j] / new_lister[j+1]
#     if idx>0:
#         j=2
#         if  x=='+':
#             result = result + new_lister[j+1]
#         if  x=='-':
#             result = result - new_lister[j+1]
#         if  x=='*':
#             result = result * new_lister[j+1]
#         if  x=='/':
#             result = result / new_lister[j+1]        
result=new_lister[0]+list_of_signs+list_of_numbers[1]    

print(result)        

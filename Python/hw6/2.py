# Задайте список из нескольких чисел. Напишите программу, 
# которая найдёт сумму четных значений списка.
# Пример:
# - [2, 3, 9, 4, 3] -> чётные значения 2 и 4, ответ: 6

a = list(map(int, input("Введите числа через пробел:\n").split()))
new_a=list(filter(lambda x: not x%2 , a))
print(sum(map(int, new_a)))


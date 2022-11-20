# Создайте программу для игры с конфетами человек против человека.
# Условие задачи: На столе лежит 2021 конфета. Играют два игрока 
# делая ход друг после друга. Первый ход определяется жеребьёвкой. 
# За один ход можно забрать не более чем 28 конфет. Все конфеты оппонента 
# достаются сделавшему последний ход. Сколько конфет нужно взять первому игроку, 
# чтобы забрать все конфеты у своего конкурента?
# a) Добавьте игру против бота
# b) Подумайте как наделить бота ""интеллектом""

# Суть решения: 2021 делим по остатку на 29(28 максимум может взять оппонент
# и 1 минимум можем взять мы). Остаток 20 конфет нужно взять, если ходим первыми. 
# Далее смотрим сколько взял конфет в каждом ходе второй игрок и добираем до 29.
# В итоге в последнем ходе должно остаться 29 конфет, то есть оппонент максимум возьмет
# 28 и 1 останентся нам на последний ход для выигрыша.

# два игрока
from random import randint

def input_move(name):
    x = int(input(f"{name}, введите количество конфет, которое возьмете от 1 до 28: "))
    while x < 1 or x > 28:
        x = int(input(f"{name}, введите корректное количество конфет: "))
    return x


def print_move(name, k, count, sweets):
    print(f"Ходил {name}, он взял {k}, теперь у него {count}. Осталось на столе {sweets} конфет.")

player1 = input("Введите имя первого игрока: ")
player2 = input("Введите имя второго игрока: ")
sweets = int(input("Введите количество конфет на столе: "))
flag = randint(0,2) # флаг очередности
if flag:
    print(f"Первый ходит {player1}")
else:
    print(f"Первый ходит {player2}")

count1 = 0 
count2 = 0

while sweets > 28:
    if flag:
        k = input_move(player1)
        count1 += k
        sweets -= k
        flag = False
        print_move(player1, k, count1, sweets)
    else:
        k = input_move(player2)
        count2 += k
        sweets -= k
        flag = True
        print_move(player2, k, count2, sweets)

if flag:
    print(f"Выиграл {player1}")
else:
    print(f"Выиграл {player2}")
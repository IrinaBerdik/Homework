# Напишите программу, удаляющую из текста все слова, содержащие ""абв"".


txt = input("Введите текст через пробел:\n")
print(f"Заданный текст: {txt}")
find = "абв"
new_text = [i for i in txt.split() if find not in i]
print(f'Текст без слов, содержащих абв: {" ".join(new_text)}')
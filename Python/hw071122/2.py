# Напишите программу для. проверки истинности утверждения
#  ¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z для всех значений предикат.

print ('enter x, y, z ')
x = bool(input())
y = bool(input())
z = bool(input())
a= not (x or y or z) 
b= not x and not y and not z
if a==b : print ("true")
else: print ("false")

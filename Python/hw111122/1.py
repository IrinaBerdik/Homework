# Вычислить число c заданной точностью d
# Пример:
# - при $d = 0.001, π = 3.141.$    $10^{-1} ≤ d ≤10^{-10}$

from math import pi
#  pi=22/7
d=float(input('etnter d '))
print(pi)
count=0

while d<1:
    d*=10
    count+=1
print(round(pi,count)) 









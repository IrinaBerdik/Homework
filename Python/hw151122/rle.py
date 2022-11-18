# Реализуйте RLE алгоритм: реализуйте модуль сжатия и восстановления данных.


string = list(input())
coded_string = ''
cumul=0
for i in range(len(string)):
    i+=cumul
    base=string[i]
    k=1
    while base==string[i+k]: 
        k+=1 
        if i+k>len(string):
            break
        if k>1:
            coded_string+=f'{base} {k}'
            cumul+=k-1
        



    

# модуль экспорта данных 

def read_data():
    lst_name = []
    with open('name.csv', 'r') as file:
        for line in file:
            temp = line.strip().split(';')
            lst_name.append(temp)
        print(lst_name)
    
    lst_tel = []
    
    with open('tel.csv', 'r') as file:
        for line in file:
            temp = line.strip().split(';')
            lst_tel.append(temp)
        print(lst_tel)


    lst = []
    for i in range(len(lst_name)):
        lst.append( [lst_name[i][0], lst_name[i][1], lst_name[i][2], lst_name[i][3], lst_name[i][4], \
                    lst_tel[i][0], lst_tel[i][1], lst_tel[i][2], lst_tel[i][3], lst_tel[i][4], lst_tel[i][5]]   )   
    return lst

    
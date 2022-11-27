from write_data import count_data

def input_data():
    dct = dict()
    Id = count_data("name.csv") 
    dct["id"] = Id     
    dct["surname"] = input('Введите Фамилию: ')
    dct["name"] = input('Введите Имя: ')
    dct["patronymic"] = input('Введите Отчество: ')
    dct["date_of_birth"] = input('Введите дату рождения: ')
    dct["tel_number1"] = input('Введите номер телефона1: ')
    dct["commentary1"] = input('Введите комментарий: ')
    dct["tel_number2"] = input('Введите номер телефона2: ')
    dct["commentary2"] = input('Введите комментарий: ')
    dct["tel_number3"] = input('Введите номер телефона3: ')
    dct["commentary3"] = input('Введите комментарий: ')
  
    return dct






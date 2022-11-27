from push_data import *
from read_data import *
from print_data import *
from search_data import *


def greeting():
    print("Телефонная книга")

def start():
    print("Доступные операции:\n\
    1 - получить весь список;\n\
    2 - добавить новый контакт;\n\
    3 - поиск контакта;\n\
    4 - выход.")
    ch = input("Введите цифру: ")
    while True:
        if ch == '1':
            data = read_data()
            print_data(data)
            start()
        elif ch == '2':
            push_data()
            start()
        elif ch == '3':
            info = input("Введите данные для поиска: ")
            data = read_data()
            item = search_data(info, data)
            if item != None:
                print_data(item, True)
            else:
                print("Данные не обнаружены")                
            start()
        else: 
            if not ch=='4':
                print("Введите корректную цифру!")
                start()
            
        if ch == '4':
            print("Работа с телефонной книгой завершена")
        break
        
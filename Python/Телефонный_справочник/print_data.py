def print_data(data, search = False):
    if len(data) > 0:
        print("id".center(5), "Фамилия".center(20), "Имя".center(10), "Отчество".center(12), "Дата рождения".center(10),\
                "Номер телефона1".center(16), "комментарий".center(20),\
                "Номер телефона2".center(16), "комментарий".center(20),\
                "Номер телефона3".center(16), "комментарий".center(20))
        print("-"*130)
        if not search:
            del data[0]
        for item in data:
            print(item[0].center(5), item[1].center(20), item[2].center(10), item[3].center(12), item[4].center(10),\
            item[5].center(16), item[6].center(20),\
            item[7].center(16), item[8].center(20), \
            item[9].center(16), item[10].center(20))
    else:
        print("\n")
        print("*"*120 + "\nСписок пуст!\n" + "*"*120)
        print("\n")





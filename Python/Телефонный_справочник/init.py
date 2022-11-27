from read_data import read_data

def init():
    if not (len(read_data()) > 0):
        
        with open("name.csv", 'a+') as file:
            file.write("id;surname;name;patronymic;date_of_birth\n")

        with open("tel.csv", 'a+') as file:
            file.write("id;tel_number1;commentary1;tel_number2;commentary2;tel_number3;commentary3;\n")





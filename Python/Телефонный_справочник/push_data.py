from input_data import input_data
from write_data import write_data

def push_data():
    dct = input_data()

    write_data([dct.get("id"), dct.get("surname"), dct.get("name"), dct.get("patronymic"), dct.get("date_of_birth")], "name.csv")

    write_data([dct["id"], dct["tel_number1"], dct["commentary1"], 
                           dct["tel_number2"], dct["commentary2"],
                           dct["tel_number3"], dct["commentary3"]], "tel.csv") 

    write_data([dct.get("id"), dct.get("surname"), dct.get("name"), dct.get("patronymic"), dct.get("date_of_birth")], "name.txt")

    write_data([dct["id"], dct["tel_number1"], dct["commentary1"], 
                           dct["tel_number2"], dct["commentary2"],
                           dct["tel_number3"], dct["commentary3"]], "tel.txt")


    

import pandas as pd
import pyodbc
import os

filename = 'result.csv'
filepath = os.path.dirname(os.path.dirname(os.path.abspath(__file__))) + "\\" + "CsvFiles" + "\\" + filename

data = pd.read_csv(filepath, delimiter=';')
df = pd.DataFrame(data,
                  columns=['ID', 'Балл', 'Предмет', 'Город', 'Дата_Зачисления', 'Учебное_Заведение'])
countRow = 0

conn = pyodbc.connect('Driver={ODBC Driver 17 for SQL Server};'
                      'Server=IRINAMESH;'
                      'Database=bigData2020;'
                      'Trusted_Connection=yes;')
cursor = conn.cursor()

conn.execute('CREATE TABLE Поступающие(ID int NOT NULL, Город nvarchar(60), Дата_Поступления date, Учебное_Заведение nvarchar(200))')

conn.execute('CREATE TABLE Оценки(ID int NOT NULL, Балл int, Предмет nvarchar(60))')

for row in df.itertuples():
    cursor.execute('''
                  INSERT INTO bigData2020.dbo.Поступающие (ID, Город, Дата_Поступления, Учебное_Заведение)
                 VALUES (?,?,?,?)
                   ''',
                   row.ID,
                   row.Город,
                   row.Дата_Зачисления,
                   row.Учебное_Заведение
                   )
    if not pd.isnull(row.Балл) and not type(row.Балл) == float and not row.Балл == 'н/я':
        cursor.execute('''
                       INSERT INTO bigData2020.dbo.Оценки (ID, Балл, Предмет)
                      VALUES (?,?,?)
                       ''',
                       row.ID,
                       row.Балл,
                       row.Предмет
                       )
conn.commit()

cursor.close()
conn.close()


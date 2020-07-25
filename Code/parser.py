import numpy
import win32com.client
import pandas as pd
import time
import pyodbc
import matplotlib.pyplot as plt

data = pd.read_csv(r'.\info2019.csv', delimiter=';')
df = pd.DataFrame(data,
                  columns=['ID', '№ уровня подготовки', 'Оценка2', 'Дисциплина2', 'Оценка3', 'Дисциплина3', 'Оценка4',
                           'Дисциплина4', 'Оценка5', 'Дисциплина5', 'Учебное заведение', 'Нас пункт УЗ'])

result = [['ID', 'Оценка2', 'Дисциплина2', 'Оценка3', 'Дисциплина3', 'Оценка4', 'Дисциплина4', 'Оценка5',
           'Дисциплина5', 'Учебное_заведение', 'Город']]
badData = [['ID', 'Оценка2', 'Дисциплина2', 'Оценка3', 'Дисциплина3', 'Оценка4', 'Дисциплина4', 'Оценка5',
            'Дисциплина5', 'Учебное_заведение', 'Город']]

for i, ii in enumerate(df['№ уровня подготовки']):
    if df['№ уровня подготовки'][
        i] == 1:  # not pd.isnull(df['Протокол зачисления'][i]) and df['№ уровня подготовки'][i] == 1:
        result.append([df['ID'][i], df['Оценка2'][i], df['Дисциплина2'][i], df['Оценка3'][i], df['Дисциплина3'][i],
                       df['Оценка4'][i],
                       df['Дисциплина4'][i], df['Оценка5'][i], df['Дисциплина5'][i], df['Учебное заведение'][i],
                       df['Нас пункт УЗ'][i]])

result.pop(0)
data = pd.DataFrame(result, columns=['ID', 'Оценка2', 'Дисциплина2', 'Оценка3', 'Дисциплина3', 'Оценка4', 'Дисциплина4',
                                     'Оценка5',
                                     'Дисциплина5', 'Учебное_заведение', 'Город'])

res = data.sort_index().sort_values(by=['Город', 'Учебное_заведение'])

numpy_matrix = res.values
print(numpy_matrix)

# write the array to an excel file
# excel = win32com.client.Dispatch("Excel.Application")
# excel.Visible = True
# excel.ScreenUpdating = False
# book = excel.Workbooks.Add()
# sheet = book.Worksheets(1)

# row = 0
# for line in numpy_matrix:
#     row += 1
#     sheet.Range(sheet.Cells(row, 1), sheet.Cells(row, len(line))).Value = line
#
# excel.ScreenUpdating = True
# sheet = None
# book = None
# excel.Quit()
# excel = None

# бд
conn = pyodbc.connect('Driver={ODBC Driver 17 for SQL Server};'
                      'Server=IRINAMESH;'
                      'Database=bigData2020;'
                      'Trusted_Connection=yes;')
cursor = conn.cursor()

#
conn.execute('CREATE TABLE Поступающие(ID int NOT NULL, Город nvarchar(100), Учебное_Заведение nvarchar(250))')

conn.execute('CREATE TABLE Оценки(ID int NOT NULL, Балл int, Предмет nvarchar(60))')

for row in data.itertuples():
    if not pd.isnull(row.Учебное_заведение) and not pd.isnull(row.Город):
        cursor.execute('''
                          INSERT INTO bigData2020.dbo.Поступающие (ID, Город, Учебное_Заведение)
                         VALUES (?,?,?)
                           ''',
                       row.ID,
                       row.Город,
                       row.Учебное_заведение
                       )
    if not pd.isnull(row.Оценка2) and not type(row.Оценка2) == float and not row.Оценка2 == 'н/я':
        cursor.execute('''
                       INSERT INTO bigData2020.dbo.Оценки (ID, Балл, Предмет)
                      VALUES (?,?,?)
                       ''',
                       row.ID,
                       row.Оценка2,
                       row.Дисциплина2
                       )
        if not pd.isnull(row.Оценка3) and not type(row.Оценка3) == float and not row.Оценка3 == 'н/я':
            cursor.execute('''
                               INSERT INTO bigData2020.dbo.Оценки (ID, Балл, Предмет)
                               VALUES (?,?,?)
                               ''',
                           row.ID,
                           row.Оценка3,
                           row.Дисциплина3
                           )
            if not pd.isnull(row.Оценка4) and not type(row.Оценка4) == float and not row.Оценка4 == 'н/я':
                cursor.execute('''
                                   INSERT INTO bigData2020.dbo.Оценки (ID, Балл, Предмет)
                                   VALUES (?,?,?)
                                   ''',
                               row.ID,
                               row.Оценка4,
                               row.Дисциплина4
                               )
                if not pd.isnull(row.Оценка5) and not type(row.Оценка5) == float and not row.Оценка5 == 'н/я':
                    cursor.execute('''
                                       INSERT INTO bigData2020.dbo.Оценки (ID, Балл, Предмет)
                                       VALUES (?,?,?)
                                       ''',
                                   row.ID,
                                   row.Оценка5,
                                   row.Дисциплина5
                                   )
    else:
        # if not pd.isnull(row.Учебное_заведение) and not pd.isnull(row.Город):
        badData.append([row.ID,
                        row.Оценка2,
                        row.Дисциплина2,
                        row.Оценка3,
                        row.Дисциплина3,
                        row.Оценка4,
                        row.Дисциплина4,
                        row.Оценка5,
                        row.Дисциплина5,
                        row.Учебное_заведение,
                        row.Город
                        ])

# write the array to an excel file
excel = win32com.client.Dispatch("Excel.Application")
excel.Visible = True
excel.ScreenUpdating = False
book = excel.Workbooks.Add()
sheet = book.Worksheets(1)

row = 0
for line in badData:
    row += 1
    sheet.Range(sheet.Cells(row, 1), sheet.Cells(row, len(line))).Value = line

excel.ScreenUpdating = True
sheet = None
book = None
excel.Quit()
excel = None

conn.commit()

cursor.close()
conn.close()

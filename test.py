import numpy
import pandas as pd
import pyodbc
import matplotlib.pyplot as plt

data = pd.read_csv(r'C:\Users\IrinaMesh\Desktop\test.csv', delimiter=';', encoding='utf-8')
df = pd.DataFrame(data, columns=['ID', 'Год', 'Город', 'ЕГЭ'])

print(df)

conn = pyodbc.connect('Driver={ODBC Driver 17 for SQL Server};'
                      'Server=IRINAMESH;'
                      'Database=bigData2020;'
                      'Trusted_Connection=yes;')
cursor = conn.cursor()

conn.execute('CREATE TABLE test (ID int NOT NULL, Год nvarchar(4), Город nvarchar(60), ЕГЭ nvarchar(3))')

for row in df.itertuples():
    cursor.execute('''
                INSERT INTO bigData2020.dbo.test (ID, Год, Город, ЕГЭ)
                VALUES (?,?,?,?)
                ''',
                   row.ID,
                   row.Год,
                   row.Город,
                   row.ЕГЭ
                   )
conn.commit()

cursor.close()
conn.close()

x = pd.DataFrame(data, columns=['Год'])
y = pd.DataFrame(data, columns=['ЕГЭ'])
plt.scatter(x, y)
plt.show()

import pyodbc
import win32com.client
conn = pyodbc.connect('Driver={ODBC Driver 17 for SQL Server};'
                      'Server=IRINAMESH;'
                      'Database=bigData2020;'
                      'Trusted_Connection=yes;')
cursor = conn.cursor()

sql_Query = "SELECT Города.Город, Широта, Долгота, count(Поступающие.ID) as [Число абитуриентов], avg(Оценки.Балл) as [Cредняя_оценка] " \
                   "FROM Поступающие " \
                   "INNER JOIN Города on Города.Город = Поступающие.Город " \
                   "INNER JOIN Оценки on Оценки.ID = Поступающие.ID " \
                   "WHERE Оценки.Предмет = 'Творческий конкурс'" \
                   "GROUP BY Города.Город, Широта, Долгота "

cursor.execute(sql_Query)
results = cursor.fetchall()

excel = win32com.client.Dispatch("Excel.Application")
excel.Visible = True
excel.ScreenUpdating = False
book = excel.Workbooks.Add()
sheet = book.Worksheets(1)
#
row = 0
for line in results:
    row += 1
    sheet.Range(sheet.Cells(row, 1), sheet.Cells(row, len(line))).Value = line

excel.ScreenUpdating = True
sheet = None
book = None
excel.Quit()
excel = None
import numpy as n
import matplotlib.pyplot as plt
import pandas as pd
import stats as s
import scipy.stats as ss
import plotly.express as px
from sklearn import linear_model
from sklearn.preprocessing import StandardScaler
from sklearn.metrics import r2_score

data = pd.read_csv(r'C:\Users\DNS\Desktop\TPU_Maps\new_csv\rus.csv', delimiter=';', encoding='utf-8')
df = pd.DataFrame(data, columns=['Средний_балл', 'Учебное_заведение', 'Город', 'Число_поступающих'])
# print(df)

# Mean, Median, and Mode
mean = n.mean(df['Средний_балл'])
median = n.median(df['Средний_балл'])
mode = s.mode(df['Средний_балл'])

print ("Среднее: ", mean, "\nМедиана: ", median, "\nМода: ", mode, "\n")

# Standard Deviation
std = n.std(df['Средний_балл'])
var = n.var(df['Средний_балл'])

print ("Стандартное отклонение: ", std, "\nОтклонение: ", var, "\n")

# Percentiles
per25 = n.percentile(df['Средний_балл'], 25)
per75 = n.percentile(df['Средний_балл'], 75)

print ("25-я процентиль: ", per25, "\n75-я процентиль: ", per75, "\n")

# Data Distribution
# лига рандома, которой у нас нет... но вот рандом из имеющихся данных 
dd = n.random.uniform(df['Средний_балл'])
plt.hist(dd, 100)
plt.show()

# Normal Data Distribution
# аналогично с предыдущим пунктом
ndd = n.random.normal(df['Средний_балл'])
plt.hist(ndd, 100)
plt.show()

# Scatter Plot (количество + качество)
# Linear Regression - trendline="ols"
fig = px.scatter(df, x = df['Средний_балл'], y = df['Число_поступающих'], color = df['Число_поступающих'], 
                 hover_data = ['Учебное_заведение'], trendline="ols")
fig.show()

# Полиномы (в plotly этого, кажется, нет)
# строится от -300 по У, и я не могу понять, почему. ровно как и и зачем третье число в скобках
x = df['Средний_балл']
y = df['Число_поступающих']

mymodel = n.poly1d(n.polyfit(x, y, 3))
myline = n.linspace(1, 100, 100)

plt.scatter(x, y)
plt.plot(myline, mymodel(myline))
plt.show()

# Multiple Regression
# не уверена, что она нам нужна в принципе. можем, конечно, на один график кинуть 2 регрессии, но... зачем?
# хотя там можно рассчитать предсказания. но опять же, не очень под наш кейс походит. надо подумать, короч.

# Scale 
# попробуем сравнить кол-во поступающих и средний балл. хотя это тоже не несет никакой ценности.
scale = StandardScaler()
x = df[['Средний_балл', 'Число_поступающих']]
scaledx = scale.fit_transform(x)

print ("Приведенные данные: ", scaledx, "\n")

#Train(spotting) & test
n.random.seed(2)
x = df['Средний_балл']
y = df['Число_поступающих'] / x #не понимаю, зачем мы делим на х

train_x = x[:80]
train_y = y[:80]

test_x = x[80:]
test_y = y[80:]

mymodel = n.poly1d(n.polyfit(train_x, train_y, 4))
r2 = r2_score(train_y, mymodel(train_x))

print("R2 = ", r2, "\n") #чем ближе значение к 1, тем лучше. у нас... не хорошо) 
print(mymodel(85)) #для предсказаний. тк у нас всё плохо выше, то тут всё еще хуже (могу потом объяснить, что к чему)

# Decision tree
# потрясающая штука, но нам ее совершенно некуда применить 

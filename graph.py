import pandas as pd
import matplotlib.pyplot as plt

#
from matplotlib import ticker

data = pd.read_csv(r'C:\Users\IrinaMesh\Desktop\creation.csv', delimiter=';', encoding='utf-8')
df = pd.DataFrame(data, columns=['Балл', 'Школа'])

ball = df['Балл'][1:10].values
school = df['Школа'][1:10].values
print(school)
plt.bar(school, ball)
plt.subplots_adjust(bottom=0.7)  #для подписей оптимально 0.7
plt.title("Творческий конкурс")
plt.xlabel("Школа")
plt.ylabel("Средний балл")
plt.xticks(rotation=90)
plt.ylim(50,100)

ax = plt.subplot()
ax = plt.subplot()
for item in ([ax.title, ax.xaxis.label, ax.yaxis.label] +
                ax.get_xticklabels() + ax.get_yticklabels()):
       item.set_fontsize(2)

ax.yaxis.set_major_locator(ticker.MultipleLocator(2))
ax.yaxis.set_minor_locator(ticker.MultipleLocator(1))

 # Добавляем линии основной сетки:
ax.grid(which='major',
        color = 'k',
        linewidth = 0.1)

 # Включаем видимость вспомогательных делений:
ax.minorticks_on()
 # Теперь можем отдельно задавать внешний вид
 # вспомогательной сетки:
ax.grid(which='minor',
        color = 'gray',
        linewidth = 0.1)

plt.savefig('creation.png', dpi = 1200)

plt.show()
import folium
import pandas as pd
import os
from folium.plugins import MarkerCluster

filename = 'chemistry_cities.csv'
filepath = os.path.dirname(os.path.dirname(os.path.abspath(__file__))) + "\\" + "CsvFiles" + "\\" + "disciplines" + "\\" + filename

data = pd.read_csv(filepath, delimiter=';', encoding='utf-8')
city = data['Город']
lat = data['Широта']
lon = data['Долгота']
people = data['Число_абитуриентов']
mark = data['Средний_балл']

def color_change(mark):
    if mark > 80:
        return 'green'
    elif mark > 65 & mark <= 80:
        return 'orange'
    else:
        return 'red'

def rad(people):
    if people > 500:
        return 50
    elif 300 < people <= 500:
        return 40
    elif 100 < people <= 300:
        return 30
    elif 50 < people <= 100:
        return 20
    elif 25 < people <= 50:
        return 20
    else:
        return 10

map = folium.Map(location=[56.484680, 84.948197], zoom_start=8)

marker_cluster = MarkerCluster().add_to(map)
for city, lat, lon, people, mark in zip(city, lat, lon, people, mark):
    # if color_change(mark) == 'green':
    folium.CircleMarker(location=[lat, lon], radius=rad(people),
                        popup=(city + ": " + str(people) + "  чел., ср. балл=" + str(mark)),
                        fill_color=color_change(mark), color="gray", fill_opacity=0.5).add_to(marker_cluster)

map.save("HtmlMaps\chemistry_cities.html")

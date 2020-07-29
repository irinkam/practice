import folium
import pandas as pd
import os
from folium.plugins import MarkerCluster
import matplotlib.pyplot as plt
import numpy as np

def fadeColor(c1, c2, mix=0):
    assert len(c1) == len(c2)
    assert mix >= 0 and mix <= 1, 'mix=' + str(mix)
    rgb1 = np.array([int(c1[ii:ii + 2], 16) for ii in range(1, len(c1), 2)])
    rgb2 = np.array([int(c2[ii:ii + 2], 16) for ii in range(1, len(c2), 2)])
    rgb = ((1 - mix) * rgb1 + mix * rgb2).astype(int)
    c = '#' + ('{:}' * 3).format(*[hex(a)[2:].zfill(2) for a in rgb])
    return c

c1 = '#FF0000'
c2 = '#FFFF00'

filename = ['phys_cities', 'math_cities', 'rus_cities', 'ikt_cities',
            'social_cities', 'chemistry_cities', 'geo_cities', 'creation_cities']


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


n = 100

for disc in filename:
    filepath = os.path.dirname(
        os.path.dirname(os.path.abspath(__file__))) + "\\" + "CsvFiles\\disciplines" + "\\" + disc + ".csv"

    data = pd.read_csv(filepath, delimiter=';', encoding='utf-8')
    city = data['Город']
    lat = data['Широта']
    lon = data['Долгота']
    people = data['Число_абитуриентов']
    mark = data['Средний_балл']

    map = folium.Map(location=[56.484680, 84.948197], zoom_start=8)
    marker_cluster = MarkerCluster().add_to(map)

    for city, lat, lon, people, mark in zip(city, lat, lon, people, mark):
        #if mark >= 80:
        #if 60 < mark <= 80:
        if mark <= 60:
            folium.CircleMarker(location=[lat, lon], radius=rad(people),
                                popup=(city + ": " + str(people) + "  чел., ср. балл=" + str(mark)),
                                fill_color=fadeColor(c1, c2, mark / n), color="gray", fill_opacity=0.9).add_to(marker_cluster)

    map.save("HtmlMaps\\gradient\\" + disc + "4.html")

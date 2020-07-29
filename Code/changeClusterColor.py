from bs4 import BeautifulSoup as Soup
import io
import os
import codecs

filename = 'map1.html'
filepath = os.path.dirname(os.path.dirname(os.path.abspath(__file__))) + "\\" + "HtmlMaps" + "\\" + filename

# File opening
bytes = min(32, os.path.getsize(filepath))
raw = open(filepath, 'rb').read(bytes)

# if raw.startswith(codecs.BOM_UTF8):
#     encoding = 'utf-8-sig'
# else:
#     encoding = 'utf-8'

infile = io.open(filepath, 'r', encoding='cp1251')
data = infile.read()
infile.close()
# File closed

# Html parsing
soup = Soup(data, features="html.parser")
head = soup.find('head')

# Adding style tag (hint: some magic with cluster colors happens here)
inside_color = 'rgba(119,136,153, 0.6)'
outside_color = 'rgba(192,192,192, 0.6)'
style = soup.new_tag('style')
style.append(f"""
.marker-cluster-small {{
    background-color: {outside_color};
}}
.marker-cluster-medium {{
    background-color: {outside_color};
}}
.marker-cluster-large {{
    background-color: {outside_color};
}}
.marker-cluster-small div {{
    background-color: {inside_color};
}}
.marker-cluster-medium div {{
    background-color: {inside_color};
}}
.marker-cluster-large div {{
    background-color: {inside_color};
}}
""")
head.append(style)

# print(head)

# Creation of 'generated' folder
generated_path = os.path.dirname(os.path.dirname(os.path.abspath(__file__))) + "\\" + 'HtmlMaps\generated'
print(generated_path)

if not os.path.exists(generated_path):
    try:
        os.mkdir(generated_path)
    except OSError:
        print("Creation of the directory '%s' failed" % generated_path)
    else:
        print("Successfully created the directory '%s'" % generated_path)
else:
    print("Directory '%s' already exists" % generated_path)

# Writing new file with template name "_{filename}.html" into "generated" directory
f = open(generated_path + "/" + "_" + filename, "w")
f.write(str(soup))
f.close()

# print(style)
# print(head)

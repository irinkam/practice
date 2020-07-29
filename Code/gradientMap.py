import matplotlib.pyplot as plt
import numpy as np

def fadeColor(c1,c2,mix=0): #fade (linear interpolate) from color c1 (at mix=0) to c2 (mix=1)
    assert len(c1)==len(c2)
    assert mix>=0 and mix<=1, 'mix='+str(mix)
    rgb1=np.array([int(c1[ii:ii+2],16) for ii in range(1,len(c1),2)])
    rgb2=np.array([int(c2[ii:ii+2],16) for ii in range(1,len(c2),2)])
    rgb=((1-mix)*rgb1+mix*rgb2).astype(int)
    #cOld='#'+''.join([hex(a)[2:] for a in rgb])
    #print(11,[hex(a)[2:].zfill(2) for a in rgb])
    c='#'+('{:}'*3).format(*[hex(a)[2:].zfill(2) for a in rgb])
    #print(rgb1, rgb2, rgb, cOld, c)
    return c

fig, ax = plt.subplots(figsize=(8, 5))
c1='#FFFFFF' #blue
c2='#008000' #green

# another set of colors
#c1='#ff0000' #red
#c2='#001dff' #blue

n=100
for x in range(n+1):
    ax.axvline(x, color=fadeColor(c1,c2,x/n), linewidth=4)

plt.show()
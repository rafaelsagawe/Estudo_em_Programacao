## Relógio simples 

import tkinter
from time import strftime

relogio = tkinter.Label()
relogio.pack()
relogio['font'] = 'Roboto 200 bold'
relogio['font'] = strftime('%H:%M:%S')

def get_current_time():
    now = strftime('%H:%M:%S')
    if now != relogio['text']:
        relogio['text'] = now
    relogio.after(100, get_current_time)

get_current_time()
relogio.mainloop()


#https://erlonbcc.wordpress.com/2020/03/29/python-tkinter-criando-relogio/
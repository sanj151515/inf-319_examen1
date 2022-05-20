# -*- coding: utf-8 -*-
"""
Created on Tue May 17 16:05:54 2022

@author: ALVARO PC
"""


from pyswip import Prolog
prolog = Prolog()
prolog.consult("data3.pl")

print("abuelos")
for elemento in prolog.query("abuelo(X,Y)"):
    print(elemento["X"], "es el abuelo de ",elemento["Y"])    
for elemento in prolog.query("abuela(X,Y)"):
    print(elemento["X"], "es la abuela de ",elemento["Y"])   

print("")
print("niet@s")
for elemento in prolog.query("nieto(X,Y)"):
    print(elemento["X"], "es el niet@ de ",elemento["Y"])  

print("")
print("prim@s")
for elemento in prolog.query("primo(X,Y)"):
    print(elemento["X"], "es el prim@ de ",elemento["Y"])      
    
padre(juan1,maria2).
padre(juan1,julio2).
madre(juana1,maria2).
madre(juana1,julio2).

padre(julio2,ana3).
padre(julio2,diego3).
madre(maria2,luz3).
madre(maria2,leo3).

abuelo(X,Z) :- padre(X,Y), padre(Y,Z).
abuelo(X,Z) :- padre(X,Y), madre(Y,Z).
abuela(X,Z) :- madre(X,Y), padre(Y,Z).
abuela(X,Z) :- madre(X,Y), madre(Y,Z).

nieto(X,Z) :- abuelo(Z,X).
nieto(X,Z) :- abuela(Z,X).

primo(X,Z) :- ((abuelo(Y,X), abuelo(Y,Z));(abuela(W,X), abuela(W,Z)),not(primo(X,Z)==primo(X,Z))),not(X==Z).
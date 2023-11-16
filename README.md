# Application Suites Numériques

**Résumé** : Cette application a pour but de s'entrainer aux différents calculs concernant les suites numériques.

## Théorie des suites :

### Généralités :

**Définition** : Une suite numérique associe à tout entier naturel $n$ un nombre réél. Le nombre associé est noté $Un$. La suite est notée $(Un)$ et $Un$ est le *terme général* de la suite.

​    <u>*Exemple*</u>:

​    La suite $(Un)$ de terme général $Un = 2n$ est telle que :

​                $\ce{U0} = 0 ; \ce{U1} = 2 ; \ce{U2} = 4 ; \ce{U3} = 6 ; ... ; \ce{U50} = 100$

​    *<u>Remarque</u>* :

​    Certaines suites ne sont définies que pour $n \ge 1$ ; par exemple, la suite de terme général $U_{n} = \frac {1} {n}$.

​    Pour cette suite : $U_{1} =  1; U_{2} = \frac {1} {2} ; ... ; U_{50} = \frac {1} {50}$

### Suite arithmétique

**1) Définition** : Une suite $(U_{n})$ est une suite arithmétique si et seulement s'il existe un nombre réel $r$, tel que :

$\forall n \in N,    U_{n\tiny{+}1} = U_{n} + r$

Le nombre $r$ est appelé <u>raison</u> de la suite arithmétique.

**2) Terme général d'une suite arithmétique** :

Si la suite $U_{n}$ est une suite arithmétique de premier terme $U_{0}$ et de raison $r$, alors : 
        $\forall n \in \mathbb{R}, U_{n+1} = U_{0} + nr$

Pour tout entier naturel $n$, nous avons $U_{n} = U_{0} + nr$ donc le point de coordonnées $(n, U_{n})$ appartient à la droite D d'équation $y = U_{0} + rx$

**3)  Expression de la somme des $(n+1)$ premiers termes**
La somme des $(n+1)$ premiers termes d'une suite arithmétique de premier terme $U_{0}$ est :
$S_{n}=U_{0} +U_{1} + ... + U_{n-1} + U_{n} = (n+1) * \frac{(U_{0} + U_{n})}{2}$
On peut retenir le schéma :
$S_{n} = (nombre\;de\;termes) *\frac  {(premier\;terme+dernier\;terme)}{2}$

<u>Cas particulier</u> :
Somme des $n$ premiers entiers naturels non nuls :
$S_{n} = 1 + 2 + 3 + ... + n = \frac{n(n+1)}{2}$

## Suite Géométrique

### 1) Définition :

Une suite $(U_{n})$ est une suite géométrique si et seulement s'il existe un nombre réel $r$, tel que :
$\forall n \in \mathbb{N}, U_{n+1} = U_{n} * r$
Le nombre $r$ est appelé raison de la suite géométrique.

### 2) Terme général d'une suite géométrique

Si la suite $(U_{n})$ est une suite géométrique de premier terme $U_{0}$ et de raison $r$, alors :

$\forall\; n \in \mathbb{N}, \:\:\:\:U_{n} = U_{0} * r^n$

Pour tout entier naturel $n : U_{n} = U_{0} * r^n$**, donc si $r$ est strictement positif, le point $M(n;U_{n})$ appartient à la courbe d'équation $y = U_{0} * r^x$. Cette courbe est la courbe représentative de la fonction exponentielle : $x -> U_{0} * r^x$

### 3) Expression de la somme $(n+1)$ premiers termes

Si $r\ne1$ *alors* $1+r+r^2+...+r^n = \frac{1-r^{n+1}}{1-r}$
Si $r = 1$ *alors* $1+r+r^2+...+r^n = n+1$

Conséquence : 
Pour une suite géométrique de premier terme $U_{0}$ et de raison $r$,

$S_{n} = U_{0} + U_{1} + U_{2} + U_{n-1} + U_{n} = U_{0} (1+ r + r^2 +...+ r^n)$

D'où le résultat suivant :
$S_{n} = U_{0} + U_{1} + U_{2} + U_{n-1} + U_{n} = U_{0} (\frac{1-r^{n+1}}{1-r})$

On peut retenir la formule générale:
    $S_{n} = (premier\;terme)(\frac{1-(raison)^{nombre\;de\;termes}}{1-raison})$

## L'application :

### Objectifs :

- Pouvoir **consulter** une leçon sur les suites numériques.
- Proposer à un joueur unique un **entrainement** aux différents exercices proposés par l'application.
- Proposer à deux joueurs un **match** portant sur les même exercices, ce match peut être :
  - Avec contrainte de temps
  - Sans contrainte de temps
    - Pouvoir écrire/lire les **meilleurs scores** (JSON?)
    - ***Bonus**: Entrainement sur les suites quelconques*

### Implémentations nécessaires :

- La recherche d'un terme d'une suite :
  
  - *Arithmétique* : Pour une raison *r* et tout entier naturel *n* et *p* tels que $n \le p$ on a 
    
    - $Un = Up + (n - p) r$  
    - Si on a $U_{0}$ alors $U_{n} =U_{0} + nr$
  
  - *Géométrique* : Pour une raison *r* et tout entier naturel *n* et *p*, on a   $Un = Up * r^{n-p}$

- La recherche du premier terme :
  
  - *Arithmétique* : $U_{0} = U_{n} - nr$
  - *Géométrique* : 

- La recherche du rang d'un terme :

- La recherche de la raison et du premier terme :
  
  - *Arithmétique* : 1 + 2 + 3 + ... + n = n(n+1)/2
  - *Géométrique* : 1 + q + q^2 + q^3 + ... + q^n = 1-q^(n+1)/1-q

- La recherche de la somme des premiers n termes :

- La recherche de la monotonie : Pour une géométrique, si la U0 est positif et que la raison est superieure à 0, la suite est croissante, si la raison est comprise entre 0 et 1, elle est décroissante. Si U0 est negatif, on inverse. Si la raison est négative, la suite est non monotone. 

> **Idées à la volée** : 
> 
> - Serait il pertinent qu'un Match soit une classe enfant d'un Entrainement ?
> - Attention aux valeurs aléatoires sur l'indice demandé, vérifier que le calcul ne génère pas de dépassement de capacité.



**Gestion du score**
Exos réussis * 150 - resets * 50 + temps * 5


------------------
**Bugs connus**
- Si je ferme le jeu avec contrainte, l'evenement du timer continue et il ne trouve pas la cible (le formulaire) -> Pas sûr en fait, certainement déjà réglé 
- 

-----------------
**À implémenter**
- Fin d'un tour si le timer passe à 0 ?

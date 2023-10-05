# Application Suites Numériques

**Résumé** : Cette application a pour but de s'entrainer aux différents calculs concernant les suites numériques.

## Théorie des suites :

### Généralités :

**Définition** : Une suite numérique associe à tout entier naturel $n$ un nombre réél. Le nombre associé est noté $Un$. La suite est notée $(Un)$ et $Un$ est le *terme général* de la suite.

​    <u>*Exemple*</u>:

​    La suite $(Un)$ de terme général $Un = 2n$ est telle que :

​                $\ce{U0} = 0 ; \ce{U1} = 2 ; \ce{U2} = 4 ; \ce{U3} = 6 ; ... ; \ce{U50} = 100$

​    *<u>Remarque</u>* :

​    Certaines suites ne sont définies que pour $n \ge 1$ ; par exemple, la suite de terme général $\ce{Un} = \frac {1} {n} $.

​    Pour cette suite : $\ce{U1} =  1; \ce{U2} = \frac {1} {2} ; ... ; \ce{U50} = \frac {1} {50}$

### Suite arithmétique

**1) Définition** : Une suite $(\ce{Un})$ est une suite arithmétique si et seulement s'il existe un nombre réel $r$, tel que :

​        $\forall n \in N,    \ce {Un\tiny{+}1} = \ce{Un} + r$

Le nombre $r$ est appelé <u>raison</u> de la suite arithmétique.

**2) Terme général d'une suite arithmétique** :

Si la suite $\ce{Un}$ est une suite arithmétique de premier terme $\ce{U0}$ et de raison $r$, alors : 

            $\forall n \in \mathbb{R}, U_{n+1} = U_{0} + nr$

Pour tout entier naturel $n$, nous avons $U_{n} = U_{0} + nr$ donc le point de coordonnées $(n, U_{n})$ appartient à la droite D d'équation $y = U_{0} + rx$



**3)  Expression de la somme des $(n+1)$ premiers termes**

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
    - Si on a $\ce{U0}$ alors $\ce{Un =U0 + nr}$
  
  - *Géométrique* : Pour une raison *r* et tout entier naturel *n* et *p*, on a   $Un = Up * r^{n-p}$

- La recherche du premier terme :
  
  - *Arithmétique* : $U0 = Un - nr$
  - *Géométrique* : 

- La recherche du rang d'un terme :

- La recherche de la raison et du premier terme :

- La recherche de la somme des premiers n termes :

- La recherche de la monotonie :

> **Idées à la volée** : 
> 
> - Serait il pertinent qu'un Match soit une classe enfant d'un Entrainement ?
> - Attention aux valeurs aléatoires sur l'indice demandé, vérifier que le calcul ne génère pas de dépassement de capacité.

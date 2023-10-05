# Application Suites Numériques

**Résumé** : Cette application a pour but de s'entrainer aux diffיrents calculs concernant les suites numériques.



**Définitions** : Une suite numérique associe à tout entier naturel *n* un nombre réél

## Objectifs :

- Pouvoir **consulter** une leçon sur les suites numériques.
- Proposer à un joueur unique un **entrainement** aux différents exercices proposés par l'application.
- Proposer à deux joueurs un **match** portant sur les même exercices, ce match peut être :
  - Avec contrainte de temps
  - Sans contrainte de temps
    - Pouvoir écrire/lire les **meilleurs scores** (JSON?)
    - ***Bonus**: Entrainement sur les suites quelconques*

### Implémentations nécessaires :
- La recherche d'un terme d'une suite :
	- *Arithmétique* : Pour une raison *r* et tout entier naturel *n* et *p* tels que *n >= p* on a 
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


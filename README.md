# cartotree
Dépôt Cartotree.

## Notes préliminaires
Il est à noter que sur Visual Studio, la manière d'architecturer une solution informatique n'est pas pareil chez les autres IDE. Une solution (donc le produit qui permet de résoudre une problèmatique) est divisée en plusieurs projets, considérés comme des modules autonomes pouvant s'exécuter sans nécessairement lancer les autres projets au préalable. 

Par exemple, une solution "ICC" avec deux projets, "PlateformeWebEtudiants" et "PlateformeWebAdministration". Ils peuvent partager des choses en commun comme une DB. Personnellement, j'ai architecturé la solution "cartotree" comme décrit plus bas.

## Architecture
Il s'agit d'une solution Visual Studio, la solution se décompose comme suit : 

### Business & Business.Tests
- Le projet Business contiendra l'ensemble des routines, workers, services background qui tourneront pour mettre à jour les données, faire des matchs entre les RSAT des sponsors et ceux des promoters. 

- Le projet Business.Tests contient un ensemble de test unitaires permettant de vérifier la validité du projet Business.


### Services & Services.Tests
- Comme son nom l'indique, le projet Services contiendra tous les services web relatifs à cartotree (ça peut aller du REST au SOAP en passant par tout et n'importe quoi), etc.

- Services.Tests ontient un ensemble de test unitaires permettant de vérifier la validité du projet Services.

### AppWeb & AppWeb.Tests
- Le projet AppWeb contient l'application web cartotree, il s'agit d'un projet ASP .NET C# avec une architecture MVC. Il servira essentiellement à afficher le panneau d'administration des utilisateurs de cartotree (dashboard). 

- Le projet AppWeb.Tests contient un ensemble de test unitaires permettant de vérifier la validité du projet AppWeb.

### Ce n'est pas fini, il se peut que j'ajoute encore un projet, pour par exemple, une API relative à la DB permettant ainsi de créer une couche d'abstraction, appelés par exemple "Data" et "Data.Tests".
Les autres projets utiliseront celui-ci intensivement, autant dire qu'il s'agira d'une des bases de la solution cartotree.

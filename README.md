# C# ENTITY FRAMEWORK CORE code first – API MVC 

**Petit tuto de démarrage à l'utilisation d'Entity Framework en code first avec C#, avec Visual Studio 2022.**

Le code first permet l'utilisation des migrations pour gérer les objets de la base de données automatiquement à partir des classes du modèle.

Pour expérimenter ces concepts fondamentaux, nous utiliserons un modèle de données, petit mais suffisant, comportant :
- une relation simple 1 n
- une relation multiple * *
- un héritage.

C'est la classe DbContext qui est responsable de la liaison entre les entités et la base de données.
Une chaine de connexion est donnée au DbContext pour réaliser la connexion physique.

Enfin, pour vérifier notre implémentation, nous allons utiliser une Api MVC avec génération automatique des contrôleurs.
Et utiliser Swagger pour manipuler l'Api ...

Enjoy 😉

Le tuto : <a href="https://github.com/nclavere/TutoEFcodefirstApiMVCcore/CoursEFcoreCodeFirst_ApiMVC.pdf" target="_blank">CoursEFcoreCodeFirst_ApiMVC.pdf</a>

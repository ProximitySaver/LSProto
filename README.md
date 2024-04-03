# VUE D'ENSEMBLE

Ce projet est conçu pour le stage avec l'objectif de servir comme un prototype sur l'affichage d'une liste de cours fictifs avec le choix de sélectionner un cours pour voir plus de détails.

# TECHNOLOGIE UTILISÉ
<ol>
  <li>ASP.NET Core est un framework utilisé par des millions de développeurs pour créer des applications et des services web </li>
  <li>ASP.NET Core MVC est une manière de concevoir des sites webs plus complexes en utilisant le modèle Model-View-Controller(MVC)</li>
  <li>Blazor Server pour exécuter le code C# de l'application tout en maintenant une connexion HTTP au serveur ASP.NET Core</li>
  <li>EF Core (Entity Framework Core) pour servir de base de données afin d'accéder facilement aux données nécessaires aux classes réalisées dans le projet. EF Core facilite la création de classes de base de données et les requêtes SQL.</li>
</ol>

# INSTRUCTIONS

## CONFIGURATION

Pour démarrer cette application , on doit installer Visual Studio avant.

On doit aller dans ce lien : https://visualstudio.microsoft.com . Puis, on fait défiler vers le bas et cliquer "Download Visual Studio" et cliquer "Community 2022". Après , lorsque les options d'installation s'affichent, on clique les options de "Développement Web et ASP.NET" et "Développement Azur". Sélectionnez la section "Composant individuel" et assurez-vous que l'option SQL Server Express 2019 LocalDB est cochée. Pour utiliser Visual Studio , on doit installera le SDK 8 avec ce lien : https://dotnet.microsoft.com/en-us/download/dotnet/8.0 et après installation lancez Git Bash ou PowerShell et écrivez cette commande "dotnet --version" et cela doit afficher 8.0.

## EXÉCUTION

On doit cloner le projet en cliquant le <>Code bouton vert et copier le lien dans HTTPS https://github.com/ProximitySaver/LSProto.git dans votre console gitbash dans un dossier vide. 

Puis, on ouvre Visual Studio et clique "Open a project or solution" et aller dans ce chemin "\LSProto\LinguoSphèreProt" et clique "LinguoSphèreProt.sln". Après , on clique à droit "LinguoSphèreProt" et cliquer "Manage NuGet Packages" et installer "Microsoft.EntityFrameworkCore" , "Microsoft.EntityFrameworkCore.Design" , "Microsoft.EntityFrameworkCore.Relational" , "Microsoft.EntityFrameworkCore.SqlServer" , "Microsoft.EntityFrameworkCore.Tools" , "Microsoft.VisualStudio.Web.CodeGeneration.Design" , "Microsoft.AspNetCore.Components.QuickGrid.EntityFrameworkAdapter". 

Puis, ouvrir le dossier Migrations et supprimer les deux fichiers dans le dossier. S'il n'y a pas, c'est bon aussi et dans le chemin dans GitBash"NomDeDossier\LSProto\LinguoSphèreProt" et écrire "dotnet ef migrations add InitialCreate". Arrêtez Visual Studio et puis relancer l’a nouveau. Puis , écrire dans GitBash "dotnet ef database update". 

Maintenant , vous devez démarrer deux fois le projet en cliquant le bouton de jouer vers le haut de vert de "https" à "IISS Express". N'oubliez pas de démarrer le projet deux pour que les données soient toutes ajoutées. Si toutes les étapes étaient suivies proprement on doit voir les courses disponibles quand on clique l'onglet "Courses" et les détails d'une course quand on clique sur un.

# CONCEPTION
Pour la conception, je me suis davantage concentré sur l'aspect fonctionnel que sur l'aspect esthétique qui, je le sais, affecte avant tout l'utilisateur lorsqu'il visite le site. Cela ne veut pas dire que je n'avais pas d'idées esthétiques pour le site. Je n'ai pas eu le temps de changer la façon dont le site était construit pour que l'aspect visuel soit correctement ajouté au site.

# POSSIBILITÉ D'IMPLEMENTER FONCTIONNALITÉS XR
D'après mes recherches, XR est une nouvelle frontière pour les concepteurs visuels, qui peuvent ainsi créer des objets immersifs et intuitifs pour les utilisateurs. En cherchant, j'ai vu Google faire des expériences avec XR en utilisant des téléphones Android pour mesurer des choses. L'appareil doit être capable d'avoir les fonctions de réalité augmentée, sinon il ne fonctionnera pas du tout. Cela signifie que les ordinateurs de bureau ou portables ne pourront pas utiliser la fonctionnalité XR pour LinguoSphère, mais que la version mobile du site web peut fonctionner pour les téléphones Android et Apple, car les plus récents en sont équipés.

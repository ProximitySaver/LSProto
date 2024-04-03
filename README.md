# VUE D'ENSEMBLE

Ce projet est concu pour le stage avec l'objectif de servir comme un prototype sur l'affichage d'une liste de cours fictifs avec la choix de sélectionner un cours pour voir plus de détails.

# TECHNOLOGIE UTILISÉ
<ol>
  <li>ASP.NET Core is a framework that is being used by millions of developers to build web apps and services. </li>
  <li>ASP.NET Core MVC est une manière de concevoir des sites webs plus complexes en utilisant le modèle Model-View-Controller(MVC)</li>
  <li>Blazor Server to execute C# code of the application while maintaining an HTTP connection to the server ASP.NET Core</li>
  <li>EF Core (Entity Framework Core) to serve as a database to easily access data needed for the classes made in the project. EF Core makes it easier to make database classes and make SQL requests.</li>
</ol>

# INSTRUCTIONS

## CONFIGURATION

 Pour démarrer cette application , on doit installer Visual Studio avant.

 On doit aller dans cette lien : https://visualstudio.microsoft.com . Puis, on fait défiler vers le bas et cliquer "Download Visual Studio" et cliquer "Community 2022". Après , lorsque les options d'installation s'affichent, on clique les options de "Développement Web et ASP.NET" et "Développement Azur". Sélectionnez la section "Composant individuels" et assurez-vous que l'option SQL Server Express 2019 LocalDB est cochée. Pour utiliser Visual Studio , on doit installera le sdk 8 avec ce lien : https://dotnet.microsoft.com/en-us/download/dotnet/8.0 et après installation lancez Git Bash ou PowerShell et écrivez cette commande "dotnet --version" et cela doit afficher 8.0.

## EXÉCUTION

On doit cloner le projet en cliquant le <>Code bouton vert et copier le lien dans HTTPS https://github.com/ProximitySaver/LSProto.git dans votre console gitbash dans un dossier vide. Puis, on ouvre Visual Studio et clique "Open a project or solution" et aller dans ce chemin "\LSProto\LinguoSphèreProt" et clique "LinguoSphèreProt.sln". Après , on clique à droit "LinguoSphèreProt" et cliquer "Manage NuGet Packages" et installer "Microsoft.EntityFrameworkCore" , "Microsoft.EntityFrameworkCore.Design" , "Microsoft.EntityFrameworkCore.Relational" , "Microsoft.EntityFrameworkCore.SqlServer" , "Microsoft.EntityFrameworkCore.Tools" , "Microsoft.VisualStudio.Web.CodeGeneration.Design" , "Microsoft.AspNetCore.Components.QuickGrid.EntityFrameworkAdapter". Puis, ouvrir le dossier Migrations et supprimmer les deux fichiers dans le dossier. S'il n'y a pas, c'est bon aussi et dans le chemin dans GitBash"NomDeDossier\LSProto\LinguoSphèreProt" et écrire "dotnet ef migrations add InitialCreate". Arrêtez Visual Studio et puis relancer le à nouveau. Puis , écrire dans GitBash "dotnet ef database update". Maintenant , vous devez démarrer deux fois le projet en cliquant le bouton de jouer vers le haut de vert de "https" à "IISS Express". N'oubliez pas de démarrer le projet deux pour que les données sont tous ajoutés. Si tous les étapes étaient suivis proprement on doit voir les courses disponibles quand on clique l'onglet "Courses" et les détails d'un course quand on clique sur un.

# CONCEPTION
 Pour la conception ,je me suis davantage concentré sur l'aspect fonctionnel que sur l'aspect esthétique qui, je le sais, affecte avant tout l'utilisateur lorsqu'il visite le site. Cela ne veut pas dire que je n'avais pas d'idées esthétiques pour le site. Je n'ai pas eu le temps de changer la façon dont le site était construit pour que l'aspect visuel soit correctement ajouté au site.

# POSSIBILITÉ D'IMPLEMENTER FONCTIONNALITÉS XR

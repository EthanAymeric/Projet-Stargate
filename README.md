# SAE24

Le projet fonctionnel est dans le ``main``

Il faudrait créer des branches pour chaque ``form`` ou ``user-control`` et les merge au main lorsque ceux-ci sont implémentés et fonctionnels. (Merge Request de préférence pour vérifier que tout va bien)

Pour cloner :
- Aller dans Visual Studio, Git -> Cloner le dépot -> Mettre l'URL et le dossier dans lequel on veut cloner le dépot.

Pour commit :
- Git -> Commit ou Stash -> Entrer un message -> Valider tout

Pour push :
- Git -> Envoyer

Chef de Projet : [Guillaume Niederlaender](https://git.unistra.fr/gniederlaender)

## TO-DO list 

- [ ] Vérifier que chacun peut ouvrir le projet DOTNET 
- [ ] Ajouter base de données 
- [ ] Ajouter toutes les extensions (packages NUGGET)
- [x] Organiser le dépôt git (workflow)
- [ ] Se mettre d'accord sur les éléments à afficher pour chaque menu 
- [ ] Choisir comment séparer les menus / morceaux de code 
- [ ] Se répartir les tâches
- [ ] Choisir un thème global et l'appliquer 

## Organisation du dépôt 

La branche `main` est la branche "stable": elle contient toutes les features fonctionnelles. Pour chaque feature, une branche `feature-NOM_DE_FEATURE` est créée, avec dans celle-ci un fichier `README.md` contenant le **responsable de la feature** (assigné après discussion) et une TO-DO list des éléments à ajouter à cette feature et ceux qui l'ont déjà été. 

Une fois la feature terminée, cette branche sera `merge` directement sur la branche `main` par le **responsable de la feature** après avoir vérifié que celle-ci s'intègre correctement au reste (tous les conflits ayant été résolus). 

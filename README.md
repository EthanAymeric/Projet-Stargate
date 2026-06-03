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

- [x] Faire formulaire de login 
- [x] Ajouter Admin à la bdd pour vérifier le login 
- [x] Ajouter les éléments formulaire création 
- [x] Générer un nom de mission 
- [x] Blinder les saisies 
- [x] Ne proposer que des chefs disponibles pendant la durée de la mission 
- [x] changer nombre de membres requis pour le nombre de membres disponibles (max du slider)
- [x] Ajouter les membres de mission 
- [x] Protéger les TextBox des injections SQL (String.Replace("'", "''");) et autres
- [x] Faire l'ajout de captures par transaction
- [ ] Ajouter des missions 
- [ ] Ne pas fermer la fenêtre lorsque la mission est créée mais reset la fenêtre pour pouvoir ajouter une nouvelle mission directement

## Organisation du dépôt 

La branche `main` est la branche "stable": elle contient toutes les features fonctionnelles. Pour chaque feature, une branche `feature-NOM_DE_FEATURE` est créée, avec dans celle-ci un fichier `README.md` contenant le **responsable de la feature** (assigné après discussion) et une TO-DO list des éléments à ajouter à cette feature et ceux qui l'ont déjà été. 

Une fois la feature terminée, cette branche sera `merge` directement sur la branche `main` par le **responsable de la feature** après avoir vérifié que celle-ci s'intègre correctement au reste (tous les conflits ayant été résolus). 

## Organisation des menus / volets 

### Création d'une mission 

- Faire un champ login
- Faire un champ mot de passe (caché) avec un bouton pour afficher le mot de passe en clair 
- Faire un bouton se connecter / valider 

> Mode connecté

- Champ nom de planète 
- Générer un nom de mission par rapport aux nombre de missions faites sur cette planète 
- Combobox pour le chef de mission 
- Choisir une date de départ et d'arrivée (label durée)
- Grosse TextBox permettant de saisir la feuille de route 
- Champ nombre de membres 
- Champ objectif databaz 
- Champ budget
- Sélectionner les membres 
- Sélectionner objectifs de capture 
- Bouton valider 

> Mode connecté 

## Listes de questions 

- [x] Est-ce que la totalité des membres sont soit civils soit militaires ? Est-ce que la totalité des espèces sont soit alliées soit ennemies ? 

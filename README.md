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

- [x] Vérifier que chacun peut ouvrir le projet DOTNET 
- [x] Ajouter base de données 
- [x] Ajouter toutes les extensions (packages NUGGET)
- [x] Organiser le dépôt git (workflow)
- [ ] Se mettre d'accord sur les éléments à afficher pour chaque menu 
- [ ] Choisir comment séparer les menus / morceaux de code 
- [ ] Se répartir les tâches
- [ ] Choisir un thème global et l'appliquer 

## Organisation du dépôt 

La branche `main` est la branche "stable": elle contient toutes les features fonctionnelles. Pour chaque feature, une branche `feature-NOM_DE_FEATURE` est créée, avec dans celle-ci un fichier `README.md` contenant le **responsable de la feature** (assigné après discussion) et une TO-DO list des éléments à ajouter à cette feature et ceux qui l'ont déjà été. 

Une fois la feature terminée, cette branche sera `merge` directement sur la branche `main` par le **responsable de la feature** après avoir vérifié que celle-ci s'intègre correctement au reste (tous les conflits ayant été résolus). 

## Organisation des menus / volets 

### Tableau de bord des missions 

Guillaume

Afficher les informations suivantes sur toutes les missions: 
- De nom de la mission 
- Date de départ 
- Durée
- Identité du chef (nom + prénom + grade ?)

> Affichage en Mode déconnecté et actualisation de l'affichage après création d'une mission 

### Création d'une mission

Eliott

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

> Mode connecté avec transaction

### Récapitulatif complet des informations sur une mission

Guillaume

> Faire un formulaire avec des onglets 

- Afficher toutes les informations concernant la mission sélectionnée (voir [Création d'une mission](#Création-d'une-mission))
- Bouton générer pdf 

> Mode déconnecté 

- Evénements du journal de bord (moyen de naviguer dedans)
- Récapitulatif des dépenses (et sommes versées)
- Récapitulatif des captures 
- Récapitulatif des contacts (informateurs)
- Bouton générer pdf 

> Mode liaison de données

- Bouton/Volet modifier les informations/ajouter des événements

> Mode connecté puis déconnecté

### Affichage des races répertoriées 

Ethan

> Faire un formulaire avec des onglets 

- Afficher nom, couleur
- Afficher type arme, degré d'agressivité (pour ennemi)
- Afficher date de premier contact, degré de bienveillance et instrument favori (pour allié)
- Faire des filtres 

> Mode déconnecté 

### Affichage des informations sur les planètes 

Ethan

- Afficher nom, température moyenne (avec un petit logo), gravité, présence de databaz
- Popup (formulaire supplémentaire) avec: espèces, missions, civils, etc...
- Faire des filtres 

#### Note d'Ethan
- L'affichage des espèces et de leur pourcentage respectif fonctionne, sans distinguer visuellement les espèces alliés des ennemis (par manque de solution pour y parvenir) ; ce n'est pas directement demandé dans le sujet, mais peut être perçu comme sous-entendu. Si quelqu'un arrive à voir comment gérer cela plus tard, n'hésitez pas. Autrement, tout fonctionne bien.
- Bien sûr, il est possible que des changements visuels ou de style soient nécessaires pour une meilleure cohésion d'apparence de l'appli. N'hésitez pas à l'indiquer si besoin.
- De nouvelles images pour les planètes et les températures ont été ajoutées dans le dossier Image.

### Données statistiques 

Ethan

- Liste de toutes les personnes (nom, prénom, type (militaire ou civil)) avec laquelle un membre
(sélectionné dans une zone de liste) est déjà parti en mission.
- Pour les missions comportant un équipage de plus de 10 personnes, indiquer la liste des
dépenses effectuées, ainsi que les budgets initiaux et actuels.
- Pour chaque planète, indiquer le nombre de missions qui y ont déjà eu lieu. Certaines planètes
n’ont jamais fait l’objet de mission, elles devront néanmoins apparaître.
- Liste des dépenses (date, motif et montant concaténés dans une seule colonne intitulée
« Dépenses les plus importantes »), nom de la mission et nom et prénom du chef de la mission,
pour les dépenses les plus élevées de chaque mission.
- Quels sont les informateurs (nom de code, espèce d’origine, somme totale reçue) qui ont perçu
le moins d’argent pendant une mission donnée ?

## Listes de questions 

- [x] Volet récapitulatif des missions: Qu'entendez-vous par "mode déconnecté puis déconnecté" ? 
- [x] Pour l'ajout d'informations concernant une mission sélectionnée, est-ce en mode connecté ou déconnecté ? 
- [x] Est-ce que la totalité des membres sont soit civils soit militaires ? Est-ce que la totalité des espèces sont soit alliées soit ennemies ? 

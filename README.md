# Projet Stargate 🪐🚀👽

Projet Stargate est une application réalisée sur Windows Forms développée en C# avec .NET Framework 4.8. Ce logiciel a été développé dans le cadre d'une Situation d'Apprentissage et d'Evaluation (SAé).

**🚩 Objectifs**
- Créer et suivre des missions de recherche et d'investigation spatiales
- Accéder facilement à toutes les informations liées à chaque mission et pouvoir les modifier au besoin
- Afficher toutes les informations intéressantes liées à chaque planète et chaque espèce
- Concevoir une interface utilisateur agréable et intuitive

---

## 🛠️ Tutoriel d'installation

### Prérequis
* **Visual Studio 2022** (ou plus récent) avec la charge de travail **Développement .NET pour ordinateur de bureau**.
* **.NET Framework 4.8** (ou .NET 6/8 Windows Forms).
* Package NuGet : `System.Data.SQLite` et `iTextSharp` (ou `QuestPDF` pour l'édition PDF).

### Procédure
1. **Cloner le dépôt** :
   ```bash
   git clone https://github.com/votre-compte/Projet-Stargate.git
   cd Projet-Stargate
   ```
2. **Ouvrir la solution** dans Visual Studio (`SAE24.slnx`).
3. **Vérifier la base de données** : S'assurer que le fichier `Stargate.db` se trouve bien dans le dossier `bin/Debug` (ou à la racine du projet avec la propriété *Copier si plus récent*).
4. **Restaurer les packages NuGet** puis **Exécuter (`F5`)**.

---

## 🛠️ Technologies Utilisées

* **Langage** : C#
* **Interface Graphique** : Windows Forms (WinForms) .NET
* **Base de données** : SQLite 3
* **Gestionnaire de version** : Git / GitLab (utilisé durant le projet, maintenant transféré sur Github)

---

## 🎮 Fonctionnalités 

### Tableau de bord

* Vue d'ensemble synthétique des missions (passées, en cours et à venir).
* Affichage du chef de mission, du budget et des dates clés.
* Génération de rapports d'activité au format **PDF** à partir du `DataSet` déconnecté local.

#### Création et configuration de missions

* **Authentification sécurisée** des administrateurs par vérification de mot de passe haché dans la base SQLite.
* Saisie de la feuille de route, sélection de la planète cible, choix du chef de mission (militaire obligatoirement), du budget et des quotas de DataBaz.
* **Affectation des membres de l'équipage** (militaires et civils).
* **Définition des objectifs de capture** gérée au travers d'une **transaction SQL** (pour garantir l'atomicité de la saisie).

### Recherche des espèces 

* Exploration du catalogue des espèces galactiques (alliées et ennemies).
* **Filtrage dynamique** par nom et par couleur.
* Consultation des spécificités :
  * **Espèces ennemies** : type d'arme, niveau d'agressivité.
  * **Espèces alliées** : niveau de bienveillance, instrument de musique favori, date de premier contact.

### Informations sur les planètes 

De la même manière que les espèces, il est possible de trier et rechercher les planètes selon des critères qui leur sont propres :
* Fiches techniques des planètes de la galaxie : température, gravité, présence ou absence de DataBaz.
* Statistiques d'occupation : répartition en pourcentage des espèces présentes sur chaque planète.
* Historique des missions s'y étant déroulées.

### Statistiques

Génération de requêtes analytiques sur la base SQLite :
1. **Réseau de membres** : Liste des personnes ayant participé à au moins une mission en commun avec un membre donné.
2. **Grandes expéditions** : Suivi budgétaire et détails des dépenses pour les missions à équipage (> 10 personnes).
3. **Exploration spatiale** : Nombre de missions par planète (y compris les planètes jamais explorées).
4. **Dépenses majeures** : Détection de la dépense la plus élevée par mission avec nom et prénom du chef de mission.
5. **Analyse des informateurs** : Identification des informateurs ayant perçu le moins d'argent lors d'une mission donnée.

--- 

## Informations complémentaires

* **Gestion de la connexion** : La classe `Connexion.cs` centralise l'ouverture et la fermeture des connexions SQLite.
* **Mode Déconnecté & In-Memory** : La classe `MesDatas.cs` stocke le `DataSet` global partagé entre les différents formulaires de l'application.
* **Sécurité & Intégrité** :
  * Validation des objectifs de capture sécurisée par une **transaction SQLite** (`Rollback` automatique en cas d'erreur).
  * Mots de passe administrateurs hachés en base.

---


## 📝 Auteurs 

- [Guillaume Niederlaender](https://github.com/Guyomeuh) (Chef de projet)
- [eliott.wnr](https://github.com/eliottwnr)
- [Ethan](https://github.com/EthanAymeric)

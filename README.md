# 🎮 Journal d’avancement — Projet “Generative Worlds”

**Groupe :**  
**Membres (2 ou 3 max):**  Miszczuk Ivan, Crenn-Durif Mael
**Thème choisi :** Médiéval

---

## 🧭 Objectif du projet

Créer un environnement procédural avec **Wave Function Collapse (WFC)** dans Unity,  
puis y intégrer des **mécaniques d’exploration ou d’interaction** permettant de modifier ou d’habiter cet environnement.

## 📚 Ressources

- [Tutorial WFC](https://www.procjam.com/tutorials/wfc/)
- [WFC Unity Plugin](https://selfsame.itch.io/unitywfc)
- [WFC initial plugin](https://github.com/mxgmn/WaveFunctionCollapse)

---

## 📅 Suivi jour par jour

### 🧩 Mardi matin – Mise en place

**Objectifs du jour :**

- Créer un projet Unity de base avec les dépendances nécessaires (WFC, VR/interaction).
- Choisir un style visuel et un type d’environnement à générer.
- Créer et rassembler les assets de base (tilesets, textures, modèles 3D).
- Comprendre le fonctionnement de base du plugin WFC sur Unity.
- Créer un premier exemple de génération simple.

## **Travail réalisé :**
Création du projet et prise en main de WFC avec un premier exemple généré

## **Résultats (captures ou description) :**

## **Problèmes rencontrés :**

## **Prochaines étapes :**
Choix du thème

---

### 🧱 Mardi après-midi – Génération procédurale

**Objectifs du jour :**

- Créer un environnement cohérent à partir d’un *training sample*.
- Expérimenter différents paramètres (symétries, contraintes XML…).

## **Travail réalisé :**
Choix du thème, tuning des paramètres de génération afin d'avoir un rendu cohérent
## **Résultats / captures :**
![alt text](Mardi.png)

## **Problèmes rencontrés :**

## **Idées d’amélioration :**

---

### 🧭 Mercredi après-midi – Interaction et navigation

**Objectifs du jour :**

- Permettre la navigation dans l’environnement généré.
- Ajouter une ou plusieurs interactions. Exemples : modification de l’environnement, collecte d’objets, déclenchement d’événements.
- Gérer les modifications dynamiques de l’environnement (re-génération partielle, sauvegarde de l’état…) --> Utiliser les ressources données et les possibilités du plugin WFC.

## **Travail réalisé :**
Integration de la VR, et d'un panneau permettant de modifier chaque zone du château en jeu
## **Résultats / captures :**
![alt text](Mercredi.png)

## **Problèmes rencontrés :**
Lors de la regénération les zones auront différentes seed et donc ne se connecteront pas forcément bien
## **Idées / pistes :**
Ajout de contraintes

---

### 🎨 Jeudi après-midi – Finition et expérience utilisateur

**Objectifs du jour :**

- Donner une cohérence visuelle et interactive à l’expérience.
- Finaliser les éléments techniques et préparer la présentation.

## **Travail réalisé :**
Recherches sur comment modifier chaque zone tout en gardant un environnement cohérent
## **Problèmes restants :**
Solutions essayées n'ont pas marché, recherche sur comment implémenter une génération par blocks qui se superposent
## **Améliorations prévues :**

---

### 🎤 Vendredi après-midi – Présentation finale

## **Résumé du projet :**
Le projet propose de modifier un château et de se promener entre ses remparts. La génération du château et des parties modifiées se fait de façon procédurale avec l'algorithme WFC.
![alt text](Final.png)

## **Ce que nous avons appris :**
J'ai pu apprendre à utiliser l'algorithme WFC qui a des applications très intéressantes.

## **Ce que nous ferions différemment :**
La regénération d'un chunk peut avoir du mal à se résoudre, il faut des fois la relancer plusieurs fois avant d'avoir un résultat. Aussi il peut aussi arriver que la partie régénérée ne s'adapte pas bien à ce qui existe déjà, une modification du code plus poussée aurait peut-être permis de régler ces problèmes.  
Les meshs des murs sont ouverts sur les côtés, il faudrait les refaire.

## **Lien vers le projet Unity / dépôt :**
<<<<<<< HEAD:Miszczuk_Crenn-Durif - Journal avancement projet.md
https://github.com/Ma10u/UnityWFC
---
=======

---

## 💬 Notes et réflexions libres

(Espace pour idées, croquis, remarques sur le WFC, les interactions, ou l’expérience utilisateur)
>>>>>>> 8e51e6d94db6cce15d0a4b21ff7d4083fbd43700:README.md

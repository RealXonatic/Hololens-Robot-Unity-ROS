# Interaction Hololens 2 avec un Bras Robot Simulé sous ROS dans Unity3D

## Description du Projet

Ce projet vise à fusionner la simulation robotique et la réalité augmentée en utilisant trois technologies principales :
- **Unity3D** pour simuler un bras robotique effectuant des tâches de "pick and place".
- **ROS** (Robot Operating System) pour gérer la logique de contrôle et les communications du robot.
- **Hololens 2** pour projeter la simulation dans un espace physique, permettant une interaction immersive et réaliste.

## Objectifs

- **Simulation réaliste** : Créer une simulation réaliste d'un bras robotique capable d'interagir avec des objets dans un environnement virtuel.
- **Intégration fluide** : Intégrer Unity3D avec ROS pour un contrôle précis et réaliste du robot.
- **Interaction immersive** : Utiliser Hololens 2 pour visualiser et interagir avec la simulation dans le monde physique.

## Aperçu de l'Architecture

1. **Unity3D** : Utilisé pour créer l'environnement virtuel et la simulation du bras robotique.
2. **ROS** : Utilisé pour gérer les commandes et la logique du robot.
3. **Hololens 2** : Utilisé pour projeter la simulation dans un espace physique et permettre l'interaction en réalité augmentée.

## Prérequis

### Connaissances nécessaires

- Programmation en C#
- Unity3D
- ROS
- Concepts de réalité augmentée et Hololens 2

### Matériel et logiciel requis

- **Unity3D 2020.3**
- **Visual Studio 2019**
- **Visual Studio Code**
- **ROS Melodic** (dans une machine virtuelle sous Ubuntu 18.04)
- **Hololens 2**
- **Windows 10 SDK (dernière version)**
- **Mixed Reality Toolkit (MRTK)**
- **PC sous Windows**

## Installation et Configuration

1. **Unity3D** : Installer Unity3D 2020.3 avec les modules Windows Universal Platform Build Support et Windows Build Support.
2. **ROS** : Installer ROS Melodic sur une machine virtuelle sous Ubuntu 18.04 et configurer l'environnement.
3. **Visual Studio 2019** : Installer avec les composants nécessaires pour le développement d'applications UWP.
4. **Hololens 2** : Activer le mode développeur et configurer le casque pour le déploiement.

## Déploiement

1. **Configurer Unity3D** : Préparer le projet Unity pour Hololens 2 et ajouter les packages nécessaires (Mixed Reality Toolkit, URDF Importer, ROS TCP Connector).
2. **Configurer ROS** : Configurer la communication entre Unity3D et ROS via les paramètres de connexion ROS dans Unity.
3. **Déployer sur Hololens 2** : Utiliser Visual Studio 2019 pour déployer l'application sur le casque Hololens 2.


## Références

1. [Unity Robotics Hub](https://github.com/Unity-Technologies/Unity-Robotics-Hub)
2. [Guide de l'application universelle Windows](https://learn.microsoft.com/fr-fr/windows/uwp/get-started/universal-application-platform-guide)
3. [Windows SDK](https://developer.microsoft.com/en-us/windows/downloads/windows-sdk/)
4. [Tutoriels pour débutants sur Hololens 2](https://learn.microsoft.com/fr-fr/training/paths/beginner-hololens-2-tutorials/)
5. [Installation de ROS Melodic sur Ubuntu](http://wiki.ros.org/melodic/Installation/Ubuntu)
6. [Vidéo tutoriel](https://www.youtube.com/watch?v=HV1v8mXNmLA)
7. [Mixed Reality Toolkit Unity](https://github.com/microsoft/MixedRealityToolkit-Unity/releases/)
8. [Configuration du suivi oculaire sur Hololens 2](https://learn.microsoft.com/en-us/windows/mixed-reality/mrtk-unity/mrtk2/features/input/eye-tracking/eye-tracking-basic-setup?view=mrtkunity-2022-05)

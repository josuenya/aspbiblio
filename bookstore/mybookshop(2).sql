-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Hôte : localhost
-- Généré le : lun. 08 mars 2021 à 14:06
-- Version du serveur :  10.4.17-MariaDB
-- Version de PHP : 8.0.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `mybookshop`
--

-- --------------------------------------------------------

--
-- Structure de la table `autors`
--

CREATE TABLE `autors` (
  `id` int(11) NOT NULL,
  `name` varchar(50) DEFAULT NULL,
  `phone` varchar(25) DEFAULT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NULL DEFAULT NULL ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `autors`
--

INSERT INTO `autors` (`id`, `name`, `phone`, `created_at`, `updated_at`) VALUES
(1, 'josue', '657850784', '2021-03-07 20:48:00', '2021-03-08 20:49:01'),
(2, 'martin lutter king', '689986789', '2021-03-07 23:59:22', '2021-03-07 23:59:22');

-- --------------------------------------------------------

--
-- Structure de la table `books`
--

CREATE TABLE `books` (
  `id` int(11) NOT NULL,
  `libelle` varchar(50) DEFAULT NULL,
  `description` varchar(50) DEFAULT NULL,
  `qty` float DEFAULT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NULL DEFAULT NULL ON UPDATE current_timestamp(),
  `editors_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `books`
--

INSERT INTO `books` (`id`, `libelle`, `description`, `qty`, `created_at`, `updated_at`, `editors_id`) VALUES
(2, 'Apprendre a programmer en C# vol1', 'Les bases de la Programmation en C#', 2, '2021-03-16 22:33:46', '2021-03-16 22:33:46', 2),
(3, 'Les bases Sur L\'agorithme', 'l\'agorithme de A a Z', 5, '2021-03-07 23:26:03', '2021-03-15 23:26:03', 3),
(4, 'comprendre la programmation systeme', 'script sur linux', 2, '2021-03-07 23:39:59', '2021-03-07 23:39:59', 2),
(5, 'Comprendre la modelisation UML', 'modelisation avec UML 2.0', 2, '2021-03-07 23:39:59', '2021-03-07 23:39:59', 4),
(6, 'debuter avec vuejs', 'Framework Frontend tres Efficase', 2, '2021-03-07 23:42:31', '2021-03-07 23:42:31', 2),
(7, 'comprendre ADO.net', 'connection a une source de donnee', 1, '2021-03-07 23:44:03', '2021-03-07 23:44:03', 1),
(8, 'Comprendre la modelisation UML', 'modelisation avec UML 2.0', 6, '2021-03-07 23:39:59', '2021-03-07 23:39:59', 4),
(9, 'debuter avec vuejs', 'Framework Frontend tres Efficase', 2, '2021-03-07 23:42:31', '2021-03-07 23:42:31', 2),
(10, 'comprendre ADO.net', 'connection a une source de donnee', 1, '2021-03-07 23:44:03', '2021-03-07 23:44:03', 1),
(11, 'Comprendre la modelisation UML', 'modelisation avec UML 2.0', 6, '2021-03-07 23:39:59', '2021-03-07 23:39:59', 4),
(12, 'debuter avec vuejs', 'Framework Frontend tres Efficase', 2, '2021-03-07 23:42:31', '2021-03-07 23:42:31', 2),
(13, 'comprendre ADO.net', 'connection a une source de donnee', 1, '2021-03-07 23:44:03', '2021-03-07 23:44:03', 1);

-- --------------------------------------------------------

--
-- Structure de la table `books_autors`
--

CREATE TABLE `books_autors` (
  `id` int(11) NOT NULL,
  `books_id` int(11) NOT NULL,
  `autors_id` int(11) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NULL DEFAULT NULL ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `books_autors`
--

INSERT INTO `books_autors` (`id`, `books_id`, `autors_id`, `created_at`, `updated_at`) VALUES
(2, 2, 1, '2021-03-16 22:35:28', '2021-03-16 22:35:28'),
(3, 3, 1, '2021-03-07 23:27:48', '2021-03-07 23:27:48'),
(4, 10, 2, '2021-03-08 00:00:34', '2021-03-08 00:00:34');

-- --------------------------------------------------------

--
-- Structure de la table `editors`
--

CREATE TABLE `editors` (
  `id` int(11) NOT NULL,
  `name` varchar(50) DEFAULT NULL,
  `adress` varchar(50) DEFAULT NULL,
  `city` varchar(50) DEFAULT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NULL DEFAULT NULL ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `editors`
--

INSERT INTO `editors` (`id`, `name`, `adress`, `city`, `created_at`, `updated_at`) VALUES
(1, 'L\'École des loisirs', 'France', 'France', '2021-03-16 22:29:11', '2021-03-16 22:29:11'),
(2, 'Larousse', 'France', 'France', '2021-03-16 22:29:11', '2021-03-16 22:29:11'),
(3, 'Hachette', 'France', 'France', '2021-03-17 22:30:26', '2021-03-17 22:30:26'),
(4, 'Hatier', 'France', 'France', '2021-03-17 22:30:26', '2021-03-17 22:30:26'),
(5, 'ASVA EDUCATION', 'Yaounde,Cameroun', 'Yaounde', '2021-03-17 22:31:43', '2021-03-24 22:31:43');

-- --------------------------------------------------------

--
-- Structure de la table `loan`
--

CREATE TABLE `loan` (
  `id` int(11) NOT NULL,
  `users_id` int(11) NOT NULL,
  `books_id` int(11) NOT NULL,
  `statut` enum('Rendu','en cours') DEFAULT NULL,
  `return_date` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NULL DEFAULT NULL ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `loan`
--

INSERT INTO `loan` (`id`, `users_id`, `books_id`, `statut`, `return_date`, `created_at`, `updated_at`) VALUES
(1, 4, 2, 'en cours', '2021-03-11 12:02:00', '2021-03-08 12:02:00', '2021-03-08 12:02:00');

-- --------------------------------------------------------

--
-- Structure de la table `purcharses`
--

CREATE TABLE `purcharses` (
  `id` int(11) NOT NULL,
  `books_id` int(11) NOT NULL,
  `buying_price` float NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NULL DEFAULT NULL ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `roles`
--

CREATE TABLE `roles` (
  `id` int(11) NOT NULL,
  `libelle` varchar(50) DEFAULT NULL,
  `description` varchar(50) DEFAULT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NULL DEFAULT NULL ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `roles`
--

INSERT INTO `roles` (`id`, `libelle`, `description`, `created_at`, `updated_at`) VALUES
(1, 'etudiants', 'etudiant', '2021-02-19 14:45:30', NULL),
(2, 'enseignants', 'enseignants', '2021-02-19 14:45:53', NULL),
(3, 'admin', 'admin', '2021-02-19 14:46:20', NULL);

-- --------------------------------------------------------

--
-- Structure de la table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `email` varchar(50) NOT NULL,
  `roles_id` int(11) NOT NULL,
  `name` varchar(30) DEFAULT NULL,
  `username` varchar(30) DEFAULT NULL,
  `password` varchar(50) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NULL DEFAULT NULL ON UPDATE current_timestamp(),
  `phone` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `users`
--

INSERT INTO `users` (`id`, `email`, `roles_id`, `name`, `username`, `password`, `created_at`, `updated_at`, `phone`) VALUES
(2, 'josue@josue.com', 3, 'josue', 'josue', 'fdfdfdfdfd', '2021-02-20 16:32:23', '2021-03-09 21:18:41', '3434455667'),
(3, 'josuenya23@gmail.com', 3, 'NYA', 'josue', 'josue237', '2021-02-27 23:26:11', '2021-03-17 21:18:47', '657850784'),
(4, 'etudiant@etudiant.com', 1, 'etudians 1', 'etudiants', 'demo12345', '2021-03-08 11:57:50', '2021-03-08 11:57:50', '675200784'),
(5, 'enseignant@enseignant.com', 2, 'enseignant', 'enseignant', 'demo12345', '2021-03-08 11:57:50', '2021-03-08 11:57:50', '678464532');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `autors`
--
ALTER TABLE `autors`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `books`
--
ALTER TABLE `books`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_editor` (`editors_id`);

--
-- Index pour la table `books_autors`
--
ALTER TABLE `books_autors`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_autors` (`autors_id`),
  ADD KEY `fk_books3` (`books_id`);

--
-- Index pour la table `editors`
--
ALTER TABLE `editors`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `loan`
--
ALTER TABLE `loan`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_book2` (`books_id`),
  ADD KEY `fk)users2` (`users_id`);

--
-- Index pour la table `purcharses`
--
ALTER TABLE `purcharses`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_book_id` (`books_id`);

--
-- Index pour la table `roles`
--
ALTER TABLE `roles`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `email` (`email`),
  ADD KEY `fk_roles` (`roles_id`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `autors`
--
ALTER TABLE `autors`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `books`
--
ALTER TABLE `books`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT pour la table `books_autors`
--
ALTER TABLE `books_autors`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table `editors`
--
ALTER TABLE `editors`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT pour la table `loan`
--
ALTER TABLE `loan`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT pour la table `purcharses`
--
ALTER TABLE `purcharses`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `roles`
--
ALTER TABLE `roles`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT pour la table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `books`
--
ALTER TABLE `books`
  ADD CONSTRAINT `fk_editor` FOREIGN KEY (`editors_id`) REFERENCES `editors` (`id`);

--
-- Contraintes pour la table `books_autors`
--
ALTER TABLE `books_autors`
  ADD CONSTRAINT `fk_autors` FOREIGN KEY (`autors_id`) REFERENCES `autors` (`id`),
  ADD CONSTRAINT `fk_books3` FOREIGN KEY (`books_id`) REFERENCES `books` (`id`);

--
-- Contraintes pour la table `loan`
--
ALTER TABLE `loan`
  ADD CONSTRAINT `fk)users2` FOREIGN KEY (`users_id`) REFERENCES `users` (`id`),
  ADD CONSTRAINT `fk_book2` FOREIGN KEY (`books_id`) REFERENCES `books` (`id`);

--
-- Contraintes pour la table `purcharses`
--
ALTER TABLE `purcharses`
  ADD CONSTRAINT `fk_book_id` FOREIGN KEY (`books_id`) REFERENCES `books` (`id`);

--
-- Contraintes pour la table `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `fk_roles` FOREIGN KEY (`roles_id`) REFERENCES `roles` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

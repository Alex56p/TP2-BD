------------------------------------------
--                                      --
--           Insertion TP2              -- 
--                                      --
--     Par Anthony Labelle-Voyez et     --
--            Alexis Parent             --
------------------------------------------

------------------------------------
--           Categories           -- 
------------------------------------
INSERT INTO CATEGORIES VALUES('Sp', 'Sport', 'Orange');
INSERT INTO CATEGORIES VALUES('Sc', 'Sciences', 'Vert');
INSERT INTO CATEGORIES VALUES('Jv', 'Jeux vidéo', 'Bleu');
INSERT INTO CATEGORIES VALUES('Di', 'Divertissement', 'Rose');

------------------------------------
--            Joueurs             -- 
------------------------------------
EXECUTE GESTIONINTELLICRACK.Ajouter_Joueur('PoneyLoverXz', 'Voyez', 'Anthony');
EXECUTE GESTIONINTELLICRACK.Ajouter_Joueur('Alex56p', 'Parent', 'Alexis');
EXECUTE GESTIONINTELLICRACK.Ajouter_Joueur('xLeafing', 'Caron', 'Samuel');
EXECUTE GESTIONINTELLICRACK.Ajouter_Joueur('batterie AAA', 'Deschamps', 'Arthur');

------------------------------------
--             Match              -- 
------------------------------------
EXECUTE GESTIONINTELLICRACK.Ajouter_Match('PoneyLoverXz', 'Alex56p', 'xLeafing', 'batterie AAA');
EXECUTE GESTIONINTELLICRACK.Ajouter_Match('PoneyLoverXz', 'Alex56p', 'xLeafing');
EXECUTE GESTIONINTELLICRACK.Ajouter_Match('PoneyLoverXz', 'Alex56p');

------------------------------------
--        Questions Sport         -- 
------------------------------------
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sp','Quel joueur du Canadiens porte le numéro 76?', 'PK Subban', 'Carey Price', 'Max Pacioretty' , 'Andrei Markov');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sp','Quels sont les joueurs du Canadiens qui a été capitaine le plus longtemps?', 'Koivu et Béliveau', 'Koivu et Gainey', 'Béliveau et Bouchard' , 'Bouchard et Gainey');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sp','Qui est l''homme le plus rapide de la planète?', 'Usain Bolt', 'PK Subban', 'Alain Patoche' , 'Hiro Nakamura');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sp','Quel pays a remporté la coupe du monde FIFA au Brésil?', 'Allemagne', 'Brésil', 'Espagne' , 'France');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sp','Quel joueuse de tennis québécoise s''est rendu à la finale de Wimbledon?', 'Eugénie Bouchard', 'PK Subban', 'Venus Williams' , 'Maria Sharapova');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sp','Quel joueur de la LNH a gagné le trophée Hart dans la saison 2013-2014?', 'Sydney Crosby', 'Steven Stamkos', 'Carey Price' , 'Alex Ovechkin');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sp','Quel équipe a gagné la coupe Stanley en 2012-2013?', 'Chicago Blackhawks', 'Boston Bruins', 'LA Kings' , 'Montreal Canadiens');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sp','Qui est le capitaine du Canadiens en 2014-2015?', 'Il n''y a pas de capitaine', 'Carey Price', 'Max Pacioretty' , 'PK Subban');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sp','Quel joueur a le plus de points dans l''histoire du Canadiens de Montréal?', 'Guy Lafleur', 'Maurice Richard', 'Jean Béliveau' , 'Saku Koivu');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sp','Quel est l''équipe de la LNH installé à Nashville?', 'Predators', 'Sharks', 'Panthers' , 'Blues');

-------------------------IL EN MANQUE 10 --------------------------

------------------------------------
--      Questions Jeux Video      -- 
------------------------------------
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Jv','Qui est le personnage principal de la série "The Legend of Zelda"?', 'Link', 'Zelda', 'Mario' , 'Donkey Kong');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Jv','En quel année est-ce que la console "Wii" est-elle sortie?', '2006', '2007', '2005' , '2008');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Jv','À quelle compagnie est la console Xbox?', 'Microsoft', 'Nintendo', 'Steam' , 'Sony');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Jv','Quelle compagnie a créé League of Legends?', 'Riot Games', 'Blizzard', 'Valve' , 'Square Enix');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Jv','Quel personnage n''est pas de la franchise "Mario" de Nintendo?', 'Pikachu', 'Daisy', 'Toad' , 'Bowser');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Jv','Combien y avait-il de Pokémon dans la première génération?', '151', '101', '51' , '201');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Jv','Quel personnage de jeu vidéo est le plus rapide?', 'Sonic', 'Mario', 'Donkey Kong' , 'Paperboy');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Jv','De quel franchise vient le personnage Master Chief"?', 'Halo', 'Nintendo', 'Steam' , 'Sony');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Jv','Quel est le nom de la première console de Microsoft?', 'Xbox', 'Xbox One', 'Xbox 360' , 'Xbox Zero');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Jv','Dans quel franchise est-ce que Samus figure-t-elle?"', 'Metroid', 'Zelda', 'Super Mario Bros' , 'Super Smash Bros');

----------------------------Il EN MANQUE 10 ----------------------------


------------------------------------
--    Questions Divertissement    -- 
------------------------------------
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Di','Qui est le grand vilain de la série Star Wars?', 'Darth Vader', 'Yoda', 'Obi-wan Kenobi' , 'Boba Fett');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Di','Qui est l''homme ayant reçu le plus d''Oscar?', 'Walt Disney', 'Leonardo DiCaprio', 'Johnny Depp' , 'Will Smith');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Di','Qui joue James Bond dans Casino Royale?', 'Daniel Craig', 'Pierce Brosnan', 'Timothy Dalton' , 'Roger Moore');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Di','Qui est le chanteur de "The Doors"?', 'Jim Morrison', 'Sting', 'Freddie Mercury' , 'Ray Manzarek');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Di','Quel groupe a composé l''album "Highway To Hell"?', 'AC/DC', 'Megadeth', 'Metallica' , 'Iron Maiden');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Di','Quel acteur n''a pas joué le rôle de James Bond?', 'Tom Cruise', 'Pierce Brosnan', 'Daniel Craig' , 'Sean Connery');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Di','Quel est le prénom de Batman?', 'Bruce', 'Peter', 'George' , 'Brian');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Di','Lequel de ces hommes a déjà gagné un Oscar?', 'Jamie Foxx', 'Leonardo DiCaprio', 'Robert Downey Jr.' , 'Edward Norton');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Di','Combien d''Oscar a gagné le film "Le Seigneur des Anneaux: Le retour du roi"?', '11', '1', '5' , '8');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Di','Lequel de ces films n''appartient pas à Disney?', 'L''Étrange Noël de monsieur Jack ', 'Frozen', 'John Carter' , 'Toy Story');

------------ Il Manque 10 Questions -----------------------------


------------------------------------
--       Questions Sciences       -- 
------------------------------------


--Questions à Doriane










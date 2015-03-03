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
INSERT INTO CATEGORIES VALUES('Jv', 'Jeux vid�o', 'Bleu');
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
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sp','Quel joueur du Canadiens porte le num�ro 76?', 'PK Subban', 'Carey Price', 'Max Pacioretty' , 'Andrei Markov');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sp','Quels sont les joueurs du Canadiens qui a �t� capitaine le plus longtemps?', 'Koivu et B�liveau', 'Koivu et Gainey', 'B�liveau et Bouchard' , 'Bouchard et Gainey');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sp','Qui est l''homme le plus rapide de la plan�te?', 'Usain Bolt', 'PK Subban', 'Alain Patoche' , 'Hiro Nakamura');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sp','Quel pays a remport� la coupe du monde FIFA au Br�sil?', 'Allemagne', 'Br�sil', 'Espagne' , 'France');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sp','Quel joueuse de tennis qu�b�coise s''est rendu � la finale de Wimbledon?', 'Eug�nie Bouchard', 'PK Subban', 'Venus Williams' , 'Maria Sharapova');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sp','Quel joueur de la LNH a gagn� le troph�e Hart dans la saison 2013-2014?', 'Sydney Crosby', 'Steven Stamkos', 'Carey Price' , 'Alex Ovechkin');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sp','Quel �quipe a gagn� la coupe Stanley en 2012-2013?', 'Chicago Blackhawks', 'Boston Bruins', 'LA Kings' , 'Montreal Canadiens');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sp','Qui est le capitaine du Canadiens en 2014-2015?', 'Il n''y a pas de capitaine', 'Carey Price', 'Max Pacioretty' , 'PK Subban');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sp','Quel joueur a le plus de points dans l''histoire du Canadiens de Montr�al?', 'Guy Lafleur', 'Maurice Richard', 'Jean B�liveau' , 'Saku Koivu');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sp','Quel est l''�quipe de la LNH install� � Nashville?', 'Predators', 'Sharks', 'Panthers' , 'Blues');

-------------------------IL EN MANQUE 10 --------------------------

------------------------------------
--      Questions Jeux Video      -- 
------------------------------------
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Jv','Qui est le personnage principal de la s�rie "The Legend of Zelda"?', 'Link', 'Zelda', 'Mario' , 'Donkey Kong');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Jv','En quel ann�e est-ce que la console "Wii" est-elle sortie?', '2006', '2007', '2005' , '2008');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Jv','� quelle compagnie est la console Xbox?', 'Microsoft', 'Nintendo', 'Steam' , 'Sony');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Jv','Quelle compagnie a cr�� League of Legends?', 'Riot Games', 'Blizzard', 'Valve' , 'Square Enix');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Jv','Quel personnage n''est pas de la franchise "Mario" de Nintendo?', 'Pikachu', 'Daisy', 'Toad' , 'Bowser');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Jv','Combien y avait-il de Pok�mon dans la premi�re g�n�ration?', '151', '101', '51' , '201');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Jv','Quel personnage de jeu vid�o est le plus rapide?', 'Sonic', 'Mario', 'Donkey Kong' , 'Paperboy');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Jv','De quel franchise vient le personnage Master Chief"?', 'Halo', 'Nintendo', 'Steam' , 'Sony');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Jv','Quel est le nom de la premi�re console de Microsoft?', 'Xbox', 'Xbox One', 'Xbox 360' , 'Xbox Zero');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Jv','Dans quel franchise est-ce que Samus figure-t-elle?"', 'Metroid', 'Zelda', 'Super Mario Bros' , 'Super Smash Bros');

----------------------------Il EN MANQUE 10 ----------------------------


------------------------------------
--    Questions Divertissement    -- 
------------------------------------
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Di','Qui est le grand vilain de la s�rie Star Wars?', 'Darth Vader', 'Yoda', 'Obi-wan Kenobi' , 'Boba Fett');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Di','Qui est l''homme ayant re�u le plus d''Oscar?', 'Walt Disney', 'Leonardo DiCaprio', 'Johnny Depp' , 'Will Smith');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Di','Qui joue James Bond dans Casino Royale?', 'Daniel Craig', 'Pierce Brosnan', 'Timothy Dalton' , 'Roger Moore');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Di','Qui est le chanteur de "The Doors"?', 'Jim Morrison', 'Sting', 'Freddie Mercury' , 'Ray Manzarek');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Di','Quel groupe a compos� l''album "Highway To Hell"?', 'AC/DC', 'Megadeth', 'Metallica' , 'Iron Maiden');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Di','Quel acteur n''a pas jou� le r�le de James Bond?', 'Tom Cruise', 'Pierce Brosnan', 'Daniel Craig' , 'Sean Connery');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Di','Quel est le pr�nom de Batman?', 'Bruce', 'Peter', 'George' , 'Brian');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Di','Lequel de ces hommes a d�j� gagn� un Oscar?', 'Jamie Foxx', 'Leonardo DiCaprio', 'Robert Downey Jr.' , 'Edward Norton');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Di','Combien d''Oscar a gagn� le film "Le Seigneur des Anneaux: Le retour du roi"?', '11', '1', '5' , '8');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Di','Lequel de ces films n''appartient pas � Disney?', 'L''�trange No�l de monsieur Jack ', 'Frozen', 'John Carter' , 'Toy Story');

------------ Il Manque 10 Questions -----------------------------


------------------------------------
--       Questions Sciences       -- 
------------------------------------


--Questions � Doriane










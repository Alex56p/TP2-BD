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
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sp','Qui a gagné la coupe Stanley en 2014?', 'Kings de LosAngeles', 'Predateurs de Nashville', 'Canadiens de Montréal' , 'Bruins de Boston');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sp','Qui est le gardien principal des Canadiens de Montréal?', 'Carey Price', 'Martin Brodeur', 'José Théodore' , 'Mike Smith');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sp','Quel est le nom du championnat de Tennis à Montréal?', 'Coupe Rogers', 'Coupe Grey', 'Coupe Stanley' , 'Coupe Molson');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sp','Qui est le propriétaire du Canadien de Montréal en 2015?', 'Geoff Molson', 'Bill Gates', 'J. Davis, William A. et Peter B. Molson' , 'Michel Therrien');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sp','Qui est l''entraineur de Bruins de Boston?', 'Claude Julien', 'Michel Therrien', 'Patrick Roy' , 'Willie Desjardins');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sp','Quelle équipe de football retrouve-t-on à Montréal?', 'Alouettes', 'Eagles', 'Seahawks' , 'Jets');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sp','Quel est l''abréviation de la ligue où se trouve les Canadiens de Montréal?', 'NHL', 'KHL', 'OHL' , 'NFL');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sp','Quel est le nom de l''ancienne équipe de baseball à Montréal?', 'Expos', 'Orioles', 'White Sox' , 'Tigers');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sp','D''où vient le joueur de hockey Jonathan Drouin?', 'Sainte-Agathe-Des-Monts', 'Montréal', 'Toronto' , 'Ottawa');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sp','Combien d''équipe retrouve-t-on dans la NHL?', '30', '40', '20' , '28');


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
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Jv','Qui a créé le jeu Minecraft?', 'Mojan', 'Bungie', 'Rockrtar Games' , 'EA Games');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Jv','Lequel parmi les suivants est l''un des personnage de Grand Theft Auto 5?', 'Tervor', 'John', 'Moe' , 'Max');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Jv','Quel est le jeu où on peut jouer de la batterie?', 'RockBand', 'Guitar Hero', 'RockSmith0' , 'DrumHero');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Jv','Quelle est la première console portable à avoir une écran tactile', 'Nitendo DS', 'GameBoy', 'PSP' , 'Xbox 360');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Jv','En quel année la console "Xbox One" est sortie au Canada?', '2013', '2007', '2015' , '2014');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Jv','Lequel parmit les suivant n''est pas une position jouable à League Of Legends?', 'Carry', 'Adc', 'Support' , 'Top');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Jv','Qui est Peach dans le monde des jeux vidéo?', 'La princesse du Mushroom Kingdom dans Mario Bros', 'Un personnage dans League Of Legend', 'Le peronnage principal de Tom Raider' , 'Aucune de ses réponses');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Jv','Quel jeu  possède la compagnie Valve?', 'Counter-Strike: Global Offensive', 'H1Z1', 'DayZ' , 'Toutes ses réponses');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Jv','Dans quel jeu retrouve-t-on l''équipe "Team SoloMid"?', 'League Of Legends', 'Halo', 'NHL 15' , 'Grand Theft Auto');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Jv','Dans quel jeu retrouve-t-on la chanson "Ain''t No Rest For the Wicked"', 'Borderlands', 'Arma 3', 'The Legend of Zelda' , 'SpinTires');



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
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Di','Qui est le chanteur du groupe Pink Floyd?', 'Roger Water', 'Daniel Craig', 'Freddie Mercury' , 'Ray Manzarek');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Di','À quel groupe appartient la chanson "Fear of the dark"?', 'Iron Maiden', 'Pink Floyd', 'Attila' , 'Metallica');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Di','Quel groupe de musique est connu pour écrire des chansons vulgaires?', 'Attila', 'Periphery', 'Disturbed' , 'Our last night');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Di','Quel groupe de musique a écrit l''album Disgusting?', 'Beartooth', 'Peripehry', 'Memphis may fire' , 'Oceans ate Alaska');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Di','Dans que film retrouve-t-on l''acteur Robert Downey Jr.?', 'Iron man', 'Titanic', '50 shades of grey' , 'Spider man');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Di','Quel acteur est mort à bord d''une voiture en 2013?', 'Paul Walker', 'Vin Diesel', 'Dwayne Johnson' , 'Cody Walker');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Di','Qui a écrit le livre 50 Shades of grey?', 'E. L. James', 'J. K. Rowling', 'J. R. R. Toliken' , 'Maxime Roussy');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Di','Qui a été le gagnant de la voix en 2014?', 'Yoan Garneau', 'Émilie Perreault', 'Marie-Ève Fournier' , 'Julie Masse');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Di','Qui est la personnage principale dans Frozen?', 'Elsa', 'Anna', 'Éliane' , 'Marie');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Di','Qui est l''acteur principal dans la série 24 Heures Chorno?', 'Kiefer Sutherland', 'Robert Downey Jr.', 'Johnny Depp' , 'Jason Statham');

------------------------------------
--       Questions Sciences       -- 
------------------------------------
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sc','Lequel parmi les instruments suivant ne permet pas de mesurer le volume?', 'Éprouvette', 'Erlenmeyer', 'Ballon' , 'Bécher');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sc','Que représente le NaCl dans la vie de tous les jours?', 'Sel de table', 'Bicarbonate de soude', 'Sable' , 'Farine');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sc','Quel est le symbole chimique du Magnésium?', 'Mg', 'Me', 'Ma' , 'Mm');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sc','Quel mélange de solution est réputé pour créer un "volcan"?', 'Le bicarbonate de soude et le vinaigre', 'Le vinaigre et l''huile', 'L''huile et le bicarbonate de soude' , 'Le vinaigre et le sel de table');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sc','Quelle partie du corps est affectée lorsqu''on fume la cigarette?', 'Les poumons', 'Le foie', 'Le larynx' , 'L''oesophage');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sc','Quel processus chimique permet la fabrication de l''alcool', 'Fermentation', 'Respiration cellulaire', 'Amplification des levres' , 'Culture des levres');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sc','Quelle structure du corps permet le renouvellement des tissus, des organes, etc.?', 'Cellules souches de la moelle osseuse', 'cellules embryonnaires', 'Cellules transformées' , 'Aucune des ces réponses');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sc','Lequel des composés suivant n''est pas un sucre?', 'Lipides', 'Lactose', 'Glucose' , 'Surose');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sc','Que peut causer un exposition excessive au soleil sans crème solaire?', 'Toutes ses réponses', 'Coups de soleil', 'Cancer de la peau' , 'Tâches cutanées');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sc','Qu''est-ce que la Malaria?', 'Une maladie', 'Un composé moléculaire', 'Une légende' , 'Un vaccin');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sc','Que retrouve-t-ton principalement dans la composition de l''air?', 'N2, O2, CO2', 'CO, Na2, O2', 'N2, He, O2' , 'H2, N2, O2');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sc','Quelle est la charge d''un proton?', 'Positive', 'Négative', 'Neutre' , 'Toutes ces réponses');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sc','Qu''est-ce qui tourne autour du noyau d''un atome?', 'Électrons', 'Neutrons', 'Protons' , 'Aucune de ces réponses');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sc','Qu''est ce que le point de fusion?', 'Solide à liquide', 'Liquide à solide', 'Solide à gazeux' , 'Gazeux à liquide');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sc','Lequel n''est pas un métal?', 'Carbone', 'Aluminium', 'Sodium' , 'Potassium');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sc','Que mesure un baromètre?', 'Pression atmosphèrique', 'Température', 'Volume' , 'Concentration');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sc','À quoi sert une pipette?', 'Prélever un petit volume', 'Mélanger une solution', 'Ajouter une solution' , 'Mesurer la pression');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sc','Qui a énoncé les lois en lien avec l''inertie?', 'Newton', 'Einstein', 'Darwin' , 'Pythagore');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sc','Laquelle des interaction suivantes ne survient pas entre deux espèces?', 'Animation', 'Compétition', 'Prédation' , 'Commensalisme');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sc','Que ne retrouve t''on pas dans une cellule?', 'Électrons', 'Cytoplasme', 'Noyau' , 'Réticulum endoplasmique');

COMMIT;










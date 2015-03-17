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
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sp','Qui a gagn� la coupe Stanley en 2014?', 'Kings de LosAngeles', 'Predateurs de Nashville', 'Canadiens de Montr�al' , 'Bruins de Boston');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sp','Qui est le gardien principal des Canadiens de Montr�al?', 'Carey Price', 'Martin Brodeur', 'Jos� Th�odore' , 'Mike Smith');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sp','Quel est le nom du championnat de Tennis � Montr�al?', 'Coupe Rogers', 'Coupe Grey', 'Coupe Stanley' , 'Coupe Molson');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sp','Qui est le propri�taire du Canadien de Montr�al en 2015?', 'Geoff Molson', 'Bill Gates', 'J. Davis, William A. et Peter B. Molson' , 'Michel Therrien');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sp','Qui est l''entraineur de Bruins de Boston?', 'Claude Julien', 'Michel Therrien', 'Patrick Roy' , 'Willie Desjardins');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sp','Quelle �quipe de football retrouve-t-on � Montr�al?', 'Alouettes', 'Eagles', 'Seahawks' , 'Jets');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sp','Quel est l''abr�viation de la ligue o� se trouve les Canadiens de Montr�al?', 'NHL', 'KHL', 'OHL' , 'NFL');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sp','Quel est le nom de l''ancienne �quipe de baseball � Montr�al?', 'Expos', 'Orioles', 'White Sox' , 'Tigers');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sp','D''o� vient le joueur de hockey Jonathan Drouin?', 'Sainte-Agathe-Des-Monts', 'Montr�al', 'Toronto' , 'Ottawa');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sp','Combien d''�quipe retrouve-t-on dans la NHL?', '30', '40', '20' , '28');


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
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Jv','Qui a cr�� le jeu Minecraft?', 'Mojan', 'Bungie', 'Rockrtar Games' , 'EA Games');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Jv','Lequel parmi les suivants est l''un des personnage de Grand Theft Auto 5?', 'Tervor', 'John', 'Moe' , 'Max');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Jv','Quel est le jeu o� on peut jouer de la batterie?', 'RockBand', 'Guitar Hero', 'RockSmith0' , 'DrumHero');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Jv','Quelle est la premi�re console portable � avoir une �cran tactile', 'Nitendo DS', 'GameBoy', 'PSP' , 'Xbox 360');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Jv','En quel ann�e la console "Xbox One" est sortie au Canada?', '2013', '2007', '2015' , '2014');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Jv','Lequel parmit les suivant n''est pas une position jouable � League Of Legends?', 'Carry', 'Adc', 'Support' , 'Top');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Jv','Qui est Peach dans le monde des jeux vid�o?', 'La princesse du Mushroom Kingdom dans Mario Bros', 'Un personnage dans League Of Legend', 'Le peronnage principal de Tom Raider' , 'Aucune de ses r�ponses');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Jv','Quel jeu  poss�de la compagnie Valve?', 'Counter-Strike: Global Offensive', 'H1Z1', 'DayZ' , 'Toutes ses r�ponses');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Jv','Dans quel jeu retrouve-t-on l''�quipe "Team SoloMid"?', 'League Of Legends', 'Halo', 'NHL 15' , 'Grand Theft Auto');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Jv','Dans quel jeu retrouve-t-on la chanson "Ain''t No Rest For the Wicked"', 'Borderlands', 'Arma 3', 'The Legend of Zelda' , 'SpinTires');



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
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Di','Qui est le chanteur du groupe Pink Floyd?', 'Roger Water', 'Daniel Craig', 'Freddie Mercury' , 'Ray Manzarek');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Di','� quel groupe appartient la chanson "Fear of the dark"?', 'Iron Maiden', 'Pink Floyd', 'Attila' , 'Metallica');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Di','Quel groupe de musique est connu pour �crire des chansons vulgaires?', 'Attila', 'Periphery', 'Disturbed' , 'Our last night');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Di','Quel groupe de musique a �crit l''album Disgusting?', 'Beartooth', 'Peripehry', 'Memphis may fire' , 'Oceans ate Alaska');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Di','Dans que film retrouve-t-on l''acteur Robert Downey Jr.?', 'Iron man', 'Titanic', '50 shades of grey' , 'Spider man');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Di','Quel acteur est mort � bord d''une voiture en 2013?', 'Paul Walker', 'Vin Diesel', 'Dwayne Johnson' , 'Cody Walker');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Di','Qui a �crit le livre 50 Shades of grey?', 'E. L. James', 'J. K. Rowling', 'J. R. R. Toliken' , 'Maxime Roussy');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Di','Qui a �t� le gagnant de la voix en 2014?', 'Yoan Garneau', '�milie Perreault', 'Marie-�ve Fournier' , 'Julie Masse');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Di','Qui est la personnage principale dans Frozen?', 'Elsa', 'Anna', '�liane' , 'Marie');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Di','Qui est l''acteur principal dans la s�rie 24 Heures Chorno?', 'Kiefer Sutherland', 'Robert Downey Jr.', 'Johnny Depp' , 'Jason Statham');

------------------------------------
--       Questions Sciences       -- 
------------------------------------
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sc','Lequel parmi les instruments suivant ne permet pas de mesurer le volume?', '�prouvette', 'Erlenmeyer', 'Ballon' , 'B�cher');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sc','Que repr�sente le NaCl dans la vie de tous les jours?', 'Sel de table', 'Bicarbonate de soude', 'Sable' , 'Farine');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sc','Quel est le symbole chimique du Magn�sium?', 'Mg', 'Me', 'Ma' , 'Mm');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sc','Quel m�lange de solution est r�put� pour cr�er un "volcan"?', 'Le bicarbonate de soude et le vinaigre', 'Le vinaigre et l''huile', 'L''huile et le bicarbonate de soude' , 'Le vinaigre et le sel de table');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sc','Quelle partie du corps est affect�e lorsqu''on fume la cigarette?', 'Les poumons', 'Le foie', 'Le larynx' , 'L''oesophage');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sc','Quel processus chimique permet la fabrication de l''alcool', 'Fermentation', 'Respiration cellulaire', 'Amplification des levres' , 'Culture des levres');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sc','Quelle structure du corps permet le renouvellement des tissus, des organes, etc.?', 'Cellules souches de la moelle osseuse', 'cellules embryonnaires', 'Cellules transform�es' , 'Aucune des ces r�ponses');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sc','Lequel des compos�s suivant n''est pas un sucre?', 'Lipides', 'Lactose', 'Glucose' , 'Surose');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sc','Que peut causer un exposition excessive au soleil sans cr�me solaire?', 'Toutes ses r�ponses', 'Coups de soleil', 'Cancer de la peau' , 'T�ches cutan�es');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sc','Qu''est-ce que la Malaria?', 'Une maladie', 'Un compos� mol�culaire', 'Une l�gende' , 'Un vaccin');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sc','Que retrouve-t-ton principalement dans la composition de l''air?', 'N2, O2, CO2', 'CO, Na2, O2', 'N2, He, O2' , 'H2, N2, O2');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sc','Quelle est la charge d''un proton?', 'Positive', 'N�gative', 'Neutre' , 'Toutes ces r�ponses');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sc','Qu''est-ce qui tourne autour du noyau d''un atome?', '�lectrons', 'Neutrons', 'Protons' , 'Aucune de ces r�ponses');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sc','Qu''est ce que le point de fusion?', 'Solide � liquide', 'Liquide � solide', 'Solide � gazeux' , 'Gazeux � liquide');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sc','Lequel n''est pas un m�tal?', 'Carbone', 'Aluminium', 'Sodium' , 'Potassium');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sc','Que mesure un barom�tre?', 'Pression atmosph�rique', 'Temp�rature', 'Volume' , 'Concentration');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sc','� quoi sert une pipette?', 'Pr�lever un petit volume', 'M�langer une solution', 'Ajouter une solution' , 'Mesurer la pression');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sc','Qui a �nonc� les lois en lien avec l''inertie?', 'Newton', 'Einstein', 'Darwin' , 'Pythagore');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sc','Laquelle des interaction suivantes ne survient pas entre deux esp�ces?', 'Animation', 'Comp�tition', 'Pr�dation' , 'Commensalisme');
EXECUTE GESTIONINTELLICRACK.Ajouter_Question('Sc','Que ne retrouve t''on pas dans une cellule?', '�lectrons', 'Cytoplasme', 'Noyau' , 'R�ticulum endoplasmique');

COMMIT;










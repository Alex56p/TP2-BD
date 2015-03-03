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
--                                -- 
------------------------------------

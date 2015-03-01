-- Généré par Oracle SQL Developer Data Modeler 4.0.3.853
--   à :        2015-02-27 12:07:27 EST
--   site :      Oracle Database 11g
--   type :      Oracle Database 11g




CREATE TABLE CATÉGORIES
  (
    CodeCategorie CHAR (1) NOT NULL ,
    NomCategorie  VARCHAR2 ,
    Couleur       VARCHAR2
  ) ;
ALTER TABLE CATÉGORIES ADD CONSTRAINT CATÉGORIES_PK PRIMARY KEY ( CodeCategorie ) ;

CREATE TABLE JOUEURS
  (
    ALIAS  VARCHAR2 NOT NULL ,
    Nom    VARCHAR2 ,
    Prenom VARCHAR2
  ) ;
ALTER TABLE JOUEURS ADD CONSTRAINT JOUEURS_PK PRIMARY KEY ( ALIAS ) ;

CREATE TABLE MATCH
  (
    NumMatch NUMBER NOT NULL ,
    Joueur1  VARCHAR2 NOT NULL ,
    Joueur2  VARCHAR2 NOT NULL ,
    Joueur3  VARCHAR2 NOT NULL ,
    Joueur4  VARCHAR2 NOT NULL
  ) ;
ALTER TABLE MATCH ADD CONSTRAINT MATCH_PK PRIMARY KEY ( NumMatch ) ;

CREATE TABLE QUESTIONS
  (
    NumQuestion    CHAR (6) NOT NULL ,
    EnonceQuestion VARCHAR2 ,
    Flag           CHAR (1) ,
    CodeCategorie  CHAR (1) NOT NULL
  ) ;
ALTER TABLE QUESTIONS ADD CONSTRAINT QUESTIONS_PK PRIMARY KEY ( NumQuestion ) ;

CREATE TABLE REPONSES
  (
    NumReponse  CHAR (8) NOT NULL ,
    Description VARCHAR2 ,
    EstBonne    CHAR (1) ,
    NumQuestion CHAR (6) NOT NULL
  ) ;
ALTER TABLE REPONSES ADD CONSTRAINT REPONSES_PK PRIMARY KEY ( NumReponse, NumQuestion ) ;

CREATE TABLE SCORES
  (
    CodeCategorie CHAR (1) NOT NULL ,
    ALIAS         VARCHAR2 NOT NULL ,
    Score         NUMBER ,
    NumMatch      NUMBER NOT NULL
  ) ;
ALTER TABLE SCORES ADD CONSTRAINT SCORES_PK PRIMARY KEY ( CodeCategorie, ALIAS, NumMatch ) ;

ALTER TABLE MATCH ADD CONSTRAINT MATCH_JOUEURS_FK FOREIGN KEY ( Joueur1 ) REFERENCES JOUEURS ( ALIAS ) ;

ALTER TABLE MATCH ADD CONSTRAINT MATCH_JOUEURS_FKv1 FOREIGN KEY ( Joueur3 ) REFERENCES JOUEURS ( ALIAS ) ;

ALTER TABLE MATCH ADD CONSTRAINT MATCH_JOUEURS_FKv2 FOREIGN KEY ( Joueur4 ) REFERENCES JOUEURS ( ALIAS ) ;

ALTER TABLE MATCH ADD CONSTRAINT MATCH_JOUEURS_FKv4 FOREIGN KEY ( Joueur2 ) REFERENCES JOUEURS ( ALIAS ) ;

ALTER TABLE QUESTIONS ADD CONSTRAINT QUESTIONS_CATÉGORIES_FK FOREIGN KEY ( CodeCategorie ) REFERENCES CATÉGORIES ( CodeCategorie ) ;

ALTER TABLE REPONSES ADD CONSTRAINT REPONSES_QUESTIONS_FK FOREIGN KEY ( NumQuestion ) REFERENCES QUESTIONS ( NumQuestion ) ;

ALTER TABLE SCORES ADD CONSTRAINT SCORES_CATÉGORIES_FK FOREIGN KEY ( CodeCategorie ) REFERENCES CATÉGORIES ( CodeCategorie ) ;

ALTER TABLE SCORES ADD CONSTRAINT SCORES_JOUEURS_FK FOREIGN KEY ( ALIAS ) REFERENCES JOUEURS ( ALIAS ) ;

ALTER TABLE SCORES ADD CONSTRAINT SCORES_MATCH_FK FOREIGN KEY ( NumMatch ) REFERENCES MATCH ( NumMatch ) ;


-- Rapport récapitulatif d'Oracle SQL Developer Data Modeler : 
-- 
-- CREATE TABLE                             6
-- CREATE INDEX                             0
-- ALTER TABLE                             15
-- CREATE VIEW                              0
-- CREATE PACKAGE                           0
-- CREATE PACKAGE BODY                      0
-- CREATE PROCEDURE                         0
-- CREATE FUNCTION                          0
-- CREATE TRIGGER                           0
-- ALTER TRIGGER                            0
-- CREATE COLLECTION TYPE                   0
-- CREATE STRUCTURED TYPE                   0
-- CREATE STRUCTURED TYPE BODY              0
-- CREATE CLUSTER                           0
-- CREATE CONTEXT                           0
-- CREATE DATABASE                          0
-- CREATE DIMENSION                         0
-- CREATE DIRECTORY                         0
-- CREATE DISK GROUP                        0
-- CREATE ROLE                              0
-- CREATE ROLLBACK SEGMENT                  0
-- CREATE SEQUENCE                          0
-- CREATE MATERIALIZED VIEW                 0
-- CREATE SYNONYM                           0
-- CREATE TABLESPACE                        0
-- CREATE USER                              0
-- 
-- DROP TABLESPACE                          0
-- DROP DATABASE                            0
-- 
-- REDACTION POLICY                         0
-- 
-- ERRORS                                   0
-- WARNINGS                                 0

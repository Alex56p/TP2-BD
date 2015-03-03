------------------------------------------
--                                      --
--              Tables TP2              -- 
--                                      --
--     Par Anthony Labelle-Voyez et     --
--            Alexis Parent             --
------------------------------------------
DROP TABLE REPONSES;
DROP TABLE SCORES;
DROP TABLE QUESTIONS;
DROP TABLE MATCH;
DROP TABLE JOUEURS;
DROP TABLE CATEGORIES;

DROP SEQUENCE SEQ_Question;
DROP SEQUENCE SEQ_REPONSE;
DROP SEQUENCE SEQ_Match;

CREATE TABLE CATEGORIES
  (
    CodeCategorie CHAR (2) NOT NULL ,
    NomCategorie  VARCHAR2(30) ,
    Couleur       VARCHAR2(30)
  ) ;
ALTER TABLE Categories ADD CONSTRAINT Categories_PK PRIMARY KEY ( CodeCategorie ) ;

CREATE TABLE JOUEURS
  (
    UserName  VARCHAR2(30) NOT NULL ,
    Nom    VARCHAR2(30) ,
    Prenom VARCHAR2(30)
  ) ;
ALTER TABLE JOUEURS ADD CONSTRAINT JOUEURS_PK PRIMARY KEY ( UserName ) ;

CREATE TABLE MATCH
  (
    NumMatch NUMBER NOT NULL ,
    Joueur1  VARCHAR2(30) ,
    Joueur2  VARCHAR2(30) ,
    Joueur3  VARCHAR2(30) ,
    Joueur4  VARCHAR2(30) 
  ) ;
ALTER TABLE MATCH ADD CONSTRAINT MATCH_PK PRIMARY KEY ( NumMatch ) ;

CREATE TABLE QUESTIONS
  (
    NumQuestion    NUMBER NOT NULL ,
    EnonceQuestion VARCHAR2(150) ,
    Flag           CHAR (1) ,
    CodeCategorie  CHAR (2) NOT NULL
  ) ;
ALTER TABLE QUESTIONS ADD CONSTRAINT QUESTIONS_PK PRIMARY KEY ( NumQuestion ) ;

CREATE TABLE REPONSES
  (
    NumReponse  NUMBER NOT NULL ,
    Description VARCHAR2(50) ,
    EstBonne    CHAR (1) ,
    NumQuestion NUMBER NOT NULL
  ) ;
ALTER TABLE REPONSES ADD CONSTRAINT REPONSES_PK PRIMARY KEY ( NumReponse, NumQuestion ) ;

CREATE TABLE SCORES
  (
    CodeCategorie CHAR (2) NOT NULL ,
    UserName         VARCHAR2(30) NOT NULL ,
    Score         NUMBER ,
    NumMatch      NUMBER NOT NULL
  ) ;
ALTER TABLE SCORES ADD CONSTRAINT SCORES_PK PRIMARY KEY ( CodeCategorie, UserName, NumMatch ) ;

ALTER TABLE MATCH ADD CONSTRAINT MATCH_JOUEURS_FK FOREIGN KEY ( Joueur1 ) REFERENCES JOUEURS ( UserName ) ;

ALTER TABLE MATCH ADD CONSTRAINT MATCH_JOUEURS_FKv1 FOREIGN KEY ( Joueur3 ) REFERENCES JOUEURS ( UserName ) ;

ALTER TABLE MATCH ADD CONSTRAINT MATCH_JOUEURS_FKv2 FOREIGN KEY ( Joueur4 ) REFERENCES JOUEURS ( UserName ) ;

ALTER TABLE MATCH ADD CONSTRAINT MATCH_JOUEURS_FKv4 FOREIGN KEY ( Joueur2 ) REFERENCES JOUEURS ( UserName ) ;

ALTER TABLE QUESTIONS ADD CONSTRAINT QUESTIONS_Categories_FK FOREIGN KEY ( CodeCategorie ) REFERENCES Categories ( CodeCategorie ) ;

ALTER TABLE REPONSES ADD CONSTRAINT REPONSES_QUESTIONS_FK FOREIGN KEY ( NumQuestion ) REFERENCES QUESTIONS ( NumQuestion ) ;

ALTER TABLE SCORES ADD CONSTRAINT SCORES_Categories_FK FOREIGN KEY ( CodeCategorie ) REFERENCES Categories ( CodeCategorie ) ;

ALTER TABLE SCORES ADD CONSTRAINT SCORES_JOUEURS_FK FOREIGN KEY ( UserName ) REFERENCES JOUEURS ( UserName ) ;

ALTER TABLE SCORES ADD CONSTRAINT SCORES_MATCH_FK FOREIGN KEY ( NumMatch ) REFERENCES MATCH ( NumMatch ) ;

---------------------------------------------------------------------------------------------------------------

CREATE SEQUENCE SEQ_Question
increment by 1
Start with 1;


CREATE SEQUENCE SEQ_Reponse
Increment by 1
start with 1;

CREATE SEQUENCE SEQ_Match
Increment by 1
start with 1;
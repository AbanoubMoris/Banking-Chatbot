--------------------------------------------------------
--  File created - Tuesday-April-21-2020   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Sequence ACCOUNT_ID
--------------------------------------------------------

   CREATE SEQUENCE  "ACCOUNT_ID"  MINVALUE 1 MAXVALUE 99 INCREMENT BY 1 START WITH 41 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence BANKER_ID
--------------------------------------------------------

   CREATE SEQUENCE  "BANKER_ID"  MINVALUE 1 MAXVALUE 99 INCREMENT BY 1 START WITH 41 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence CARD_NO
--------------------------------------------------------

   CREATE SEQUENCE  "CARD_NO"  MINVALUE 1 MAXVALUE 9999999999999 INCREMENT BY 1 START WITH 41 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence CLIENT_SSN
--------------------------------------------------------

   CREATE SEQUENCE  "CLIENT_SSN"  MINVALUE 1 MAXVALUE 999 INCREMENT BY 1 START WITH 41 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence DEPARTMENTS_SEQ
--------------------------------------------------------

   CREATE SEQUENCE  "DEPARTMENTS_SEQ"  MINVALUE 1 MAXVALUE 9990 INCREMENT BY 10 START WITH 1 NOCACHE  NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence EMPLOYEES_SEQ
--------------------------------------------------------

   CREATE SEQUENCE  "EMPLOYEES_SEQ"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 NOCACHE  NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence LOAN_NO
--------------------------------------------------------

   CREATE SEQUENCE  "LOAN_NO"  MINVALUE 1 MAXVALUE 99 INCREMENT BY 1 START WITH 21 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence LOCATIONS_SEQ
--------------------------------------------------------

   CREATE SEQUENCE  "LOCATIONS_SEQ"  MINVALUE 1 MAXVALUE 9900 INCREMENT BY 100 START WITH 1 NOCACHE  NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence PAYMENT_NO
--------------------------------------------------------

   CREATE SEQUENCE  "PAYMENT_NO"  MINVALUE 1 MAXVALUE 999 INCREMENT BY 1 START WITH 41 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence TRANSACTION_NO
--------------------------------------------------------

   CREATE SEQUENCE  "TRANSACTION_NO"  MINVALUE 1 MAXVALUE 999 INCREMENT BY 1 START WITH 21 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Table ACCOUNT
--------------------------------------------------------

  CREATE TABLE "ACCOUNT" 
   (	"ACCOUNTID" NUMBER(2,0), 
	"ACCOUNTBALANCE" NUMBER(10,0), 
	"ACCOUNTPASSWORD" VARCHAR2(24 BYTE), 
	"ACCOUNTEMAILADDRESS" VARCHAR2(40 BYTE), 
	"CLIENTID" NUMBER(3,0), 
	"ACCOUNTTYPENAME" VARCHAR2(25 BYTE)
   ) ;
--------------------------------------------------------
--  DDL for Table ACCOUNTTYPE
--------------------------------------------------------

  CREATE TABLE "ACCOUNTTYPE" 
   (	"ACCOUNTTYPENAME" VARCHAR2(25 BYTE), 
	"ACCOUNTLIMIT" NUMBER(10,0), 
	"WITHDRAWLIMT" NUMBER(10,0), 
	"DEPOSITLIMIT" NUMBER(10,0)
   ) ;
--------------------------------------------------------
--  DDL for Table BANKER
--------------------------------------------------------

  CREATE TABLE "BANKER" 
   (	"BANKERID" NUMBER(2,0), 
	"BANKERFNAME" VARCHAR2(20 BYTE), 
	"BANKERLNAME" VARCHAR2(20 BYTE), 
	"BANKERNATIONALID" NUMBER(15,0), 
	"BANKERPHONENUMBER" NUMBER(14,0), 
	"BANKERADDRESS" VARCHAR2(50 BYTE), 
	"BANKERGENDER" CHAR(1 BYTE), 
	"BANKERPASSWORD" VARCHAR2(24 BYTE)
   ) ;
--------------------------------------------------------
--  DDL for Table CARD
--------------------------------------------------------

  CREATE TABLE "CARD" 
   (	"CARDNO" NUMBER(14,0), 
	"CARDENDDATE" DATE, 
	"CARDAMOUNT" NUMBER(8,0), 
	"ACCOUNTID" NUMBER(2,0), 
	"CARDSSN" NUMBER(3,0), 
	"CARDPIN" NUMBER(4,0)
   ) ;
--------------------------------------------------------
--  DDL for Table CLIENT
--------------------------------------------------------

  CREATE TABLE "CLIENT" 
   (	"CLIENTID" NUMBER(3,0), 
	"CLIENTFNAME" VARCHAR2(24 BYTE), 
	"CLIENTLNAME" VARCHAR2(24 BYTE), 
	"CLIENTPHONENUMBER" VARCHAR2(14 BYTE), 
	"CLIENTGENDER" CHAR(1 BYTE), 
	"CLIENTADDRESS" VARCHAR2(50 BYTE), 
	"CLIENTNATIONALID" NUMBER(15,0)
   ) ;
--------------------------------------------------------
--  DDL for Table LOAN
--------------------------------------------------------

  CREATE TABLE "LOAN" 
   (	"LOANNO" NUMBER(3,0), 
	"LOANTOTALAMOUNT" NUMBER(9,0), 
	"ACCOUNTID" NUMBER(2,0), 
	"INSTALLMENTMONTHS" NUMBER(2,0), 
	"LOANSTARTDATE" DATE, 
	"LASTPAYMENTDATE" DATE
   ) ;
--------------------------------------------------------
--  DDL for Table PAYMENT
--------------------------------------------------------

  CREATE TABLE "PAYMENT" 
   (	"PAYMENTNO" NUMBER(3,0), 
	"PAYMENTAMOUNT" NUMBER(9,0), 
	"PAYMENTDATE" DATE, 
	"LOANNO" NUMBER(3,0)
   ) ;
--------------------------------------------------------
--  DDL for Table REGISTRATION
--------------------------------------------------------

  CREATE TABLE "REGISTRATION" 
   (	"CLIENTID" NUMBER, 
	"BANKERID" NUMBER(2,0)
   ) ;
--------------------------------------------------------
--  DDL for Table TRANSACTION
--------------------------------------------------------

  CREATE TABLE "TRANSACTION" 
   (	"TRANSACTIONNO" NUMBER(3,0), 
	"TRANSACTIONTYPE" VARCHAR2(15 BYTE), 
	"TRANSACTIONAMOUNT" NUMBER(7,0), 
	"ACCOUNTID" NUMBER(2,0), 
	"TRANSACTIONDATE" DATE, 
	"ACCOUNTCURRUNTBALANCE" NUMBER(10,0)
   ) ;

---------------------------------------------------
--   DATA FOR TABLE BANKER
--   FILTER = none used
---------------------------------------------------
REM INSERTING into BANKER
Insert into BANKER (BANKERID,BANKERFNAME,BANKERLNAME,BANKERNATIONALID,BANKERPHONENUMBER,BANKERADDRESS,BANKERGENDER,BANKERPASSWORD) values (2,'Thomas','Hesham',30003249739204,1083927445,'Cairo , Egypt','M','1234567');
Insert into BANKER (BANKERID,BANKERFNAME,BANKERLNAME,BANKERNATIONALID,BANKERPHONENUMBER,BANKERADDRESS,BANKERGENDER,BANKERPASSWORD) values (22,'Ahmed','Mohamed',12345678900987,12345678990,'Cairo, Egypt','F','1234567');
Insert into BANKER (BANKERID,BANKERFNAME,BANKERLNAME,BANKERNATIONALID,BANKERPHONENUMBER,BANKERADDRESS,BANKERGENDER,BANKERPASSWORD) values (28,'Amina','Ahmed',84844884848474,23982389325,'Cairo','F','12345678');
Insert into BANKER (BANKERID,BANKERFNAME,BANKERLNAME,BANKERNATIONALID,BANKERPHONENUMBER,BANKERADDRESS,BANKERGENDER,BANKERPASSWORD) values (24,'Khaled','Mohammed',12345678976543,9876543212,'Cairo,Egypt','M','123594793');
Insert into BANKER (BANKERID,BANKERFNAME,BANKERLNAME,BANKERNATIONALID,BANKERPHONENUMBER,BANKERADDRESS,BANKERGENDER,BANKERPASSWORD) values (26,'Saed','Mostafa',43434343434343,43894389435,'Cairo,Egypt','M','1234567');

---------------------------------------------------
--   END DATA FOR TABLE BANKER
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE PAYMENT
--   FILTER = none used
---------------------------------------------------
REM INSERTING into PAYMENT
Insert into PAYMENT (PAYMENTNO,PAYMENTAMOUNT,PAYMENTDATE,LOANNO) values (21,220,to_timestamp('21-FEB-20 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),2);
Insert into PAYMENT (PAYMENTNO,PAYMENTAMOUNT,PAYMENTDATE,LOANNO) values (22,220,to_timestamp('21-MAR-20 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),2);

---------------------------------------------------
--   END DATA FOR TABLE PAYMENT
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE ACCOUNT
--   FILTER = none used
---------------------------------------------------
REM INSERTING into ACCOUNT
Insert into ACCOUNT (ACCOUNTID,ACCOUNTBALANCE,ACCOUNTPASSWORD,ACCOUNTEMAILADDRESS,CLIENTID,ACCOUNTTYPENAME) values (3,5000,'gsgss2','ahmed3@gmail.com',5,'PrePaid Account');
Insert into ACCOUNT (ACCOUNTID,ACCOUNTBALANCE,ACCOUNTPASSWORD,ACCOUNTEMAILADDRESS,CLIENTID,ACCOUNTTYPENAME) values (2,7044,'sekjer321$','mahmed32@outlook.com',5,'Student Account');

---------------------------------------------------
--   END DATA FOR TABLE ACCOUNT
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE CLIENT
--   FILTER = none used
---------------------------------------------------
REM INSERTING into CLIENT
Insert into CLIENT (CLIENTID,CLIENTFNAME,CLIENTLNAME,CLIENTPHONENUMBER,CLIENTGENDER,CLIENTADDRESS,CLIENTNATIONALID) values (8,'Ahmed','Gaber','129247783','M','ElObour, Egypt',200390909209303);
Insert into CLIENT (CLIENTID,CLIENTFNAME,CLIENTLNAME,CLIENTPHONENUMBER,CLIENTGENDER,CLIENTADDRESS,CLIENTNATIONALID) values (5,'Thomas','Khaled','106833243','M','Giza, Egypt',200043892843839);
Insert into CLIENT (CLIENTID,CLIENTFNAME,CLIENTLNAME,CLIENTPHONENUMBER,CLIENTGENDER,CLIENTADDRESS,CLIENTNATIONALID) values (6,'Ahmed','Mohammed','106833823','M','SA',200043892634839);
Insert into CLIENT (CLIENTID,CLIENTFNAME,CLIENTLNAME,CLIENTPHONENUMBER,CLIENTGENDER,CLIENTADDRESS,CLIENTNATIONALID) values (7,'Ahmed','Mohammed','106833123','M','Giza, Egypt',200043833234839);

---------------------------------------------------
--   END DATA FOR TABLE CLIENT
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE CARD
--   FILTER = none used
---------------------------------------------------
REM INSERTING into CARD
Insert into CARD (CARDNO,CARDENDDATE,CARDAMOUNT,ACCOUNTID,CARDSSN,CARDPIN) values (6,to_timestamp('25-MAY-20 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),2000,2,234,1234);
Insert into CARD (CARDNO,CARDENDDATE,CARDAMOUNT,ACCOUNTID,CARDSSN,CARDPIN) values (7,to_timestamp('25-MAY-20 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),2000,3,247,1234);

---------------------------------------------------
--   END DATA FOR TABLE CARD
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE ACCOUNTTYPE
--   FILTER = none used
---------------------------------------------------
REM INSERTING into ACCOUNTTYPE
Insert into ACCOUNTTYPE (ACCOUNTTYPENAME,ACCOUNTLIMIT,WITHDRAWLIMT,DEPOSITLIMIT) values ('Student Account',20000,5000,5000);
Insert into ACCOUNTTYPE (ACCOUNTTYPENAME,ACCOUNTLIMIT,WITHDRAWLIMT,DEPOSITLIMIT) values ('Bussnius Account',1000000,50000,250000);
Insert into ACCOUNTTYPE (ACCOUNTTYPENAME,ACCOUNTLIMIT,WITHDRAWLIMT,DEPOSITLIMIT) values ('PrePaid Account',500000,10000,50000);

---------------------------------------------------
--   END DATA FOR TABLE ACCOUNTTYPE
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE LOAN
--   FILTER = none used
---------------------------------------------------
REM INSERTING into LOAN
Insert into LOAN (LOANNO,LOANTOTALAMOUNT,ACCOUNTID,INSTALLMENTMONTHS,LOANSTARTDATE,LASTPAYMENTDATE) values (1,2000,2,2,to_timestamp('20-APR-20 11.11.12.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'),to_timestamp('20-APR-20 11.11.12.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'));
Insert into LOAN (LOANNO,LOANTOTALAMOUNT,ACCOUNTID,INSTALLMENTMONTHS,LOANSTARTDATE,LASTPAYMENTDATE) values (3,2000,2,2,to_timestamp('20-APR-20 11.13.13.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'),to_timestamp('20-APR-20 11.13.13.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'));
Insert into LOAN (LOANNO,LOANTOTALAMOUNT,ACCOUNTID,INSTALLMENTMONTHS,LOANSTARTDATE,LASTPAYMENTDATE) values (2,2000,2,10,to_timestamp('21-JAN-20 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),to_timestamp('21-APR-20 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'));

---------------------------------------------------
--   END DATA FOR TABLE LOAN
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE REGISTRATION
--   FILTER = none used
---------------------------------------------------
REM INSERTING into REGISTRATION
Insert into REGISTRATION (CLIENTID,BANKERID) values (5,2);

---------------------------------------------------
--   END DATA FOR TABLE REGISTRATION
---------------------------------------------------

---------------------------------------------------
--   DATA FOR TABLE TRANSACTION
--   FILTER = none used
---------------------------------------------------
REM INSERTING into TRANSACTION
Insert into TRANSACTION (TRANSACTIONNO,TRANSACTIONTYPE,TRANSACTIONAMOUNT,ACCOUNTID,TRANSACTIONDATE,ACCOUNTCURRUNTBALANCE) values (1,'Deposit',2000,2,to_timestamp('19-APR-20 11.37.07.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'),7000);
Insert into TRANSACTION (TRANSACTIONNO,TRANSACTIONTYPE,TRANSACTIONAMOUNT,ACCOUNTID,TRANSACTIONDATE,ACCOUNTCURRUNTBALANCE) values (21,'Deposit',2000,3,to_timestamp('13-APR-20 09.36.50.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'),2000);
Insert into TRANSACTION (TRANSACTIONNO,TRANSACTIONTYPE,TRANSACTIONAMOUNT,ACCOUNTID,TRANSACTIONDATE,ACCOUNTCURRUNTBALANCE) values (2,'Deposit',2500,2,to_timestamp('10-APR-20 12.00.00.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),25000);
Insert into TRANSACTION (TRANSACTIONNO,TRANSACTIONTYPE,TRANSACTIONAMOUNT,ACCOUNTID,TRANSACTIONDATE,ACCOUNTCURRUNTBALANCE) values (61,'Deposit',1598,2,to_timestamp('14-APR-20 06.13.03.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),1598);
Insert into TRANSACTION (TRANSACTIONNO,TRANSACTIONTYPE,TRANSACTIONAMOUNT,ACCOUNTID,TRANSACTIONDATE,ACCOUNTCURRUNTBALANCE) values (62,'Deposit',1111,2,to_timestamp('14-APR-20 06.18.49.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),2709);
Insert into TRANSACTION (TRANSACTIONNO,TRANSACTIONTYPE,TRANSACTIONAMOUNT,ACCOUNTID,TRANSACTIONDATE,ACCOUNTCURRUNTBALANCE) values (63,'Deposit',1122,2,to_timestamp('14-APR-20 06.25.25.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),3831);
Insert into TRANSACTION (TRANSACTIONNO,TRANSACTIONTYPE,TRANSACTIONAMOUNT,ACCOUNTID,TRANSACTIONDATE,ACCOUNTCURRUNTBALANCE) values (64,'Deposit',1166,2,to_timestamp('14-APR-20 06.29.45.000000000 AM','DD-MON-RR HH.MI.SS.FF AM'),4997);
Insert into TRANSACTION (TRANSACTIONNO,TRANSACTIONTYPE,TRANSACTIONAMOUNT,ACCOUNTID,TRANSACTIONDATE,ACCOUNTCURRUNTBALANCE) values (3,'Deposit',5000,2,to_timestamp('20-APR-20 09.34.22.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'),10000);
Insert into TRANSACTION (TRANSACTIONNO,TRANSACTIONTYPE,TRANSACTIONAMOUNT,ACCOUNTID,TRANSACTIONDATE,ACCOUNTCURRUNTBALANCE) values (4,'Deposit',2000,2,to_timestamp('20-APR-20 10.14.49.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'),7000);
Insert into TRANSACTION (TRANSACTIONNO,TRANSACTIONTYPE,TRANSACTIONAMOUNT,ACCOUNTID,TRANSACTIONDATE,ACCOUNTCURRUNTBALANCE) values (5,'Deposit',2000,2,to_timestamp('20-APR-20 10.17.20.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'),7000);
Insert into TRANSACTION (TRANSACTIONNO,TRANSACTIONTYPE,TRANSACTIONAMOUNT,ACCOUNTID,TRANSACTIONDATE,ACCOUNTCURRUNTBALANCE) values (6,'Deposit',2044,2,to_timestamp('20-APR-20 10.18.44.000000000 PM','DD-MON-RR HH.MI.SS.FF AM'),7044);

---------------------------------------------------
--   END DATA FOR TABLE TRANSACTION
---------------------------------------------------
--------------------------------------------------------
--  Constraints for Table ACCOUNT
--------------------------------------------------------

  ALTER TABLE "ACCOUNT" ADD PRIMARY KEY ("ACCOUNTID") ENABLE;
 
  ALTER TABLE "ACCOUNT" MODIFY ("ACCOUNTBALANCE" NOT NULL ENABLE);
 
  ALTER TABLE "ACCOUNT" MODIFY ("ACCOUNTPASSWORD" NOT NULL ENABLE);
 
  ALTER TABLE "ACCOUNT" MODIFY ("ACCOUNTEMAILADDRESS" NOT NULL ENABLE);
 
  ALTER TABLE "ACCOUNT" MODIFY ("CLIENTID" NOT NULL ENABLE);
 
  ALTER TABLE "ACCOUNT" MODIFY ("ACCOUNTTYPENAME" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table ACCOUNTTYPE
--------------------------------------------------------

  ALTER TABLE "ACCOUNTTYPE" ADD CONSTRAINT "ACCOUNTTYPE_CHECK" CHECK (ACCOUNTTYPENAME in ('Student Account','PrePaid Account','Bussnius Account')) ENABLE;
 
  ALTER TABLE "ACCOUNTTYPE" MODIFY ("ACCOUNTLIMIT" NOT NULL ENABLE);
 
  ALTER TABLE "ACCOUNTTYPE" MODIFY ("WITHDRAWLIMT" NOT NULL ENABLE);
 
  ALTER TABLE "ACCOUNTTYPE" MODIFY ("DEPOSITLIMIT" NOT NULL ENABLE);
 
  ALTER TABLE "ACCOUNTTYPE" ADD PRIMARY KEY ("ACCOUNTTYPENAME") ENABLE;
--------------------------------------------------------
--  Constraints for Table BANKER
--------------------------------------------------------

  ALTER TABLE "BANKER" ADD CONSTRAINT "BANKER_UK1" UNIQUE ("BANKERNATIONALID") ENABLE;
 
  ALTER TABLE "BANKER" ADD CONSTRAINT "GENDER_CHECK_BANKER" CHECK (BankerGender in ('F','M')) ENABLE;
 
  ALTER TABLE "BANKER" ADD PRIMARY KEY ("BANKERID") ENABLE;
 
  ALTER TABLE "BANKER" MODIFY ("BANKERFNAME" NOT NULL ENABLE);
 
  ALTER TABLE "BANKER" MODIFY ("BANKERLNAME" NOT NULL ENABLE);
 
  ALTER TABLE "BANKER" MODIFY ("BANKERNATIONALID" NOT NULL ENABLE);
 
  ALTER TABLE "BANKER" MODIFY ("BANKERPHONENUMBER" NOT NULL ENABLE);
 
  ALTER TABLE "BANKER" MODIFY ("BANKERADDRESS" NOT NULL ENABLE);
 
  ALTER TABLE "BANKER" MODIFY ("BANKERGENDER" NOT NULL ENABLE);
 
  ALTER TABLE "BANKER" MODIFY ("BANKERPASSWORD" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table CARD
--------------------------------------------------------

  ALTER TABLE "CARD" ADD PRIMARY KEY ("CARDNO") ENABLE;
 
  ALTER TABLE "CARD" MODIFY ("CARDENDDATE" NOT NULL ENABLE);
 
  ALTER TABLE "CARD" MODIFY ("CARDAMOUNT" NOT NULL ENABLE);
 
  ALTER TABLE "CARD" MODIFY ("ACCOUNTID" NOT NULL ENABLE);
 
  ALTER TABLE "CARD" MODIFY ("CARDSSN" NOT NULL ENABLE);
 
  ALTER TABLE "CARD" MODIFY ("CARDPIN" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table CLIENT
--------------------------------------------------------

  ALTER TABLE "CLIENT" ADD CONSTRAINT "CLIENT_UK1" UNIQUE ("CLIENTNATIONALID") ENABLE;
 
  ALTER TABLE "CLIENT" ADD CONSTRAINT "GENDER_CHECK_CLIENT" CHECK (ClientGender in ('F','M')) ENABLE;
 
  ALTER TABLE "CLIENT" ADD PRIMARY KEY ("CLIENTID") ENABLE;
 
  ALTER TABLE "CLIENT" MODIFY ("CLIENTFNAME" NOT NULL ENABLE);
 
  ALTER TABLE "CLIENT" MODIFY ("CLIENTLNAME" NOT NULL ENABLE);
 
  ALTER TABLE "CLIENT" MODIFY ("CLIENTPHONENUMBER" NOT NULL ENABLE);
 
  ALTER TABLE "CLIENT" MODIFY ("CLIENTGENDER" NOT NULL ENABLE);
 
  ALTER TABLE "CLIENT" MODIFY ("CLIENTADDRESS" NOT NULL ENABLE);
 
  ALTER TABLE "CLIENT" MODIFY ("CLIENTNATIONALID" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table LOAN
--------------------------------------------------------

  ALTER TABLE "LOAN" ADD PRIMARY KEY ("LOANNO") ENABLE;
 
  ALTER TABLE "LOAN" MODIFY ("LOANTOTALAMOUNT" NOT NULL ENABLE);
 
  ALTER TABLE "LOAN" MODIFY ("ACCOUNTID" NOT NULL ENABLE);
 
  ALTER TABLE "LOAN" MODIFY ("INSTALLMENTMONTHS" NOT NULL ENABLE);
 
  ALTER TABLE "LOAN" MODIFY ("LOANSTARTDATE" NOT NULL ENABLE);
 
  ALTER TABLE "LOAN" MODIFY ("LASTPAYMENTDATE" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table PAYMENT
--------------------------------------------------------

  ALTER TABLE "PAYMENT" ADD PRIMARY KEY ("PAYMENTNO") ENABLE;
 
  ALTER TABLE "PAYMENT" MODIFY ("PAYMENTAMOUNT" NOT NULL ENABLE);
 
  ALTER TABLE "PAYMENT" MODIFY ("PAYMENTDATE" NOT NULL ENABLE);
 
  ALTER TABLE "PAYMENT" MODIFY ("LOANNO" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table REGISTRATION
--------------------------------------------------------

  ALTER TABLE "REGISTRATION" ADD CONSTRAINT "REGISTRATIONID" PRIMARY KEY ("CLIENTID", "BANKERID") ENABLE;
 
  ALTER TABLE "REGISTRATION" MODIFY ("CLIENTID" NOT NULL ENABLE);
 
  ALTER TABLE "REGISTRATION" MODIFY ("BANKERID" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table TRANSACTION
--------------------------------------------------------

  ALTER TABLE "TRANSACTION" ADD PRIMARY KEY ("TRANSACTIONNO") ENABLE;
 
  ALTER TABLE "TRANSACTION" MODIFY ("TRANSACTIONTYPE" NOT NULL ENABLE);
 
  ALTER TABLE "TRANSACTION" MODIFY ("TRANSACTIONAMOUNT" NOT NULL ENABLE);
 
  ALTER TABLE "TRANSACTION" MODIFY ("ACCOUNTID" NOT NULL ENABLE);
 
  ALTER TABLE "TRANSACTION" MODIFY ("TRANSACTIONDATE" NOT NULL ENABLE);
 
  ALTER TABLE "TRANSACTION" MODIFY ("ACCOUNTCURRUNTBALANCE" NOT NULL ENABLE);
 
  ALTER TABLE "TRANSACTION" ADD CONSTRAINT "TRANSTYPE_CHECK" CHECK (TRANSACTIONTYPE in ('Withdraw','Deposit')) ENABLE;
--------------------------------------------------------
--  DDL for Index BANKER_UK1
--------------------------------------------------------

  CREATE UNIQUE INDEX "BANKER_UK1" ON "BANKER" ("BANKERNATIONALID") 
  ;
--------------------------------------------------------
--  DDL for Index CLIENT_UK1
--------------------------------------------------------

  CREATE UNIQUE INDEX "CLIENT_UK1" ON "CLIENT" ("CLIENTNATIONALID") 
  ;
--------------------------------------------------------
--  DDL for Index REGISTRATIONID
--------------------------------------------------------

  CREATE UNIQUE INDEX "REGISTRATIONID" ON "REGISTRATION" ("CLIENTID", "BANKERID") 
  ;
--------------------------------------------------------
--  Ref Constraints for Table ACCOUNT
--------------------------------------------------------

  ALTER TABLE "ACCOUNT" ADD FOREIGN KEY ("ACCOUNTTYPENAME")
	  REFERENCES "ACCOUNTTYPE" ("ACCOUNTTYPENAME") ON DELETE CASCADE ENABLE;
 
  ALTER TABLE "ACCOUNT" ADD FOREIGN KEY ("CLIENTID")
	  REFERENCES "CLIENT" ("CLIENTID") ON DELETE CASCADE ENABLE;


--------------------------------------------------------
--  Ref Constraints for Table CARD
--------------------------------------------------------

  ALTER TABLE "CARD" ADD FOREIGN KEY ("ACCOUNTID")
	  REFERENCES "ACCOUNT" ("ACCOUNTID") ON DELETE CASCADE ENABLE;

--------------------------------------------------------
--  Ref Constraints for Table LOAN
--------------------------------------------------------

  ALTER TABLE "LOAN" ADD FOREIGN KEY ("ACCOUNTID")
	  REFERENCES "ACCOUNT" ("ACCOUNTID") ON DELETE CASCADE ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table PAYMENT
--------------------------------------------------------

  ALTER TABLE "PAYMENT" ADD FOREIGN KEY ("LOANNO")
	  REFERENCES "LOAN" ("LOANNO") ON DELETE CASCADE ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table REGISTRATION
--------------------------------------------------------

  ALTER TABLE "REGISTRATION" ADD FOREIGN KEY ("CLIENTID")
	  REFERENCES "CLIENT" ("CLIENTID") ON DELETE CASCADE ENABLE;
 
  ALTER TABLE "REGISTRATION" ADD FOREIGN KEY ("BANKERID")
	  REFERENCES "BANKER" ("BANKERID") ON DELETE CASCADE ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table TRANSACTION
--------------------------------------------------------

  ALTER TABLE "TRANSACTION" ADD FOREIGN KEY ("ACCOUNTID")
	  REFERENCES "ACCOUNT" ("ACCOUNTID") ON DELETE CASCADE ENABLE;
--------------------------------------------------------
--  DDL for Procedure CHECKCARDNUMPIN
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "CHECKCARDNUMPIN" (cardnum IN CARD.CARDNO%TYPE,
pinin in CARD.CARDPIN%type,
cardnumout out CARD.CARDNO%TYPE
)
IS
BEGIN

  SELECT c.cardno
  into cardnumout
  from CARD c
  where c.cardno = cardnum and c.cardpin = pinin ;
  exception when NO_DATA_FOUND
  then dbms_output.put_line ('User not found, Register first!'); 
END;

/

--------------------------------------------------------
--  DDL for Procedure CHECKDATA
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "CHECKDATA" (nationalid IN BANKER.BANKERNATIONALID%TYPE,
pass in BANKER.bankerpassword%type ,
national_id out BANKER.BANKERNATIONALID%TYPE,
passw out BANKER.bankerpassword%type,
fName out BANKER.BANKERFNAME%type
)
IS
BEGIN

  SELECT b.bankernationalid, b.bankerpassword , b.bankerfname
  into national_id , passw , fName
  from banker b
  where b.bankernationalid = nationalid 
  and   b.bankerpassword = pass;
  exception when NO_DATA_FOUND
  then dbms_output.put_line ('User not found, Register first!'); 

  COMMIT;

END;

/

--------------------------------------------------------
--  DDL for Procedure CHECKUSERDATA
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "CHECKUSERDATA" (nationalid IN BANKER.BANKERNATIONALID%TYPE,
pass in BANKER.bankerpassword%type ,
national_id out BANKER.BANKERNATIONALID%TYPE,
passw out BANKER.bankerpassword%type,
fName out BANKER.BANKERFNAME%type
)
IS
BEGIN

  SELECT c.clientnationalid , a.accountpassword  , c.clientfname
  into national_id , passw , fName
  from client c , account a
  where c.clientnationalid = nationalid 
  and  a.accountpassword  = pass and a.clientid = c.clientid;
  exception when NO_DATA_FOUND
  then dbms_output.put_line ('User not found, Register first!'); 

  COMMIT;

END;

/

--------------------------------------------------------
--  DDL for Procedure DELETEACCOUNT
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "DELETEACCOUNT" (num in NUMBER) is 
a NUMBER;
begin
select accountid into a from card where cardno= num;
delete from card where accountid = a;
delete from transaction where accountid = a;
delete from account where accountid = a;
end;

/

--------------------------------------------------------
--  DDL for Procedure GETACCOUNTFROMCARDNO
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "GETACCOUNTFROMCARDNO" (cardID in card.CARDNO% TYPE , ACCOUNTID out account.ACCOUNTID% TYPE)
as
begin
select card.ACCOUNTID into ACCOUNTID
from card
WHERe rownum <= 1 and card.cardno= cardID ;

COMMIT;

end;

/

--------------------------------------------------------
--  DDL for Procedure GETACCOUNTID
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "GETACCOUNTID" (
CID in ACCOUNT.ACCOUNTID%type,
id out CARD.ACCOUNTID%type
)
IS
BEGIN

  SELECT a.accountid
  into id
  from account a 
  where a.clientid = CID;
  exception when NO_DATA_FOUND
  then dbms_output.put_line ('User not found, Register first!'); 

  COMMIT;

END;

/

--------------------------------------------------------
--  DDL for Procedure GETBANKERID
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "GETBANKERID" (
NID in BANKER.BANKERNATIONALID%type,
BID out BANKER.BANKERID%type
)
IS
BEGIN

  SELECT b.bankerid 
  into BID 
  from banker b
  where b.bankernationalid = NID;
  exception when NO_DATA_FOUND
  then dbms_output.put_line ('User not found, Register first!'); 

  COMMIT;

END;

/

--------------------------------------------------------
--  DDL for Procedure GETCARDFROMACCOUNTID
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "GETCARDFROMACCOUNTID" (AccountI in NUMBER , accounts out sys_refcursor)
as
begin
open accounts for   
select CARDNO
from card 
WHERE card.ACCOUNTID = AccountI;

end;

/

--------------------------------------------------------
--  DDL for Procedure GETCARDNO
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "GETCARDNO" (CardNum in NUMBER,cards out sys_refcursor)
as 
BEGIN
open cards for 
select CARDNO, CARDENDDATE, CARDAMOUNT ,CARDSSN ,CARDPIN 
from card
where card.CARDNO = CardNum;
end;

/

--------------------------------------------------------
--  DDL for Procedure GETCLIENTACCOUNTS
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "GETCLIENTACCOUNTS" (cardID in card.CARDNO% TYPE , CID out client.clientid% TYPE)
as
begin
select CLIENTID into cid
from account , card
WHERe rownum <= 1 and account.ACCOUNTID = (SELECT accountid
                            FROM card
                            WHERE ROWNUM <= 1)
and card.cardno= cardID ;

COMMIT;

end;

/

--------------------------------------------------------
--  DDL for Procedure GETCLIENTACCOUNTSFROMCLIENT
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "GETCLIENTACCOUNTSFROMCLIENT" (CLIENTIDss in NUMBER , accounts out sys_refcursor)
as
begin
open accounts for 
select ACCOUNTID,ACCOUNTBALANCE,ACCOUNTEMAILADDRESS,ACCOUNTTYPENAME
from account 
WHERE account.CLIENTID = CLIENTIDss;

end;

/

--------------------------------------------------------
--  DDL for Procedure GETCLIENTID
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "GETCLIENTID" (
NID in BANKER.BANKERNATIONALID%type,
id out CLIENT.CLIENTID%type
)
IS
BEGIN

  SELECT c.clientid
  into id
  from CLIENT c 
  where c.clientnationalid = NID;
  exception when NO_DATA_FOUND
  then dbms_output.put_line ('User not found, Register first!'); 

  COMMIT;

END;

/

--------------------------------------------------------
--  DDL for Procedure GETDATA
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "GETDATA" (
NID in BANKER.BANKERNATIONALID%type,
fName out BANKER.BANKERFNAME%type,
lName out BANKER.BANKERLNAME%type,
nationalid out BANKER.BANKERNATIONALID%TYPE,
phoneNumber out BANKER.BANKERPHONENUMBER%type,
address out BANKER.BANKERADDRESS%type,
gender out BANKER.BANKERGENDER%type,
pass out BANKER.bankerpassword%type 
)
IS
BEGIN

  SELECT b.bankerfname , b.bankerlname ,b.bankernationalid, b.bankerphonenumber , b.bankeraddress , b.bankergender ,  b.bankerpassword
  into fName , lName , nationalid , phoneNumber , address , gender , pass
  from banker b
  where b.bankernationalid = NID;
  exception when NO_DATA_FOUND
  then dbms_output.put_line ('User not found, Register first!'); 

  COMMIT;

END;

/

--------------------------------------------------------
--  DDL for Procedure GETLASTTRANS
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "GETLASTTRANS" (cardnum in NUMBER, trans out sys_refcursor)
as
begin
open trans for
select transactionamount ,transactiontype , transactiondate
from transaction INNER join card on card.cardno = cardnum and card.accountid = transaction.accountid
where extract(MONTH from transactiondate) = extract(month from sysdate);
end;

/

--------------------------------------------------------
--  DDL for Procedure GETPAYMENTNO
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "GETPAYMENTNO" 
(PaymentNum OUT NUMBER)
AS
BEGIN
  select max(paymentno)
  into PaymentNum
  from payment;
END GETPAYMENTNO;

/

--------------------------------------------------------
--  DDL for Procedure GetAccountByCardNo
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "GetAccountByCardNo" (CardNo in NUMBER , accounts out sys_refcursor)
as
begin
open accounts for 
select  CARDNO, CARDENDDATE, CARDAMOUNT ,ACCOUNTID,CARDSSN ,CARDPIN 
from card 
WHERE card.CARDNO = CardNo;

end;

/

--------------------------------------------------------
--  DDL for Procedure GetClientIdFromCardId
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "GetClientIdFromCardId" (cardID in card.CARDNO% TYPE , CID out client.clientid% TYPE)
as
--AccountID NUMBER:=0;
begin

select CLIENTID into cid
from account , card
WHERe rownum <= 1 and account.ACCOUNTID = (SELECT accountid
                            FROM card
                            WHERE ROWNUM <= 1)
and card.cardno= cardID ;

COMMIT;

END;

/

--------------------------------------------------------
--  DDL for Procedure INSERTACCOUNT
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "INSERTACCOUNT" (
accountbalance in ACCOUNT.ACCOUNTBALANCE%type ,
pass in ACCOUNT.ACCOUNTPASSWORD%TYPE,
email in ACCOUNT.ACCOUNTEMAILADDRESS%type,
c_id in ACCOUNT.CLIENTID%type,
accounttype in ACCOUNT.ACCOUNTTYPENAME%type
)
IS
BEGIN

INSERT INTO ACCOUNT (ACCOUNTID,
ACCOUNTBALANCE,
ACCOUNTPASSWORD, 
ACCOUNTEMAILADDRESS, 
CLIENTID,
ACCOUNTTYPENAME
) 
VALUES (ACCOUNT_ID.nextval,
accountbalance, 
pass,
email, 
c_id,
accounttype
);
COMMIT;

END;

/

--------------------------------------------------------
--  DDL for Procedure INSERTBANKER
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "INSERTBANKER" (
	   fname IN BANKER.BANKERFNAME%TYPE,
	   lname IN BANKER.BANKERLNAME%TYPE,
	   nationalid IN BANKER.BANKERNATIONALID%TYPE,
	   phonenumber IN BANKER.BANKERPHONENUMBER%TYPE,
     address IN BANKER.BANKERADDRESS%TYPE,
     gender IN BANKER.BANKERGENDER%TYPE,
     password IN BANKER.BANKERPASSWORD%TYPE
     )
IS
BEGIN

  INSERT INTO BANKER (bankerid,BANKERFNAME, BANKERLNAME, BANKERNATIONALID, BANKERPHONENUMBER,BANKERADDRESS,BANKERGENDER,BANKERPASSWORD) 
  VALUES (BANKER_ID.nextval,fname, lname,nationalid, phonenumber,address,gender,password);

  COMMIT;

END;

/

--------------------------------------------------------
--  DDL for Procedure INSERTCARD
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "INSERTCARD" (
cardenddate in CARD.CARDENDDATE%type ,
cardamount in CARD.CARDAMOUNT%TYPE,
account_id in CARD.ACCOUNTID%type,
pin in CARD.CARDPIN%type
)
IS
BEGIN

INSERT INTO CARD (CARDNO, cardenddate, cardamount, accountid, cardssn, cardpin) 
VALUES (card_no.nextval,
cardenddate, 
cardamount, 
account_id,
CLIENT_SSN.nextval, 
pin
);
COMMIT;

END;

/

--------------------------------------------------------
--  DDL for Procedure INSERTCLIENT
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "INSERTCLIENT" (
fname IN CLIENT.CLIENTFNAME%TYPE,
lname in CLIENT.CLIENTLNAME%type ,
phonenumber in CLIENT.CLIENTPHONENUMBER%TYPE,
gender in CLIENT.CLIENTGENDER%type,
address in CLIENT.CLIENTADDRESS%type,
nationalid in CLIENT.CLIENTNATIONALID%type
)
IS
BEGIN

INSERT INTO CLIENT (CLIENTID,
CLIENTFNAME,
CLIENTLNAME, 
CLIENTPHONENUMBER, 
CLIENTGENDER,
CLIENTADDRESS,
CLIENTNATIONALID
) 
VALUES (CLIENT_SSN.nextval,
fname, 
lname,
phonenumber, 
gender,
address,
nationalid
);
 
  
  

  COMMIT;

END;

/

--------------------------------------------------------
--  DDL for Procedure INSERT_PAYMENT
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "INSERT_PAYMENT" 
( PNum NUMBER
, PAmmount NUMBER
, PDate DATE
, LoanNum NUMBER
) AS
BEGIN
  insert into payment
  (paymentno, paymentamount, paymentdate, loanno)
  values(pnum, pammount, pdate, loannum);
END INSERT_PAYMENT;

/

--------------------------------------------------------
--  DDL for Procedure MAKETRANSACTION
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "MAKETRANSACTION" (
TRANSACTIONTYPE varchar,
TRANSACTIONAMOUNT number,
ACCOUNTID number,
ACCOUNTCURRUNTBALANCE NUMBER
)
as BEGIN
  Insert into TRANSACTION (TRANSACTIONNO,TRANSACTIONTYPE,TRANSACTIONAMOUNT,ACCOUNTID,TRANSACTIONDATE,ACCOUNTCURRUNTBALANCE) 
  values (TRANSACTION_NO.NEXTVAL,TRANSACTIONTYPE,TRANSACTIONAMOUNT,ACCOUNTID, sysdate,ACCOUNTCURRUNTBALANCE);
  
end;

/

--------------------------------------------------------
--  DDL for Procedure REQLOAN
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "REQLOAN" (cardnum in NUMBER ,loanamount in NUMBER , install in NUMBER)
is
a NUMBER;
begin
select accountid into a from card where cardno = cardnum;
insert into loan values(LOAN_NO.nextval, loanamount, a , install , current_date , current_date );
end;

/

--------------------------------------------------------
--  DDL for Procedure UPDATEACCOUTBALANCE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "UPDATEACCOUTBALANCE" (accountid1 in account.ACCOUNTID%TYPE,Balance1 in account.ACCOUNTBALANCE% TYPE)
as 
BEGIN
UPDATE account
SET account.ACCOUNTBALANCE = balance1
WHERE account.ACCOUNTID = accountid1;
end;

/

--------------------------------------------------------
--  DDL for Procedure UPDATEBANKERDATA
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "UPDATEBANKERDATA" (
nationalid IN BANKER.BANKERNATIONALID%TYPE,
fname in BANKER.BANKERFNAME%type ,
lname in BANKER.BANKERLNAME%TYPE,
phoneNumber in BANKER.BANKERPHONENUMBER%type,
address in BANKER.BANKERADDRESS%type,
pass in BANKER.BANKERPASSWORD%type
)
IS
BEGIN

  update banker b
  set b.bankerfname = fname , b.bankerlname = lname  , b.BANKERPHONENUMBER  = phonenumber , b.BANKERADDRESS = address  , b.BANKERPASSWORD = pass
  where b.bankernationalid = nationalid ;
  

  COMMIT;

END;

/

--------------------------------------------------------
--  DDL for Procedure UPDATE_ACCOUNT
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "UPDATE_ACCOUNT" 
(accID  NUMBER, email  VARCHAR2, pass  VARCHAR2)
AS
BEGIN
  UPDATE Account
  set ACCOUNTPASSWORD = pass, accountemailaddress = email
  where accountid = accID;
END UPDATE_ACCOUNT;

/


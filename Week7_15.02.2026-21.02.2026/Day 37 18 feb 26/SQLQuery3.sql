create database insurance;
use insurance;



create table address_details(
    address_id int primary key,
    h_no varchar(6),
    city varchar(50),
    addressline1 varchar(50),
    state varchar(50),
    pin varchar(10)
);

create table user_details(
    user_id int primary key,
    firstname varchar(50),
    lastname varchar(50),
    email varchar(50),
    mobileno varchar(15),
    address_id int,
    dob date,
    constraint fk_user_address
        foreign key(address_id) references address_details(address_id)
);

create table ref_policy_types(
    policy_type_code varchar(10) primary key,
    policy_type_name varchar(50)
);

create table policy_sub_types(
    policy_type_id varchar(10) primary key,
    policy_type_code varchar(10),
    description varchar(50),
    yearsofpayements int,
    amount decimal(12,2),
    maturityperiod int,
    maturityamount decimal(12,2),
    validity int,
    constraint fk_policytype
        foreign key(policy_type_code) references ref_policy_types(policy_type_code)
);

create table user_policies(
    policy_no varchar(20) primary key,
    user_id int,
    date_registered date,
    policy_type_id varchar(10),
    constraint fk_policy_user
        foreign key(user_id) references user_details(user_id),
    constraint fk_policy_subtype
        foreign key(policy_type_id) references policy_sub_types(policy_type_id)
);

create table policy_payments(
    receipno int primary key,
    user_id int,
    policy_no varchar(20),
    dateofpayment date,
    amount decimal(12,2),
    fine decimal(12,2),
    constraint fk_payment_user
        foreign key(user_id) references user_details(user_id),
    constraint fk_payment_policy
        foreign key(policy_no) references user_policies(policy_no)
);

-- ========================
-- INSERT DATA
-- ========================

insert into address_details values(1,'6-21','hyderabad','kphb','andhrapradesh','1254');
insert into address_details values(2,'7-81','chennai','seruseri','tamilnadu','16354');
insert into address_details values(3,'3-71','lucknow','street','uttarpradesh','86451');
insert into address_details values(4,'4-81','mumbai','iroli','maharashtra','51246');
insert into address_details values(5,'5-81','bangalore','mgroad','karnataka','125465');
insert into address_details values(6,'6-81','ahamadabad','street2','gujarat','125423');
insert into address_details values(7,'9-21','chennai','sholinganur','tamilnadu','654286');

insert into user_details values(1111,'raju','reddy','raju@gmail.com','9854261456',4,'1986-04-11');
insert into user_details values(2222,'vamsi','krishna','vamsi@gmail.com','9854261463',1,'1990-04-11');
insert into user_details values(3333,'naveen','reddy','naveen@gmail.com','9854261496',4,'1985-03-14');
insert into user_details values(4444,'raghava','rao','raghava@gmail.com','9854261412',4,'1985-09-21');
insert into user_details values(5555,'harsha','vardhan','harsha@gmail.com','9854261445',4,'1992-10-11');

insert into ref_policy_types values('58934','car');
insert into ref_policy_types values('58539','home');
insert into ref_policy_types values('58683','life');

insert into policy_sub_types values('6893','58934','theft',1,5000.00,null,200000.00,1);
insert into policy_sub_types values('6894','58934','accident',1,20000.00,null,200000.00,3);
insert into policy_sub_types values('6895','58539','fire',1,50000.00,null,500000.00,3);
insert into policy_sub_types values('6896','58683','anandhlife',7,50000.00,15,1500000.00,null);
insert into policy_sub_types values('6897','58683','sukhlife',10,5000.00,13,300000.00,null);

insert into user_policies values('689314',1111,'1994-04-18','6896');
insert into user_policies values('689316',1111,'2012-05-18','6895');
insert into user_policies values('689317',1111,'2012-06-20','6894');
insert into user_policies values('689318',2222,'2012-06-21','6894');
insert into user_policies values('689320',3333,'2012-06-18','6894');
insert into user_policies values('689420',4444,'2012-04-09','6896');

insert into policy_payments values(121,4444,'689420','2012-04-09',50000.00,null);
insert into policy_payments values(345,4444,'689420','2013-04-09',50000.00,null);
insert into policy_payments values(300,1111,'689317','2012-06-20',20000.00,null);
insert into policy_payments values(225,1111,'689316','2012-05-18',20000.00,null);
insert into policy_payments values(227,1111,'689314','1994-04-18',50000.00,null);
insert into policy_payments values(100,1111,'689314','1995-04-10',50000.00,null);
insert into policy_payments values(128,1111,'689314','1996-04-11',50000.00,null);
insert into policy_payments values(96,1111,'689314','1997-04-18',50000.00,200.00);
insert into policy_payments values(101,1111,'689314','1998-04-09',50000.00,null);
insert into policy_payments values(105,1111,'689314','1999-04-08',50000.00,null);
insert into policy_payments values(120,1111,'689314','2000-04-05',50000.00,null);
insert into policy_payments values(367,2222,'689318','2012-06-21',20000.00,null);
insert into policy_payments values(298,3333,'689320','2012-06-18',20000.00,null);

SELECT ps.policy_type_id, rp.policy_type_name, ps.description
FROM policy_sub_types ps
JOIN ref_policy_types rp ON ps.policy_type_code = rp.policy_type_code
WHERE rp.policy_type_name = 'car';

SELECT ps.policy_type_code,
       COUNT(up.policy_no) AS NO_OF_POLICIES
FROM user_policies up
JOIN policy_sub_types ps
ON up.policy_type_id = ps.policy_type_id
GROUP BY ps.policy_type_code;

SELECT u.user_id,
       u.firstname,
       u.lastname,
       u.email,
       u.mobileno
FROM user_details u
JOIN address_details a
ON u.address_id = a.address_id
WHERE a.city = 'chennai';

SELECT u.user_id,
       u.firstname + ' ' + u.lastname AS USER_NAME,
       u.email,
       u.mobileno
FROM user_details u
JOIN user_policies up ON u.user_id = up.user_id
JOIN policy_sub_types ps ON up.policy_type_id = ps.policy_type_id
JOIN ref_policy_types r ON ps.policy_type_code = r.policy_type_code
WHERE r.policy_type_name = 'car';


SELECT DISTINCT u.user_id,
       u.firstname,
       u.lastname
FROM user_details u
JOIN user_policies up ON u.user_id = up.user_id
JOIN policy_sub_types ps ON up.policy_type_id = ps.policy_type_id
JOIN ref_policy_types r ON ps.policy_type_code = r.policy_type_code
WHERE r.policy_type_name = 'car'
AND u.user_id NOT IN
(
    SELECT u.user_id
    FROM user_details u
    JOIN user_policies up ON u.user_id = up.user_id
    JOIN policy_sub_types ps ON up.policy_type_id = ps.policy_type_id
    JOIN ref_policy_types r ON ps.policy_type_code = r.policy_type_code
    WHERE r.policy_type_name = 'home'
);




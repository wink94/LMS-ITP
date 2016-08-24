


create table lab_appointment_limit(
ID int  not null auto_increment,
SetDate Datetime not null default CURRENT_TIMESTAMP,
appointment_limit int ,
primary key(ID)
);

SELECT CURDATE();

insert into lab_appointment_limit(appointment_limit) 
values(10);
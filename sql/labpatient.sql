create table lab_patient(
labPatientID int(10)  not null auto_increment,
labPatientName varchar(45) not null,
labPatientAge int not null,
labPatientGender varchar(10) not null,
labPatientEmail varchar(45) not null,
labPatientPhone varchar(10) not null,
primary key(labPatientID)
);
alter table lab_patient  auto_increment = 1000000000;

insert into lab_patient(labPatientName,labPatientAge,labPatientGender,labPatientEmail,labPatientPhone) 
values('asdda ad',45,'Male','adsdad@aasd.vv','1234567890');
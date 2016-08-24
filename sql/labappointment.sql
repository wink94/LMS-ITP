create table lab_appointment(
labAppointmentID int(7)  not null auto_increment,
labAppointmentDate Date not null,
labPatientID int(10) ,
primary key(labAppointmentID)
);
alter table lab_appointment auto_increment=1000000
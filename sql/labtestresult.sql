

create table lab_test_result(
labPatientID int(10)  not null ,
labTestID varchar(10) not null,
labAppointmentStatus int(1) default 0 not null,

primary key(labPatientID,labTestID)
);

insert into lab_test_result (labPatientID,labTestID) values(1234567890,'LT005')


insert into lab_test_result (labPatientID,labTestID) values(1234567890,'LT008')
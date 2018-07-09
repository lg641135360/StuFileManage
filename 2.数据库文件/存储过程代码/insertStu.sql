create proc insertStu
@stuNo varchar(50),
@stuName varchar(50),
@stuSex varchar(2),
@stuNation varchar(50),
@stuBirthDate datetime,
@stuBirthPlace varchar(50),
@stuAdmissionTime datetime,
@sDeptClassno int,
@recordno int
as 
	begin 
		insert into StuInfo
			(sno,name,sex,nation,birthDate,birthPlace,admissionTime,sDeptClassno,recordno)
		values
			(@stuNo,@stuName,@stuSex,@stuNation,@stuBirthDate,@stuBirthPlace,@stuAdmissionTime,@sDeptClassno,@recordno)
	end
go
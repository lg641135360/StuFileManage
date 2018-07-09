create proc updateStuBySno
@stuNo varchar(50),
@stuName varchar(50),
@stuSex varchar(2),
@stuNation varchar(50),
@stuBirthDate datetime,
@stuBirthPlace varchar(50),
@stuAdmissionTime datetime
as 
	begin 
		update StuInfo set name = @stuName,
						sex = @stuSex,
						nation = @stuNation,
						birthDate = @stuBirthDate,
						birthPlace = @stuBirthPlace,
						admissionTime = @stuAdmissionTime
						
	end
go
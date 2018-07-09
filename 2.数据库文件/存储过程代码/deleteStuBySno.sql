create proc deleteStuBySno
@stuNo varchar(50)
as
	begin
		delete from StuInfo where sno = @stuNo
	end
go
	
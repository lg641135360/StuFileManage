create proc deleteFromStuByName
@SName varchar(50)
as	
	begin	
		delete from StuInfo where name = @SName
		return @@rowcount
	end
go
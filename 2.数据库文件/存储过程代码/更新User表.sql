create proc updateUserByLoginName
@UserLoginName varchar(20),
@UserPassword varchar(20),
@Limit int
as
	begin
		update UserLogin set
			password = @UserPassword,
			limit = @Limit
		where loginName = @UserLoginName
	end
go
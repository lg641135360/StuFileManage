create proc insertUser
@UserLoginName varchar(20),
@UserPassword varchar(20),
@Limit int
as 
	begin 
		insert into UserLogin
			(loginName,password,limit)
		values
			(@UserLoginName,@UserPassword,@Limit)
	end
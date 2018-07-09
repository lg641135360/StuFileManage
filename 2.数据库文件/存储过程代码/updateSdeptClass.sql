create proc updateStuDeptClass
@stuDeptClassNo int,
@department varchar(50),
@class varchar(50)
as 
	begin 
		update SdeptClass set 
				department = @department,
				class = @class
		where sDeptClassno = @stuDeptClassNo			
	end
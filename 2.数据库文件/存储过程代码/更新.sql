create proc insertSdeptClass
@sDeptClassNo int,
@department varchar(50),
@class varchar(50),
@result varchar(50) output
as
	if exists(select * from StuInfo where sDeptClassno = @sDeptClassNo)
		begin
			update SdeptClass set department = @department, class = @class where sDeptClassno = @sDeptClassNo
			set @result = '院系班级已修改!'
		end
	else
		begin
			set @result = '无此学生！'
		end
go
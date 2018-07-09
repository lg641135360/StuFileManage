create proc updateRecordChange
@RecordNo int,
@ChangeDate datetime,
@OriginalDept varchar(20),
@CurrentDept varchar(20),
@OriginalClass varchar(20),
@CurrentClass varchar(20)
as 
	begin 
		update RecordChange set 
				changeDate = @ChangeDate,
				originalDept = @OriginalDept,
				currentDept = @CurrentDept,
				originalClass = @OriginalClass,
				currentClass = @CurrentClass
		where recordno = @RecordNo			
	end
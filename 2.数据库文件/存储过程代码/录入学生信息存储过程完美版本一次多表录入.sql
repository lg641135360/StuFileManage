USE [StuFileManagement]
GO
/****** Object:  StoredProcedure [dbo].[insertStu]    Script Date: 07/08/2018 14:56:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[insertStu]
@stuNo varchar(50),
@stuName varchar(50),
@stuSex varchar(2),
@stuNation varchar(50),
@stuBirthDate datetime,
@stuBirthPlace varchar(50),
@stuAdmissionTime datetime,
@stuDeptClassNo int,
@stuRecordNo int
as 
	begin 
		-- 先把没有外键约束的插入
		insert into StuInfo
			(sno,name,sex,nation,birthDate,birthPlace,admissionTime)
		values
			(@stuNo,@stuName,@stuSex,@stuNation,@stuBirthDate,@stuBirthPlace,@stuAdmissionTime)
			
		-- 插入其他两张表的主要部分
		insert into SdeptClass
			(sDeptClassno)
		values
			(@stuDeptClassNo)
			
		insert into RecordChange
			(recordno,sno)
		values(@stuRecordNo,@stuNo)
		-- 	更新主表
		update StuInfo set sDeptClassno = @stuDeptClassNo,recordno = @stuRecordNo where sno = @stuNo
		
	end

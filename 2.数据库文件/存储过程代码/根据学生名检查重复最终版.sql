USE [StuFileManagement]
GO
/****** Object:  StoredProcedure [dbo].[ExistStuByName]    Script Date: 07/07/2018 21:57:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER proc [dbo].[ExistStuByName]  
@stuName varchar(50)  
as  
begin  
     if (select COUNT(1) from StuInfo s where s.name=@stuName)>0  
		return 1  
     else  
		return 0
end  

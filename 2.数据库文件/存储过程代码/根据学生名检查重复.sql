
create proc ExistStuByName  
@stuName varchar(50),  
@result varchar(8) output --输出参数  
as  
begin  
     if (select COUNT(1) from StuInfo s where s.name=@stuName)>0  
     set   
        @result='存在!'  
     else  
     set   
        @result='不存在!'  
end  
go 
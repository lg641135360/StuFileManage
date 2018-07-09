
               
              
create view sel_stu_all as
select dbo.StuInfo.*,dbo.SdeptClass.department,dbo.SdeptClass.class,dbo.EduRecord.eduexperienceno,dbo.EduRecord.startDate,
		dbo.EduRecord.endDate,dbo.RecordChange.changeDate,dbo.RecordChange.originalDept,dbo.RecordChange.currentDept,
		dbo.RecordChange.originalClass,dbo.RecordChange.currentClass
from dbo.StuInfo inner join 
		dbo.SdeptClass on dbo.StuInfo.sDeptClassno = dbo.SdeptClass.sDeptClassno inner join
		dbo.EduRecord on dbo.StuInfo.sno = dbo.EduRecord.sno inner join
		dbo.RecordChange on dbo.StuInfo.recordno = dbo.RecordChange.recordno

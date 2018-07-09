/*
 * ER/Studio 8.0 SQL Code Generation
 * Company :      Microsoft
 * Project :      Model1.DM1
 * Author :       Microsoft
 *
 * Date Created : Friday, July 06, 2018 15:29:58
 * Target DBMS : Microsoft SQL Server 2008
 */

/* 
 * TABLE: EduRecord 
 */

CREATE TABLE EduRecord(
    eduexperienceno    int              NOT NULL,
    sno                varchar(20)      NOT NULL,
    startDate          smalldatetime    NULL,
    endDate            smalldatetime    NULL,
    stuName            varchar(50)      NULL,
    CONSTRAINT PK4 PRIMARY KEY NONCLUSTERED (eduexperienceno)
)
go



IF OBJECT_ID('EduRecord') IS NOT NULL
    PRINT '<<< CREATED TABLE EduRecord >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE EduRecord >>>'
go

/* 
 * TABLE: RecordChange 
 */

CREATE TABLE RecordChange(
    recordno         int              NOT NULL,
    sno              varchar(20)      NULL,
    changeType       varchar(4)       NULL,
    changeDate       smalldatetime    NULL,
    originalClass    varchar(20)      NULL,
    originalDept     varchar(20)      NULL,
    currentDept      varchar(20)      NULL,
    currentClass     varchar(20)      NULL,
    changeReason     varchar(100)     NULL,
    CONSTRAINT PK5 PRIMARY KEY NONCLUSTERED (recordno)
)
go



IF OBJECT_ID('RecordChange') IS NOT NULL
    PRINT '<<< CREATED TABLE RecordChange >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE RecordChange >>>'
go

/* 
 * TABLE: SdeptClass 
 */

CREATE TABLE SdeptClass(
    sDeptClassno    int            NOT NULL,
    department      varchar(20)    NULL,
    class           varchar(20)    NULL,
    CONSTRAINT PK3 PRIMARY KEY NONCLUSTERED (sDeptClassno)
)
go



IF OBJECT_ID('SdeptClass') IS NOT NULL
    PRINT '<<< CREATED TABLE SdeptClass >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE SdeptClass >>>'
go

/* 
 * TABLE: StuInfo 
 */

CREATE TABLE StuInfo(
    sno              varchar(20)      NOT NULL,
    name             varchar(20)      NULL,
    sex              varchar(2)       NOT NULL,
    nation           varchar(20)      NULL,
    birthDate        smalldatetime    NULL,
    birthPlace       varchar(40)      NULL,
    admissionTime    smalldatetime    NULL,
    sDeptClassno     int              NOT NULL,
    recordno         int              NULL,
    CONSTRAINT PK1 PRIMARY KEY NONCLUSTERED (sno)
)
go



IF OBJECT_ID('StuInfo') IS NOT NULL
    PRINT '<<< CREATED TABLE StuInfo >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE StuInfo >>>'
go

/* 
 * TABLE: UserLogin 
 */

CREATE TABLE UserLogin(
    loginName    varchar(20)    NULL,
    password     varchar(20)    NULL,
    limit        int            NULL
)
go



IF OBJECT_ID('UserLogin') IS NOT NULL
    PRINT '<<< CREATED TABLE UserLogin >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE UserLogin >>>'
go

/* 
 * TABLE: EduRecord 
 */

ALTER TABLE EduRecord ADD CONSTRAINT RefStuInfo6 
    FOREIGN KEY (sno)
    REFERENCES StuInfo(sno)
go


/* 
 * TABLE: StuInfo 
 */

ALTER TABLE StuInfo ADD CONSTRAINT RefRecordChange4 
    FOREIGN KEY (recordno)
    REFERENCES RecordChange(recordno)
go

ALTER TABLE StuInfo ADD CONSTRAINT RefSdeptClass7 
    FOREIGN KEY (sDeptClassno)
    REFERENCES SdeptClass(sDeptClassno)
go



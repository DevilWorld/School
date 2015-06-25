CREATE TABLE dbo.tblCourse
(
	CourseID	INT	IDENTITY(1, 1) NOT NULL
	, Name		VARCHAR(250)
	, Active	BIT
	, CreatedBy	VARCHAR(15)
	, CreatedDate	DATETIME
	, ModifiedBy	VARCHAR(15)
	, ModifiedDate	DATETIME
	PRIMARY KEY CLUSTERED (CourseID)
)
GO
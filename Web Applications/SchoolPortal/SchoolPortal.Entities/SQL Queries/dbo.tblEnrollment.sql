CREATE TABLE dbo.tblEnrollment
(
	EnrollmentID	INT	IDENTITY(1, 1) NOT NULL
	, PersonID		INT
	, CourseID		INT
	FOREIGN KEY (PersonID) REFERENCES dbo.tblPerson(PersonID)
	, FOREIGN KEY (CourseID) REFERENCES dbo.tblCourse(CourseID)
)
GO

ALTER TABLE dbo.tblEnrollment ADD PRIMARY KEY(EnrollmentID)
GO

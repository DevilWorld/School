CREATE TABLE dbo.tblPerson
(
	PersonID		INT	IDENTITY(1, 1)	NOT NULL
	, UserID		VARCHAR(15)
	, FirstName		VARCHAR(100)
	, LastName		VARCHAR(100)
	, MiddleName	VARCHAR(100)
	, Sex			CHAR(1)
	, DOB			DATETIME
	, Active		BIT
	, CreatedDate	DATETIME
	, CreatedBy		VARCHAR(15)
	, ModifiedDate	DATETIME
	, ModifiedBy	VARCHAR(15)

	PRIMARY KEY CLUSTERED (PersonID)
)
GO

ALTER TABLE dbo.tblPerson ADD [Address]	VARCHAR(500)
								, City	VARCHAR(30)
								, [State]	VARCHAR(30)
								, Zip		INT
GO
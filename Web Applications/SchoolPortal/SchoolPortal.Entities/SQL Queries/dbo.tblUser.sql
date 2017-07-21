CREATE TABLE dbo.tblUser
(
	Id	int identity(1, 1),
	UserId	varchar(30)	not null,
	Password	varchar(30)	not null,
	CreatedBy	int	not null,
	CreatedDate	DateTime	Not Null,
	ModifiedBy	int	null,
	ModifiedDate	DateTime	Null,
	Active		Bit Not Null,
	Constraint pk_tbl_user_id	Primary Key (Id)
)
Go
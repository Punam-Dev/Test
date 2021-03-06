--Drop Table Forms

Create Table Forms(
	FormsID BigInt Primary Key Identity(1,1) Not Null,
	FirstName nVarChar(128),
	LastName nVarChar(128),
	Email nVarChar(512),
	SSN nVarChar(128),
	Phone nVarChar(15),
	BankName nVarChar(128),
	AccountNo nVarChar(32),
	LoanAmount Decimal(19,2),
	Address nVarChar(2048),
	City nVarChar(64),
	State nVarChar(64),
	Zip nVarChar(16),
	DOB Date,
	LicenceNo nVarChar(64),
	LicenceState nVarChar(64),
	IP nVarChar(64),
	FormIsSubmit Bit,
	UserCreatedByUserID Char(36),
	UserCreatedDate DateTime,
	UserUpdatedByUserID Char(36),
	UserUpdatedDate DateTime,
	
	Constraint FK_Forms_Users_UserCreatedByUserID Foreign Key(UserCreatedByUserID) References Users(UserID),
	Constraint FK_Forms_Users_UserUpdatedByUserID Foreign Key(UserUpdatedByUserID) References Users(UserID),
)

--Truncate table forms

--Select * from forms
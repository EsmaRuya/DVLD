-- CREATE DATABASE DVDL;

--CREATE TABLE People (
--	PersonId INT IDENTITY (1,1) PRIMARY KEY,
--	N_number NVARCHAR(20),
--    FirstName NVARCHAR(100),
--	SecondName NVARCHAR(100),
--	ThirdName NVARCHAR(100),
--	LastName NVARCHAR(100),
--	DateOfBirth DateTime,
--	Gender NVARCHAR(10),
--	Address NVARCHAR(100),
--	Phone NVARCHAR(50),
--	Email NVARCHAR(50),
--	Nationality INT,
--	ImagePath NVARCHAR(250)
--);

--INSERT INTO People (N_number, FirstName, SecondName, LastName, DateOfBirth, Gender, Address, Phone, Nationality)
--VALUES ('n1', 'Fatima', 'Ali', 'BenSalah', '1995-06-15', 'F', '123 Main Street, Rabat', '0612345678', '114');

-- SELECT @@SERVERNAME

--CREATE TABLE Countries (
--    CountryId INT IDENTITY(1,1) PRIMARY KEY,
--    CountryName VARCHAR(100) NOT NULL
--);

--INSERT INTO Countries (CountryName) VALUES
--('Afghanistan'),('Albania'), ('Algeria'), ('Andorra'), ('Angola'), ('Antigua and Barbuda'),('Argentina'), ('Armenia'),('Australia'),('Austria'), ('Azerbaijan'),
-- ('Bahamas'),('Bahrain'),('Bangladesh'),('Barbados'),('Belarus'),('Belgium'),('Belize'),('Benin'),('Bhutan'),('Bolivia'),('Bosnia and Herzegovina'),('Botswana'),
-- ('Brazil'),('Brunei'),('Bulgaria'),('Burkina Faso'),('Burundi'), ('Cambodia'),('Cameroon'),('Canada'),('Cape Verde'),('Central African Republic'), ('Chad'),
--('Chile'),('China'),('Colombia'),('Comoros'),('Congo'),('Costa Rica'),('Croatia'),('Cuba'),('Cyprus'),('Czech Republic'),('Denmark'),('Djibouti'),('Dominica'),
--('Dominican Republic'),('Ecuador'),('Egypt'),('El Salvador'),-('Equatorial Guinea'),('Eritrea'),('Estonia'),('Eswatini'),('Ethiopia'),('Fiji'),('Finland'),
--('France'),('Gabon'),('Gambia'),('Georgia'),('Germany'),('Ghana'),('Greece'),('Grenada'),('Guatemala'),('Guinea'),('Guinea-Bissau'),('Guyana'),('Haiti'),
--('Honduras'),('Hungary'),('Iceland'),('India'),('Indonesia'),('Iran'),('Iraq'),('Ireland'),('Italy'),('Jamaica'),('Japan'),('Jordan'),('Kazakhstan'),('Kenya'),
--('Kiribati'),('Kuwait'),('Kyrgyzstan'),('Laos'),('Latvia'),('Lebanon'),('Lesotho'),('Liberia'),('Libya'),('Liechtenstein'),('Lithuania'),('Luxembourg'),('Madagascar'),
--('Malawi'),('Malaysia'),('Maldives'),('Mali'),('Malta'),('Marshall Islands'),('Mauritania'),('Mauritius'),('Mexico'),('Micronesia'),('Moldova'),('Monaco'),('Mongolia'),
--('Montenegro'),('Morocco'),('Mozambique'),('Myanmar'),('Namibia'),('Nauru'),('Nepal'),('Netherlands'),('New Zealand'),('Nicaragua'),('Niger'),('Nigeria'),('North Korea'),('North Macedonia'),
--('Norway'),('Oman'),('Pakistan'),('Palau'),('Panama'),('Papua New Guinea'),('Paraguay'),('Peru'),('Philippines'),('Poland'),('Portugal'),('Qatar'),('Romania'),('Russia'),('Rwanda'),
--('Saint Kitts and Nevis'),('Saint Lucia'),('Saint Vincent and the Grenadines'),('Samoa'),('San Marino'),('Sao Tome and Principe'),('Saudi Arabia'),('Senegal'),('Serbia'),('Seychelles'),
--('Sierra Leone'),('Singapore'),('Slovakia'),('Slovenia'),('Solomon Islands'),('Somalia'),('South Africa'),('South Korea'),('South Sudan'),('Spain'),('Sri Lanka'),('Sudan'),
--('Suriname'),('Sweden'),('Switzerland'),('Syria'),('Taiwan'),('Tajikistan'),('Tanzania'),('Thailand'),('Timor-Leste'),('Togo'),('Tonga'),('Trinidad and Tobago'),('Tunisia'),('Turkey'),
--('Turkmenistan'),('Tuvalu'),('Uganda'),('Ukraine'),('United Arab Emirates'),('United Kingdom'),('United States'),('Uruguay'),('Uzbekistan'),('Vanuatu'),('Vatican City'),
--('Venezuela'),('Vietnam'),('Yemen'),('Zambia'),('Zimbabwe');

--SELECT 
--    p.PersonId,
--    p.FirstName,
--    p.Nationality,
--    c.CountryName
--FROM People p
--LEFT JOIN Countries c ON p.Nationality = c.CountryId;

--CREATE TABLE Users (
--    UserId INT IDENTITY(1,1) PRIMARY KEY,
--    PersonId INT NOT NULL,
--	CONSTRAINT FK_Users_People
--        FOREIGN KEY (PersonId) REFERENCES People(PersonId),
--	UserName NVARCHAR(20),
--	PassWord NVARCHAR(20),
--	isActive BIT
--);

--BACKUP DATABASE DVDL
--TO DISK = 'C:/DVDL.bak';

--CREATE TABLE ApplicationTypes (
--    ApplicationTypesId INT IDENTITY(1,1) PRIMARY KEY,
--    ApplicationTitle NVARCHAR(100) NOT NULL,
--	ApplicationFees SMALLMONEY NOT NULL
--);

--CREATE TABLE Applications (
--    ApplicationId INT IDENTITY(1,1) PRIMARY KEY,
--    ApplicationPersonId INT NOT NULL,
--	CONSTRAINT FK_Applications_PersonId
--        FOREIGN KEY (ApplicationPersonId) REFERENCES People(PersonId),
--	ApplicationDate DateTime NOT NULL,
--	ApplicationTypeId INT NOT NULL,
--	CONSTRAINT FK_Applications_Types
--        FOREIGN KEY (ApplicationTypeId) REFERENCES ApplicationTypes(ApplicationTypesId),
--	ApplicationStatus TINYINT NOT NULL,
--	LastStatusDate DateTime NOT NULL,
--	PaidFees SMALLMONEY NOT NULL,
--	CreatedByUserId INT NOT NULL,
--	CONSTRAINT FK_Applications_UserId
--        FOREIGN KEY (CreatedByUserId) REFERENCES Users(UserId)
--);

--INSERT INTO ApplicationTypes (ApplicationTitle, ApplicationFees)
--VALUES ('New Local Driving License Service', 15),( 'Renew Driving License Service',5), ('Replacement for a Lost Driving License',10),
--		('Replacement for a Damaged Driving License',5), ('Release Detained Driving License',15), ('New International License',50);

--CREATE TABLE LicenseClasses (
--    LicenseClassId INT IDENTITY(1,1) PRIMARY KEY,
--    ClassName NVARCHAR(100) NOT NULL,
--	ClassDescription NVARCHAR(250) NOT NULL,
--	MinimumAllowedAge INT NOT NULL,
--	DefaultValiditingLength INT NOT NULL,
--	ClassFees SMALLMONEY NOT NULL
--);

--CREATE TABLE LocalDrivingLicenseApplications (
--	LocalDrivingLicenseApplicationId INT IDENTITY(1,1) PRIMARY KEY,
--	ApplicationId INT NOT NULL,
--	CONSTRAINT FK_App_Id
--		FOREIGN KEY (ApplicationId) REFERENCES Applications(ApplicationId),
--	LicenseClassId INT NOT NULL,
--	CONSTRAINT FK_ClassId
--		FOREIGN KEY (LicenseClassId) REFERENCES LicenseClasses(LicenseClassId)
--);

--CREATE TABLE TestTypes (
--	TestTypeId INT PRIMARY KEY NOT NULL,
--	TestTypeTitle NVARCHAR(50) NOT NULL,
--	TestTypeDescription NVARCHAR(150) NOT NULL,
--	TestTypeFees MONEY NOT NULL
--);

--CREATE TABLE TestAppointments (
--	TestAppointmentId INT PRIMARY KEY NOT NULL,
--	TestTypeId INT NOT NULL,
--	CONSTRAINT FK_TestId
--		FOREIGN KEY (TestTypeId) REFERENCES TestTypes(TestTypeId),
--	LocalDrivingLicenseApplicationId INT NOT NULL,
--	CONSTRAINT FK_ApplicationId
--		FOREIGN KEY  (LocalDrivingLicenseApplicationId) REFERENCES LocalDrivingLicenseApplications(LocalDrivingLicenseApplicationId),
--	AppointmentDate DATETIME NOT NULL,
--	PaidFees MONEY NOT NULL,
--	CreatedByUserId INT NOT NULL,
--	CONSTRAINT FK_UserId
--		FOREIGN KEY (CreatedByUserId) REFERENCES Users(UserId),
--	isLocked TINYINT NOT NULL
--);

--CREATE TABLE Tests (
--	TestId INT PRIMARY KEY NOT NULL,
--	TestAppointmentId INT NOT NULL,
--	CONSTRAINT FK_AppId
--		FOREIGN KEY (TestAppointmentId) REFERENCES TestAppointments(TestAppointmentId),
--	TestResult FLOAT NOT NULL,
--	Notes NVARCHAR(150) NOT NULL,
--	CreatedByUserId INT NOT NULL,
--	CONSTRAINT FK_CreatedUserId
--		FOREIGN KEY (CreatedByUserId) REFERENCES Users(UserId)
--);

--CREATE TABLE Drivers (
--	DriverId INT IDENTITY(1,1) PRIMARY KEY,
--	PersonId INT NOT NULL,
--	CONSTRAINT FK_PersonId
--		FOREIGN KEY (PersonId) REFERENCES People(PersonId),
--	CreatedByUserId INT NOT NULL,
--	CONSTRAINT FK_Created_UserId
--		FOREIGN KEY (CreatedByUserId) REFERENCES Users(UserId),
--		CreatedDate DATETIME NOT NULL
--);

--CREATE TABLE Licenses (
--	LicenseId INT IDENTITY(1,1) PRIMARY KEY,
--	ApplicationId INT NOT NULL,
--	CONSTRAINT FK_ApplId
--		FOREIGN KEY (ApplicationId) REFERENCES Applications(ApplicationId),
--	DriverId INT NOT NULL,
--	CONSTRAINT FK_DriverId
--		FOREIGN KEY (DriverId) REFERENCES Drivers(DriverId),
--	LicenseClassId INT NOT NULL,
--	CONSTRAINT FK_LicenseClassId
--		FOREIGN KEY (LicenseClassId) REFERENCES LicenseClasses(LicenseClassId),
--	IssueDate DATETIME NOT NULL,
--	ExpiredDate DATETIME NOT NULL,
--	Notes NVARCHAR(250),
--	PaidFees SMALLMONEY NOT NULL,
--	isActive BIT NOT NULL,
--	IssueReason TINYINT NOT NULL,
--	CreatedByUserId INT NOT NULL,
--	CONSTRAINT FK_C_UserId
--		FOREIGN KEY (CreatedByUserId) REFERENCES Users(UserId)
--);

--CREATE TABLE DetainedLicenses (
--	DetainedId INT PRIMARY KEY NOT NULL,
--	LicenseId INT NOT NULL,
--	CONSTRAINT FK_LicenseId
--		FOREIGN KEY (LicenseId) REFERENCES Licenses(LicenseId),
--	DetainedDate DATETIME NOT NULL,
--	FineFees SMALLMONEY NOT NULL,
--	CreatedByUserId INT NOT NULL,
--	CONSTRAINT FK_CreatByUserId
--		FOREIGN KEY (CreatedByUserId) REFERENCES Users(UserId),
--	isReleased BIT NOT NULL,
--	ReleaseDate DATETIME,
--	ReleasedByUserId INT,
--	CONSTRAINT FK_CUserId
--		FOREIGN KEY (ReleasedByUserId) REFERENCES Users(UserId),
--	ReleasedApplicationId INT,
--	CONSTRAINT FK_ReleaseAppId
--		FOREIGN KEY (ReleasedApplicationId) REFERENCES Applications(ApplicationId)
--);

--ALTER TABLE TestAppointments
--ADD CONSTRAINT FK_RetakeTestAppId
--FOREIGN KEY (RetakeTestApplicationId)
--REFERENCES Applications (ApplicationId);

--CREATE TABLE InternationalLicenses (
--	InternationalLicenseId INT PRIMARY KEY NOT NULL,
--		ApplicationId INT NOT NULL,
--	CONSTRAINT FK_InternationalLicenses_AppId
--		FOREIGN KEY (ApplicationId) REFERENCES Applications(ApplicationId),
--	DriverId INT NOT NULL,
--	CONSTRAINT FK_InternationalLicenses_DriverId
--		FOREIGN KEY (DriverId) REFERENCES Drivers(DriverId),
--	IssuedUsingLocalLicenseId INT NOT NULL,
--	CONSTRAINT FK_InternationalLicenses_Licenses
--		FOREIGN KEY (IssuedUsingLocalLicenseId) REFERENCES Licenses(LicenseId),
--	IssueDate SMALLDATETIME NOT NULL,
--	ExpirationDate SMALLDATETIME NOT NULL,
--	isActive BIT NOT NULL,
--	CreatedByUserId INT NOT NULL,
--	CONSTRAINT FK_InternationalLicenses_CreatedByUserId
--		FOREIGN KEY (CreatedByUserId) REFERENCES Users(UserId)
--);


SELECT * FROM TestAppointments;
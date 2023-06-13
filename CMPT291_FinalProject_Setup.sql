USE [CMPT_291_FinalProject]
GO

DROP TABLE dbo.Rental
DROP TABLE dbo.Car
DROP TABLE dbo.CarType
DROP TABLE dbo.Branch
DROP TABLE dbo.Customer

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Customer](
	[CustomerID] [nchar](4) NOT NULL,
	[FirstName] [nchar](20) NULL,
	[LastName] [nchar](20) NULL,
	[DOB] [nchar](10) NULL,
	[PhoneNumber] [nchar](10) NULL,
	[Insurance] [nchar](20) NULL,
	[City] [nchar](20) NULL,
	[StreetName] [nchar](30) NULL,
	[PostalCode] [nchar](6) NULL,
	primary key (CustomerID)
);

CREATE TABLE [dbo].[Branch](
	[BranchID] [nchar](4) NOT NULL,
	[City] [nchar](20) NOT NULL,
	[StreetName] [nchar](30) NULL,
	[PostalCode] [nchar](20) NULL,
	primary key (BranchID),
);

CREATE TABLE [dbo].[CarType](
	[CTID] [nchar](5) NOT NULL,
	[Type] [nchar](20) NULL,
	[DailyPrice] [int] NULL,
	[WeeklyPrice] [int] NULL,
	[MonthlyPrice] [int] NULL,
	primary key (CTID),
);

CREATE TABLE [dbo].[Car](
	[CarID] [nchar](5) NOT NULL,
	[Make] [nchar](20) NULL,
	[Model] [nchar](20) NULL,
	[Year] [int] NULL,
	[Mileage] [int] NULL,
	[Registration] [nchar](10) NOT NULL,
	[LicensePlate] [nchar](7) NULL,
	[CTID] [nchar](5) NOT NULL,
	primary key (CarID),
	foreign key (CTID) references CarType
);

CREATE TABLE [dbo].[Rental](
	[RentalID] [nchar](4) NOT NULL,
	[DateFrom] DATE NOT NULL,
	[DateTo] DATE NOT NULL,
	[Price] [int] NULL,
	[CustomerID] [nchar](4) NOT NULL,
	[CarID] [nchar](5) NOT NULL,
	[BranchIDIn] [nchar](4) NOT NULL,
	[BranchIDOut] [nchar](4) NOT NULL,
	primary key (RentalID, CustomerID, CarID),
	foreign key (CustomerID) references Customer,
	foreign key (CarID) references Car,
	foreign key (BranchIDIn) references Branch,
	foreign key (BranchIDOut) references Branch
);

/****  Customer ****/
Insert into Customer values ('1001','Gerald','Murray','1970-08-16','5879689829', 'TD', 'Edmonton', '133 Street Northwest', 'T5N2A1');
Insert into Customer values ('1002','Emilia','Ortiz','1989-07-20', '5879493257', 'State Farm', 'Calgary', 'Ascencison Bay', 'T1X1P7');
Insert into Customer values ('1003','Teresa','Matthews','1996-04-28','3802653960', 'AMA', 'Leduc' , 'Nootka Road', 'T9E4H3');
Insert into Customer values ('1004','Cleo','Mendoza','1980-09-30','5877167200', 'State Farm', 'Calgary' , 'Hidden Creek Rise Northwest', 'T3A6L4');
Insert into Customer values ('1005','Robbie','Stevens','1989-08-24','4033073104', 'TD ', 'Edmonton' , '112a Street Northwest', 'T6H3K5');
Insert into Customer values ('1006','George','White','1983-06-30','4032638426', 'Intact', 'Letherbridge' , '2 Avenue North', 'T1H0C2');
Insert into Customer values ('1007','Carl','Ford','2003-05-12','7807345972', 'AMA', 'Calgary' , 'Rundleside Drive Northeast', 'T1Y1G3');
Insert into Customer values ('1008','Bethan','Cunningham','2005-01-01','5871049711', 'Intact', 'Red Deer' , 'Salisbury Avenue', 'T4N0C2');
Insert into Customer values ('1009','Mia','Stephens','1995-12-25','8257180574', 'TD ', 'Red Deer' , 'Kentwood Drive', 'T4P0A5');
Insert into Customer values ('1010','Beatrice','Coleman','2000-06-05','7805764442', 'Aviva', 'Calgary' , '44 Street Northeast', 'T2A2M8');
Insert into Customer values ('1011','Larry','Cox','1984-11-20','8256643118', 'Economical', 'Saint Albert' , 'Northstar Close', 'T8N3K3');
Insert into Customer values ('1012','Jerry','Evans','1980-10-05','7808642250', 'Desjardins ', 'Edmonton' , 'Manning Drive Northwest', 'T5Y3B2');
Insert into Customer values ('1013','Dale','Ramos','1991-06-20','4035818752', 'RSA Canada', 'Spruce Grove' , 'Huxley Cove', 'T7X4S5');
Insert into Customer values ('1014','Lawrence','Rivera','2003-07-10','8253268293', 'State Farm', 'Airdrie' , 'Kingsview Boulevard Southeast', 'T4A0C4');


/****  Branch ****/
Insert into Branch values ('2001','Edmonton','37 Street Northwest','T5W2B7');
Insert into Branch values ('2002','Calgary','Sunridge Way Northeast','T1Y0A5');
Insert into Branch values ('2003','Red Deer','55 Street','T4N2H3');
Insert into Branch values ('2004','Leduc','51 Street','T9E5C3');
Insert into Branch values ('2005','Letherbridge','19 Street North','T1H3K4');
Insert into Branch values ('2006','Spruce Grove','Lakeland Drive','T7X3W7');
Insert into Branch values ('2007','Saint Albert','Lamoureux Place','T8N2J4');




/****  CarType ****/
Insert into CarType values ('CT01',	'Small Sedan', 65,	386.75, 1314.95)
Insert into CarType values ('CT02',	'Medium Sedan', 77,	458.15,	1557.71)
Insert into CarType values ('CT03',	'SUV', 64,	380.8, 1294.72)
Insert into CarType values ('CT04',	'Van', 80,	476, 1618.4)
Insert into CarType values ('CT05',	'Truck', 115, 684.25, 2326.45)
Insert into CarType values ('CT06',	'Premium Car', 154, 916.3, 3115.42)


   

/****  Cars ****/
Insert into Car values ('4001',	'Dodge'		, 'Charger'			, 2018 , 85079 , 'Alberta'  , 'CHF2993' ,	'CT02')
Insert into Car values ('4002',	'Nissan'	, 'Versa'			, 2019 , 57929 , 'Quebec'   , 'BKS2304' ,	'CT01')
Insert into Car values ('4003',	'Toyota'	, 'Corolla'			, 2018 , 82642 , 'Ontario'  , 'CMS6541' ,	'CT01')
Insert into Car values ('4004',	'Ford'		, 'F-150'			, 2018 , 98793 , 'Alberta'  , 'BPR1234' ,	'CT05')
Insert into Car values ('4005',	'Ford'		, 'Edge'			, 2016 , 10488 , 'Manitoba' , 'BNS6220' ,	'CT03')
Insert into Car values ('4006',	'Dodge'		, 'Grand Caravan'	, 2019 , 92350 , 'Alberta'  , 'CFH3520' ,	'CT04')
Insert into Car values ('4007',	'Kia'		, 'Forte'			, 2020 , 77733 , 'Ontario'  , 'CLS4512' ,	'CT01')
Insert into Car values ('4008',	'Mitsubishi', 'Mirage'			, 2020 , 28324 , 'Quebec'   , 'CLR2304' ,	'CT01')
Insert into Car values ('4009',	'Ford'		, 'Escape'			, 2020 , 40011 , 'Alberta'  , 'CRH2563' ,	'CT03')
Insert into Car values ('4010',	'Hyundai'	, 'Elantra'			, 2017 , 10685 , 'Ontario'	, 'CMY9812' ,	'CT01')
Insert into Car values ('4011',	'Ford'		, 'Mustang'			, 2018 , 23916 , 'Alberta'	, 'BHM0912' ,	'CT06')
Insert into Car values ('4012',	'Toyota'	, 'RAV4'			, 2018 , 40312 , 'Manitoba'	, 'CLS1293' ,	'CT03')
Insert into Car values ('4013',	'Toyota'	, 'Camry'			, 2019 , 20520 , 'Ontario'	, 'CMS7482' ,	'CT02')
Insert into Car values ('4014',	'Dodge'		, 'RAM 1500'		, 2018 , 98550 , 'Ontario'	, 'CKL6273' ,	'CT05')
Insert into Car values ('4015',	'Hyundai'	, 'Sonata'			, 2018 , 90523 , 'Alberta'	, 'CKT8903' ,	'CT02')
Insert into Car values ('4016',	'Nissan'	, 'Maxima'			, 2022 , 20453 , 'Quebec'	, 'CPL1823' ,	'CT06')


/****  Rental ****/
Insert into Rental values ('3009','2023-01-04','2023-01-11', 476,'1009', '4009', '2003', '2001');
Insert into Rental values ('3001','2023-01-13','2023-01-15', 308,'1001', '4016', '2001', '2001');
Insert into Rental values ('3002','2023-01-18','2023-02-17', 1618.4,'1002', '4009', '2002', '2002');
Insert into Rental values ('3003','2023-01-23','2023-01-24', 77,'1003', '4013', '2004', '2004');
Insert into Rental values ('3008','2023-01-23','2023-01-30', 458.15,'1008', '4001', '2001', '2003');
Insert into Rental values ('3010','2023-02-02','2023-04-03', 3681.86,'1010', '4006', '2002', '2001');
Insert into Rental values ('3004','2023-02-20','2023-02-23', 240,'1004', '4005', '2002', '2002');
Insert into Rental values ('3007','2023-03-16','2023-03-23', 684.25,'1007', '4016', '2001', '2002');
Insert into Rental values ('3006','2023-03-20','2023-03-24', 320,'1006', '4012', '2005', '2005');
Insert into Rental values ('3014','2023-04-05','2023-04-08', 231,'1014', '4015', '2002', '2001');
Insert into Rental values ('3011','2023-04-20','2023-05-04', 773.5,'1001', '4007', '2007', '2001');
Insert into Rental values ('3013','2023-04-20','2023-04-24', 260,'1013', '4008', '2006', '2006');
Insert into Rental values ('3005','2023-05-11','2023-05-14', 462,'1005', '4011', '2001', '2002');
Insert into Rental values ('3012','2023-06-21','2023-06-24', 195,'1012', '4010', '2002', '2002');
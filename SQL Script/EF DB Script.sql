/*

Create Tables [Student] and [Standard]
Insert scripts for both table

*/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID(N'dbo.Student', N'U') IS NOT NULL  
   DROP TABLE [dbo].[Student];  
GO


IF OBJECT_ID(N'dbo.Standard', N'U') IS NOT NULL  
   DROP TABLE [dbo].[Standard];  
GO

CREATE TABLE [dbo].[Standard](
	[StandardID]			[int]			NOT NULL,
	[StandardName]			[varchar](50)	NOT NULL,
	[StandardDescription]	[varchar](50)	NOT NULL,

   CONSTRAINT [UQ_Standard_StandardName] UNIQUE ([StandardName]),
   CONSTRAINT [PK_StandardID] PRIMARY KEY NONCLUSTERED ([StandardID] ASC),
) 
GO

CREATE TABLE [dbo].[Student](
	[StudentID]			[int]			NOT NULL,
	[StudentName]		[varchar](50)	NOT NULL,
	[StudentRollID]		[int]			NOT NULL,
	[StudentLocation]	[varchar](50)	NOT NULL,
	[StandardID]		[int]			NOT NULL,

	 CONSTRAINT [UQ_Student_StudentRollID] UNIQUE ([StudentRollID]),
	 CONSTRAINT [PK_StudentID] PRIMARY KEY NONCLUSTERED ([StudentID] ASC),
	 CONSTRAINT [FK_Student_Standard] FOREIGN KEY ([StandardID]) REFERENCES [dbo].[Standard] ([StandardID]),
) 
GO


-- Insert script
-- STANDARD

INSERT INTO [Standard] (StandardID, StandardName, StandardDescription)
VALUES (1, 'G1', 'Grade 1')

INSERT INTO [Standard] (StandardID, StandardName, StandardDescription)
VALUES (2, 'G2', 'Grade 2')

INSERT INTO [Standard] (StandardID, StandardName, StandardDescription)
VALUES (3, 'G3', 'Grade 3')


-- STUDENT

INSERT INTO [Student] (StudentID, StudentName, StudentRollID, StudentLocation, StandardID)
VALUES (1, 'sAM', 100, '60020', 1)

INSERT INTO [Student] (StudentID, StudentName, StudentRollID, StudentLocation, StandardID)
VALUES (2, 'RYAN', 101, '60020', 1)

INSERT INTO [Student] (StudentID, StudentName, StudentRollID, StudentLocation, StandardID)
VALUES (3, 'ARAV', 102, '60020', 1)

--

INSERT INTO [Student] (StudentID, StudentName, StudentRollID, StudentLocation, StandardID)
VALUES (4, 'TOM', 201, '60020', 2)

INSERT INTO [Student] (StudentID, StudentName, StudentRollID, StudentLocation, StandardID)
VALUES (5, 'RONIT', 202, '60020', 2)

INSERT INTO [Student] (StudentID, StudentName, StudentRollID, StudentLocation, StandardID)
VALUES (6, 'SIM', 203, '60020', 2)

--

INSERT INTO [Student] (StudentID, StudentName, StudentRollID, StudentLocation, StandardID)
VALUES (7, 'TOM', 301, '60020', 3)

INSERT INTO [Student] (StudentID, StudentName, StudentRollID, StudentLocation, StandardID)
VALUES (8, 'RONIT', 302, '60020', 3)

INSERT INTO [Student] (StudentID, StudentName, StudentRollID, StudentLocation, StandardID)
VALUES (9, 'SIM', 303, '60020', 3)
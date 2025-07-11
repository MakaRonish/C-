USE [SchoolDB]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 29-Jul-20 2:44:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[CourseId] [int] IDENTITY(1,1) NOT NULL,
	[CourseName] [varchar](50) NULL,
	[Location] [geography] NULL,
	[TeacherId] [int] NULL,
 CONSTRAINT [PK_Course_1] PRIMARY KEY CLUSTERED 
(
	[CourseId] ASC
))
GO
/****** Object:  Table [dbo].[Student]    Script Date: 29-Jul-20 2:44:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[StudentID] [int] IDENTITY(1,1) NOT NULL,
	[StudentName] [varchar](50) NULL,
	[StandardId] [int] NULL,
	[RowVersion] [timestamp] NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
))
GO
/****** Object:  Table [dbo].[StudentCourse]    Script Date: 29-Jul-20 2:44:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentCourse](
	[StudentId] [int] NOT NULL,
	[CourseId] [int] NOT NULL,
 CONSTRAINT [PK_StudentCourse] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC,
	[CourseId] ASC
))
GO
/****** Object:  View [dbo].[View_StudentCourse]    Script Date: 29-Jul-20 2:44:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_StudentCourse]
AS
SELECT     dbo.Student.StudentID, dbo.Student.StudentName, dbo.Course.CourseId, dbo.Course.CourseName
FROM         dbo.Student INNER JOIN
                      dbo.StudentCourse ON dbo.Student.StudentID = dbo.StudentCourse.StudentId INNER JOIN
                      dbo.Course ON dbo.StudentCourse.CourseId = dbo.Course.CourseId
GO
/****** Object:  Table [dbo].[Standard]    Script Date: 29-Jul-20 2:44:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Standard](
	[StandardId] [int] IDENTITY(1,1) NOT NULL,
	[StandardName] [varchar](50) NULL,
	[Description] [varchar](50) NULL,
 CONSTRAINT [PK_Standard] PRIMARY KEY CLUSTERED 
(
	[StandardId] ASC
))
GO
/****** Object:  Table [dbo].[StudentAddress]    Script Date: 29-Jul-20 2:44:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentAddress](
	[StudentID] [int] NOT NULL,
	[Address1] [varchar](50) NOT NULL,
	[Address2] [varchar](50) NULL,
	[City] [varchar](50) NOT NULL,
	[State] [varchar](50) NOT NULL,
 CONSTRAINT [PK_StudentAddress] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
))
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 29-Jul-20 2:44:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[TeacherId] [int] IDENTITY(1,1) NOT NULL,
	[TeacherName] [varchar](50) NULL,
	[StandardId] [int] NULL,
	[TeacherType] [int] NULL,
 CONSTRAINT [PK_Teacher_1] PRIMARY KEY CLUSTERED 
(
	[TeacherId] ASC
))
GO
SET IDENTITY_INSERT [dbo].[Course] ON 

INSERT [dbo].[Course] ([CourseId], [CourseName], [Location], [TeacherId]) VALUES (1, N'Maths', NULL, 1)
INSERT [dbo].[Course] ([CourseId], [CourseName], [Location], [TeacherId]) VALUES (2, N'Science', NULL, 2)
INSERT [dbo].[Course] ([CourseId], [CourseName], [Location], [TeacherId]) VALUES (3, N'History', NULL, 3)
INSERT [dbo].[Course] ([CourseId], [CourseName], [Location], [TeacherId]) VALUES (4, N'English', NULL, 4)
INSERT [dbo].[Course] ([CourseId], [CourseName], [Location], [TeacherId]) VALUES (5, N'Spanish', NULL, 5)
INSERT [dbo].[Course] ([CourseId], [CourseName], [Location], [TeacherId]) VALUES (6, N'Computer Science', NULL, 6)
SET IDENTITY_INSERT [dbo].[Course] OFF
GO
SET IDENTITY_INSERT [dbo].[Standard] ON 

INSERT [dbo].[Standard] ([StandardId], [StandardName], [Description]) VALUES (1, N'Standard1', N'Standard 1\Grade1')
INSERT [dbo].[Standard] ([StandardId], [StandardName], [Description]) VALUES (2, N'Standard2', N'Grade2')
INSERT [dbo].[Standard] ([StandardId], [StandardName], [Description]) VALUES (3, N'Standard3', N'Grade3')
INSERT [dbo].[Standard] ([StandardId], [StandardName], [Description]) VALUES (4, N'Standard4', N'Grade4')
INSERT [dbo].[Standard] ([StandardId], [StandardName], [Description]) VALUES (5, N'Standard5', N'Grade5')
INSERT [dbo].[Standard] ([StandardId], [StandardName], [Description]) VALUES (6, N'Standard6', N'Grade6')
INSERT [dbo].[Standard] ([StandardId], [StandardName], [Description]) VALUES (7, N'Standard7', N'Grade7')
INSERT [dbo].[Standard] ([StandardId], [StandardName], [Description]) VALUES (8, N'Standard8', N'Grade8')
INSERT [dbo].[Standard] ([StandardId], [StandardName], [Description]) VALUES (9, N'Standard9', N'Grade9')
SET IDENTITY_INSERT [dbo].[Standard] OFF
GO
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([StudentID], [StudentName], [StandardId]) VALUES (1, N'Bill', 2)
INSERT [dbo].[Student] ([StudentID], [StudentName], [StandardId]) VALUES (2, N'Steve', 2)
INSERT [dbo].[Student] ([StudentID], [StudentName], [StandardId]) VALUES (3, N'James', 4)
INSERT [dbo].[Student] ([StudentID], [StudentName], [StandardId]) VALUES (4, N'Tim', 1)
INSERT [dbo].[Student] ([StudentID], [StudentName], [StandardId]) VALUES (5, N'Rama', 3)
INSERT [dbo].[Student] ([StudentID], [StudentName], [StandardId]) VALUES (6, N'Mohan', 5)
INSERT [dbo].[Student] ([StudentID], [StudentName], [StandardId]) VALUES (7, N'Merry', 6)
INSERT [dbo].[Student] ([StudentID], [StudentName], [StandardId]) VALUES (8, N'Kapil', 7)
INSERT [dbo].[Student] ([StudentID], [StudentName], [StandardId]) VALUES (9, N'Imran', 8)
INSERT [dbo].[Student] ([StudentID], [StudentName], [StandardId]) VALUES (10, N'Don', 9)
SET IDENTITY_INSERT [dbo].[Student] OFF
GO
INSERT [dbo].[StudentAddress] ([StudentID], [Address1], [Address2], [City], [State]) VALUES (1, N'Parkview', NULL, N'Seattle', N'Washington ')
INSERT [dbo].[StudentAddress] ([StudentID], [Address1], [Address2], [City], [State]) VALUES (4, N'Sepulveda', N'TSquare', N'Culver', N'California')
GO
SET IDENTITY_INSERT [dbo].[Teacher] ON 

INSERT [dbo].[Teacher] ([TeacherId], [TeacherName], [StandardId], [TeacherType]) VALUES (1, N'Newton', 9, 1)
INSERT [dbo].[Teacher] ([TeacherId], [TeacherName], [StandardId], [TeacherType]) VALUES (2, N'Kalidas', 8, 2)
INSERT [dbo].[Teacher] ([TeacherId], [TeacherName], [StandardId], [TeacherType]) VALUES (3, N'John', 7, 1)
INSERT [dbo].[Teacher] ([TeacherId], [TeacherName], [StandardId], [TeacherType]) VALUES (4, N'James', 3, 3)
INSERT [dbo].[Teacher] ([TeacherId], [TeacherName], [StandardId], [TeacherType]) VALUES (5, N'Ravi', 4, 2)
INSERT [dbo].[Teacher] ([TeacherId], [TeacherName], [StandardId], [TeacherType]) VALUES (6, N'Amir', 5, 1)
INSERT [dbo].[Teacher] ([TeacherId], [TeacherName], [StandardId], [TeacherType]) VALUES (7, N'Bjarne', 6, 2)
INSERT [dbo].[Teacher] ([TeacherId], [TeacherName], [StandardId], [TeacherType]) VALUES (8, N'Tomy', 1, 2)
INSERT [dbo].[Teacher] ([TeacherId], [TeacherName], [StandardId], [TeacherType]) VALUES (9, N'Chris', 2, 1)
INSERT [dbo].[Teacher] ([TeacherId], [TeacherName], [StandardId], [TeacherType]) VALUES (10, N'Brian', 2, 2)
SET IDENTITY_INSERT [dbo].[Teacher] OFF
GO
ALTER TABLE [dbo].[Teacher] ADD  CONSTRAINT [DF_Teacher_StandardId]  DEFAULT ((0)) FOR [StandardId]
GO
ALTER TABLE [dbo].[Course]  WITH NOCHECK ADD  CONSTRAINT [FK_Course_Teacher] FOREIGN KEY([TeacherId])
REFERENCES [dbo].[Teacher] ([TeacherId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Course] NOCHECK CONSTRAINT [FK_Course_Teacher]
GO
ALTER TABLE [dbo].[Student]  WITH NOCHECK ADD  CONSTRAINT [FK_Student_Standard] FOREIGN KEY([StandardId])
REFERENCES [dbo].[Standard] ([StandardId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Student] NOCHECK CONSTRAINT [FK_Student_Standard]
GO
ALTER TABLE [dbo].[StudentAddress]  WITH CHECK ADD  CONSTRAINT [FK_StudentAddress_Student] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Student] ([StudentID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StudentAddress] CHECK CONSTRAINT [FK_StudentAddress_Student]
GO
ALTER TABLE [dbo].[StudentCourse]  WITH CHECK ADD  CONSTRAINT [FK_StudentCourse_Course] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Course] ([CourseId])
GO
ALTER TABLE [dbo].[StudentCourse] CHECK CONSTRAINT [FK_StudentCourse_Course]
GO
ALTER TABLE [dbo].[StudentCourse]  WITH CHECK ADD  CONSTRAINT [FK_StudentCourse_Student] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([StudentID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StudentCourse] CHECK CONSTRAINT [FK_StudentCourse_Student]
GO
ALTER TABLE [dbo].[Teacher]  WITH CHECK ADD  CONSTRAINT [FK_Teacher_Standard] FOREIGN KEY([StandardId])
REFERENCES [dbo].[Standard] ([StandardId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Teacher] CHECK CONSTRAINT [FK_Teacher_Standard]
GO
/****** Object:  StoredProcedure [dbo].[GetCoursesByStudentId]    Script Date: 29-Jul-20 2:44:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetCoursesByStudentId]
	-- Add the parameters for the stored procedure here
	@StudentId int = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
select c.courseid, c.coursename,c.Location, c.TeacherId
from student s left outer join studentcourse sc on sc.studentid = s.studentid left outer join course c on c.courseid = sc.courseid
where s.studentid = @StudentId
END

GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteStudent]    Script Date: 29-Jul-20 2:44:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_DeleteStudent]
	-- Add the parameters for the stored procedure here
	@StudentId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    DELETE FROM [dbo].[Student]
	where StudentID = @StudentId

END

GO
/****** Object:  StoredProcedure [dbo].[sp_InsertStudentInfo]    Script Date: 29-Jul-20 2:44:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_InsertStudentInfo]
	-- Add the parameters for the stored procedure here
	@StandardId int = null,
	@StudentName varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

     INSERT INTO [SchoolDB].[dbo].[Student]
           ([StudentName]
           ,[StandardId])
     VALUES
           (
           @StudentName,
@StandardId
)
SELECT SCOPE_IDENTITY() AS StudentId

END

GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateStudent]    Script Date: 29-Jul-20 2:44:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_UpdateStudent]
	-- Add the parameters for the stored procedure here
	@StudentId int,
	@StandardId int = null,
	@StudentName varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    Update [SchoolDB].[dbo].[Student] 
	set StudentName = @StudentName,
	StandardId = @StandardId
	where StudentID = @StudentId;

END

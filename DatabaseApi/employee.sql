USE [employee]
GO
/****** Object:  Table [dbo].[DESIGINATION]    Script Date: 04/01/2020 08:00:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DESIGINATION](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NAME] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DEPARTMENT]    Script Date: 04/01/2020 08:00:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DEPARTMENT](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NAME] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMPLOYEE]    Script Date: 04/01/2020 08:00:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMPLOYEE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FIRST_NAME] [nvarchar](50) NULL,
	[LAST_NAME] [nvarchar](50) NULL,
	[ADDRESS] [nvarchar](255) NULL,
	[EMPLOYEE_ID] [nvarchar](50) NULL,
	[CONTACT_NO] [nvarchar](20) NULL,
	[PERMANENT_EMPLOYEE] [bit] NULL,
	[DEPARTMENT_ID] [int] NULL,
	[DESIGINATION_ID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMPLOYEE_SALARY]    Script Date: 04/01/2020 08:00:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMPLOYEE_SALARY](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EMPLOYEE_ID] [int] NULL,
	[SALARY] [decimal](18, 2) NULL,
	[START_DATE] [date] NULL,
	[LAST_DATE] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Default [DF__EMPLOYEE___SALAR__403A8C7D]    Script Date: 04/01/2020 08:00:24 ******/
ALTER TABLE [dbo].[EMPLOYEE_SALARY] ADD  DEFAULT ((0)) FOR [SALARY]
GO
/****** Object:  ForeignKey [FK__EMPLOYEE__DEPART__3B75D760]    Script Date: 04/01/2020 08:00:24 ******/
ALTER TABLE [dbo].[EMPLOYEE]  WITH CHECK ADD FOREIGN KEY([DEPARTMENT_ID])
REFERENCES [dbo].[DEPARTMENT] ([ID])
GO
/****** Object:  ForeignKey [FK__EMPLOYEE__DESIGI__3C69FB99]    Script Date: 04/01/2020 08:00:24 ******/
ALTER TABLE [dbo].[EMPLOYEE]  WITH CHECK ADD FOREIGN KEY([DESIGINATION_ID])
REFERENCES [dbo].[DESIGINATION] ([ID])
GO
/****** Object:  ForeignKey [FK__EMPLOYEE___EMPLO__3F466844]    Script Date: 04/01/2020 08:00:24 ******/
ALTER TABLE [dbo].[EMPLOYEE_SALARY]  WITH CHECK ADD FOREIGN KEY([EMPLOYEE_ID])
REFERENCES [dbo].[EMPLOYEE] ([ID])
GO

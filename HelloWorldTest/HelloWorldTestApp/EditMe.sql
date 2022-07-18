CREATE DATABASE [HelloWorldTestDB]
GO

USE [HelloWorldTestDB]
GO

--Table that contains active alarms
CREATE TABLE [dbo].[Alarm] (
	[ID]					[uniqueidentifier] NOT NULL,
	[TimeStamp]				[datetime] NOT NULL,
	[MachineID]				[bigint] NOT NULL,
	[Code]					[nvarchar](50) NOT NULL,
	[Description]			[nvarchar](128) NULL,
CONSTRAINT [PK_Alarm] PRIMARY KEY CLUSTERED (
	[ID] ASC
) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

--Table that contains machines information
CREATE TABLE [dbo].[Machine] (
	[ID]					[bigint] NOT NULL,
	[Type]					[tinyint] NOT NULL, -- Allowed values 0, 1, 2, 3
	[Status]				[tinyint] NOT NULL,
	[Serial]				[nvarchar](255) NOT NULL,
	[Name]					[nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Machine] PRIMARY KEY CLUSTERED (
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Alarm]  WITH CHECK ADD  CONSTRAINT [FK_Alarm_Machine] FOREIGN KEY([MachineID])
REFERENCES [dbo].[Machine] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Alarm] CHECK CONSTRAINT [FK_Alarm_Machine]
GO


--TODO: Create a view that shows all active alarms (Timestamp, Code, Description) for machine with type 1
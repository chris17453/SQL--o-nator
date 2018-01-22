
GO

/****** Object:  Table [dbo].[db_hash]    Script Date: 1/5/2018 9:20:46 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[db_hash](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ip] [varchar](16) NOT NULL,
	[dns] [varchar](255) NOT NULL,
	[user] [varchar](255) NOT NULL,
	[machine] [varchar](255) NOT NULL,
	[filename] [varchar](255) NOT NULL,
	[sql_hash] [varchar](32) NOT NULL,
	[sql_position] [int] NOT NULL,
	[file_hash] [varchar](32) NOT NULL,
	[ran] [datetime] NOT NULL,
	[rows_affected] [int] NOT NULL
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[db_hash] ADD  CONSTRAINT [DF_db_hash_ran]  DEFAULT (getdate()) FOR [ran]
GO

ALTER TABLE [dbo].[db_hash] ADD  CONSTRAINT [DF_db_hash_rows_affected]  DEFAULT ((-1)) FOR [rows_affected]
GO



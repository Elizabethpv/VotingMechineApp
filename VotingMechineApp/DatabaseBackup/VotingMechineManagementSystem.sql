USE [VotingMechineManagementSystem]
GO
/****** Object:  Table [dbo].[VotingMechine]    Script Date: 08-04-2021 12:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VotingMechine](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[VotingState] [nvarchar](50) NOT NULL,
	[SachinCount] [int] NOT NULL,
	[SavravCount] [int] NOT NULL,
	[KhanCount] [int] NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[VotingMechine] ON 

INSERT [dbo].[VotingMechine] ([Id], [VotingState], [SachinCount], [SavravCount], [KhanCount]) VALUES (1, N'Finish Election', 31, 18, 18)
SET IDENTITY_INSERT [dbo].[VotingMechine] OFF
GO
/****** Object:  StoredProcedure [dbo].[UpdateKhanCount]    Script Date: 08-04-2021 12:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateKhanCount]
AS
BEGIN
	UPDATE [dbo].[VotingMechine]
	SET [KhanCount]=[KhanCount]+1
	,[VotingState]='TempStop'
	WHERE [Id]=1
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateSachinCount]    Script Date: 08-04-2021 12:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateSachinCount]

AS
BEGIN
	UPDATE [dbo].[VotingMechine]
	SET [SachinCount]=[SachinCount]+1
	,[VotingState]='TempStop'
	WHERE [Id]=1
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateSavravCount]    Script Date: 08-04-2021 12:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateSavravCount]
AS
BEGIN
	UPDATE [dbo].[VotingMechine]
	SET [SavravCount]=[SavravCount]+1
	,[VotingState]='TempStop'
	WHERE [Id]=1
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateVoteState]    Script Date: 08-04-2021 12:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateVoteState]
      @VotingState NVARCHAR(50)
	
AS
BEGIN
	UPDATE [dbo].[VotingMechine]
	SET VotingState=@VotingState
	WHERE [Id]=1
END
GO
/****** Object:  StoredProcedure [dbo].[VotingMechineSystem]    Script Date: 08-04-2021 12:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[VotingMechineSystem]
AS
BEGIN
	
	SELECT *FROM [dbo].[VotingMechine]
END
GO

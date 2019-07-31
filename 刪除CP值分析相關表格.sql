-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE RemoveTable
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF OBJECT_ID('ALL_CP') IS NOT NULL Drop table dbo.ALL_CP;
	IF OBJECT_ID('U_CP') IS NOT NULL Drop table dbo.U_CP;
	IF OBJECT_ID('G_CP') IS NOT NULL Drop table dbo.G_CP;
	IF OBJECT_ID('D_CP') IS NOT NULL Drop table dbo.D_CP;
	IF OBJECT_ID('大眾傳播學群_CP') IS NOT NULL Drop table dbo.大眾傳播學群_CP;
	IF OBJECT_ID('工程學群_CP') IS NOT NULL Drop table dbo.工程學群_CP;
	IF OBJECT_ID('文史哲學群_CP') IS NOT NULL Drop table dbo.文史哲學群_CP;
	IF OBJECT_ID('外語學群_CP') IS NOT NULL Drop table dbo.外語學群_CP;
	IF OBJECT_ID('生命科學學群_CP') IS NOT NULL Drop table dbo.生命科學學群_CP;
	IF OBJECT_ID('生物資源學群_CP') IS NOT NULL Drop table dbo.生物資源學群_CP;
	IF OBJECT_ID('地球與環境學群_CP') IS NOT NULL Drop table dbo.地球與環境學群_CP;
	IF OBJECT_ID('法政學群_CP') IS NOT NULL Drop table dbo.法政學群_CP;
	IF OBJECT_ID('社會與心理學群_CP') IS NOT NULL Drop table dbo.社會與心理學群_CP;
	IF OBJECT_ID('建築與設計學群_CP') IS NOT NULL Drop table dbo.建築與設計學群_CP;
	IF OBJECT_ID('財經學群_CP') IS NOT NULL Drop table dbo.財經學群_CP;
	IF OBJECT_ID('教育學群_CP') IS NOT NULL Drop table dbo.教育學群_CP;
	IF OBJECT_ID('資訊學群_CP') IS NOT NULL Drop table dbo.資訊學群_CP;
	IF OBJECT_ID('遊憩與運動學群_CP') IS NOT NULL Drop table dbo.遊憩與運動學群_CP;
	IF OBJECT_ID('管理學群_CP') IS NOT NULL Drop table dbo.管理學群_CP;
	IF OBJECT_ID('數理化學群_CP') IS NOT NULL Drop table dbo.數理化學群_CP;
	IF OBJECT_ID('醫藥衛生學群_CP') IS NOT NULL Drop table dbo.醫藥衛生學群_CP;
	IF OBJECT_ID('藝術學群_CP') IS NOT NULL Drop table dbo.藝術學群_CP;
END
GO

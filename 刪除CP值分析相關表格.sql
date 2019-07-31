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
	IF OBJECT_ID('�j���Ǽ��Ǹs_CP') IS NOT NULL Drop table dbo.�j���Ǽ��Ǹs_CP;
	IF OBJECT_ID('�u�{�Ǹs_CP') IS NOT NULL Drop table dbo.�u�{�Ǹs_CP;
	IF OBJECT_ID('��v���Ǹs_CP') IS NOT NULL Drop table dbo.��v���Ǹs_CP;
	IF OBJECT_ID('�~�y�Ǹs_CP') IS NOT NULL Drop table dbo.�~�y�Ǹs_CP;
	IF OBJECT_ID('�ͩR��ǾǸs_CP') IS NOT NULL Drop table dbo.�ͩR��ǾǸs_CP;
	IF OBJECT_ID('�ͪ��귽�Ǹs_CP') IS NOT NULL Drop table dbo.�ͪ��귽�Ǹs_CP;
	IF OBJECT_ID('�a�y�P���ҾǸs_CP') IS NOT NULL Drop table dbo.�a�y�P���ҾǸs_CP;
	IF OBJECT_ID('�k�F�Ǹs_CP') IS NOT NULL Drop table dbo.�k�F�Ǹs_CP;
	IF OBJECT_ID('���|�P�߲z�Ǹs_CP') IS NOT NULL Drop table dbo.���|�P�߲z�Ǹs_CP;
	IF OBJECT_ID('�ؿv�P�]�p�Ǹs_CP') IS NOT NULL Drop table dbo.�ؿv�P�]�p�Ǹs_CP;
	IF OBJECT_ID('�]�g�Ǹs_CP') IS NOT NULL Drop table dbo.�]�g�Ǹs_CP;
	IF OBJECT_ID('�Ш|�Ǹs_CP') IS NOT NULL Drop table dbo.�Ш|�Ǹs_CP;
	IF OBJECT_ID('��T�Ǹs_CP') IS NOT NULL Drop table dbo.��T�Ǹs_CP;
	IF OBJECT_ID('�C�ͻP�B�ʾǸs_CP') IS NOT NULL Drop table dbo.�C�ͻP�B�ʾǸs_CP;
	IF OBJECT_ID('�޲z�Ǹs_CP') IS NOT NULL Drop table dbo.�޲z�Ǹs_CP;
	IF OBJECT_ID('�Ʋz�ƾǸs_CP') IS NOT NULL Drop table dbo.�Ʋz�ƾǸs_CP;
	IF OBJECT_ID('���Ľå;Ǹs_CP') IS NOT NULL Drop table dbo.���Ľå;Ǹs_CP;
	IF OBJECT_ID('���N�Ǹs_CP') IS NOT NULL Drop table dbo.���N�Ǹs_CP;
END
GO

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
CREATE PROCEDURE CP_Preprocessing
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	Create Table ALL_CP
	(DID nvarchar(MAX),
	Uname nvarchar(Max), 
	Dname nvarchar(Max),  
	UDname nvarchar(Max),
	MinScore float,
	SalaryInK float);

	Insert into ALL_CP(DID, Uname, DName, MinScore, SalaryInK)
	Select DID, Uname, Dname, ROUND((Minscore/(EW1+EW2+EW3+EW4+EW5+EW6+EW7+EW8+EW9+EW10)),2), (cast(Salary as float)/cast(1000 as float))
	From D
	Where Salary > 0 And Minscore > 0;

	Update ALL_CP SET DName =REPLACE(DName, '参璸', '窾烦') ;
	Update ALL_CP SET DName = REPLACE(DName, '╰参', '﹝');
	Update ALL_CP SET DName = substring(Dname,1, charindex('╰',Dname)) Where DName like '%╰%';
	Update ALL_CP SET DName = REPLACE(DName, '﹝', '╰参');
	Update ALL_CP SET DName = REPLACE(DName, '窾烦', '参璸');

	update ALL_CP SET DName = substring(Dname,1, charindex('祘',Dname))
	Where DName like '%厩祘%';

	Update ALL_CP
	Set UDName = Concat(Uname,' ', Dname);
	---------------------------------------------------------------------

	Create Table D_CP     
			(ID int PRIMARY KEY IDENTITY,
			Uname nvarchar(Max), 
			Dname nvarchar(Max),  
			UDname nvarchar(Max),
			MinScore float,
			SalaryInK float,
			P float,
			C float,
			CP float);

	Insert into D_CP(Uname, DName, UDName, MinScore, SalaryInK)
	Select UName, DName, UDName, ROUND(AVG(MinScore),2), ROUND(AVG(SalaryInK),2)
	From ALL_CP
	Group By UName, DName, UDName;

	Update D1 Set D1.P= (SELECT COUNT(D2.MinScore)
				FROM D_CP D2
				WHERE D1.MinScore < D2.MinScore)+1 
	FROM D_CP D1;

	Update D1
	Set D1.C= (SELECT COUNT(D2.SalaryInK)
				FROM D_CP D2
				WHERE D1.SalaryInK < D2.SalaryInK)+1
	FROM D_CP D1;
	declare @total int
	set @total = (select count(*) from D_CP);

	Update D_CP Set P=ROUND(((@total-P+1)/@total)*100,2);
	Update D_CP Set C=ROUND(((@total-C+1)/@total)*100,2);
	Update D_CP Set CP=ROUND(C-P,2);
	----------------------------------------------------------------------------------------
	Create Table G_CP
	(ID int PRIMARY KEY IDENTITY,
	Gname nvarchar(Max), 
	MinScore float,
	SalaryInK float,
	P float,
	C float,
	CP float);

	Insert into G_CP(Gname, MinScore, SalaryInK)
	Select GName, ROUND(AVG(MinScore),2), ROUND(AVG(SalaryInK),2)
	From ALL_CP, DC, CG
	Where ALL_CP.DID=DC.DID
	And DC.CName=CG.CName
	Group by GName;

	Update D1
	Set D1.P= (SELECT COUNT(D2.MinScore)
			FROM G_CP D2
			WHERE D1.MinScore < D2.MinScore)+1
	From G_CP D1;

	Update D1
	Set D1.C= (SELECT COUNT(D2.SalaryInK)
			FROM G_CP D2
			WHERE D1.SalaryInK < D2.SalaryInK)+1
	From G_CP D1;

	declare @gtotal int;
	set @gtotal = (Select Count(*) From G_CP);  
	Update G_CP Set P= ROUND((@gtotal-P+1)/@gtotal*100,2), C=ROUND((@gtotal-C+1)/@gtotal*100,2);
	Update G_CP Set CP=ROUND(C-P,2);
	-------------------------------------------------------------------
	Create Table U_CP
			(ID int PRIMARY KEY IDENTITY,
			Uname nvarchar(Max), 
			MinScore float,
			SalaryInK float,
			P float,
			C float,
			CP float);


	Insert into U_CP(Uname, MinScore, SalaryInK)
	Select UName, ROUND(AVG(MinScore),2), ROUND(AVG(SalaryInK),2)
	From ALL_CP
	Group by UName;

	Update D1
	Set D1.P= (SELECT COUNT(D2.MinScore)
			FROM U_CP D2
			WHERE D1.MinScore < D2.MinScore)+1
	From U_CP D1;

	Update D1
	Set D1.C= (SELECT COUNT(D2.SalaryInK)
			FROM U_CP D2
			WHERE D1.SalaryInK <= D2.SalaryInK)+1
	From U_CP D1;

	declare @utotal int;
	set @utotal = (Select Count(*) From U_CP);  
	Update U_CP
	Set P= ROUND((@utotal-P+1)/@utotal*100,2), C=ROUND((@utotal-C+1)/@utotal*100,2);
	Update U_CP Set CP=ROUND(C-P,2);
	------------------------------------------------------------------------------------------
	declare @gname varchar(50);
	IF OBJECT_ID('tempdb..#GroupList') IS NOT NULL Drop table #GroupList
	create table #GroupList(name varchar(50));
	insert into #GroupList(name)
	select distinct CG.Gname from CG where CG.Gname <> 'ぃだ╰厩竤'
	declare @g_total int;
	set @g_total = (select COUNT(*) from #GroupList);
	declare @sql varchar(MAX);
	while(@g_total > 0)
	begin
		select top 1 @gname=name from #GroupList
		set @sql = 'CREATE TABLE '+@gname+'_CP (ID int NOT NULL PRIMARY KEY IDENTITY,
		Uname varchar(Max), 
		Dname varchar(Max),  
		UDname varchar(Max),
		MinScore float,
		SalaryInK float,
		P float,
		C float,
		CP float);'+
		'INSERT INTO '+@gname+'_CP(Uname, DName, UDName, MinScore, SalaryInK) Select ALL_CP.UName, ALL_CP.DName, ALL_CP.UDName, ROUND(AVG(ALL_CP.MinScore),2), ROUND(AVG(ALL_CP.SalaryInK),2)
		From ALL_CP, DC, CG Where ALL_CP.DID = DC.DID And DC.CName = CG.CName And CG.GName = '''+@gname+''' Group By ALL_CP.UName, ALL_CP.DName, ALL_CP.UDName;'+
		'Update D1 Set D1.P = (SELECT COUNT(D2.MinScore) FROM '+@gname+'_CP D2 WHERE D1.MinScore < D2.MinScore)+1 FROM '+@gname+'_CP D1;'+
		'Update D1 Set D1.C = (SELECT COUNT(D2.SalaryInK) FROM '+@gname+'_CP D2 WHERE D1.SalaryInK < D2.SalaryInK) +1 FROM '+@gname+'_CP D1;'+
		'declare @total int; set @total = (Select Count(*) From '+@gname+'_CP);
		Update '+@gname+'_CP Set P=ROUND((@total-P+1)/@total*100,2), C=ROUND((@total-C+1)/@total*100,2);
		Update '+@gname+'_CP Set CP=ROUND(C-P,2);'
		execute(@sql)
		delete from #GroupList where #GroupList.name = @gname
		set @g_total = (select COUNT(*) from #GroupList);
	end
	drop table #GroupList
END
GO


Insert into dbo.NflPlayType select distinct PlayType from dbo.NflPlay;

Update NflPlay
SET NflPlay.NflPlayTypeId = NflPlayType.Id
From NflPlay inner join NflPlayType on NflPlay.PlayType = NflPlayType.[Description]

DECLARE @EmptyPlayTypeId as Int
SET @EmptyPlayTypeId = (select Id from dbo.NflPlayType Where [Description] = '')

Update dbo.NflPlay 
Set NflPlayTypeId = NULL
Where NflPlayTypeId = @EmptyPlayTypeId

Delete from dbo.NflPlayType Where Id = @EmptyPlayTypeId
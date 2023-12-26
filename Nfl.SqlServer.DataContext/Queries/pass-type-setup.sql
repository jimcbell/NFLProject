-- Insert the different pass types into the pass type table.
Insert into dbo.NflPassType select distinct PassType from dbo.NflPlay

-- Update the database with references to the new pass type table.
Update NflPlay
SET NflPlay.NflPassTypeId = NflPassType.Id
From NflPlay inner join NflPassType on NflPlay.PassType = NflPassType.[Description]

-- There is an empty pass type and play type for when records don't have these, find the id of this in the table.
DECLARE @EmptyPassTypeId as Int
SET @EmptyPassTypeId = (select Id from dbo.NflPassType Where [Description] = '')

--Select * from dbo.NflPassType Where Id = @EmptyPassTypeId

-- Make these references null to the empty pass type as we are going to remove it from the table.
Update dbo.NflPlay 
Set NflPassTypeId = NULL
Where NflPassTypeId = @EmptyPassTypeId

-- Delete the empty pass type from the pass type table
Delete from dbo.NflPassType Where Id = @EmptyPassTypeId


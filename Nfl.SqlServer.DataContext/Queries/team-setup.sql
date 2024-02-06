Insert into dbo.NflTeam select distinct OffenseTeam from dbo.NflPlay

Update NflPlay
SET NflPlay.OffensiveTeamId = NflTeam.Id
From NflTeam inner join NflPlay on NflPlay.OffenseTeam = NflTeam.ShortName

Update NflPlay
SET NflPlay.DefensiveTeamId = NflTeam.Id
From NflTeam inner join NflPlay on NflPlay.DefenseTeam = NflTeam.ShortName


select * from dbo.NflPlay p 
join NflTeam t 
on p.OffensiveTeamId = t.Id

select * from dbo.NflPlay p 
join NflTeam t 
on p.DefensiveTeamId = t.Id
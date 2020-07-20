UPDATE [dbo].[allpeople] SET [Name]=[dbo].[Clients].Name, [FirstName]=[dbo].[Clients].[FirstName]
FROM [dbo].[Clients]
WHERE [dbo].[allpeople].[Id]=[dbo].[Clients].[Id] 




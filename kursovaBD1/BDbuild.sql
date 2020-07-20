UPDATE [dbo].[allpeople] SET [Street ]=[dbo].[BUILDS].[Street],[home]=[dbo].[BUILDS].[home],[flat]=[dbo].[BUILDS].[flat]
FROM [dbo].[BUILDS]
WHERE [dbo].[allpeople].[Id]=[dbo].[BUILDS].[Id]
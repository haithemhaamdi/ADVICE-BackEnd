USE [ARTIPERSONNEL_SOC001]
GO

INSERT INTO [dbo].[USER]
           ([CodeUser]
           ,[CodeEmploye]
           ,[Login]
           ,[Password]
           ,[Connections]
           ,[MacAddress]
           ,[CreateDate]
           ,[ModifyDate]
           ,[Status]
           ,[CodeRole])
     VALUES
           ('USR000001'
           ,'EMP000001'
           ,'DHWAFA'
           ,'49-9D-F2-AF-B4-C0-31-18-89-3B-40-2C-1D-71-27-D0'
           ,5
           ,'41.89.54.135'
           ,GETDATE()
           ,GETDATE()
           ,1
		   ,'R001')
GO
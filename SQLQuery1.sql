USE [H:\AGILE TEAM\.VS\STOCK.MDF]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblStocks_SelectAll]

SELECT	@return_value as 'Return Value'

GO

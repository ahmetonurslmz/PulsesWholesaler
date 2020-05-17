CREATE PROCEDURE [dbo].[PcheckAvailabilityPulseStock]
	@GetPulseStockId int = 0
AS
	SELECT * FROM [dbo].[PulseStocks] WHERE pulse_stock_id=@GetPulseStockId
RETURN 0
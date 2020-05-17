CREATE PROCEDURE [dbo].[PupdatePulseStock]
	@PulseStockId int,
	@NewPulseStockSize int
AS
	UPDATE [dbo].[PulseStocks] SET pulse_stock_size=@NewPulseStockSize
	WHERE pulse_stock_id=@PulseStockId
RETURN 0

CREATE PROCEDURE [dbo].[PfetchSales]
AS
	SELECT customer_id, customer_tc_id, customer_full_name, pulse_name, pulse_quantity
	FROM [dbo].[Sales]
	INNER JOIN [dbo].[PulseStocks]
	ON [dbo].[Sales].pulse_type_id = [dbo].[PulseStocks].pulse_stock_id
RETURN 0
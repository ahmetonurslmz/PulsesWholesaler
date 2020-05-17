CREATE PROCEDURE [dbo].[PcreateSale]
	@CustomerTcId bigint,
	@CustomerFullName nvarchar(50),
	@PulseTypeId int,
	@PulseQuantity int
AS
	INSERT INTO [dbo].[Sales] (customer_tc_id, customer_full_name, pulse_type_id, pulse_quantity) VALUES (@CustomerTcId, @CustomerFullName, @PulseTypeId, @PulseQuantity)
RETURN 0

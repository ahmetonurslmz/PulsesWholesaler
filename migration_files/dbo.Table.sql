CREATE TABLE [dbo].[Sales]
(
	[customer_id] INT NOT NULL PRIMARY KEY, 
    [customer_tc_id] INT NOT NULL, 
    [customer_full_name] NCHAR(10) NOT NULL, 
    [pulse_type_id] INT NOT NULL, 
    [pulse_quantity] INT NOT NULL
)

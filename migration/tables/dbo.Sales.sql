CREATE TABLE [dbo].[Sales]
(
	[customer_id]        INT        IDENTITY (1, 1) NOT NULL,
    [customer_tc_id]     BIGINT     NOT NULL,
    [customer_full_name] NCHAR (50) NOT NULL,
    [pulse_type_id]      INT        NOT NULL,
    [pulse_quantity]     INT        NOT NULL,
    PRIMARY KEY CLUSTERED ([customer_id] ASC),
    FOREIGN KEY ([pulse_type_id]) REFERENCES [dbo].[PulseStocks] ([pulse_stock_id])
)

CREATE TABLE [dbo].[PulseStocks] (
    [pulse_stock_id]   INT          IDENTITY (1, 1) NOT NULL,
    [pulse_stock_size] INT          DEFAULT ((1000)) NULL,
    [pulse_name]       VARCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([pulse_stock_id] ASC)
);


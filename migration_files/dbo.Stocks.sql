CREATE TABLE [dbo].[Stocks] (
    [stock_id]   INT        IDENTITY (1, 1) NOT NULL,
    [stock_size] INT        NULL,
    [pulse_name] VARCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([stock_id] ASC)
);


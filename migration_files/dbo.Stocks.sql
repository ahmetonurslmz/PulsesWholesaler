CREATE TABLE [dbo].[Stocks] (
    [stock_id]   INT        NOT NULL IDENTITY(1,1),
    [stock_size] INT        NULL,
    [pulse_name] NCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([stock_id] ASC)
);




CREATE TABLE [dbo].[Sales] (
    [customer_id]        INT        NOT NULL,
    [customer_tc_id]     INT        NOT NULL,
    [customer_full_name] NCHAR (10) NOT NULL,
    [pulse_type_id]      INT        NOT NULL foreign key references Stocks(stock_id),
    [pulse_quantity]     INT        NOT NULL,
    PRIMARY KEY CLUSTERED ([customer_id] ASC)
);


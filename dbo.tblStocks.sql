CREATE TABLE [dbo].[tblStocks] (
    [item_id]            INT        IDENTITY (1, 1) NOT NULL,
    [item_name]          VARCHAR(50) NULL,
    [item_description]   VARCHAR(50) NULL,
    [item_available]     VARCHAR(50) NULL,
    [quantity_available] BIT        NULL,
    [price_per_item]     MONEY      NULL,
    [supplier_id]        INT        NULL,
    [order_id]           INT        NULL,
    [restock_date]       DATE       NULL,
    PRIMARY KEY CLUSTERED ([item_id] ASC)
);


CREATE Table [dbo].[Table] (
    [UserId]     INT           IDENTITY (1, 1) NOT NULL,
    [UserName]   NVARCHAR (50) NOT NULL,
    [UserAmount] INT           DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC)
);


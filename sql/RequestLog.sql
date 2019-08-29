CREATE TABLE RequestLog (
    ID int IDENTITY (1, 1) NOT NULL,
    Request nvarchar(max) NOT NULL,
    VrijemePocetka DateTime NOT NULL,
    VrijemeKraja DateTime NOT NULL,

    CONSTRAINT PK_RequestLog PRIMARY KEY CLUSTERED (ID),
)

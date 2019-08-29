CREATE TABLE Grad (
    ID int IDENTITY (1, 1) NOT NULL,
    Naziv nvarchar(255) NOT NULL,
    BrojStanovnika int NOT NULL,
    DrzavaID int NOT NULL,
    Active bit NOT NULL DEFAULT 1,

    CONSTRAINT PK_Grad PRIMARY KEY CLUSTERED (ID),
    CONSTRAINT FK_Grad_Drzava FOREIGN KEY (DrzavaID) REFERENCES Drzava(ID)
)

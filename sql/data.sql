

ALTER TABLE Grad DROP CONSTRAINT [FK_Grad_Drzava];

TRUNCATE TABLE Grad;
TRUNCATE TABLE Drzava;

ALTER TABLE Grad ADD CONSTRAINT FK_Grad_Drzava FOREIGN KEY (DrzavaID) REFERENCES Drzava(ID);

INSERT INTO Drzava (Naziv, Active)
VALUES
    ('Hrvatska', 1),
    ('Slovenija', 1),
    ('Španjolska', 1)

INSERT INTO Grad (Naziv, BrojStanovnika, DrzavaID, Active)
VALUES
    ('Zagreb', 600000, 1, 1),
    ('Ljubljana', 150000, 2, 1),
    ('Maribor', 100000, 2, 1),
    ('Madrid', 3000000, 3, 1),
    ('Barcelona', 1500000, 3, 1),
    ('Valencia', 700000, 3, 1)



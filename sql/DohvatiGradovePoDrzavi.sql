CREATE PROCEDURE DohvatiGradovePoDrzavi
(
    @DrzavaID int = NULL
)
AS

SELECT
    g.ID,
    g.Naziv
FROM Grad g
WHERE
    @DrzavaID IS NULL
    OR g.DrzavaID = @DrzavaID
CREATE PROCEDURE DohvatiDrzaveIGradovePoBrojuStanovnika
(
    @BrojStanovnika int
)
AS

SELECT
    g.ID,
    g.Naziv,
    IsDrzava = 0
FROM Grad g
WHERE
    g.BrojStanovnika > @BrojStanovnika

UNION ALL

SELECT
    d.ID,
    d.Naziv,
    IsDrzava = 1
FROM
    Drzava d
    INNER JOIN Grad g on g.DrzavaID = d.ID
GROUP BY
	d.ID,
	d.Naziv
HAVING SUM(g.BrojStanovnika) > @BrojStanovnika
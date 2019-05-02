-- every track, with his genre
SELECT Track.Name, Genre.Name
FROM TRACK
	LEFT OUTER JOIN Genre ON Track.GenreId = Genre.GenreId;

-- condition is always ture
SELECT g1.Name, g2.Name -- works as a cross join
From Genre as g1
	INNER JOIN Genre AS g2 ON 1 = 1;

-- all rock songs in the database, showing the name like this:
--        (artist name)  - (song name)

SELECT COALESCE(Artist.Name, 'Unknown Artist') + '-' + Track.Name
FROM Album
	INNER JOIN Track ON Track.AlbumId = Album.AlbumId
	Inner Join Artist ON Artist.ArtistId = Album.ArtistId
	Inner Join Genre ON Track.GenreID = Track.GenreId
WHERE Genre.Name = 'Rock'

SELECT FirstName FROM Employee
UNION ALL
SELECT FirstName FROM Customer;

SELECT FirstName FROM Employee
INTERSECT
SELECT FirstName FROM Customer;
--these two do the same thing
SELECT DISTINCT e.FirstName
FROM Employee AS e
	INNER JOIN Customer as c on e.FirstName = c.FirstName

SELECT FirstName FROM Employee
EXCEPT 
SELECT FirstName FROM Customer;

-- every track that has never been purchased
SELECT TrackID, Name
FROM Track
WHERE TRACKID NOT IN(
SELECT TrackID 
FROM InvoiceLine
);

--the track that has been bought the most times
SELECT Name
FROM Track
WHERE TrackID = (
	SELECT TOP(1) TrackId
	FROM InvoiceLine
	GROUP BY TrackId
	ORDER BY SUM(Quantity) DESC, TrackId
);

-- similar to subquery is "common table expression" (CTE)
WITH PurchasedTracks AS (
	SELECT TrackID
	FROM InvoiceLine
)
SELECT TrackID, Name
FROM Track
Where TrackID NOT IN (
	SELECT * FROM PurchasedTracks
	)

-- the artist with the longest title
SELECT *
FROM Artist
WHERE ArtistId IN (
	SELECT ArtistId
	FROM Album
	WHERE LEN(Title) >= ALL (
		SELECT LEN(Title) FROM Album
		)
);

-- 1. which artists did not make any albums at all?
SELECT Name
FROM Artist
WHERE ArtistID NOT IN(
	SELECT ArtistId
	FROM Album
);

SELECT Name
FROM Artist
	INNER JOIN Album ON Artist.ArtistId = Album.ArtistId
--WHERE 

-- 2. which artists did not record any tracks of the Latin genre?
SELECT DISTINCT Artist.Name
FROM Artist
	INNER JOIN Album ON Artist.ArtistId = Album.ArtistId
	Inner Join Track ON Album.AlbumId = Track.AlbumId
	Inner Join Genre ON Track.GenreId =	Genre.GenreId
WHERE Album.ArtistId NOT IN(
	SELECT ArtistId
	FROM Album
		INNER JOIN Track ON Album.AlbumId = Track.AlbumId
		INNER JOIN Genre ON Track.GenreId = Genre.GenreId
	WHERE Genre.Name = 'Latin'
	)


-- 3. which video track has the longest length? (use media type table)

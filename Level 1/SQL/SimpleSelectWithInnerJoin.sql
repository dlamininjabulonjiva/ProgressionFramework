SELECT DISTINCT b.Name as BuldingName, ISNULL(COUNT(DISTINCT bks.Id),0) as BookableSpaces, r.Number
FROM dbo.BookableSpace bks WITH(NOLOCK)
INNER JOIN dbo.Building b WITH(NOLOCK)
	ON bks.BuildingId = b.Id
INNER JOIN dbo.Room r WITH(NOLOCK)
	ON bks.RoomId = r.Id
WHERE r.Availability = 0
	  AND r.CheckedIn = 0
GROUP BY b.Name, r.Number
DECLARE @AvailableSpaces AS TABLE
(
	buldingName NVARCHAR(50),
	bookableSpaces INT
)

INSERT INTO @AvailableSpaces
SELECT b.Name as buldingName, ISNULL(COUNT(DISTINCT bks.Id),0) as bookableSpaces
FROM dbo.BookableSpace bks WITH(NOLOCK)
INNER JOIN dbo.Building b WITH(NOLOCK)
	ON bks.BuildingId = b.Id
INNER JOIN dbo.Room r WITH(NOLOCK)
	ON bks.RoomId = r.Id
WHERE r.Availability = 1
AND r.MoveInDate >= GETDATE()
GROUP BY b.Name

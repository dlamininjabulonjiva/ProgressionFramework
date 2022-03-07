;WITH UpdateAll AS (
	SELECT DateAdded
	FROM Customer
)
UPDATE UpdateAll
SET DateAdded = GETDATE()
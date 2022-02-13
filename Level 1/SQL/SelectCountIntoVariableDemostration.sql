Declare  @count int
Select @count = COALESCE(COUNT(bk.Id),0) 
From dbo.Booking bk (nolock)
INNER JOIN Building bld (nolock)
	ON bk.BuildingId = bld.Id
WHERE bk.IntendsToRenew = 0 And bld.Name = 'The Lab'

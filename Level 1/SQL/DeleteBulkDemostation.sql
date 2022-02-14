Declare @NumberOfItemsToDelete int
Declare @PolicyID int
Declare @PolicyTypeId int

DELETE PolicyHistoryTemp FROM
(
	SELECT TOP (CAST(@NumberOfItemsToDelete AS INTEGER)) *
	FROM tblPolicyHistory 
	WHERE  fPolicyID = @PolicyID
	AND fPolicyTypeId = @PolicyTypeId
) PolicyHistoryTemp;

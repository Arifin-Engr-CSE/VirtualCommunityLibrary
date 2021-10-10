CREATE PROC [dbo].[ItemHistory_GetAll]
	@ItemID int
AS
/*
Created on - 21/03/2021
Created by - Shamim

Purpose - Get Book history
Usage - In BookController BookHistory GET method

*/
SET NOCOUNT ON

--temp table variable to store books history data

DECLARE @BookHistory TABLE
(
	RowID SMALLINT,
	EventDate DATE, 
	BookName NVARCHAR(200),
	EventType NVARCHAR(200),
	EventDetail NVARCHAR(1000)
)

INSERT INTO @BookHistory(EventDate,BookName,EventType,EventDetail)
	
	SELECT --Book add history
		t1.CreatedOn, 
		t1.ItemName, 
		'Added' AS EventType, 
		CONCAT('Book gifted by ', t2.PartyName) AS EventDetail
	FROM [dbo].[Item] t1 WITH(NOLOCK) 
		INNER JOIN [dbo].[ItemParty] t2 WITH(NOLOCK) 
			ON t1.ItemOwnerID = t2.ItemPartyID
			AND t1.ItemID = @ItemID
	UNION ALL

	SELECT  --Borrow history
		t1.BorrowDate,
		t2.ItemName,
		'Borrowed',
		CONCAT('Book borrowed by ', t3.PartyName ,' for ', t1.BorrowedForHowManyDays, ' days')
	FROM [dbo].[ItemBorrowHistory] t1 WITH(NOLOCK)
		INNER JOIN [dbo].[Item] t2 WITH(NOLOCK) 
			ON t1.ItemID = t2.ItemID 
			AND t1.ItemID = @ItemID
		INNER JOIN [dbo].[ItemParty] t3 WITH(NOLOCK) 
			ON t1.ItemPartyID = t3.ItemPartyID

	UNION ALL

	SELECT --Returned history
		t1.ActualReturnDate,
		t2.ItemName,
		'Returned',
		CONCAT('Book returned by ', t3.PartyName,' after ', DATEDIFF(DAY, t1.BorrowDate,t1.ActualReturnDate), ' days')
	FROM [dbo].[ItemBorrowHistory] t1 WITH(NOLOCK)
		INNER JOIN [dbo].[Item] t2 WITH(NOLOCK) 
			ON t1.ItemID = t2.ItemID 
			AND t1.ActualReturnDate IS NOT NULL
			AND t1.ItemID = @ItemID
		INNER JOIN [dbo].[ItemParty] t3 WITH(NOLOCK) 
			ON t1.ItemPartyID = t3.ItemPartyID

--Display the data

	SELECT 
		RowID = ROW_NUMBER() OVER(ORDER BY EventDate DESC),
		EventDate,
		BookName,
		EventType,
		EventDetail
	FROM @BookHistory

SET NOCOUNT OFF


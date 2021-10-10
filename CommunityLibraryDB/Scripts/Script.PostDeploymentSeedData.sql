/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
--seeding [ItemBorrowDayCounts]
GO
INSERT [dbo].[ItemBorrowDayCount] ([LibraryLocationID], [NumberOfDays]) VALUES ( 1, 5)
GO
INSERT [dbo].[ItemBorrowDayCount] ([LibraryLocationID], [NumberOfDays]) VALUES ( 1, 7)
GO
INSERT [dbo].[ItemBorrowDayCount] ([LibraryLocationID], [NumberOfDays]) VALUES ( 2, 7)
GO
INSERT [dbo].[ItemBorrowDayCount] ([LibraryLocationID], [NumberOfDays]) VALUES ( 2, 4)
GO

--seeding [ItemBorrowHistories]
SET IDENTITY_INSERT [dbo].[ItemBorrowHistories] ON 
GO
INSERT [dbo].[ItemBorrowHistories] ([ItemBorrowID], [ItemID], [ItemPartyID], [LibraryLocationID], [BorrowDate], [BorrowedForHowManyDays], [ReturnDate], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [ItemBorrowDayCountID]) VALUES (1, 2, 4, 6, CAST(N'2021-03-03T00:00:00.000' AS DateTime), 7, CAST(N'2021-03-11T00:00:00.000' AS DateTime), NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[ItemBorrowHistories] ([ItemBorrowID], [ItemID], [ItemPartyID], [LibraryLocationID], [BorrowDate], [BorrowedForHowManyDays], [ReturnDate], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [ItemBorrowDayCountID]) VALUES (2, 1, 2, 1, CAST(N'2021-03-01T00:00:00.000' AS DateTime), 7, CAST(N'2021-03-25T00:00:00.000' AS DateTime), NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[ItemBorrowHistories] ([ItemBorrowID], [ItemID], [ItemPartyID], [LibraryLocationID], [BorrowDate], [BorrowedForHowManyDays], [ReturnDate], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [ItemBorrowDayCountID]) VALUES (3, 1, 2, 1, CAST(N'2021-03-04T00:00:00.000' AS DateTime), 7, CAST(N'2021-03-19T00:00:00.000' AS DateTime), NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[ItemBorrowHistories] ([ItemBorrowID], [ItemID], [ItemPartyID], [LibraryLocationID], [BorrowDate], [BorrowedForHowManyDays], [ReturnDate], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [ItemBorrowDayCountID]) VALUES (4, 1, 2, 1, NULL, 0, CAST(N'2021-03-05T00:00:00.000' AS DateTime), NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[ItemBorrowHistories] ([ItemBorrowID], [ItemID], [ItemPartyID], [LibraryLocationID], [BorrowDate], [BorrowedForHowManyDays], [ReturnDate], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [ItemBorrowDayCountID]) VALUES (5, 1, 2, 1, NULL, 0, CAST(N'2021-03-06T00:00:00.000' AS DateTime), NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[ItemBorrowHistories] ([ItemBorrowID], [ItemID], [ItemPartyID], [LibraryLocationID], [BorrowDate], [BorrowedForHowManyDays], [ReturnDate], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [ItemBorrowDayCountID]) VALUES (6, 2, 4, 6, CAST(N'2021-03-05T00:00:00.000' AS DateTime), 7, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[ItemBorrowHistories] ([ItemBorrowID], [ItemID], [ItemPartyID], [LibraryLocationID], [BorrowDate], [BorrowedForHowManyDays], [ReturnDate], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [ItemBorrowDayCountID]) VALUES (7, 2, 4, 6, CAST(N'2021-03-12T00:00:00.000' AS DateTime), 7, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[ItemBorrowHistories] ([ItemBorrowID], [ItemID], [ItemPartyID], [LibraryLocationID], [BorrowDate], [BorrowedForHowManyDays], [ReturnDate], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [ItemBorrowDayCountID]) VALUES (9, 3, 2, 5, CAST(N'2021-03-13T00:00:00.000' AS DateTime), 5, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[ItemBorrowHistories] ([ItemBorrowID], [ItemID], [ItemPartyID], [LibraryLocationID], [BorrowDate], [BorrowedForHowManyDays], [ReturnDate], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [ItemBorrowDayCountID]) VALUES (10, 2, 1, 6, CAST(N'2021-03-03T00:00:00.000' AS DateTime), 7, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[ItemBorrowHistories] ([ItemBorrowID], [ItemID], [ItemPartyID], [LibraryLocationID], [BorrowDate], [BorrowedForHowManyDays], [ReturnDate], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [ItemBorrowDayCountID]) VALUES (11, 4, 1, 2, CAST(N'2021-03-10T00:00:00.000' AS DateTime), 7, CAST(N'2021-03-17T00:00:00.000' AS DateTime), NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[ItemBorrowHistories] ([ItemBorrowID], [ItemID], [ItemPartyID], [LibraryLocationID], [BorrowDate], [BorrowedForHowManyDays], [ReturnDate], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [ItemBorrowDayCountID]) VALUES (12, 1, 1, 1, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[ItemBorrowHistories] OFF
GO

--Seeding [ItemBorrowStatus]
SET IDENTITY_INSERT [dbo].[ItemBorrowStatus] ON 
GO
INSERT [dbo].[ItemBorrowStatus] ([BorrowStatusID], [BorrowStatus], [BorrowDescription], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [LibraryLocationID]) VALUES (1, N'Borrowed', N'test', CAST(N'2021-03-02T18:21:44.597' AS DateTime), N'af615eac-f99e-4bfa-98b9-cdfe2392177b', NULL, NULL, 1)
GO
INSERT [dbo].[ItemBorrowStatus] ([BorrowStatusID], [BorrowStatus], [BorrowDescription], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [LibraryLocationID]) VALUES (2, N'Available', N'test', CAST(N'2021-03-02T18:21:55.443' AS DateTime), N'af615eac-f99e-4bfa-98b9-cdfe2392177b', NULL, NULL, 1)
GO
INSERT [dbo].[ItemBorrowStatus] ([BorrowStatusID], [BorrowStatus], [BorrowDescription], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [LibraryLocationID]) VALUES (5, N'Borrowed', N'test', CAST(N'2021-03-02T18:25:11.627' AS DateTime), N'af615eac-f99e-4bfa-98b9-cdfe2392177b', NULL, NULL, 1)
GO
INSERT [dbo].[ItemBorrowStatus] ([BorrowStatusID], [BorrowStatus], [BorrowDescription], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [LibraryLocationID]) VALUES (6, N'Withdrawn', N'test', CAST(N'2021-03-02T18:25:49.600' AS DateTime), N'af615eac-f99e-4bfa-98b9-cdfe2392177b', NULL, NULL, 1)
GO
SET IDENTITY_INSERT [dbo].[ItemBorrowStatus] OFF

--seeding ItemLibraryLocations
GO
SET IDENTITY_INSERT [dbo].[ItemLibraryLocation] ON 
GO
INSERT [dbo].[ItemLibraryLocation] ([LibraryLocationID], [LibraryLocationName], [LibraryLocationAddress], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [LibraryLocationManagerID]) VALUES (1, N'MountDruitt', N'test', CAST(N'2021-03-02T18:20:39.830' AS DateTime), N'af615eac-f99e-4bfa-98b9-cdfe2392177b', NULL, NULL, 1)
GO
INSERT [dbo].[ItemLibraryLocation] ([LibraryLocationID], [LibraryLocationName], [LibraryLocationAddress], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [LibraryLocationManagerID]) VALUES (2, N'RootyHill', N'test', CAST(N'2021-03-02T18:20:54.330' AS DateTime), N'af615eac-f99e-4bfa-98b9-cdfe2392177b', NULL, NULL, 4)
GO
SET IDENTITY_INSERT [dbo].[ItemLibraryLocation] OFF

--seeding ItemParties
GO
SET IDENTITY_INSERT [dbo].[ItemParty] ON 
GO
INSERT [dbo].[ItemParty] ([ItemPartyID], [PartyName], [PartyAddress], [PartyMobile], [PartyNoteIfAny], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [PartyTypeID]) VALUES (1, N'Item Party1', N'test', N'01700000000', N'test', CAST(N'2021-03-02T18:18:55.720' AS DateTime), N'af615eac-f99e-4bfa-98b9-cdfe2392177b', NULL, NULL, 3)
GO                    
INSERT [dbo].[ItemParty] ([ItemPartyID], [PartyName], [PartyAddress], [PartyMobile], [PartyNoteIfAny], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [PartyTypeID]) VALUES (2, N'Item Party2', N'test', N'01700000000', N'test', CAST(N'2021-03-02T18:19:18.133' AS DateTime), N'af615eac-f99e-4bfa-98b9-cdfe2392177b', NULL, NULL, 3)
GO                    
INSERT [dbo].[ItemParty] ([ItemPartyID], [PartyName], [PartyAddress], [PartyMobile], [PartyNoteIfAny], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [PartyTypeID]) VALUES (3, N'Item Party3', N'test', N'01700000000', N'test', CAST(N'2021-03-02T18:19:43.053' AS DateTime), N'af615eac-f99e-4bfa-98b9-cdfe2392177b', NULL, NULL, 2)
GO                    
INSERT [dbo].[ItemParty] ([ItemPartyID], [PartyName], [PartyAddress], [PartyMobile], [PartyNoteIfAny], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [PartyTypeID]) VALUES (4, N'Item Party4', N'test', N'01700000000', N'test', CAST(N'2021-03-02T18:20:10.073' AS DateTime), N'af615eac-f99e-4bfa-98b9-cdfe2392177b', NULL, NULL, 3)
GO
SET IDENTITY_INSERT [dbo].[ItemParty] OFF
GO

--ItemPartyTypes
SET IDENTITY_INSERT [dbo].[ItemPartyType] ON 
GO
INSERT [dbo].[ItemPartyType] ([ItemPartyTypeID], [PartyTypeName], [PartyTypeDescription], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (1, N'LibraryInCharge', N'test', CAST(N'2021-03-02T18:17:33.777' AS DateTime), N'af615eac-f99e-4bfa-98b9-cdfe2392177b', NULL, NULL)
GO
INSERT [dbo].[ItemPartyType] ([ItemPartyTypeID], [PartyTypeName], [PartyTypeDescription], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (2, N'Borrower', N'test', CAST(N'2021-03-02T18:17:45.583' AS DateTime), N'af615eac-f99e-4bfa-98b9-cdfe2392177b', NULL, NULL)
GO
INSERT [dbo].[ItemPartyType] ([ItemPartyTypeID], [PartyTypeName], [PartyTypeDescription], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (3, N'Owner', N'test', CAST(N'2021-03-02T18:17:56.703' AS DateTime), N'af615eac-f99e-4bfa-98b9-cdfe2392177b', NULL, NULL)
GO
INSERT [dbo].[ItemPartyType] ([ItemPartyTypeID], [PartyTypeName], [PartyTypeDescription], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (4, N'Supporter', N'test', CAST(N'2021-03-02T18:18:06.587' AS DateTime), N'af615eac-f99e-4bfa-98b9-cdfe2392177b', NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[ItemPartyType] OFF
GO

--seeding ItemPhotoes
SET IDENTITY_INSERT [dbo].[ItemPhotoes] ON 
GO
GO
INSERT [dbo].[ItemPhotoes] ([PhotoID], [PhotoURL], [PhotoBinary], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [ItemID], [PhotoPriority]) VALUES (24, N'~/AppFiles/Images/2212230268.jpg', '', NULL, NULL, NULL, NULL, 2, 1)
GO
INSERT [dbo].[ItemPhotoes] ([PhotoID], [PhotoURL], [PhotoBinary], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy], [ItemID], [PhotoPriority]) VALUES (25, N'~/AppFiles/Images/default.png', NULL, NULL, NULL, NULL, NULL, 3, 2)
GO
SET IDENTITY_INSERT [dbo].[ItemPhotoes] OFF
GO

--seeding Items
SET IDENTITY_INSERT [dbo].[Item] ON 
GO
INSERT [dbo].[Item] ([ItemID], [ItemName], [ItemOwnerID], [ItemMaker], [ItemProducer], [ItemTypeID], [ItemHasPhoto], [ItemBorrowStatusID], [LibraryLocationID], [ItemConditionWhenRegistered], [AdditionalNote], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (1, N'The Greate Miracle-The story of THE PROPHET ISA', 1, N'', N'UK ISLAMIC ACADEMY', 2, 1, 2, 1, N'test', N'test', CAST(N'2021-03-02T18:27:23.793' AS DateTime), N'af615eac-f99e-4bfa-98b9-cdfe2392177b', NULL, NULL)
GO
INSERT [dbo].[Item] ([ItemID], [ItemName], [ItemOwnerID], [ItemMaker], [ItemProducer], [ItemTypeID], [ItemHasPhoto], [ItemBorrowStatusID], [LibraryLocationID], [ItemConditionWhenRegistered], [AdditionalNote], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (2, N'AN-NAWAWI FORTY HADITH',  1, N'EZZEDIN IBRAHIM, DENYS JOHNSON-DAVIS', N'Islamic Book Service Ltd', 1, 1, 1, 6, N'test', N'test', CAST(N'2021-03-02T18:27:53.323' AS DateTime), N'af615eac-f99e-4bfa-98b9-cdfe2392177b', NULL, NULL)
GO
INSERT [dbo].[Item] ([ItemID], [ItemName], [ItemOwnerID], [ItemMaker], [ItemProducer], [ItemTypeID], [ItemHasPhoto], [ItemBorrowStatusID], [LibraryLocationID], [ItemConditionWhenRegistered], [AdditionalNote], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (3, N'Marvellous stories from the life of Muhammad',  1, N'Mardijah Aldrich Tarantino', N'The Islamic Foundation', 2, 0, 2, 5, N'test', N'test', CAST(N'2021-03-02T18:28:13.830' AS DateTime), N'af615eac-f99e-4bfa-98b9-cdfe2392177b', NULL, NULL)
GO
INSERT [dbo].[Item] ([ItemID], [ItemName], [ItemOwnerID], [ItemMaker], [ItemProducer], [ItemTypeID], [ItemHasPhoto], [ItemBorrowStatusID], [LibraryLocationID], [ItemConditionWhenRegistered], [AdditionalNote], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (4, N'For those who seek reason', 1, N'Dr. Saiyeed Afsar Mahmood', N'London Islamic Research Academy', 1, 1, 2, 2, N'test', N'test', CAST(N'2021-03-02T18:28:41.137' AS DateTime), N'af615eac-f99e-4bfa-98b9-cdfe2392177b', NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Item] OFF

--seeding ItemTypes
GO
SET IDENTITY_INSERT [dbo].[ItemType] ON 
GO
INSERT [dbo].[ItemType] ([ID], [ItemTypeName], [TypeDescription], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (1, N'Book', N'test', CAST(N'2021-03-02T18:16:50.830' AS DateTime), N'af615eac-f99e-4bfa-98b9-cdfe2392177b', NULL, NULL)
GO
INSERT [dbo].[ItemType] ([ID], [ItemTypeName], [TypeDescription], [CreatedOn], [CreatedBy], [ModifiedOn], [ModifiedBy]) VALUES (2, N'Applence', N'test', CAST(N'2021-03-02T18:16:59.310' AS DateTime), N'af615eac-f99e-4bfa-98b9-cdfe2392177b', NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[ItemType] OFF

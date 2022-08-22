USE [KasaAppTwo]
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([Id], [UserName], [Password], [Name], [LastName], [EmailAddress], [Active], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (2, N'Zikadin', N'4e8a273b3543207fe94f17515b68f247', N'Zika', N'Zikadinovic', N'zika@gmail.com', 1, 0, CAST(N'2022-08-21T18:46:23.8872691' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employees] ([Id], [UserName], [Password], [Name], [LastName], [EmailAddress], [Active], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (3, N'Luka', N'ac9865496eb1efe3d300939368b5add8', N'Luka', N'Lukic', N'LukaAdmin@gmail.com', 1, 0, CAST(N'2022-08-21T20:26:43.6883107' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employees] ([Id], [UserName], [Password], [Name], [LastName], [EmailAddress], [Active], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (4, N'LukaKorisnik', N'd77c5fd2b7d0d4251d7eee5deedb49a8', N'Luka', N'Lukic', N'LukaKorisnik@gmail.com', 1, 0, CAST(N'2022-08-21T20:31:21.4506876' AS DateTime2), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
SET IDENTITY_INSERT [dbo].[Tables] ON 

INSERT [dbo].[Tables] ([Id], [Name], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted], [IsActive]) VALUES (1, N'Neki sto', 0, CAST(N'2022-08-20T13:53:30.8495145' AS DateTime2), CAST(N'2022-08-21T21:10:05.3958394' AS DateTime2), NULL, 0)
INSERT [dbo].[Tables] ([Id], [Name], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted], [IsActive]) VALUES (2, N'Pice', 1, CAST(N'2022-08-21T18:58:20.7221560' AS DateTime2), CAST(N'2022-08-21T00:00:00.0000000' AS DateTime2), CAST(N'2022-08-21T00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Tables] ([Id], [Name], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted], [IsActive]) VALUES (3, N'Stojedan', 0, CAST(N'2022-08-21T20:44:24.7563070' AS DateTime2), CAST(N'2022-08-21T21:19:06.7870355' AS DateTime2), NULL, 0)
INSERT [dbo].[Tables] ([Id], [Name], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted], [IsActive]) VALUES (4, N'StoDva', 0, CAST(N'2022-08-21T20:44:28.3180323' AS DateTime2), CAST(N'2022-08-21T21:10:55.7264637' AS DateTime2), NULL, 0)
INSERT [dbo].[Tables] ([Id], [Name], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted], [IsActive]) VALUES (5, N'Stozalukudatestira', 0, CAST(N'2022-08-21T21:21:29.9662235' AS DateTime2), NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[Tables] OFF
GO
SET IDENTITY_INSERT [dbo].[Bills] ON 

INSERT [dbo].[Bills] ([Id], [TableId], [WeiterId], [BillOpened], [BillClosed], [FinalPrice], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (2, 1, 2, CAST(N'2022-08-21T19:07:17.8872235' AS DateTime2), CAST(N'2022-08-21T19:11:16.1629383' AS DateTime2), CAST(420.00 AS Decimal(18, 2)), 0, CAST(N'2022-08-21T19:07:17.9420671' AS DateTime2), CAST(N'2022-08-21T19:11:18.0884824' AS DateTime2), NULL)
INSERT [dbo].[Bills] ([Id], [TableId], [WeiterId], [BillOpened], [BillClosed], [FinalPrice], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (3, 1, 2, CAST(N'2022-08-21T19:26:04.5164387' AS DateTime2), CAST(N'2022-08-21T21:10:05.3401317' AS DateTime2), CAST(1120.00 AS Decimal(18, 2)), 0, CAST(N'2022-08-21T19:26:04.5946604' AS DateTime2), CAST(N'2022-08-21T21:10:05.3957655' AS DateTime2), NULL)
INSERT [dbo].[Bills] ([Id], [TableId], [WeiterId], [BillOpened], [BillClosed], [FinalPrice], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (4, 4, 3, CAST(N'2022-08-21T20:50:01.0143425' AS DateTime2), CAST(N'2022-08-21T21:10:55.7240072' AS DateTime2), CAST(1620.00 AS Decimal(18, 2)), 0, CAST(N'2022-08-21T20:50:01.0484558' AS DateTime2), CAST(N'2022-08-21T21:10:55.7264628' AS DateTime2), NULL)
INSERT [dbo].[Bills] ([Id], [TableId], [WeiterId], [BillOpened], [BillClosed], [FinalPrice], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (5, 3, 3, CAST(N'2022-08-21T21:17:08.1529098' AS DateTime2), CAST(N'2022-08-21T21:19:07.6981809' AS DateTime2), CAST(1980.00 AS Decimal(18, 2)), 0, CAST(N'2022-08-21T21:17:08.2300706' AS DateTime2), CAST(N'2022-08-21T21:19:07.6995344' AS DateTime2), NULL)
SET IDENTITY_INSERT [dbo].[Bills] OFF
GO
SET IDENTITY_INSERT [dbo].[UseCases] ON 

INSERT [dbo].[UseCases] ([Id], [UseCaseIdentifier], [Name], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (1, 1, N'RegisterNewTable', 0, CAST(N'2022-08-21T20:21:34.3160463' AS DateTime2), NULL, NULL)
INSERT [dbo].[UseCases] ([Id], [UseCaseIdentifier], [Name], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (2, 2, N'GetTables', 0, CAST(N'2022-08-21T20:21:42.4139984' AS DateTime2), NULL, NULL)
INSERT [dbo].[UseCases] ([Id], [UseCaseIdentifier], [Name], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (3, 3, N'CreateNewBill', 0, CAST(N'2022-08-21T20:22:04.2887546' AS DateTime2), NULL, NULL)
INSERT [dbo].[UseCases] ([Id], [UseCaseIdentifier], [Name], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (4, 4, N'AddNewEmployee', 0, CAST(N'2022-08-21T20:22:11.2236436' AS DateTime2), NULL, NULL)
INSERT [dbo].[UseCases] ([Id], [UseCaseIdentifier], [Name], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (5, 5, N'AddNewType', 0, CAST(N'2022-08-21T20:22:19.9435332' AS DateTime2), NULL, NULL)
INSERT [dbo].[UseCases] ([Id], [UseCaseIdentifier], [Name], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (6, 6, N'RemoveType', 0, CAST(N'2022-08-21T20:22:25.4300519' AS DateTime2), NULL, NULL)
INSERT [dbo].[UseCases] ([Id], [UseCaseIdentifier], [Name], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (7, 7, N'UpdateType', 0, CAST(N'2022-08-21T20:22:30.9157840' AS DateTime2), NULL, NULL)
INSERT [dbo].[UseCases] ([Id], [UseCaseIdentifier], [Name], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (8, 8, N'GetType', 0, CAST(N'2022-08-21T20:22:36.0578715' AS DateTime2), NULL, NULL)
INSERT [dbo].[UseCases] ([Id], [UseCaseIdentifier], [Name], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (9, 9, N'NewSubType', 0, CAST(N'2022-08-21T20:22:41.4567491' AS DateTime2), NULL, NULL)
INSERT [dbo].[UseCases] ([Id], [UseCaseIdentifier], [Name], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (10, 10, N'RemoveSubType', 0, CAST(N'2022-08-21T20:22:48.6711318' AS DateTime2), NULL, NULL)
INSERT [dbo].[UseCases] ([Id], [UseCaseIdentifier], [Name], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (11, 11, N'UpdateSubType', 0, CAST(N'2022-08-21T20:22:52.8296153' AS DateTime2), NULL, NULL)
INSERT [dbo].[UseCases] ([Id], [UseCaseIdentifier], [Name], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (12, 12, N'GetSubType', 0, CAST(N'2022-08-21T20:22:58.6555300' AS DateTime2), NULL, NULL)
INSERT [dbo].[UseCases] ([Id], [UseCaseIdentifier], [Name], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (13, 13, N'NewMenu', 0, CAST(N'2022-08-21T20:23:08.9957649' AS DateTime2), NULL, NULL)
INSERT [dbo].[UseCases] ([Id], [UseCaseIdentifier], [Name], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (14, 14, N'RemoveMenu', 0, CAST(N'2022-08-21T20:23:13.5243183' AS DateTime2), NULL, NULL)
INSERT [dbo].[UseCases] ([Id], [UseCaseIdentifier], [Name], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (15, 15, N'UpdateMenu', 0, CAST(N'2022-08-21T20:23:18.3029814' AS DateTime2), NULL, NULL)
INSERT [dbo].[UseCases] ([Id], [UseCaseIdentifier], [Name], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (16, 16, N'Getmenus', 0, CAST(N'2022-08-21T20:23:29.7144376' AS DateTime2), NULL, NULL)
INSERT [dbo].[UseCases] ([Id], [UseCaseIdentifier], [Name], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (17, 17, N'AddBillDetail', 0, CAST(N'2022-08-21T20:23:43.5066742' AS DateTime2), NULL, NULL)
INSERT [dbo].[UseCases] ([Id], [UseCaseIdentifier], [Name], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (18, 18, N'CloseBill', 0, CAST(N'2022-08-21T20:23:50.4830796' AS DateTime2), NULL, NULL)
INSERT [dbo].[UseCases] ([Id], [UseCaseIdentifier], [Name], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (19, 19, N'ActivateUser', 0, CAST(N'2022-08-21T20:23:55.7477936' AS DateTime2), NULL, NULL)
INSERT [dbo].[UseCases] ([Id], [UseCaseIdentifier], [Name], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (20, 20, N'AddPriviledgeToUser', 0, CAST(N'2022-08-21T20:24:20.6724232' AS DateTime2), NULL, NULL)
INSERT [dbo].[UseCases] ([Id], [UseCaseIdentifier], [Name], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (21, 21, N'AddUseCase', 0, CAST(N'2022-08-21T20:24:24.9228464' AS DateTime2), NULL, NULL)
INSERT [dbo].[UseCases] ([Id], [UseCaseIdentifier], [Name], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (22, 22, N'RemovePriviledgeFromuser', 0, CAST(N'2022-08-21T20:24:29.3377823' AS DateTime2), NULL, NULL)
INSERT [dbo].[UseCases] ([Id], [UseCaseIdentifier], [Name], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (23, 23, N'GetUseCase', 0, CAST(N'2022-08-21T20:24:38.6438576' AS DateTime2), NULL, NULL)
INSERT [dbo].[UseCases] ([Id], [UseCaseIdentifier], [Name], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (24, 24, N'GetUseCasePriviledge', 0, CAST(N'2022-08-21T20:24:42.6112862' AS DateTime2), NULL, NULL)
INSERT [dbo].[UseCases] ([Id], [UseCaseIdentifier], [Name], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (25, 25, N'GetAllLog', 0, CAST(N'2022-08-21T20:24:47.4752964' AS DateTime2), NULL, NULL)
INSERT [dbo].[UseCases] ([Id], [UseCaseIdentifier], [Name], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (26, 26, N'GetAllActiveBills', 0, CAST(N'2022-08-21T20:24:52.4690249' AS DateTime2), NULL, NULL)
SET IDENTITY_INSERT [dbo].[UseCases] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee_UseCases] ON 

INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (1, 3, 1, 0, CAST(N'2022-08-21T20:26:43.6884854' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (2, 3, 24, 0, CAST(N'2022-08-21T20:26:43.6884917' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (3, 3, 23, 0, CAST(N'2022-08-21T20:26:43.6884914' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (4, 3, 22, 0, CAST(N'2022-08-21T20:26:43.6884913' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (5, 3, 21, 0, CAST(N'2022-08-21T20:26:43.6884910' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (6, 3, 20, 0, CAST(N'2022-08-21T20:26:43.6884907' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (7, 3, 19, 0, CAST(N'2022-08-21T20:26:43.6884906' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (8, 3, 18, 0, CAST(N'2022-08-21T20:26:43.6884901' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (9, 3, 17, 0, CAST(N'2022-08-21T20:26:43.6884899' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (10, 3, 16, 0, CAST(N'2022-08-21T20:26:43.6884896' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (11, 3, 15, 0, CAST(N'2022-08-21T20:26:43.6884894' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (12, 3, 14, 0, CAST(N'2022-08-21T20:26:43.6884890' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (13, 3, 13, 0, CAST(N'2022-08-21T20:26:43.6884888' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (14, 3, 12, 0, CAST(N'2022-08-21T20:26:43.6884886' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (15, 3, 11, 0, CAST(N'2022-08-21T20:26:43.6884884' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (16, 3, 10, 0, CAST(N'2022-08-21T20:26:43.6884881' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (17, 3, 9, 0, CAST(N'2022-08-21T20:26:43.6884877' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (18, 3, 8, 0, CAST(N'2022-08-21T20:26:43.6884875' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (19, 3, 7, 0, CAST(N'2022-08-21T20:26:43.6884874' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (20, 3, 6, 0, CAST(N'2022-08-21T20:26:43.6884872' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (21, 3, 5, 0, CAST(N'2022-08-21T20:26:43.6884869' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (22, 3, 4, 0, CAST(N'2022-08-21T20:26:43.6884867' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (23, 3, 3, 0, CAST(N'2022-08-21T20:26:43.6884862' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (24, 3, 2, 0, CAST(N'2022-08-21T20:26:43.6884859' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (25, 3, 25, 0, CAST(N'2022-08-21T20:26:43.6884919' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (26, 3, 26, 0, CAST(N'2022-08-21T20:26:43.6884921' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (27, 4, 1, 0, CAST(N'2022-08-21T20:31:21.4508402' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (28, 4, 19, 0, CAST(N'2022-08-21T20:31:21.4508435' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (29, 4, 18, 0, CAST(N'2022-08-21T20:31:21.4508433' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (30, 4, 17, 0, CAST(N'2022-08-21T20:31:21.4508431' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (31, 4, 16, 0, CAST(N'2022-08-21T20:31:21.4508429' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (32, 4, 15, 0, CAST(N'2022-08-21T20:31:21.4508427' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (33, 4, 14, 0, CAST(N'2022-08-21T20:31:21.4508426' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (34, 4, 13, 0, CAST(N'2022-08-21T20:31:21.4508424' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (35, 4, 12, 0, CAST(N'2022-08-21T20:31:21.4508422' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (36, 4, 11, 0, CAST(N'2022-08-21T20:31:21.4508421' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (37, 4, 10, 0, CAST(N'2022-08-21T20:31:21.4508419' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (38, 4, 9, 0, CAST(N'2022-08-21T20:31:21.4508417' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (39, 4, 8, 0, CAST(N'2022-08-21T20:31:21.4508415' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (40, 4, 7, 0, CAST(N'2022-08-21T20:31:21.4508413' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (41, 4, 6, 0, CAST(N'2022-08-21T20:31:21.4508411' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (42, 4, 5, 0, CAST(N'2022-08-21T20:31:21.4508410' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (43, 4, 3, 0, CAST(N'2022-08-21T20:31:21.4508407' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (44, 4, 2, 0, CAST(N'2022-08-21T20:31:21.4508405' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (45, 4, 24, 0, CAST(N'2022-08-21T20:31:21.4508436' AS DateTime2), NULL, NULL)
INSERT [dbo].[Employee_UseCases] ([Id], [UserId], [UseCaseId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (46, 4, 26, 0, CAST(N'2022-08-21T20:31:21.4508438' AS DateTime2), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Employee_UseCases] OFF
GO
SET IDENTITY_INSERT [dbo].[Types] ON 

INSERT [dbo].[Types] ([Id], [Name], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (1, N'Pice', 0, CAST(N'2022-08-21T18:59:14.2178970' AS DateTime2), NULL, NULL)
INSERT [dbo].[Types] ([Id], [Name], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (2, N'Alkohol', 0, CAST(N'2022-08-21T19:00:16.5677329' AS DateTime2), NULL, NULL)
INSERT [dbo].[Types] ([Id], [Name], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (3, N'Hrana', 0, CAST(N'2022-08-21T19:00:30.0803644' AS DateTime2), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Types] OFF
GO
SET IDENTITY_INSERT [dbo].[SubTypes] ON 

INSERT [dbo].[SubTypes] ([Id], [Name], [TypeId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (1, N'Gazirano', 1, 0, CAST(N'2022-08-21T19:01:13.5988094' AS DateTime2), NULL, NULL)
INSERT [dbo].[SubTypes] ([Id], [Name], [TypeId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (2, N'Gusti', 1, 0, CAST(N'2022-08-21T19:01:18.8569279' AS DateTime2), NULL, NULL)
INSERT [dbo].[SubTypes] ([Id], [Name], [TypeId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (3, N'Kuvana', 3, 0, CAST(N'2022-08-21T20:45:43.7759151' AS DateTime2), NULL, NULL)
INSERT [dbo].[SubTypes] ([Id], [Name], [TypeId], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (4, N'Rostilj', 3, 0, CAST(N'2022-08-21T20:45:49.9448547' AS DateTime2), NULL, NULL)
SET IDENTITY_INSERT [dbo].[SubTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[Menus] ON 

INSERT [dbo].[Menus] ([Id], [Name], [Price], [SubTypeId], [PictureSrc], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (1, N'Kokakola', CAST(140.00 AS Decimal(18, 2)), 1, N'1661108662.jpg', 0, CAST(N'2022-08-21T19:04:22.2119655' AS DateTime2), CAST(N'2022-08-21T19:05:16.3690899' AS DateTime2), NULL)
INSERT [dbo].[Menus] ([Id], [Name], [Price], [SubTypeId], [PictureSrc], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (2, N'Supa', CAST(200.00 AS Decimal(18, 2)), 3, N'1661114826.jpg', 0, CAST(N'2022-08-21T20:47:06.7063179' AS DateTime2), NULL, NULL)
INSERT [dbo].[Menus] ([Id], [Name], [Price], [SubTypeId], [PictureSrc], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (3, N'Ribljacorba', CAST(250.00 AS Decimal(18, 2)), 3, N'1661114844.jpg', 0, CAST(N'2022-08-21T20:47:24.7385990' AS DateTime2), NULL, NULL)
INSERT [dbo].[Menus] ([Id], [Name], [Price], [SubTypeId], [PictureSrc], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (4, N'Cevapi', CAST(180.00 AS Decimal(18, 2)), 4, N'1661114865.jpg', 0, CAST(N'2022-08-21T20:47:45.9269874' AS DateTime2), NULL, NULL)
INSERT [dbo].[Menus] ([Id], [Name], [Price], [SubTypeId], [PictureSrc], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (5, N'Pljeskavica', CAST(150.00 AS Decimal(18, 2)), 4, N'1661114897.jpg', 0, CAST(N'2022-08-21T20:48:17.1868069' AS DateTime2), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Menus] OFF
GO
SET IDENTITY_INSERT [dbo].[BillDetailss] ON 

INSERT [dbo].[BillDetailss] ([Id], [BillId], [MenuId], [Amount], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (1, 2, 1, 3, 0, CAST(N'2022-08-21T19:07:49.3901447' AS DateTime2), NULL, NULL)
INSERT [dbo].[BillDetailss] ([Id], [BillId], [MenuId], [Amount], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (2, 3, 1, 5, 0, CAST(N'2022-08-21T19:26:16.1781470' AS DateTime2), NULL, NULL)
INSERT [dbo].[BillDetailss] ([Id], [BillId], [MenuId], [Amount], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (3, 4, 3, 2, 0, CAST(N'2022-08-21T21:10:47.2695650' AS DateTime2), NULL, NULL)
INSERT [dbo].[BillDetailss] ([Id], [BillId], [MenuId], [Amount], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (4, 5, 1, 2, 0, CAST(N'2022-08-21T21:18:52.2939246' AS DateTime2), NULL, NULL)
INSERT [dbo].[BillDetailss] ([Id], [BillId], [MenuId], [Amount], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (5, 5, 2, 1, 0, CAST(N'2022-08-21T21:18:55.6489675' AS DateTime2), NULL, NULL)
INSERT [dbo].[BillDetailss] ([Id], [BillId], [MenuId], [Amount], [IsDeleted], [Date_Created], [Date_Updated], [Date_Deleted]) VALUES (6, 5, 3, 6, 0, CAST(N'2022-08-21T21:18:59.4788036' AS DateTime2), NULL, NULL)
SET IDENTITY_INSERT [dbo].[BillDetailss] OFF
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220820111524_Initial push', N'5.0.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220820112241_Adding one field', N'5.0.16')
GO

SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [Name]) VALUES (1, N'Monitors')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (2, N'Desktops')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (3, N'Laptops')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Items] ON 

INSERT [dbo].[Items] ([Id], [Name], [Description], [Src], [Price], [CategoryId]) VALUES (1, N'MicroStore Monitor', N'24" monitor', N'AdobeStock_110470948.jpeg', CAST(100.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Items] ([Id], [Name], [Description], [Src], [Price], [CategoryId]) VALUES (2, N'TopBrand Monitor', N'32" Monitor', N'AdobeStock_142455675.jpeg', CAST(300.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Items] ([Id], [Name], [Description], [Src], [Price], [CategoryId]) VALUES (3, N'BasicBrand Monitor', N'16" Monitor', N'AdobeStock_325481234.jpeg', CAST(80.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Items] ([Id], [Name], [Description], [Src], [Price], [CategoryId]) VALUES (4, N'BasicBrand Desktop', N'HP Desktop', N'AdobeStock_156552505.jpeg', CAST(750.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[Items] ([Id], [Name], [Description], [Src], [Price], [CategoryId]) VALUES (5, N'MicroStore Desktop', N'Dell Desktop', N'AdobeStock_156552505.jpeg', CAST(1000.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[Items] ([Id], [Name], [Description], [Src], [Price], [CategoryId]) VALUES (6, N'TopBrand Desktop', N'Asus Desktop', N'AdobeStock_325481234.jpeg', CAST(1400.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[Items] ([Id], [Name], [Description], [Src], [Price], [CategoryId]) VALUES (7, N'BasicBrand Laptop', N'Lenovo IdeaPad', N'AdobeStock_167286969.jpeg', CAST(350.00 AS Decimal(18, 2)), 3)
INSERT [dbo].[Items] ([Id], [Name], [Description], [Src], [Price], [CategoryId]) VALUES (8, N'MicroStore Laptop', N'HP EliteBook', N'AdobeStock_275969953.jpeg', CAST(800.00 AS Decimal(18, 2)), 3)
INSERT [dbo].[Items] ([Id], [Name], [Description], [Src], [Price], [CategoryId]) VALUES (9, N'TopBrand Laptop', N'Lenovo Thinkpad', N'AdobeStock_283782357.jpeg', CAST(2000.00 AS Decimal(18, 2)), 3)
SET IDENTITY_INSERT [dbo].[Items] OFF
GO

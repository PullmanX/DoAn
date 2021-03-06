USE [QuanLyQuanCafe]
GO
/****** Object:  StoredProcedure [dbo].[USP_GetAccountByUserName]    Script Date: 7/27/2020 6:23:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetAccountByUserName]
@userName nvarchar(100)
AS 
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName
END


GO
/****** Object:  StoredProcedure [dbo].[USP_GetListBillByDate]    Script Date: 7/27/2020 6:23:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetListBillByDate]
@checkIn date, @checkOut date
AS 
BEGIN
	SELECT t.name AS [Tên bàn], b.totalPrice AS [Tổng tiền], DateCheckIn AS [Ngày vào], DateCheckOut AS [Ngày ra], discount AS [Giảm giá]
	FROM dbo.Bill AS b,dbo.TableFood AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1
	AND t.id = b.idTable
END


GO
/****** Object:  StoredProcedure [dbo].[USP_GetListBillByDateAndPage]    Script Date: 7/27/2020 6:23:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetListBillByDateAndPage]
@checkIn date, @checkOut date, @page int
AS 
BEGIN
	DECLARE @pageRows INT = 10
	DECLARE @selectRows INT = @pageRows
	DECLARE @exceptRows INT = (@page - 1) * @pageRows
	
	;WITH BillShow AS( SELECT b.ID, t.name AS [Tên bàn], b.totalPrice AS [Tổng tiền], DateCheckIn AS [Ngày vào], DateCheckOut AS [Ngày ra], discount AS [Giảm giá]
	FROM dbo.Bill AS b,dbo.TableFood AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1
	AND t.id = b.idTable)
	
	SELECT TOP (@selectRows) * FROM BillShow WHERE id NOT IN (SELECT TOP (@exceptRows) id FROM BillShow)
END


GO
/****** Object:  StoredProcedure [dbo].[USP_GetListBillByDateForReport]    Script Date: 7/27/2020 6:23:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetListBillByDateForReport]
@checkIn date, @checkOut date
AS 
BEGIN
	SELECT t.name, b.totalPrice, DateCheckIn, DateCheckOut, discount
	FROM dbo.Bill AS b,dbo.TableFood AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1
	AND t.id = b.idTable
END


GO
/****** Object:  StoredProcedure [dbo].[USP_GetNumBillByDate]    Script Date: 7/27/2020 6:23:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetNumBillByDate]
@checkIn date, @checkOut date
AS 
BEGIN
	SELECT COUNT(*)
	FROM dbo.Bill AS b,dbo.TableFood AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1
	AND t.id = b.idTable
END


GO
/****** Object:  StoredProcedure [dbo].[USP_GetTableList]    Script Date: 7/27/2020 6:23:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetTableList]
AS SELECT * FROM dbo.TableFood


GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBill]    Script Date: 7/27/2020 6:23:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InsertBill]
@idTable INT
AS
BEGIN
	INSERT dbo.Bill 
	        ( DateCheckIn ,
	          DateCheckOut ,
	          idTable ,
	          status,
	          discount
	        )
	VALUES  ( GETDATE() , -- DateCheckIn - date
	          NULL , -- DateCheckOut - date
	          @idTable , -- idTable - int
	          0,  -- status - int
	          0
	        )
END


GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBillInfo]    Script Date: 7/27/2020 6:23:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InsertBillInfo]
@idBill INT, @idFood INT, @count INT
AS
BEGIN

	DECLARE @isExitsBillInfo INT
	DECLARE @foodCount INT = 1
	
	SELECT @isExitsBillInfo = id, @foodCount = b.count 
	FROM dbo.BillInfo AS b 
	WHERE idBill = @idBill AND idFood = @idFood

	IF (@isExitsBillInfo > 0)
	BEGIN
		DECLARE @newCount INT = @foodCount + @count
		IF (@newCount > 0)
			UPDATE dbo.BillInfo	SET count = @foodCount + @count WHERE idFood = @idFood
		ELSE
			DELETE dbo.BillInfo WHERE idBill = @idBill AND idFood = @idFood
	END
	ELSE
	BEGIN
		INSERT	dbo.BillInfo
        ( idBill, idFood, count )
		VALUES  ( @idBill, -- idBill - int
          @idFood, -- idFood - int
          @count  -- count - int
          )
	END
END


GO
/****** Object:  StoredProcedure [dbo].[USP_Login]    Script Date: 7/27/2020 6:23:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_Login]
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord
END


GO
/****** Object:  StoredProcedure [dbo].[USP_SwitchTabel]    Script Date: 7/27/2020 6:23:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_SwitchTabel]
@idTable1 INT, @idTable2 int
AS BEGIN

	DECLARE @idFirstBill int
	DECLARE @idSeconrdBill INT
	
	DECLARE @isFirstTablEmty INT = 1
	DECLARE @isSecondTablEmty INT = 1
	
	
	SELECT @idSeconrdBill = id FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
	SELECT @idFirstBill = id FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'
	
	IF (@idFirstBill IS NULL)
	BEGIN
		PRINT '0000001'
		INSERT dbo.Bill
		        ( DateCheckIn ,
		          DateCheckOut ,
		          idTable ,
		          status
		        )
		VALUES  ( GETDATE() , -- DateCheckIn - date
		          NULL , -- DateCheckOut - date
		          @idTable1 , -- idTable - int
		          0  -- status - int
		        )
		        
		SELECT @idFirstBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0
		
	END
	
	SELECT @isFirstTablEmty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idFirstBill
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'
	
	IF (@idSeconrdBill IS NULL)
	BEGIN
		PRINT '0000002'
		INSERT dbo.Bill
		        ( DateCheckIn ,
		          DateCheckOut ,
		          idTable ,
		          status
		        )
		VALUES  ( GETDATE() , -- DateCheckIn - date
		          NULL , -- DateCheckOut - date
		          @idTable2 , -- idTable - int
		          0  -- status - int
		        )
		SELECT @idSeconrdBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
		
	END
	
	SELECT @isSecondTablEmty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idSeconrdBill
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'

	SELECT id INTO IDBillInfoTable FROM dbo.BillInfo WHERE idBill = @idSeconrdBill
	
	UPDATE dbo.BillInfo SET idBill = @idSeconrdBill WHERE idBill = @idFirstBill
	
	UPDATE dbo.BillInfo SET idBill = @idFirstBill WHERE id IN (SELECT * FROM IDBillInfoTable)
	
	DROP TABLE IDBillInfoTable
	
	IF (@isFirstTablEmty = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable2
		
	IF (@isSecondTablEmty= 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable1
END


GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateAccount]    Script Date: 7/27/2020 6:23:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_UpdateAccount]
@userName NVARCHAR(100), @displayName NVARCHAR(100), @password NVARCHAR(100), @newPassword NVARCHAR(100)
AS
BEGIN
	DECLARE @isRightPass INT = 0
	
	SELECT @isRightPass = COUNT(*) FROM dbo.Account WHERE USERName = @userName AND PassWord = @password
	
	IF (@isRightPass = 1)
	BEGIN
		IF (@newPassword = NULL OR @newPassword = '')
		BEGIN
			UPDATE dbo.Account SET DisplayName = @displayName WHERE UserName = @userName
		END		
		ELSE
			UPDATE dbo.Account SET DisplayName = @displayName, PassWord = @newPassword WHERE UserName = @userName
	end
END


GO
/****** Object:  UserDefinedFunction [dbo].[fuConvertToUnsign1]    Script Date: 7/27/2020 6:23:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END


GO
/****** Object:  Table [dbo].[Account]    Script Date: 7/27/2020 6:23:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[UserName] [nchar](10) NOT NULL,
	[DisplayName] [nvarchar](100) NOT NULL,
	[PassWord] [nvarchar](1000) NOT NULL,
	[Type] [int] NOT NULL,
	[id_user] [nvarchar](50) NULL,
 CONSTRAINT [PK__Account__C9F28457C63FB57E] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Bill]    Script Date: 7/27/2020 6:23:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[DateCheckIn] [date] NULL,
	[DateCheckOut] [date] NULL,
	[idTable] [int] NULL,
	[status] [int] NULL,
	[discount] [int] NULL,
	[totalPrice] [float] NULL,
 CONSTRAINT [PK__Bill__3213E83F150FD711] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BillInfo]    Script Date: 7/27/2020 6:23:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillInfo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idBill] [int] NULL,
	[idFood] [int] NULL,
	[count] [int] NULL,
 CONSTRAINT [PK__BillInfo__3213E83F3963724E] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Food]    Script Date: 7/27/2020 6:23:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NULL,
	[idCategory] [int] NULL,
	[price] [float] NULL,
	[status] [int] NULL,
 CONSTRAINT [PK__Food__3213E83FB996C7A6] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FoodCategory]    Script Date: 7/27/2020 6:23:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FoodCategory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NULL,
 CONSTRAINT [PK__FoodCate__3213E83F167A1332] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LICHLAM]    Script Date: 7/27/2020 6:23:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LICHLAM](
	[id] [nchar](10) NOT NULL,
	[Thu2] [nvarchar](50) NULL,
	[Thu3] [nvarchar](50) NULL,
	[Thu4] [nvarchar](50) NULL,
	[Thu5] [nvarchar](50) NULL,
	[Thu6] [nvarchar](50) NULL,
	[Thu7] [nvarchar](50) NULL,
	[CN] [nvarchar](50) NULL,
 CONSTRAINT [PK_LICHLAM] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 7/27/2020 6:23:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [nchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[NgSinh] [date] NULL,
	[GioiTinh] [nchar](10) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [nchar](10) NULL,
	[TenTaiKhoan] [nchar](10) NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 7/27/2020 6:23:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[id] [nchar](10) NOT NULL,
	[TenTaiKhoan] [nchar](10) NULL,
	[MaHang] [nvarchar](50) NULL,
	[TenHang] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_PHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUNHAPCT]    Script Date: 7/27/2020 6:23:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAPCT](
	[id] [nchar](10) NOT NULL,
	[idPN] [nchar](10) NULL,
	[MaNV] [nchar](10) NULL,
	[MaHang] [nvarchar](50) NULL,
	[TenHang] [nvarchar](50) NULL,
	[Soluong] [int] NULL,
	[TongTien] [float] NULL,
 CONSTRAINT [PK_PHIEUNHAPCT] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QUANLY]    Script Date: 7/27/2020 6:23:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUANLY](
	[MaQL] [nchar](10) NOT NULL,
	[TenQL] [nvarchar](50) NULL,
	[NgSinh] [date] NULL,
	[GioiTinh] [nchar](10) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [nchar](10) NULL,
	[TenTaiKhoan] [nchar](10) NULL,
	[idLL] [nchar](10) NULL,
 CONSTRAINT [PK_QUANLY] PRIMARY KEY CLUSTERED 
(
	[MaQL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TableFood]    Script Date: 7/27/2020 6:23:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableFood](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NULL,
	[status] [nvarchar](100) NULL,
 CONSTRAINT [PK__TableFoo__3213E83FACE47D0D] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Account] ([UserName], [DisplayName], [PassWord], [Type], [id_user]) VALUES (N'Admin     ', N'Admin', N'admin', 0, N'Admin')
INSERT [dbo].[Account] ([UserName], [DisplayName], [PassWord], [Type], [id_user]) VALUES (N'Long      ', N'stafff', N'123', 0, N'Member')
INSERT [dbo].[Account] ([UserName], [DisplayName], [PassWord], [Type], [id_user]) VALUES (N'Tan       ', N'staff', N'123', 0, N'Member')
SET IDENTITY_INSERT [dbo].[Bill] ON 

INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (1, CAST(0x5A410B00 AS Date), CAST(0x5B410B00 AS Date), 1, 1, 0, 97)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (2, CAST(0x5A410B00 AS Date), CAST(0x5A410B00 AS Date), 3, 1, 0, 300)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (3, CAST(0x5A410B00 AS Date), CAST(0x5A410B00 AS Date), 6, 1, 0, 600)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (4, CAST(0x5A410B00 AS Date), CAST(0x5B410B00 AS Date), 11, 1, 0, 18)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (5, CAST(0x5A410B00 AS Date), CAST(0x5A410B00 AS Date), 7, 1, 0, 250)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (6, CAST(0x5A410B00 AS Date), CAST(0x5A410B00 AS Date), 7, 1, 0, 200)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (7, CAST(0x5B410B00 AS Date), CAST(0x5B410B00 AS Date), 2, 1, 0, 160)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (8, CAST(0x5B410B00 AS Date), CAST(0x5B410B00 AS Date), 4, 1, 0, 130)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (9, CAST(0x5B410B00 AS Date), CAST(0x5B410B00 AS Date), 1, 1, 0, 72)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (10, CAST(0x5B410B00 AS Date), CAST(0x5B410B00 AS Date), 4, 1, 0, 88)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (11, CAST(0x5D410B00 AS Date), CAST(0x5D410B00 AS Date), 1, 1, 0, 36)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (12, CAST(0x5D410B00 AS Date), CAST(0x5D410B00 AS Date), 7, 1, 3, 34.92)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (13, CAST(0x5D410B00 AS Date), CAST(0x5D410B00 AS Date), 7, 1, 10, 16.2)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (14, CAST(0x5D410B00 AS Date), CAST(0x5D410B00 AS Date), 1, 1, 0, 54)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (15, CAST(0x5D410B00 AS Date), CAST(0x5F410B00 AS Date), 8, 1, 0, 72)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (16, CAST(0x5D410B00 AS Date), CAST(0x5D410B00 AS Date), 7, 1, 0, 54)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (17, CAST(0x5D410B00 AS Date), CAST(0x5D410B00 AS Date), 1, 1, 0, 90)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (18, CAST(0x5E410B00 AS Date), CAST(0x5E410B00 AS Date), 1, 1, 0, 54)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (19, CAST(0x5E410B00 AS Date), CAST(0x5F410B00 AS Date), 1, 1, 0, 72)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (20, CAST(0x5F410B00 AS Date), CAST(0x5F410B00 AS Date), 1, 1, 0, 72)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (21, CAST(0x5F410B00 AS Date), CAST(0x5F410B00 AS Date), 1, 1, 0, 72)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (22, CAST(0x5F410B00 AS Date), CAST(0x5F410B00 AS Date), 1, 1, 0, 72)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (23, CAST(0x5F410B00 AS Date), CAST(0x5F410B00 AS Date), 1, 1, 10, 48.6)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (24, CAST(0x5F410B00 AS Date), CAST(0x5F410B00 AS Date), 1, 1, 0, 72)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (25, CAST(0x5F410B00 AS Date), CAST(0x5F410B00 AS Date), 2, 1, 0, 72)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (26, CAST(0x5F410B00 AS Date), CAST(0x5F410B00 AS Date), 1, 1, 0, 36)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (27, CAST(0x5F410B00 AS Date), CAST(0x5F410B00 AS Date), 3, 1, 0, 147)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (28, CAST(0x5F410B00 AS Date), CAST(0x5F410B00 AS Date), 1, 1, 5, 199.5)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (29, CAST(0x60410B00 AS Date), CAST(0x60410B00 AS Date), 4, 1, 0, 72)
SET IDENTITY_INSERT [dbo].[Bill] OFF
SET IDENTITY_INSERT [dbo].[BillInfo] ON 

INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (2, 2, 2, 4)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (3, 3, 4, 3)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (4, 4, 2, 4)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (6, 5, 2, 4)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (7, 6, 2, 4)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (8, 1, 9, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (9, 1, 5, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (10, 1, 7, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (17, 7, 13, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (18, 1, 13, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (20, 7, 2, 4)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (21, 7, 8, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (22, 7, 9, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (23, 7, 4, 3)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (24, 7, 5, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (25, 7, 7, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (26, 8, 7, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (27, 8, 4, 3)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (28, 8, 5, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (29, 8, 2, 4)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (30, 8, 8, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (31, 8, 9, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (35, 10, 2, 4)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (36, 10, 14, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (37, 10, 13, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (38, 9, 2, 4)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (39, 11, 2, 4)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (40, 12, 2, 4)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (41, 13, 2, 4)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (42, 14, 2, 4)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (43, 16, 2, 4)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (45, 15, 2, 4)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (46, 17, 2, 4)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (47, 18, 2, 4)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (48, 19, 2, 4)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (49, 20, 2, 4)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (50, 21, 2, 4)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (51, 22, 2, 4)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (52, 23, 2, 4)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (53, 24, 2, 4)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (54, 25, 2, 4)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (55, 26, 2, 4)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (56, 27, 2, 4)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (57, 27, 4, 3)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (58, 28, 11, 14)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (59, 29, 2, 4)
SET IDENTITY_INSERT [dbo].[BillInfo] OFF
SET IDENTITY_INSERT [dbo].[Food] ON 

INSERT [dbo].[Food] ([id], [name], [idCategory], [price], [status]) VALUES (2, N'Cà Phê Đen', 1, 18000, 0)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price], [status]) VALUES (4, N'Cafe đá', 3, 25000, 0)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price], [status]) VALUES (5, N'Trà Vãi', 3, 25000, 0)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price], [status]) VALUES (6, N'7Up', 2, 15000, 0)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price], [status]) VALUES (7, N'Trà ÔLong', 3, 20000, 0)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price], [status]) VALUES (8, N'Cà Phê Sữa', 1, 20000, 0)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price], [status]) VALUES (9, N'Bạc Xỉu', 1, 22000, 0)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price], [status]) VALUES (10, N'Sting', 2, 15000, 0)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price], [status]) VALUES (11, N'Number One', 2, 15000, 0)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price], [status]) VALUES (13, N'Trà Sữa Chocolate', 4, 30000, 0)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price], [status]) VALUES (14, N'Sữa Tươi', 4, 40000, 0)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price], [status]) VALUES (15, N'Trà Sữa Truyền Thống', 4, 25000, 0)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price], [status]) VALUES (20, N'abc', 2, 25000, NULL)
SET IDENTITY_INSERT [dbo].[Food] OFF
SET IDENTITY_INSERT [dbo].[FoodCategory] ON 

INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (1, N'Coffee')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (2, N'Nước giải khát')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (3, N'Tea')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (4, N'Milk Tea')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (5, N'Nước')
SET IDENTITY_INSERT [dbo].[FoodCategory] OFF
INSERT [dbo].[LICHLAM] ([id], [Thu2], [Thu3], [Thu4], [Thu5], [Thu6], [Thu7], [CN]) VALUES (N'Ca1       ', N'Tân', N'Long', N'Tân', N'Tân, Hậu', N'Long, Hậu', N'Tân', N'Long')
INSERT [dbo].[LICHLAM] ([id], [Thu2], [Thu3], [Thu4], [Thu5], [Thu6], [Thu7], [CN]) VALUES (N'Ca2       ', N'Hậu ', N'Tân', N'Long', N'Hậu, Tân', N'Long , Hụa', N'Tân', N'Tân')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NgSinh], [GioiTinh], [DiaChi], [SDT], [TenTaiKhoan]) VALUES (N'002       ', N'Lưu Công Long', CAST(0x50260B00 AS Date), N'Nu        ', N'Hưng Hòa', N'213456789 ', N'Long      ')
INSERT [dbo].[PHIEUNHAP] ([id], [TenTaiKhoan], [MaHang], [TenHang], [SoLuong]) VALUES (N'001       ', N'Tan       ', N'ST', N'Sting', 100)
INSERT [dbo].[PHIEUNHAP] ([id], [TenTaiKhoan], [MaHang], [TenHang], [SoLuong]) VALUES (N'002       ', N'Long      ', N'Nu', N'Number One', 10000)
SET IDENTITY_INSERT [dbo].[TableFood] ON 

INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (1, N'Bàn 0', N'Thường')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (2, N'Bàn 1', N'Thường')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (3, N'Bàn 2', N'Thường')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (4, N'Bàn 3', N'Thường')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (5, N'Bàn 4', N'Thường')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (6, N'Bàn 5', N'Thường')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (7, N'Bàn 6', N'Thường')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (8, N'Bàn 7', N'Thường')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (9, N'Bàn 8', N'Máy Lạnh')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (10, N'Bàn 9', N'Máy Lạnh')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (11, N'Bàn 10', N'MáyLạnh')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (12, N'Bàn 11', N'Máy Lạnh')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (13, N'Bàn 12', N'Ngồi Bệt')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (14, N'Bàn 13', N'Ngồi Bệt')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (15, N'Bàn 14', N'Ngồi Bệt')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (16, N'Bàn 15', N'Ngồi Bệt')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (17, N'Bàn 20', N'Thường')
SET IDENTITY_INSERT [dbo].[TableFood] OFF
ALTER TABLE [dbo].[Account] ADD  CONSTRAINT [DF__Account__Display__2B3F6F97]  DEFAULT (N'Kter') FOR [DisplayName]
GO
ALTER TABLE [dbo].[Account] ADD  CONSTRAINT [DF__Account__PassWor__2C3393D0]  DEFAULT ((0)) FOR [PassWord]
GO
ALTER TABLE [dbo].[Account] ADD  CONSTRAINT [DF__Account__Type__2D27B809]  DEFAULT ((0)) FOR [Type]
GO
ALTER TABLE [dbo].[Bill] ADD  CONSTRAINT [DF__Bill__DateCheckI__1ED998B2]  DEFAULT (getdate()) FOR [DateCheckIn]
GO
ALTER TABLE [dbo].[Bill] ADD  CONSTRAINT [DF__Bill__status__1FCDBCEB]  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[BillInfo] ADD  CONSTRAINT [DF__BillInfo__count__300424B4]  DEFAULT ((0)) FOR [count]
GO
ALTER TABLE [dbo].[Food] ADD  CONSTRAINT [DF__Food__name__3F466844]  DEFAULT (N'Chưa đặt tên') FOR [name]
GO
ALTER TABLE [dbo].[Food] ADD  CONSTRAINT [DF__Food__price__403A8C7D]  DEFAULT ((0)) FOR [price]
GO
ALTER TABLE [dbo].[FoodCategory] ADD  CONSTRAINT [DF__FoodCatego__name__32E0915F]  DEFAULT (N'Chưa đặt tên') FOR [name]
GO
ALTER TABLE [dbo].[TableFood] ADD  CONSTRAINT [DF__TableFood__name__33D4B598]  DEFAULT (N'Bàn chưa có tên') FOR [name]
GO
ALTER TABLE [dbo].[TableFood] ADD  CONSTRAINT [DF__TableFood__statu__34C8D9D1]  DEFAULT (N'Trống') FOR [status]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_TableFood] FOREIGN KEY([idTable])
REFERENCES [dbo].[TableFood] ([id])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_TableFood]
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD  CONSTRAINT [FK_BillInfo_Bill] FOREIGN KEY([idBill])
REFERENCES [dbo].[Bill] ([id])
GO
ALTER TABLE [dbo].[BillInfo] CHECK CONSTRAINT [FK_BillInfo_Bill]
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD  CONSTRAINT [FK_BillInfo_Food] FOREIGN KEY([idFood])
REFERENCES [dbo].[Food] ([id])
GO
ALTER TABLE [dbo].[BillInfo] CHECK CONSTRAINT [FK_BillInfo_Food]
GO
ALTER TABLE [dbo].[Food]  WITH CHECK ADD  CONSTRAINT [FK_Food_FoodCategory] FOREIGN KEY([idCategory])
REFERENCES [dbo].[FoodCategory] ([id])
GO
ALTER TABLE [dbo].[Food] CHECK CONSTRAINT [FK_Food_FoodCategory]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_Account] FOREIGN KEY([TenTaiKhoan])
REFERENCES [dbo].[Account] ([UserName])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_Account]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_Account] FOREIGN KEY([TenTaiKhoan])
REFERENCES [dbo].[Account] ([UserName])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_Account]
GO
ALTER TABLE [dbo].[PHIEUNHAPCT]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAPCT_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUNHAPCT] CHECK CONSTRAINT [FK_PHIEUNHAPCT_NHANVIEN]
GO
ALTER TABLE [dbo].[PHIEUNHAPCT]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAPCT_PHIEUNHAP] FOREIGN KEY([idPN])
REFERENCES [dbo].[PHIEUNHAP] ([id])
GO
ALTER TABLE [dbo].[PHIEUNHAPCT] CHECK CONSTRAINT [FK_PHIEUNHAPCT_PHIEUNHAP]
GO
ALTER TABLE [dbo].[QUANLY]  WITH CHECK ADD  CONSTRAINT [FK_QUANLY_Account] FOREIGN KEY([TenTaiKhoan])
REFERENCES [dbo].[Account] ([UserName])
GO
ALTER TABLE [dbo].[QUANLY] CHECK CONSTRAINT [FK_QUANLY_Account]
GO
ALTER TABLE [dbo].[QUANLY]  WITH CHECK ADD  CONSTRAINT [FK_QUANLY_LICHLAM] FOREIGN KEY([idLL])
REFERENCES [dbo].[LICHLAM] ([id])
GO
ALTER TABLE [dbo].[QUANLY] CHECK CONSTRAINT [FK_QUANLY_LICHLAM]
GO

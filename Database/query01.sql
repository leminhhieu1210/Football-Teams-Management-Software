CREATE TRIGGER trg_SoluongCauThuDoiBong
ON dbo.CauThu FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @madoi NVARCHAR(50),@madoiMoi NVARCHAR(50), @maCauThu NVARCHAR(50), @soluongCT INT
	IF EXISTS (SELECT * FROM Inserted) AND NOT EXISTS (SELECT * FROM Deleted)
	BEGIN
	    SELECT @madoi = Inserted.MaDoi FROM Inserted
		UPDATE dbo.DoiBong SET
        SoLuongCauThu = SoLuongCauThu + 1 WHERE MaDoi = @madoi
	END
	IF EXISTS (SELECT * FROM Inserted) AND EXISTS (SELECT * FROM Deleted)
	BEGIN
	    SELECT @madoi = Deleted.MaDoi FROM Deleted
		SELECT @madoiMoi =Inserted.MaDoi FROM Inserted
		UPDATE dbo.DoiBong SET
        SoLuongCauThu = SoLuongCauThu + 1
		WHERE MaDoi = @madoiMoi
		UPDATE dbo.DoiBong SET
        SoLuongCauThu = SoLuongCauThu - 1
		WHERE MaDoi = @madoi
	END
END

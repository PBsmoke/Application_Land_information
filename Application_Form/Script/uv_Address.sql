IF EXISTS (SELECT * FROM sys.views WHERE name = 'uv_Address')
	DROP VIEW uv_Address
GO
CREATE VIEW dbo.uv_Address AS
SELECT Geo.GEO_NAME
,Prov.PROVINCE_NAME
,Amph.AMPHUR_NAME
,Dist.DISTRICT_NAME
,Zipc.zipcode
,ISNULL(Geo.GEO_NAME,'') + ' ' + ISNULL(Prov.PROVINCE_NAME,'')  + ' ' + ISNULL(Amph.AMPHUR_NAME,'') + ' ' + ISNULL(Dist.DISTRICT_NAME,'') + ' ' + ISNULL(Zipc.zipcode,'') AS FullAdd
 FROM tblgeography AS Geo
LEFT JOIN tblprovinces AS Prov ON Geo.GEO_ID = Prov.GEO_ID
LEFT JOIN tblamphures AS Amph ON Prov.PROVINCE_ID = Amph.PROVINCE_ID
LEFT JOIN tbldistricts AS Dist ON Amph.AMPHUR_ID = Dist.AMPHUR_ID
LEFT JOIN tblzipcodes AS Zipc ON Dist.DISTRICT_CODE = Zipc.district_code
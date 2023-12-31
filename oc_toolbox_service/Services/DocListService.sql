SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE DocList
(
	@inFrench bit = 0, @forPreview bit = 0
)
AS
BEGIN
    SET NOCOUNT ON

	select DocId, 
		   Category = case when isnull(@inFrench, 0) = 0 then DocCategoryNameEn else DocCategoryNameFr end, 
		   Type = DocType, 
		   Name = case when isnull(@inFrench, 0) = 0 then DocNameEn else DocNameFr end, 
		   Description = case when isnull(@inFrench, 0) = 0 then DocDescriptionEn else DocDescriptionFr end, 
		   SizeKB = cast((case when isnull(@inFrench, 0) = 0 then datalength(DocDataEn) else datalength(DocDataFr) end) / 8192 as int),
		   FileName = replace(replace(replace(DocNameEn, '\', '_'), '/', '_'), '.', '_') + '.' + DocType,
		   IconName = 
			case 
			when DocType = 'pdf' then 'file-pdf-o'
			when DocType in ('xlsx', 'xls') then 'file-excel-o'
			when DocType in ('docx', 'doc') then 'file-word-o'
			when DocType in ('pptx', 'ppt') then 'file-powerpoint-o'
			when DocType in ('jpeg', 'jpg', 'png', 'bmp', 'heif', 'gif', 'tif', 'tiff') then 'file-image-o'
			when DocType in ('mp3', 'wav', 'aiff') then 'file-audio-o'
			when DocType in ('mp4', 'wov', 'wmv', 'avi') then 'file-video-o'
			when DocType in ('txt') then 'file-text-o'
			else 'file-o'			
			end,
		   IconColor = 
			case 
			when DocType = 'pdf' then '#ff0000'
			when DocType in ('xlsx', 'xls') then '#009900'
			when DocType in ('docx', 'doc') then '#3366ff'
			when DocType in ('pptx', 'ppt') then '#cc3300'
			when DocType in ('jpeg', 'jpg', 'png', 'bmp', 'heif', 'gif', 'tif', 'tiff') then '#334938'
			when DocType in ('mp3', 'wav', 'aiff') then '#474056'
			when DocType in ('mp4', 'wov', 'wmv', 'avi') then '#589b8c'
			when DocType in ('txt') then '#be4d4d'
			else '#990000'			
			end,
		   IsPublished
	  from Doc inner join DocCategory Cat on Doc.DocCategoryId = Cat.DocCategoryId
	 where isnull(Doc.IsDeleted, 0) = 0
	   and (isnull(@inFrench, 0) = 0 and DocDataEn is not null or DocDataFr is not null)
	   and (IsPublished = 1 or isnull(@forPreview, 0) = 1)
	 order by 2, 4
END
GO

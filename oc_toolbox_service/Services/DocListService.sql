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
		   Type = case when isnull(@inFrench, 0) = 0 then DocTypeEn else DocTypeFr end, 
		   Name = case when isnull(@inFrench, 0) = 0 then DocNameEn else isnull(DocNameFr, DocNameEn) end, 
		   Description = case when isnull(@inFrench, 0) = 0 then DocDescriptionEn else isnull(DocDescriptionFr, DocDescriptionEn) end,
		   DateLastUpdated = convert(nvarchar(10), LastUpdatedTime, 120), 
		   SizeKB = cast((case when isnull(@inFrench, 0) = 0 then datalength(DocDataEn) else datalength(DocDataFr) end) / 8192 as int),
		   FileName = replace(replace(replace(DocNameEn, '\', '_'), '/', '_'), '.', '_') + '.' + (case when isnull(@inFrench, 0) = 0 then DocTypeEn else DocTypeFr end),
		   IconName = 
			case 
			when (case when isnull(@inFrench, 0) = 0 then DocTypeEn else DocTypeFr end) = 'pdf' then 'file-pdf-o'
			when (case when isnull(@inFrench, 0) = 0 then DocTypeEn else DocTypeFr end) in ('xlsx', 'xls') then 'file-excel-o'
			when (case when isnull(@inFrench, 0) = 0 then DocTypeEn else DocTypeFr end) in ('docx', 'doc') then 'file-word-o'
			when (case when isnull(@inFrench, 0) = 0 then DocTypeEn else DocTypeFr end) in ('pptx', 'ppt') then 'file-powerpoint-o'
			when (case when isnull(@inFrench, 0) = 0 then DocTypeEn else DocTypeFr end) in ('jpeg', 'jpg', 'png', 'bmp', 'heif', 'gif', 'tif', 'tiff') then 'file-image-o'
			when (case when isnull(@inFrench, 0) = 0 then DocTypeEn else DocTypeFr end) in ('mp3', 'wav', 'aiff') then 'file-audio-o'
			when (case when isnull(@inFrench, 0) = 0 then DocTypeEn else DocTypeFr end) in ('mp4', 'wov', 'wmv', 'avi') then 'file-video-o'
			when (case when isnull(@inFrench, 0) = 0 then DocTypeEn else DocTypeFr end) in ('txt') then 'file-text-o'
			else 'file-o'			
			end,
		   IconColor = 
			case 
			when (case when isnull(@inFrench, 0) = 0 then DocTypeEn else DocTypeFr end) = 'pdf' then '#ff0000'
			when (case when isnull(@inFrench, 0) = 0 then DocTypeEn else DocTypeFr end) in ('xlsx', 'xls') then '#009900'
			when (case when isnull(@inFrench, 0) = 0 then DocTypeEn else DocTypeFr end) in ('docx', 'doc') then '#3366ff'
			when (case when isnull(@inFrench, 0) = 0 then DocTypeEn else DocTypeFr end) in ('pptx', 'ppt') then '#cc3300'
			when (case when isnull(@inFrench, 0) = 0 then DocTypeEn else DocTypeFr end) in ('jpeg', 'jpg', 'png', 'bmp', 'heif', 'gif', 'tif', 'tiff') then '#334938'
			when (case when isnull(@inFrench, 0) = 0 then DocTypeEn else DocTypeFr end) in ('mp3', 'wav', 'aiff') then '#474056'
			when (case when isnull(@inFrench, 0) = 0 then DocTypeEn else DocTypeFr end) in ('mp4', 'wov', 'wmv', 'avi') then '#589b8c'
			when (case when isnull(@inFrench, 0) = 0 then DocTypeEn else DocTypeFr end) in ('txt') then '#be4d4d'
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

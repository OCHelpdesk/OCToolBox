/****** Object:  StoredProcedure [dbo].[VideoList]    Script Date: 2/5/2024 3:14:38 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[VideoList]
(
	@inFrench bit = 0, @forPreview bit = 0
)
AS
BEGIN
    SET NOCOUNT ON

	IF OBJECT_ID('TEMPDB..#Videos') IS NOT NULL DROP TABLE #Videos
	select VideoId,
		   CategoryId = Video.VideoCategoryId,
		   Category = case when isnull(@inFrench, 0) = 0 then VideoCategoryNameEn else VideoCategoryNameFr end, 
		   SubcategoryId = isnull(Video.VideoSubcategoryId, 0),
		   Subcategory = ISNULL((case when isnull(@inFrench, 0) = 0 then VideoSubcategoryNameEn else VideoSubcategoryNameFr end), ''), 
		   Name = case when isnull(@inFrench, 0) = 0 then VideoNameEn else isnull(VideoNameFr, VideoNameEn) end, 
		   Description = isnull(case when isnull(@inFrench, 0) = 0 then VideoDescriptionEn else isnull(VideoDescriptionFr, VideoDescriptionEn) end, ''),
		   URL = case when isnull(@inFrench, 0) = 0 then VideoEnURL else isnull(VideoFrURL, VideoEnURL) end,
		   ThumbnailURL = case when isnull(@inFrench, 0) = 0 then VideoEnThumbnailURL else isnull(VideoFrThumbnailURL, VideoEnThumbnailURL) end,
		   IsPublished
	  into #Videos
	  from Video inner join VideoCategory Cat on Video.VideoCategoryId = Cat.VideoCategoryId
		   left join VideoSubcategory Sub on Video.VideoSubcategoryId = Sub.VideoSubcategoryId 
	 where isnull(Video.IsDeleted, 0) = 0
	   and (isnull(@inFrench, 0) = 0 and [VideoEnURL] is not null or [VideoFrURL] is not null)
	   and (IsPublished = 1 or isnull(@forPreview, 0) = 1)

	 select CategoryId = cast(CategoryId as nvarchar(10)) + ':0', Category
	   from #Videos
	 union
	 select CategoryId = cast(CategoryId as nvarchar(10)) + ':' + cast(SubcategoryId as nvarchar(10)), Category + ': ' + Subcategory
	   from #Videos
	  where SubcategoryId <> 0
	 order by Category

	 select * from #Videos order by Category, Subcategory, Name
END
GO


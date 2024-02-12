/****** Object:  StoredProcedure [dbo].[VideoList]    Script Date: 2/5/2024 3:14:38 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE [dbo].[LabelSdsProductList]
(
	@inFrench bit = 0, @forPreview bit = 0
)
AS
BEGIN
    SET NOCOUNT ON

	IF OBJECT_ID('TEMPDB..#List') IS NOT NULL DROP TABLE #List
	select Id = [ProductId],
		   Name = case when isnull(@inFrench, 0) = 0 or ISNULL([ProductNameFr], '') = '' then [ProductNameEn] else [ProductNameFr] end,
		   Manufacturer,
		   PCP,
		   RevisionNumber,
		   Ingredient = case when isnull(@inFrench, 0) = 0 or ISNULL(ActiveIngredientFr, '') = '' then isnull(ActiveIngredientEn, '') else ActiveIngredientFr end,
		   LocationId = isnull(cast(LocationId as nvarchar(10)), ''),
		   Location = case when LocationId is null then '' else (case when isnull(@inFrench, 0) = 0 then ProductLocationNameEn else ProductLocationNameFr end) end,
		   PesticideClassId = isnull(cast(PesticideClassId as nvarchar(10)), ''),
		   PesticideClass = case when PesticideClassId is null then '' else (case when isnull(@inFrench, 0) = 0 then ProductPesticideClassNameEn else ProductPesticideClassNameFr end) end,
		   FormulationTypeId = isnull(cast(FormulationId as nvarchar(10)), ''),
		   FormulationType = case when FormulationId is null then '' else (case when isnull(@inFrench, 0) = 0 then ProductFormulationNameEn else ProductFormulationNameFr end) end,
		   TargetPestIds = cast('' as nvarchar(1000)),
		   TargetPests = cast('' as nvarchar(1000)),
		   LabelDocId = cast(isnull(case when isnull(@inFrench, 0) = 0 or ISNULL([LabelFrDocId], 0) = 0 then LabelEnDocId else LabelFrDocId end, 0) as nvarchar(10)),
		   LabelDocName = cast('' as nvarchar(255)),
		   SDSDocId = cast(isnull(case when isnull(@inFrench, 0) = 0 or ISNULL([SDSFrDocId], 0) = 0 then SDSEnDocId else SDSFrDocId end, 0) as nvarchar(10)),
		   SDSDocName = cast('' as nvarchar(255)),
		   IsPublished
	  into #List
	  from Product Prod
		   left join ProductLocation Loc on Prod.LocationId = Loc.ProductLocationId
		   left join ProductPesticideClass Clas on Prod.PesticideClassId = Clas.ProductPesticideClassId
		   left join ProductFormulation Formu on Prod.FormulationId = Formu.ProductFormulationId
	 where isnull(Prod.IsDeleted, 0) = 0
	   and (IsPublished = 1 or isnull(@forPreview, 0) = 1)
	 order by [ProductId]

	 update #List set LabelDocName = Doc.DocName
	   from #List List inner join ProductDoc Doc on List.LabelDocId = Doc.ProductDocId
	  where LabelDocId <> '0' 
	 update #List set SDSDocName = Doc.DocName
	   from #List List inner join ProductDoc Doc on List.SDSDocId = Doc.ProductDocId
	  where SDSDocId <> '0' 

	 update #List set LabelDocId = '' where LabelDocId = '0'
	 update #List set SDSDocId = '' where SDSDocId = '0'

	 declare @id int = (select min(id) from #List), @maxId int = (select max(id) from #List)
	 declare @ids nvarchar(1000), @names nvarchar(1000)
	 while (@id <= @maxId)
	 begin
		select @ids = '', @names = ''
		if exists (select top 1 1 from #List where id = @id)
		begin
			select @ids = @ids + (case when @ids = '' then '' else ', ' end) + id,
				   @names = @names + (case when @names = '' then '' else ', ' end) + name
			  from (
			    select id = '[' + cast(p.TargetCategoryId as nvarchar(10)) + ':0]',
					   Name = case when isnull(@inFrench, 0) = 0 then TargetCategoryNameEn else TargetCategoryNameFr end
				  from ProductTarget p
					   inner join TargetCategory c on p.TargetCategoryId = c.TargetCategoryId
				 where p.ProductId = @id and p.TargetId = 0
				union
				select id = '[' + cast(p.TargetCategoryId as nvarchar(10)) + ':' + cast(p.TargetId as nvarchar(10)) + ']',
					   Name = case when isnull(@inFrench, 0) = 0 then TargetCategoryNameEn else TargetCategoryNameFr end
							+ ': '
							+ case when isnull(@inFrench, 0) = 0 then TargetNameEn else TargetNameFr end
				  from ProductTarget p
					   inner join TargetCategory c on p.TargetCategoryId = c.TargetCategoryId	
					   inner join Target t on p.TargetId = t.TargetId
				 where p.ProductId = @id and p.TargetId <> 0
			  ) as p
			  order by Name
			update #List set TargetPestIds = @Ids, TargetPests = @names where id = @id
		end
		set @id = @id + 1
	 end

	 IF OBJECT_ID('TEMPDB..#Manufacturer') IS NOT NULL DROP TABLE #Manufacturer
	 CREATE TABLE #Manufacturer (Id int Identity(1, 1), [Name] NVARCHAR(255))
	 INSERT INTO #Manufacturer select distinct Manufacturer from #List order by Manufacturer
	 select * from #Manufacturer order by Id
	 select Id = ProductLocationId, Name = case when isnull(@inFrench, 0) = 0 then ProductLocationNameEn else ProductLocationNameFr end from ProductLocation order by Name
	 select Id = ProductPesticideClassId, Name = case when isnull(@inFrench, 0) = 0 then ProductPesticideClassNameEn else ProductPesticideClassNameFr end from ProductPesticideClass order by Name
	 select Id = ProductFormulationId, Name = case when isnull(@inFrench, 0) = 0 then ProductFormulationNameEn else ProductFormulationNameFr end from ProductFormulation order by Name
	 /*
	 select Id = '[' + cast(T.TargetCategoryId as nvarchar(10)) + ':' + cast(TargetId as nvarchar(10)) + ']',
	 	    Name = case when isnull(@inFrench, 0) = 0 then TargetCategoryNameEn else TargetCategoryNameFr end
				 + ': '
				 + case when isnull(@inFrench, 0) = 0 then TargetNameEn else TargetNameFr end
	   from [dbo].[Target] T inner join [dbo].[TargetCategory] C on T.TargetCategoryId = C.TargetCategoryId
	 union
	  */
	 select Id = '[' + cast([TargetCategoryId] as nvarchar(10)) + ':0]',
		    Name = case when isnull(@inFrench, 0) = 0 then TargetCategoryNameEn else TargetCategoryNameFr end
	   from [dbo].[TargetCategory]
	  where [TargetCategoryId] <> 0
	  order by Name

	 select * from #List order by Name
END
GO



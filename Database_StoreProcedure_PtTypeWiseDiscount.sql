create table mst_PtType(
PtTypeId int primary key identity(1,1),
PtType nvarchar(50),
)
ALTER TABLE mst_PtType
ADD IsActive bit

create table mst_PtTypeWiseDiscount(
Id int primary key identity(1,1),
OpIpType bit,
PtTypeId int,
Constraint fk_PtType foreign key(PtTypeId) references mst_PtType(PtTypeId)
)

ALTER TABLE mst_PtTypeWiseDiscount
ADD Discount Int , IsActive BIT;

ALTER TABLE mst_PtType
ADD IsActive bit

select * from mst_PtTypeWiseDiscount
select * from mst_PtType

 

truncate table mst_PtType

----------------------------- Sp mst_PtType ---------------------------------------------------------
--create Store Procedure Select in mst_PtType

create proc get_trn_PtTypeList
as begin 
select * from mst_PtType
return 
end

exec get_trn_PtTypeList

--create Insert Store Procedure 
create proc inst_trn_PTypeMaster
(
@PtType nvarchar(50),
@IsActive bit
)
as begin 
insert into [mst_PtType] values(@PtType,@IsActive)
return 
end

exec inst_trn_PTypeMaster 
    @PtType = 'SP',
    @IsActive = 1;


--create Update Store Procedure 
create proc edit_trn_PtTypeMaster
(
@PtTypeId int, 
@PtType nvarchar(50),
@IsActive bit
)
as begin 
update mst_PtType set PtType=@PtType,IsActive=@IsActive where PtTypeId=@PtTypeId
return 
end
exec edit_trn_PtTypeMaster
    @PtTypeId=50,
    @PtType = 'SP3',
    @IsActive = 1;
--create Search Store Procedure 

CREATE PROCEDURE get_trn_PtTypeSearchList
    @searchText NVARCHAR(50)
AS
BEGIN
    SELECT PtTypeId, PtType, IsActive
    FROM mst_PtType
    WHERE PtType LIKE '%' + @searchText + '%'
    ORDER BY PtType
END
-- Check for existing PtType records
create proc check_trn_PtTypeExists
    @PtType NVARCHAR(50)
as
begin
    select IsActive
    from mst_PtType
    where PtType = @PtType
end
-- Check for existing PtType For Update
create proc check_trn_PtTypeExistsForUpdate
    @PtType Nvarchar(50),
    @PtTypeId int
as
begin
    select count(*)
    from mst_PtType
    where PtType = @PtType AND PtTypeId <> @PtTypeId
end
--------------------------- Sp mst_PtTypeWiseDiscount -----------------------------------------------------------
--create Store Procedure Select in mst_PtTypeWiseDiscount
create proc get_trn_PtTypeWiseDiscountList
as
begin
    select 
        d.Id,
        IIF(d.OpIpType = 1, 'OPD', 'IPD') AS OpIpType,
        p.PtType AS PatientType,
        p.PtTypeId,
        d.Discount,
        d.IsActive
    from 
        mst_PtTypeWiseDiscount d
    join 
        mst_PtType p ON d.PtTypeId = p.PtTypeId;
end

exec get_trn_PtTypeWiseDiscountList

--drop proc select_trn_PtTypeWiseDiscount

--create Store Procedure Insert in mst_PtTypeWiseDiscount
create proc inst_trn_PtTypeWiseDiscountMaster
(
    @OpIpType bit,          
    @PtTypeId int,          
    @Discount int,          
    @IsActive bit           
)
as
begin
    insert into mst_PtTypeWiseDiscount (OpIpType, PtTypeId, Discount, IsActive)
    values (@OpIpType, @PtTypeId, @Discount, @IsActive);
end

--create Store Procedure Check exist in mst_PtTypeWiseDiscount
create proc check_trn_PtTypeWiseDiscountExists
(
    @OpIpType bit,          
    @PtTypeId int           
)
as
begin
    select count(*) as RecordCount
    from mst_PtTypeWiseDiscount
    where OpIpType = @OpIpType AND PtTypeId = @PtTypeId;
end

--create Store Procedure Select Active PtType cmb in mst_PtTypeWiseDiscount
create proc get_trn_ActivePtTypes
as
begin
    select * from mst_PtType where IsActive = 1;
end

--create Store Procedure check PtTypeWise Discount Duplicate in mst_PtTypeWiseDiscount

create proc check_trn_PtTypeWiseDiscountDuplicate
(
    @PtTypeId int,
    @OpIpType bit,
    @Id int
)
as
begin
    select count(*) as DuplicateCount
    from mst_PtTypeWiseDiscount
    where PtTypeId = @PtTypeId 
      and OpIpType = @OpIpType 
      and Id <> @Id;
end

--create Update Store Procedure PtTypeWiseDiscount
create proc edit_trn_PtTypeWiseDiscountMaster
(
    @Id int,
    @PtTypeId int,
    @OpIpType bit,
    @Discount int,
    @IsActive bit
)
as
begin
    update mst_PtTypeWiseDiscount
    set PtTypeId = @PtTypeId,
        OpIpType = @OpIpType,
        Discount = @Discount,
        IsActive = @IsActive
    where Id = @Id;
end

--create Search Store Procedure  PtTypeWiseDiscount
create proc get_trn_PtTypeWiseDiscountSearchList
(
    @SearchText nvarchar(50)
)
as
begin
    select 
        d.Id,
        IIF(d.OpIpType = 1, 'OPD', 'IPD') AS OpIpType,
        p.PtType AS PatientType,
        p.PtTypeId,
        d.Discount,
        d.IsActive
    from mst_PtTypeWiseDiscount d
    join mst_PtType p on d.PtTypeId = p.PtTypeId
    where p.PtType like '%' + @SearchText + '%';
end

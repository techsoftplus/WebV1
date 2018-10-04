
namespace ForManager94NgoThiNham.Common
{
    public class TVConstants
    {      
        public class StoredProcedure
        {           
            public class OTOSanPham
            {
                public const string GetAnhSanPhamId = @"admin_GetAnhSanPhamId @SanPhamId ={0}";
                public const string GetAnhSanPhamById = @"admin_GetAnhSanPhamById @Id ={0}";
                public const string AddAnhSanPham = @"admin_AddAnhSanPham @Name={0},@SanPhamId={1},@HinhAnh={2} ,@SapXep={3}";
                public const string UpdateAnhSanPham = @"admin_UpdateAnhSanPham @Id={0}, @Name={1},@SanPhamId={2},@HinhAnh={3} ,@SapXep={4},@IsChangeImage={5}";
                public const string DeleteAnhSanPham = @"admin_DeleteAnhSanPham @Id={0}";
            }
           
        }
    }
}

namespace ForManager94NgoThiNham.Common
{
    public class TVConstants
    {      
        public class StoredProcedure
        {           
            public class OTOSanPham
            {
                public const string GetMaxSanPhamId=@"RemaxHongKongManager_SanPhamManager_GetMaxSanPhamId";
                public const string GetSanPhamBySanPhamId= @"RemaxHongKongManager_SanPhamManager_GetSanPhamBySanPhamId @SanPhamId={0}";
                public const string GetSanPhamFilters= @"RemaxHongKongManager_SanPhamManager_GetSanPhamFilters @PageNumber = {0}, @PageSize = {1}, @TuKhoa = {2}";
                public const string SearchSanPhams = @"RemaxHongKongManager_SanPhamManager_SearchSanPhams @TuKhoa={0}";
                public const string GetSanPhams= @"RemaxHongKongManager_SanPhamManager_GetSanPhams @ChuyenMucId = {0}, @TuKhoa = {1}, @PageNumber = {2}, @PageSize = {3}";
                public const string Insert= @"RemaxHongKongManager_SanPhamManager_Insert @Id ={0} ,@SanPhamId ={1} ,@Ma ={2} ,@TieuDe ={3} ,@UrlAlias ={4} ,@UrlPhoto ={5} ,@DacDiem ={6} ,@GioiThieu ={7},@ThongSoKyThuat ={8},@BaoHanh ={9},@ThoiHanBaoHanh ={10},@Breadcrumb ={11},@ChuyenMucs ={12},@MauSacs ={13},@Tags ={14},@GiamTru ={15},@GiaCu ={16},@GiaMoi ={17} ,@AnhVideo ={18} ,@UrlVideo ={19} ,@MotaVideo ={20} ,@TieuDeIn ={21} ,@NhaSanXuatIn ={22} ,@DiaChiSanXuatIn ={23},@XuatXuIn ={24},@NamSanXuatIn ={25},@DinhLuongIn ={26},@ThongSoKyThuatIn ={27},@ChatLieuIn ={28},@MauSacIn ={29},@HuongDanIn ={30},@CanhBaoIn ={31},@NhapKhauIn ={32},@DiaChiCongTyIn ={33},@TitleMeta ={34} ,@DescriptionMeta ={35},@KeywordMeta ={36},@TuKhoa ={37},@NgayDang ={38},@NgaySua ={39},@NguoiSuaId ={40},@NgayTao ={41},@NguoiTaoId ={42},@TrangThai ={43}";                
                public const string Update= @"RemaxHongKongManager_SanPhamManager_Update @Id ={0} ,@SanPhamId ={1} ,@Ma ={2} ,@TieuDe ={3} ,@UrlAlias ={4} ,@UrlPhoto ={5} ,@DacDiem ={6} ,@GioiThieu ={7},@ThongSoKyThuat ={8},@BaoHanh ={9},@ThoiHanBaoHanh ={10},@Breadcrumb ={11},@ChuyenMucs ={12},@MauSacs ={13},@Tags ={14},@GiamTru ={15},@GiaCu ={16},@GiaMoi ={17} ,@AnhVideo ={18} ,@UrlVideo ={19} ,@MotaVideo ={20} ,@TieuDeIn ={21} ,@NhaSanXuatIn ={22} ,@DiaChiSanXuatIn ={23},@XuatXuIn ={24},@NamSanXuatIn ={25},@DinhLuongIn ={26},@ThongSoKyThuatIn ={27},@ChatLieuIn ={28},@MauSacIn ={29},@HuongDanIn ={30},@CanhBaoIn ={31},@NhapKhauIn ={32},@DiaChiCongTyIn ={33},@TitleMeta ={34} ,@DescriptionMeta ={35},@KeywordMeta ={36},@TuKhoa ={37},@NgayDang ={38},@NgaySua ={39},@NguoiSuaId ={40},@NgayTao ={41},@NguoiTaoId ={42},@TrangThai ={43}";
                public const string Delete = @"RemaxHongKongManager_SanPhamManager_Delete @Id={0}";
            }
            public class OTOSanPhamTag
            {
                public const string GetSanPhamTags = @"RemaxHongKongManager_SanPhamTagManager_GetSanPhamTags";
                public const string GetSanPhamTagsById = @"RemaxHongKongManager_SanPhamTagManager_GetSanPhamTagsById";
                public const string Insert = @"RemaxHongKongManager_SanPhamTagManager_Insert";
                public const string Update = @"RemaxHongKongManager_SanPhamTagManager_Update";
                public const string Delete = @"RemaxHongKongManager_SanPhamTagManager_Delete";
            }
            public class OTOSanPhamChuyenMuc
            {
                public const string GetSanPhamChuyenMucs = @"RemaxHongKongManager_SanPhamChuyenMucManager_GetSanPhamChuyenMucs";
                public const string Insert = @"RemaxHongKongManager_SanPhamChuyenMucManager_Insert";
                public const string Update = @"RemaxHongKongManager_SanPhamChuyenMucManager_Update";
                public const string Delete = @"RemaxHongKongManager_SanPhamChuyenMucManager_Delete";
            }
            public class OTOSanPhamBoLoc
            {
                public const string AddSanPhamBoLoc = @"RemaxHongKongManager_SanPhamBoLocManager_AddSanPhamBoLoc";
                public const string Delete = @"RemaxHongKongManager_SanPhamBoLocManager_Delete";
                public const string GetSanPhamBoLocBySanPhamId = @"RemaxHongKongManager_SanPhamBoLocManager_GetSanPhamBoLocBySanPhamId";
            }
            // Bài viết
            public class OTOBaiViet
            {
                public const string GetBaiVietByBaiVietId = @"RemaxHongKongManager_BaiVietManager_GetBaiVietByBaiVietId ";
                public const string GetBaiViets = @"RemaxHongKongManager_BaiVietManager_GetBaiViets ";                
                public const string IsExistMa = @"RemaxHongKongManager_BaiVietManager_IsExistMa";
                public const string SearchBaiViets = @"RemaxHongKongManager_BaiVietManager_SearchBaiViets ";
                public const string Insert = @"RemaxHongKongManager_BaiVietManager_Insert ";
                public const string Update = @"RemaxHongKongManager_BaiVietManager_Update ";
                public const string Delete = @"RemaxHongKongManager_BaiVietManager_Delete";
            }
            public class OTOBaiVietTag
            {
                public const string GetBaiVietTags = @"RemaxHongKongManager_BaiVietTagManager_GetBaiVietTags";
                public const string GetBaiVietTagsById = @"RemaxHongKongManager_BaiVietTagManager_GetBaiVietTagsById ";
                public const string Insert = @"RemaxHongKongManager_BaiVietTagManager_Insert";
                public const string Update = @"RemaxHongKongManager_BaiVietTagManager_Update";
                public const string Delete = @"RemaxHongKongManager_BaiVietTagManager_Delete ";
            }
        }
    }
}
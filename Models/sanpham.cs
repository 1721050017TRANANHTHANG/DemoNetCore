using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcMovie.Models
{
    public class sanpham
    {
        [Key]
        public string spID { get; set; }
        public string tensp { get; set; }

        public string lspID { get; set; }
        [ForeignKey("lspID")]
        public Loaisanpham LoaiSanpham { get; set; }
    }
}

//dotnet-aspnet-codegenerator controller -name sanphamsController -m sanpham -dc MvcMovieContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -sqlite

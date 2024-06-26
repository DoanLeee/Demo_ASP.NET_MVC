using System.ComponentModel.DataAnnotations;

namespace QuanLiSach.Models
{
	public class ProductModel
	{
		[Key]
		public int Id { get; set; }

		[Required, MinLength(4, ErrorMessage = "Yêu cầu nhập tên sản phẩm ")]
		public string Name { get; set; }

		public string Slug {  get; set; }

		[Required, MinLength(6, ErrorMessage = "Yêu cầu nhập tên mô tả sản phẩm ")]
		public string Description { get; set; }

		[Required, MinLength(4, ErrorMessage = "Yêu cầu nhập giá sản phẩm ")]
		public decimal Price { get; set; }

		public int IdBrand { get; set; }

		public int IdCategory { get; set; }


		public CategoryModel Category { get; set; }

		public BrandModel Brand { get; set; }
		public String Image { get; set; }
		public String Author { get; set; }
	}
}

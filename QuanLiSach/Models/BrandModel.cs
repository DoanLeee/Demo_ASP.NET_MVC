using System.ComponentModel.DataAnnotations;

namespace QuanLiSach.Models
{
	public class BrandModel
	{
		[Key]
		public int Id { get; set; }

		[Required, MinLength(4, ErrorMessage = "Yêu cầu nhập tên thương hiệu ")]
		public string Name { get; set; }


		[Required, MinLength(6, ErrorMessage = "Yêu cầu nhập tên mô tả thương hiệu ")]
		public string Description { get; set; }

		[Required]
		public string Slug { get; set; }

		public int State { get; set; }
	}
}

﻿using System.ComponentModel.DataAnnotations;

namespace QuanLiSach.Models
{
	public class CategoryModel
	{
		[Key]
		public int? Id { get; set; }

		[Required,MinLength(4,ErrorMessage ="Yêu cầu nhập tên danh mục ")]
		public string? Name { get; set; }


		[Required, MinLength(6, ErrorMessage = "Yêu cầu nhập tên mô tả danh mục ")]
		public string? Description { get; set; }

		[Required]
		public string? Slug { get; set; }

		public int? State { get; set; }
	}
}

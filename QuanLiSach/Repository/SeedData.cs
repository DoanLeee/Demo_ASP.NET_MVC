using Microsoft.EntityFrameworkCore;
using QuanLiSach.Models;

namespace QuanLiSach.Repository
{
	public class SeedData
	{
		public static void SeedingData(DataContext _context)
		{
			_context.Database.Migrate();
			if (!_context.Products.Any())
			{
				CategoryModel SGK = new CategoryModel { Name = "Sách giáo khoa", Slug = "SGK", Description = "Sách giáo khoa cho học sinh", State = 1 };
				CategoryModel TT = new CategoryModel { Name = "Truyện tranh", Slug = "TT", Description = "Truyện tranh giải trí", State = 1 };
				BrandModel HD = new BrandModel { Name = "Hồng Đức", Slug = "hongduc", Description = "Hồng Đức", State = 1 };
				BrandModel Fahasha = new BrandModel { Name = "Fahasha", Slug = "Fahasha", Description = "Fahasha", State = 1 };



				_context.Products.AddRange(

						new ProductModel
						{
							Name = "Conan",
							Slug = "Conan",
							Description = "Trinh thám",
							Image = "1.jpg",
							Category = TT,
							Brand = Fahasha,
							Price = 1233,
							Author = "Gosho Aoyama"
						},
						new ProductModel
						{
							Name = "Doraemon",
							Slug = "Doraemon",
							Description = "Thiếu nhi",
							Image = "1.jpg",
							Category = TT,
							Brand = Fahasha,
							Price = 1233,
							Author = "Fujiko Fujio"
						}
					);
				_context.SaveChanges();
			}
		}
	}
}

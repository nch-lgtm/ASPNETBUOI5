using bai3.Models;

namespace bai3.Data
{
    public class DataSeeds
    {
        
        public static List<Category> categories = new List<Category>()
        {
            new Category() { Id = 1, Name = "Tiểu thuyết" },
            new Category() { Id = 2, Name = "Khoa học" },
            new Category() { Id = 3, Name = "Thiếu nhi" },
            new Category() { Id = 4, Name = "Kỹ năng sống" },
            new Category() { Id = 5, Name = "Lịch sử - Địa lý" },
        };

        
        public static List<Product> products = new List<Product>()
        {
            new Product() { Id = 1,  Name = "Nhà Giả Kim",                    Price = 89000,  Description = "Tiểu thuyết triết lý về hành trình theo đuổi ước mơ", CategoryId = 1 },
            new Product() { Id = 2,  Name = "Sapiens: Lược Sử Loài Người",   Price = 250000, Description = "Hành trình tiến hóa của loài người qua các thời kỳ",  CategoryId = 5 },
            new Product() { Id = 3,  Name = "Đắc Nhân Tâm",                  Price = 120000, Description = "Nghệ thuật thu phục lòng người kinh điển",            CategoryId = 4 },
            new Product() { Id = 4,  Name = "Doraemon - Tập 1",              Price = 25000,  Description = "Truyện tranh thiếu nhi kinh điển của Nhật Bản",        CategoryId = 3 },
            new Product() { Id = 5,  Name = "Lược Sử Thời Gian",             Price = 180000, Description = "Khám phá vũ trụ và bản chất của thời gian",            CategoryId = 2 },
            new Product() { Id = 6,  Name = "Rừng Na Uy",                    Price = 150000, Description = "Tiểu thuyết tình cảm lãng mạn của Murakami",           CategoryId = 1 },
            new Product() { Id = 7,  Name = "Tôi Tài Giỏi, Bạn Cũng Thế",    Price = 135000, Description = "Phương pháp học tập và phát triển bản thân hiệu quả",  CategoryId = 4 },
            new Product() { Id = 8,  Name = "Cô Bé Bán Diêm",                Price = 45000,  Description = "Truyện cổ tích cảm động của Andersen",                 CategoryId = 3 },
            new Product() { Id = 9,  Name = "Vũ Trụ",                        Price = 220000, Description = "Khám phá vũ trụ bao la cùng Carl Sagan",               CategoryId = 2 },
            new Product() { Id = 10, Name = "Đại Việt Sử Ký Toàn Thư",       Price = 350000, Description = "Bộ sử ký cổ nhất còn lưu giữ của Việt Nam",           CategoryId = 5 },
            new Product() { Id = 11, Name = "Bắt Trẻ Đồng Xanh",             Price = 110000, Description = "Tiểu thuyết kinh điển về tuổi trẻ nổi loạn",           CategoryId = 1 },
            new Product() { Id = 12, Name = "Hoàng Tử Bé",                   Price = 60000,  Description = "Truyện thiếu nhi kinh điển của Saint-Exupéry",         CategoryId = 3 },
            new Product() { Id = 13, Name = "Nhà Lãnh Đạo Không Chức Danh",  Price = 140000, Description = "Nghệ thuật lãnh đạo bản thân và ảnh hưởng tích cực",   CategoryId = 4 },
            new Product() { Id = 14, Name = "Nguồn Gốc Các Loài",            Price = 280000, Description = "Học thuyết tiến hóa của Charles Darwin",               CategoryId = 2 },
            new Product() { Id = 15, Name = "Việt Nam Sử Lược",              Price = 200000, Description = "Lịch sử Việt Nam tóm lược của Trần Trọng Kim",         CategoryId = 5 },
            new Product() { Id = 16, Name = "Cuốn Theo Chiều Gió",           Price = 320000, Description = "Tiểu thuyết lịch sử kinh điển nước Mỹ",                CategoryId = 1 },
            new Product() { Id = 17, Name = "Truyện Cổ Grimm",               Price = 85000,  Description = "Kho tàng truyện cổ tích của anh em nhà Grimm",         CategoryId = 3 },
            new Product() { Id = 18, Name = "Thói Quen Nguyên Tử",           Price = 160000, Description = "Xây dựng thói quen tốt và loại bỏ thói quen xấu",     CategoryId = 4 },
            new Product() { Id = 19, Name = "Vật Lý Vui",                    Price = 130000, Description = "Vật lý giải trí hấp dẫn cho mọi lứa tuổi",             CategoryId = 2 },
            new Product() { Id = 20, Name = "Đất Nước Việt Nam Qua Các Thời Kỳ", Price = 300000, Description = "Lịch sử Việt Nam qua các triều đại phong kiến",   CategoryId = 5 },
        };
    }
}
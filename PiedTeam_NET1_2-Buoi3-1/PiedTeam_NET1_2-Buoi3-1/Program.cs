class Program
{
    public class Product
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public decimal Price {get; set;}
        public string Category { get; set;}
    }
    public class ProductDto
    {
        public string ProductName {get; set;}
        public decimal ProductPrice {get; set;}
        public string Category {get; set;}
    }

    static void Main(string[] args)
    {
        // List<Product> products = new List<Product>
        // {
        //     new Product { Id = 1, Name = "iPhone 15", Price = 25000, Category = "Điện thoại" },
        //     new Product { Id = 2, Name = "Samsung S24", Price = 22000, Category = "Điện thoại" },
        //     new Product { Id = 3, Name = "MacBook Air", Price = 32000, Category = "Laptop" },
        //     new Product { Id = 4, Name = "Dell XPS", Price = 28000, Category = "Laptop" },
        //     new Product { Id = 5, Name = "AirPods Pro", Price = 6500, Category = "Phụ kiện" },
        //     new Product { Id = 6, Name = "Galaxy Buds", Price = 4500, Category = "Phụ kiện" }
        // };

        //LINQ: 1 trong những cong cụ mạnh mẽ nhất của C# để xu li du lieu
        //phần core, biết mới làm .NET dc
        //LINQ (Language Intergated Query) là 1p của .NET framework
        // cung cap 1 cach tiep can manh me va
        // linh hoat de truy van va thao tac du lieu từ
        // nhieu nguon khac nhau như (collections, dtb, XML, ...
        // bang cach sd cú phap giong nhu SQL nhung tich hop truc tiep
        // vao ngon ngu lap trinh C#
        /*
        trc day khi chua co LINQ
        - muon query db -> viết sql
        - muon lọc 1 ds -> viết dòng For - sau đó If else để lấy ra
        - với mỗi nguồn dlieu phải sd những cách riêng biet khác nhau
        sau khi co LINQ
        - viết truy vấn db bằng cú pháp (ngôn ngữ) C# luon
        - viet 1 kiểu thôi, nhma kiểu này có thể truy vấn từ nhiều nguon (SQL, Collection)
         */
        List<int> list = [1, 2, 3, 4, 5];
        List<int> listResult = []; // lấy ra mảng các số chan
        // trc khi sd LINQ
        // foreach (var item in list)
        // {
        //     if (item % 2 == 0)
        //     {
        //         listResult.Add(item);   
        //     }
        // }
        //
        // foreach (var item in listResult)
        // {
        //     Console.WriteLine(item);
        // }

        // sau khi sd LINQ
        listResult = list.Where(x => x % 2 == 0).ToList();
        foreach (var item in listResult)
        {
            Console.WriteLine(item);
        }

        //LINQ có 2 dạng chính: LINQ to Object, LINQ to SQL
        //LINQ to Object:
        // dùng để query các Collection: List, Array, Dictionary,...
        //vd: listResult = list.Where(x=> x % 2 == 0).ToList();
        //LINQ to SQL
        // LINQ + Entity Framework kết hop lại de query db
        // giup ng dùng co the truy van du lieu bang ngon ngu C#
        // khi minh viet code C#, EF sẽ convert code đó sang SQL giúp mình
        //vd: _dbContext.Users.Where(x => x.FirstName.Contains("abc"))
        // SELECT * from Users WHERE FirstName LIKE "%abc%"
        // các lợi ích của viết LINQ
        // dễ đọc, dễ hiểu 
        // truy vấn từ nhiều nguồn
        // "SQL STRING" || "chấm tu field ra"
        // dễ dàng trong việc ptr, kh truy vấn sai
            //khi mình viết SQL, thì no la string ma, có thể viet sai chinh ta
            // có thể sai tên cột, tên table
            //còn khi viết bằng code thi cac cột là cac field trong class
            // chỉ viec . là sài thôi, kh cần care chính tả
        //trong LINQ muon truy vấn theo đk nào thì . ra sài thôi
        //thì có 2 trường phái viết LINQ
        /*
        1. LINQ Query Syntax (cú pháp truy vấn)
        - kiểu này thì no giong hệt SQL, nhưng viết trong C#
        - var result = from p in products where p.Name.Contain("abc")
        2. LINQ Method Syntax (cú pháp truy vấn)
        -  var result = products.Where(p => p.Name.Contain("abc"));
        */
        // Deferred Execution (lazy loading) và Immediate Execution (Eager Loading)
        /*
         Deferred Execution (lazy loading):
         - LINQ sẽ kh chạy ngay khi bạn vừa click xong
         - nó chỉ hỗ tro xây dựng 1 biểu thức (Expression) - 1 bảng kế hoach
         - va chờ đến khi bạn duyệt (Interate) thì nó mới thực hien bang ke hoach
         - từ duyệt (Interate) này thể hiện ở những cho nao. for, foreach
         */
        List<int> demoDeferredExecution = [1, 2, 3, 4, 5];
        var filter = demoDeferredExecution.Where(item => item % 2 == 0);
        Console.WriteLine("====");
        demoDeferredExecution.Add(6);
        foreach (var item in filter)
        {
            Console.WriteLine(item);
        }
        // 2 4 6
        //filters nó là 1 bản ke hoạch chờ đợi để dc duyệt và trả ra kq
        // còn đối với tuong tac db, thì nó dc coi là 1 câu query nóng hổi
            //vừa dc viet ra, nhưng chưa dc thực thi
        //vì sao mình lại dùng Deffered vay anh?
        // -> khi nó còn la 1 bang ke hoach thi minh vẫn co thể chỉnh sửa dc nhieu lan
        
        /*
        var query = User.Where(x => x.FirstName.Contains("abc"));
        lồng them dieu kien
        query = query.Where(x => x.Age > 10);
        và sẽ apply thêm nhiều thứ khac nữa
         */
        /*
         * Deferred Query Operators phổ biến
         * - Where -> truy vấn đk
         * - Select -> truy vấn đẻ lấy ra 1 kiểu dữ liệu khac (Projection)
         * - OrderBy, OrderByDescending -> sap xep thu tự của dữ liệu
         * - GroupBy -> nhóm du lieu theo 1 tiu chí nào đó
         * - Join -> kết hợp dữ liệu từ 2 nguon khac nhau
         * - Skip, SkipWhile -> bo qua
         * - Take, TakeWhile -> lấy
         * - Distinct
         *
         * -> Mấy thằng trên trả về IEnumerable hoặc IQueryable // Trong tương lai sẽ biết
         * -> giai thich phân trang
         */
        /*
         * Immediate Execution (Eager Loading)
         * - Query trả ra kết quả ngay lập tức khi gọi phương thức
         *
         * Chỉ có ít số ít các phương thức sẽ kích hoạt việc thực thi Query
         * ToList(), ToArray(), ToDictionary(), Count(), ... Trả ra 1 collection hoặc 1 giá trị (Count) ngay lập tức
         * FirstOrDefault(), First(), SingleOrDefault(), Single(), ... Trả ra phần tử đầu tiên
         */
        
        //where dùng de truy vấn dữ liệu giống như if 
            //lay ra sản phẩm nao co Category la điện thoại
            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "iPhone 15", Price = 25000, Category = "Điện thoại" },
                new Product { Id = 2, Name = "Samsung S24", Price = 22000, Category = "Điện thoại" },
                new Product { Id = 3, Name = "MacBook Air", Price = 32000, Category = "Laptop" },
                new Product { Id = 4, Name = "Dell XPS", Price = 28000, Category = "Laptop" },
                new Product { Id = 5, Name = "AirPods Pro", Price = 6500, Category = "Phụ kiện" },
                new Product { Id = 6, Name = "Galaxy Buds", Price = 4500, Category = "Phụ kiện" }
            };
            var phoneListV1 = products.Where(p => p.Category == "Điện thoại").ToList();
            //lấy ra sản phẩm có giá trị lớn hơn 20k
            var phoneListV2 = products.Where(p => p.Price > 20000).ToList();
            //lấy ra sản phẩm có cate là điện thoại va có giá > 20k
            var phoneListV3 = products.Where(p => p.Category == "Điện thoại"
                                                        && p.Price > 20000).ToList();
            //lấy ra sản phẩm có cate là điện thoại hoac có giá > 20k
            var phoneListV4 = products.Where(p => p.Category == "Điện thoại"
                                                        || p.Price > 20000).ToList();
    }
}
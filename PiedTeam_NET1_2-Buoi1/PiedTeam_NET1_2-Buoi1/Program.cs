namespace PiedTeam_NET1_2_Buoi1;

public class Program
{
    static void Main(string[] args)
    {
        //có bao nhiêu kiểu dữ liệu khi ta học lập trình
        //primitive và kiểu object
        /*
         * value type (primitive) và reference type (object)
         * 
         */
        // int a = 3;
        // int b = 2;
        // int c = a + b;
        // Console.WriteLine(c);
        // Console.WriteLine("hello world");
        
        //khi mà 1 bieens đc khởi tạo thì nó sẽ dc đề cập đến 2 vùng nhớ. STACK | HEAP
            //sẽ giảng kĩ hơn ở bên dưới
        //reference type
            //string
            //array
            //class: Student, Person
            //interface
        //Class và Object khác nhau chỗ nào
            //Class: 
            //Object: là 1 thể hiện của 1 class (Instance). ví dụ khi nhắc tới class học sinh
                // thì chúng ta sẽ có các THE HIEN như là học sinh Tân, học sinh Bình, học sinh Khoa
                // class co the coi như 1 cái khuôn, bên trong này có thuoc tính, phương thức,...
        //khi lưu ValueType thì có mấy vùng nhớ dc sử dụng
        //int d = 3; //lưu ở trên Stack, biến d là 1 biến cục bộ
        //theo mn, 1 biến có kiểu là ValueType co dc tồn tại trong Heap kh
            //xíu giai quyết
            // -> có, khi khai báo 1 field có kiểu là ValueType nằm trong class
        // Student p1 = new Student();
        // Student p2 = p1;
        
        //p1 va p1 sẽ nằm trong Stack và cùng trỏ tới vùng nhớ Object trên Heap
        
        //mn hiểu ntn về Static
            //static là 1 vùng nhớ đặc biệt, nam riêng biệt so với Stack va Heap
            //là 1 vùng nho sài chung dc cấp phát và tồn tại suot vòng đời cua app
            // int a = 10;
            // int b = 20;
            // Console.WriteLine("Num b: "+ b);
            // Console.WriteLine("Num a: " + a);
            // Console.WriteLine("=====");
            // Console.WriteLine($"Num a: {a}", a);
            // Console.WriteLine($"Num b: {b}", b);
            // Console.WriteLine($"Num a: {a}, Num b: {b}", a, b);
            // Console.WriteLine("num a: {0}", a);
            // Console.WriteLine("num b: {0}", b);
            // Console.WriteLine($"num a: {a}", a);
            //function
            // có 4 kiểu hàm
            //pass by value
        // static void PassByValue(int a) 
        // { 
        //     //thang a chỉ mượn gia trị của x thôi, a chỉ ton tại trong func nay thoi
        //     //biến cục bộ
        //     a = 100;
        //     Console.WriteLine(a);
        // }
        // int x = 1;
        // PassByValue(x);
        
            //pass by reference (out, ref)
            // C# cung cap thêm 2 món lạ lquan -> tham số của func
            //tham số truyền vao la 1 con tror
            //out: trả ra gtri thông qua biến out
            //ref:truyen vao 1 biến có sẵn, hàm co thê thay đổi gtri của bien đó
            //2 thằng này giup mở rộng việc trả về của 1 cái hàm
            
            //ref là cgi
                //nó giống con trỏ trong C
                //thay đổi bên ngoài thì ben trong hàm cũng thay đổi và nguoc lại
                //khi chơi voi biến ref thì bat buoc phải có biến đó trc khi truyền vào
        // static void PassByRef(ref int a)
        // {
        //     a = 100;
        // }
        //
        // int m = 10;
        // Console.WriteLine("before ref m: " + m);
        // PassByRef(ref m);
        // Console.WriteLine("after ref m: " + m);
        
        //out
        //khi chơi với out la bat buộc ben trong phải sửa lai tham số
            //sửa lai giá trị của biến out
        //tui hứa sẽ trả cho b 1 con số
        // static void PassByOut(out int a)
        // {
        //     a = 100;
        // }
        //
        // int n = 10;
        // PassByOut(out n);
        // Console.WriteLine("after out: " + n);
        //viết hàm tính tổng của các số từ 1 den n. 
        //cấm dùng return nhưng vẫn lấy dc gtri sau khi tính tổng
        // static void TotalCount(int n, out int sum)
        // {
        //     sum = 0;
        //     for (int i = 0; i < n; i++)
        //     {
        //         sum += i;
        //     }
        // }
        // int sum;
        // TotalCount(10, out sum); 
        // Console.WriteLine("total sum: " + sum);
        
        //viết 1 hàm tính tổng các số chẵn và tổng số lượng các số chan từ 1 đến n
        //cấm dùng return nhưng vẫn lấy dc 2 kết quả
        static void CalEvenAndCount(int n, out int s, out int c)
        {
            c = 0;
            s = 0;
            for (int i = 1; i <= n; i += 2)
            {
                if (n % 2 == 0)
                {
                    s += i;
                    c++;
                }
            }
        }
        CalEvenAndCount(10, out int s,  out int c);
        Console.WriteLine("total sum from 1 to: " + s);
        Console.WriteLine("count: " + c);
    }
}
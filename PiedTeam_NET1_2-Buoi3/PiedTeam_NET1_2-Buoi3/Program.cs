class PiedTeam_NET1_2Buoi3
{
    public class Student
    {
        // INSTANCE VARIABLE - bien de luu info cua 1 object
        // BACK-FIELD, DATA-FIELD - BIEN DUNG DE LUU INFO CUA 1 OBJECT (tên gọi của C#)
        // neu kh ghi puvlic, private (kh khai bao access modifier) thì mặc định là Private
        // private string _id = "123";
        
        // DEFAULT VALUE 
            // khi ma minh khoi tao 1 field ma kh gán gì cả thì field đo sẽ có 1 gtri mac dinh
            // string: null
            // int: 0
            // boolean: false
            // Object: null
            // Array: null
            
        // Constructor - ham khoi tao
            // Overload: khi co nhieu Constructor cùng ten ma khac tham so 
            // private int _id;
            // private string _name;
            // private int _age;
            // -> get set
            public static int Id {set;get;}
            public string Name {set;get;}
            public int Yob {set;get;}

            public void ShowProfile()
            {
                Console.WriteLine($"ID: {Id}, Name: {Name}, Yob: {Yob}");
            }

            //khi mà viết
            // private string _id;
            // nó sẽ viết 2 hàm get set bên dưới
            
            public Student(int id, string name, int yob)
            {
                Id = id;
                Name = name;
                Yob = yob;
            }
            
            //empty constructor
                // la constructor dc tao ra tu dong
            // public Student(){}
            
            // Get data field
            // Traditional Style
            // public string GetName()
            // {
            //     //Mac du _name private nhung vì ở trong pham vi Class, thi chung ta van lay dc
            //     return _name;
            // }

            // public void SetName(string name)
            // {
            //     _name = name;
            // }
            // .NET cũng cung cap giup viết hàm tiện hơn - Expression Body
                // khi body của 1 hàm. chỉ có 1 lệnh duy nhất thì co the viet gọn lai nhu sau
        // public string GetNameV2() => _name;
        // public void SetNameV2(string name) => _name = name;
        
    }
    static void Main(string[] args)
    {
        Student s1 = new Student(123, "Bao", 2006);
        Student s2 = new Student(123, "Bao", 2006);
        s1.ShowProfile();
        s2.ShowProfile();
        // đinh nghĩa thêm ve static
            //"static" giong như 1 thang ngoi tren cao coi may thang khac o duoi danh nhau
            //thang nao la static thi ra chieèu khac ngồi (vùng nhớ riêng)
            // như v ID ngồi day, Main ngồi day
            // cái nào mà ăn theo Object thi kh nen sd Static (đã demo case s1 s2)
                //vd: Tên ng, Tuổi, mã số là ăn theo từng ng -> non -> static
                
            //khi nào ta dùng static
                // các bộ đồ chơi (tool, hàm tai sd)
                // cac const,...
        //4 tính chất cơ bản của OOP
        //1. Encapsulation:
            // đóng gói những method vào 1 class hoàn chỉnh, 1 cai khuôn
            // cung cấp khả năng modularity (mô đun hóa, chia nhỏ ra de ez quản li
            // bảo ve tính toàn vẹn của dữ liệu -> chỉ cho phép truy cập thông qa các access modifier (public, private, protected
            // hoặc là các hàm get/set
        
        //2. Inheritance: 
            // đề cập den khả nang ke thua, tái sd lai code cu
            // khi class B kế thua class A, thì class B sẽ chứa code riêng của nó,
            // chua' c code của class A, code ở day là Property và Method
        //3. Polymorphism:
            // đề cập đến khả năng thể hiện các Class và Action theo nhiu cach khác nhau
            // vd: cac interface, abstract clas, class thông qua viec Implement cac Interface
            // hoặc Inheritance các method (Override | Overload)
            // mỗi class thể hện bản sac rieng (implement) của nó khi kế thùa hoac implement
            //ngoài ra tính đa hình nay là 1 tinh chat cục ki qtrong trong viec hinh thanh
                //cong nghe lõi của .NET (Dependency Injection)
        //4. Abstraction:
            // viết những thứ phức tạp thành những thu cơ bản mà kh mất chat
            //vd: 1hs thì có những tính chất mơ hồ như Ten, Tuoi, Nam sinh, các loai hanh dong
                // như là học, chơi như the nao thì tutu tính, thì những thứ phức tạp ở đây
                // là những hđ cụ thể như la choi ntn, ro rang cụ thể hon
            //chung quy lại hs chỉ có thể có những hd don gian như la choi và học (Abstract Method)
            
    }
}
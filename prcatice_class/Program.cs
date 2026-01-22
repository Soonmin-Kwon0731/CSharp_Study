//public class Person
//{
//    /*
//    필드(Field): 클래스의 데이터 또는 상태를 나타내는 변수
//     */
//    private string name;
//    private int age;

//    /*
//    프로퍼티(property): 필드에 대한 접근을 제어하는 멤버로, 데이터의 캡슐화를 지원한다.
//     */
//    public string Name
//    {
//        get { return name; }
//        set { name = value; }
//    }

//    public int Age
//    {
//        get { return age; }
//        set
//        {
//            if (value >= 0)
//            {
//                age = value;
//            }
//        }
//    }

//    /*
//    생성자(Constructor): 객체가 생성될 때 호출되는 특별한 메서드로, 초기화 작업을 수행한다.
//     */
//    public Person(string name, int age)
//    {
//        this.name = name;
//        this.age = age;
//    }

//    /*
//    메서드(Method): 클래스가 수행할 수 있는 동작을 정의.
//    */
//    public void Introduce()
//    {
//        Console.WriteLine($"안녕하세요, 저는 {name}이고, 나이는 {age}입니다.");
//    }
//}
Car car = new Car();
car.ShowInformation();
string brand = car.GetBrand();
Console.WriteLine(brand);
Console.ReadKey();

class Car
{
    string brand;
    string model;
    string color;

    public Car() //ctor + tab을 누르면 자동 생성됨. ㄷㄷ
    {
        brand = "현대";
        model = "소나타";
        color = "검정";
    }


    public void ShowInformation()
    {
        Console.WriteLine($"브랜드는 {brand}입니다.");
        Console.WriteLine($"모델은 {model}입니다.");
        Console.WriteLine($"색상은 {color}입니다.");
    }

    public string GetBrand()
    {
        return brand;
    }
}
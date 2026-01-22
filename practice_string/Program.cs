//문자열 선언과 초기화

//문자열은 string 키워드를 사용하여 선언하고, 쌍따옴표(" ")를 사용하여 초기화합니다.

string greeting = "Hello, World!";
string emptyString = "";   // 빈 문자열
string nullString = null;  // null 문자열
//문자열의 불변성

//C#에서 문자열은 불변이므로, 문자열을 수정하는 것처럼 보여도 실제로는 새로운 문자열이 생성됩니다.

string original = "Hello";
original = original + ", World!";  // 새로운 문자열이 생성됨
//문자열 연결(Concatenation)

//문자열을 연결하려면 + 연산자 또는 string.Concat 메서드를 사용할 수 있습니다.

string firstName = "John";
string lastName = "Doe";
string fullName = firstName + " " + lastName;  // "John Doe"
//문자열 보간(String Interpolation)

//C#에서는 문자열 보간을 사용하여 문자열 내에 변수 값을 포함할 수 있습니다. 보간된 문자열은 $ 기호로 시작합니다.

string name = "Alice";
int age = 30;
string message = $"Name: {name}, Age: {age}";  // "Name: Alice, Age: 30"
//문자열 형식화(String Formatting)

//string.Format 메서드나 ToString 메서드를 사용하여 형식화된 문자열을 생성할 수 있습니다.

//string formatted = string.Format("Name: {0}, Age: {1}", name, age);
//문자열 속성, 메서드

//문자열에는 다양한 속성 및 메서드가 있어 여러 작업을 쉽게 수행할 수 있습니다.

//- 길이 확인: Length 속성을 사용하여 문자열 길이를 확인합니다.

int length = greeting.Length;
//부분 문자열 추출: Substring 메서드를 사용하여 문자열의 일부를 추출합니다.

string part = greeting.Substring(0, 5);  // "Hello"
//문자열 포함 여부 확인: Contains 메서드를 사용하여 특정 문자열을 포함하는지 확인합니다.

bool containsWorld = greeting.Contains("World");  // true
//문자열 비교: Equals 메서드나 == 연산자를 사용하여 문자열을 비교합니다. 대소문자를 무시한 비교는 StringComparison.OrdinalIgnoreCase를 사용합니다.

//bool isEqual = greeting.Equals("HELLO, WORLD!", StringComparison.OrdinalIgnoreCase);
//대소문자 변환: ToUpper와 ToLower 메서드를 사용하여 문자열을 대문자 또는 소문자로 변환합니다.

string upper = greeting.ToUpper();  // "HELLO, WORLD!"
string lower = greeting.ToLower();  // "hello, world!"
//공백 제거: Trim, TrimStart, TrimEnd 메서드를 사용하여 문자열의 공백을 제거할 수 있습니다.

string withSpaces = "  Hello  ";
string trimmed = withSpaces.Trim();  // "Hello"

string withChars = "***Hello***";
string trimmedChars = withChars.Trim('*');  // "Hello"

string withLeadingSpaces = "  Hello  ";
string trimmedStart = withLeadingSpaces.TrimStart();  // "Hello  "

string withLeadingChars = "***Hello***";
string trimmedStartChars = withLeadingChars.TrimStart('*');  // "Hello***"

string withTrailingSpaces = "  Hello  ";
string trimmedEnd = withTrailingSpaces.TrimEnd();  // "  Hello"

string withTrailingChars = "***Hello***";
string trimmedEndChars = withTrailingChars.TrimEnd('*');  // "***Hello"

string mixedChars = "-*_Hello_*--";
string trimmedMixed = mixedChars.Trim('-', '*', '_');  // "Hello"
string trimmedMixedStart = mixedChars.TrimStart('-', '*', '_');  // "Hello_*--"
string trimmedMixedEnd = mixedChars.TrimEnd('-', '*', '_');  // "-*_Hello"
//문자열 분할(Split)

//Split 메서드를 사용하여 문자열을 특정 구분자로 나누어 배열로 반환할 수 있습니다.

string colors = "Red,Green,Blue";
string[] colorArray = colors.Split(',');  // ["Red", "Green", "Blue"]
//문자열 결합(Join)

//배열의 문자열을 특정 구분자로 결합하여 하나의 문자열로 만들 수 있습니다.

string joinedColors = string.Join(" | ", colorArray);  // "Red | Green | Blue"
//이스케이프 시퀀스

//문자열 내에서 특수 문자를 나타낼 때는 이스케이프 시퀀스를 사용합니다.

//\n: 줄 바꿈

//\t: 탭

//\": 큰따옴표

//\\: 백슬래시

//string path = "C:\\Users\\John";      // C:\Users\John
//string quote = "He said, \"Hello!\""; // He said, "Hello!"
//문자열의 가변 버전: StringBuilder

//여러 문자열 조작이 필요한 경우, StringBuilder를 사용하면 더 효율적입니다.

StringBuilder sb = new StringBuilder();
sb.Append("Hello");
sb.Append(", ");
sb.Append("World!");
string result = sb.ToString();  // "Hello, World!"


Console.WriteLine("===캐릭터 생성 시스템 가동 ===");
// [섹션 1-1] 정수형 타입 (명시적 선언)
int level = 1;
long experience = 0;

// [섹션 1-2] 소수형 타입
float moveSpeed = 5.5f;       // float는 뒤에 'f' 필수
double criticalRate = 0.15;   // double은 기본 소수
decimal money = 1000.50m;     // decimal은 뒤에 'm' 필수 (돈 계산)

// [섹션 1-3] bool, char 타입
bool isAlive = true;
char rank = 'C';              // 문자는 작은 따옴표

// [섹션 1-5] 암시적 선언 (var)
// 컴파일러가 우변의 "홍길동"을 보고 string 타입임을 추론합니다.
var characterName = "홍길동";

// [섹션 1-4] Enum 사용
CharacterClass characterJob = CharacterClass.Warrior;

// ---결과 출력 ---
Console.WriteLine($"이름 : {characterName}");
Console.WriteLine($"직업 : {characterJob}");
Console.WriteLine($"레벨 : {level} (Rank : {rank}");
Console.WriteLine($"경험치 : {experience}");
Console.WriteLine($"생존여부: {isAlive}");
Console.WriteLine("--------------------------------");
Console.WriteLine($"이동속도 : {moveSpeed}");
Console.WriteLine($"치명타 확률 : {criticalRate * 100}%");
Console.WriteLine($"소지금 : {money}Gold");

Console.ReadKey();

enum CharacterClass
{
    Warrior,
    Mage,
    Archer
}
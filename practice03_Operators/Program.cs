// =======================================
//[섹션 3] 연산자 실습: 턴제 전투 맛보기
// =======================================

Console.WriteLine("=== 전투 시작 ===");

//1. 변수 세팅
int playerAtk = 10;
int maxHp = 100;
int currentHp = 100;
String? playerName = null; //?는 비어있을 수 있다(null)이라는 뜻

//2. Null 병합 연산자 (??)
//playerName이 비어있으면(null) "이름없는 영웅"을 대입
string displayName = playerName ?? "이름없는 영웅";

Console.WriteLine($"플레이어 등장: {displayName} HP: {currentHp}/{maxHp}");
Console.WriteLine("야생의 슬라임이 나타났다.");

//----------------------------------------
//3. 산술 연산자
//데미지 계산: 공격력의 1.5배 크리티컬 데미지 예상
//(int)는 소수점을 정수로 강제 변환하는 '캐스팅'
int criticalDmg = (int)(playerAtk * 1.5f);

//4. 할당 연산자
// 몬스터가 플레이어를 공격! 체력이 20 깎임
Console.WriteLine(">> 슬라임의 몸통박치기!");
currentHp -= 20;
currentHp = 40;

// 5. 증강 연산자
// 턴이 지나감
int turn = 1;
turn++;
Console.WriteLine($"[턴 {turn}] 남은 체력: {currentHp}");


// ----------------------------------------------------

// 6. 논리 연산자 (&&, ||) 와 비교 연산자 (>, <=)
// 포션 먹기 조건: 체력이 50 이하이고(AND), 포션이 있어야 함
bool hasPotion = true;
bool isLowHp = currentHp <= 50;

// 조건: 체력이 낮고(AND) 포션이 있는가?
bool canUsePotion = isLowHp && hasPotion;

Console.WriteLine($"포션 사용 가능 여부: {canUsePotion}");

// 7. 나머지 연산자 (%) - 패턴 확인
// 3번째 턴마다 필살기를 쓸 수 있다고 가정
// 현재 턴(2)을 3으로 나눈 나머지가 0인가?
bool isSkillTurn = (turn % 3 == 0);

Console.WriteLine($"필살기 사용 가능 여부: {isSkillTurn}");




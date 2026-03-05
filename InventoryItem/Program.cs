using System;

// README.md를 읽고 코드를 작성하세요.
// InventoryItem 구조체를 정의하세요.

InventoryItem[] inv = new InventoryItem[5];//배열 칸 선언
inv[0] = new InventoryItem("검", 3.5, 1500);// 칸에 값 넣기
inv[1] = new InventoryItem("방패", 5.0, 1200);
inv[2] = new InventoryItem("포션", 0.3, 50);
inv[3] = new InventoryItem("활", 1.8, 1300);
inv[4] = new InventoryItem("투구", 2.0, 800);

PrintList(inv);
 

 PrintSum(inv);

void PrintSum(InventoryItem[] inv)
{
double Total = 0;
int TotalPrice = 0;
double Average = 0;
    //double Max = double.MinValue;
    //double Min = double.MaxValue;
    InventoryItem maxPrice = inv[0];
    InventoryItem minWeight = inv[0];

    //배열에 저장된 값들을 계산
    for (int i = 0; i < inv.Length; i++ ) 
    {
        Total += inv[i].Weight;
        TotalPrice += inv[i].Price;
        Average += inv[i].Price / inv.Length;

     

        if (inv[i].Price > maxPrice.Price)
        {
            maxPrice = inv[i];
            //초기엔 0번 인덱스칸 값이 저장
            //이후 비교하면서 더 큰 값이 나오면 저장
            
        }
        else if (inv[i].Weight < minWeight.Weight)
        {
            minWeight = inv[i];
            //초기엔 0번 인덱스칸 값이 저장
            //이후 비교하면서 더 작은 값이 나오면 저장
        }

    }
    Console.WriteLine("=== 인벤토리 통계 ===");
    Console.WriteLine($"전체 무게: {Total:F1}kg");
    Console.WriteLine($"전체 가격: {TotalPrice}골드");
    Console.WriteLine($"평균 가격: {Average}골드");
    Console.WriteLine($"가장 비싼 아이템: {maxPrice.Name}");
    Console.WriteLine($"가장 가벼운 아이템: {minWeight.Name}");
    //아이템 출력때 Max, Min은 아이템명이 아닌 값이 출력되는 문제가 있었음
    //math.Max, min은 값만 비교하기 때문에 문자열인 아이템 명을 출력 하지 못함
    //for문에 가격 비교 조건문 추가해서 인덱스에 있는 아이템 자체를 저장하게 했고
    //출력은 .Name으로 아이템 명만 추출해서 출력시킴
}





void PrintList(InventoryItem[] inv)//함수화
{
    Console.WriteLine("=== 인벤토리 통계 ===");
    foreach(var list in inv)
    {
        Console.WriteLine($"{list.Name} - 무게: {list.Weight}kg, 가격: {list.Price}골드");
    }
    
}

struct InventoryItem
{
    //public double Total;
    //public double TotalPrice;
    //public double Average;
    //public double Max;
    //public double Min;
    //계산 관련 필드
    //========================
    public string Name;
    public double Weight;
    public int Price;

    public InventoryItem(string name, double weight, int price)
    {
        Name = name;
        Weight = weight;

        Price = price;
       
    }


}
//과정 기록
//1. InventoryItem 구조체 정의
//2. InventoryItem 배열 생성 및 초기화
//3. 배열 출력 함수 PrintList 작성
//4. 테스트 위해 PrintList 함수 호출
//5. 정상출력 확인후 통계 계산 함수 PrintSum 작성
//6. PrintSum 함수에서 전체 무게, 전체 가격, 평균 가격 계산
//7. 테스트 과정에서 예상 실행 결과와 완전히 다르게 출력되는 문제 발생.
//8. 초기 저장 방식은 inv[i].Price 형태로 저장함
//9. 언뜻 보기에 합계가 저장될것같지만 실제로는 inv[i]때문에 배열의 칸마다 수가 저장되는 상황 발생
//10. 이런 형식은 합해야 할 수가 배열 인덱스마다 저장되므로 합의 계산이 이루어지지 않음
//11. 문제 해결을 위해 저장용 변수을 임의로 추가함
//12. 마지막 2개 항목에서 아이템명이 아닌 숫자가 출력되는 문제 발생
//13. 조건문 대신 사용하려 했던 math.Max, Min은 값만 비교하기 때문에 문자열인 아이템 명을 출력 하지 못함
//14.초기 의도는 최대,최솟값이 있는 배열을 저장하고 그 배열 인덱스의 Name값만 추출하는 목적이였음
//15. 그러나 math함수로 추출한 값을 해당 인덱스의 name값을 가져오는게 불가능했음.
//16. if문으로 최대,최솟값을 가지는 인덱스 저장 방식으로 변경함
//17. 해당 인덱스.Name으로 아이템 명만 추출해서 출력.
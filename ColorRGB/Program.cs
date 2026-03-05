using System;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");

ColorRGB[] clr = new ColorRGB[3];  
clr[0] = new ColorRGB("빨강",255, 0, 0);
clr[1] = new ColorRGB("흰색",255, 255, 255);
clr[2] = new ColorRGB("커스텀",100, 150, 200);
Console.WriteLine("=== RGB 색상 밝기 계산 ===");
for(int i = 0; i < 3; i++)
{
    Console.WriteLine($"{clr[i].Name} - R: {clr[i].R}, G: {clr[i].G}, B: {clr[i].B} → 밝기: {clr[i].GetBrightness()}");
}

struct ColorRGB
{
    public string Name;
    public int R;
    public int G; 
    public int B;

    public ColorRGB(string name, int r, int g, int b)
    {
        Name = name;
        R = r;
        G = g;
        B = b;
    }

    public int GetBrightness()
    {
        return (R + G + B) / 3;
    }


}
//요구사항엔 필드 3개만 있었지만
//이후 색상의 이름을 출력하는데 문제가 생김
// 색상 이름을 저장하기 위해 Name 필드를 추가.


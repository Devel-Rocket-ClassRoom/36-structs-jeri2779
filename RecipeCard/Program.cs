using System;

// README.md를 읽고 코드를 작성하세요.

RecipeCard card = new RecipeCard()
{
    Name = "토마토 파스타",
    Servings = 2,
    Ingredients = new Ingredient[]
    {
        new Ingredient("스파게티면", 200, "g"),
        new Ingredient("토마토소스", 150, "ml"),
        new Ingredient("양파", 1, "개"),
        new Ingredient("마늘", 3, "쪽")
    },
};

card.PrintRecipe();//원본
Console.WriteLine();
card.ScaleRecipe(4);// x2배





struct Ingredient
{
    public string Name;
    public double Amount;
    public string Unit;

    public Ingredient(string name, double amount, string unit)
    {
        Name = name;
        Amount = amount;//
        Unit = unit;//
    }
}

struct RecipeCard
{
    public string Name;
    public int Servings;
    public Ingredient[] Ingredients;

    public RecipeCard(string name, int servings, Ingredient[] ingredients)
    {
        Name = name;
        Servings = servings;
        Ingredients = ingredients;
    }

    public void PrintRecipe()
    {
        Console.WriteLine($"[{Name}] ({Servings}인분)");
        Console.WriteLine("재료:");
        foreach (var ingredient in Ingredients)
        {
            Console.WriteLine($"- {ingredient.Name}: {ingredient.Amount} {ingredient.Unit}");

        }
    }
     

    public void ScaleRecipe(int newSevings)
    {
         
        //예시에서는 2인분이 4인분으로 늘어나야 하므로, 각 재료의 양도 2배로 늘어나야 함
        //newServings에 4가 들어오면 ingredients의 양 x2배
        //단순히 x2만 한다고 가정하면
        // for (int i = 0; i < Ingredients.Length; i++)
        // {
        //     Ingredients[i].Amount *= 2;
        // }
        //만약 2배가 아닌 3,4,배가 늘어나야 한다면?
        int newScale = newSevings / Servings;// newScale은 4/2 = 2가 됨
        for (int i = 0; i < Ingredients.Length; i++)
        {
            //amount값만 조정하면 되므로 .Amount로 추출해서 계산
            Ingredients[i].Amount *= newScale;
            
            //각 배열의 Amount값을 Amont * newScale 결과값을 갱신
        }
        

        Console.WriteLine($"[{Name}] ({newSevings}인분)");
        Console.WriteLine("재료:");
        foreach (var ingredient in Ingredients)
        {
            Console.WriteLine($"- {ingredient.Name}: {ingredient.Amount} {ingredient.Unit}");

        }

    }


}
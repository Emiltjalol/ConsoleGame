using Konsollspelet2;

public class Food
{
    public string FoodName { get; set; }
    public int Nutrition { get; set; } = 10;

    public Food(string foodName, int nutrition)
    {
        FoodName = foodName;
        Nutrition = nutrition;
    }

    // This should be an instance method, NOT static
    public void EatFood(Character character)
    {
        character.Hunger += Nutrition;
    }
}

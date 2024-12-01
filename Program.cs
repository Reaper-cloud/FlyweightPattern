public class Program
{
    public static void Main(string[] args)
    {
        CharacterFactory factory = new CharacterFactory();

        // Создание персонажей
        Character hero1 = factory.GetCharacter("Hero", "Warrior", "warrior.png");
        Character hero2 = factory.GetCharacter("Hero", "Warrior", "warrior.png");
        Character mage = factory.GetCharacter("Mage", "Wizard", "wizard.png");

        // Изменение уровня и опыта
        hero1.AddExperience(100);
        hero1.LevelUp();

        // Проверка, что hero1 и hero2 - это один и тот же объект
        Console.WriteLine(hero1 == hero2); // true

        // Вывод информации о персонажах
        Console.WriteLine(hero1);
        Console.WriteLine(hero2);
        Console.WriteLine(mage);
    }
}

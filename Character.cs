using System;
using System.Collections.Generic;

// Класс Character
public class Character
{
    private readonly string name; // Легковесные данные
    private readonly string type; // Легковесные данные
    private readonly string image; // Легковесные данные
    private int level; // Изменяемый атрибут
    private int experience; // Изменяемый атрибут

    public Character(string name, string type, string image)
    {
        this.name = name;
        this.type = type;
        this.image = image;
        this.level = 1; // Начальный уровень
        this.experience = 0; // Начальный опыт
    }

    // Геттеры для легковесных данных
    public string Name => name;
    public string Type => type;
    public string Image => image;

    // Методы для изменения уровня и опыта
    public void LevelUp()
    {
        level++;
    }

    public void AddExperience(int exp)
    {
        experience += exp;
    }

    public int Level => level;
    public int Experience => experience;

    public override string ToString()
    {
        return $"Character{{ Name='{name}', Type='{type}', Image='{image}', Level={level}, Experience={experience} }}";
    }
}

// Фабрика для создания экземпляров Character
public class CharacterFactory
{
    private readonly Dictionary<string, Character> characters = new Dictionary<string, Character>();

    public Character GetCharacter(string name, string type, string image)
    {
        string key = $"{name}_{type}"; // Уникальный ключ для персонажа
        if (!characters.ContainsKey(key))
        {
            Character character = new Character(name, type, image);
            characters[key] = character;
            return character;
        }
        return characters[key]; // Возвращаем существующий экземпляр
    }
}

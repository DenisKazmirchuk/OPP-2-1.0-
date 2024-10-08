using System;

// Базовий клас "Документ"
class Document
{
    public string Title { get; set; }

    // Конструктор з параметрами
    public Document(string title)
    {
        Title = title;
    }

    // Віртуальні методи
    public virtual void ShowInfo()
    {
        Console.WriteLine($"Документ: {Title}");
    }

    public virtual void ProcessDocument()
    {
        Console.WriteLine("Обробка документа...");
    }
}

// Похідний клас "Курсова"
class Coursework : Document
{
    public string Student { get; set; }
    public string Subject { get; set; }
    public int Grade { get; set; }

    // Конструктор з параметрами
    public Coursework(string title, string student, string subject, int grade)
        : base(title)
    {
        Student = student;
        Subject = subject;
        Grade = grade;
    }

    // Реалізація віртуальних методів
    public override void ShowInfo()
    {
        Console.WriteLine($"Курсова робота: {Title}, Студент: {Student}, Дисципліна: {Subject}, Оцінка: {Grade}");
    }

    public override void ProcessDocument()
    {
        Console.WriteLine("Обробка курсової роботи...");
    }

    // Метод 1: Перевірка студента і оновлення оцінки
    public void UpdateGrade(string student, int newGrade)
    {
        if (Student == student)
        {
            Grade = newGrade;
            Console.WriteLine($"Оновлена інформація про курсову роботу: Студент: {Student}, Дисципліна: {Subject}, Оцінка: {Grade}");
        }
        else
        {
            Console.WriteLine("Студента не знайдено.");
        }
    }

    // Метод 2: Вивести назву роботи та оцінку
    public void ShowTitleAndGrade()
    {
        Console.WriteLine($"Назва роботи: {Title}, Оцінка: {Grade}");
    }
}

// Похідний клас "Диплом"
class Thesis : Document
{
    public string Student { get; set; }
    public int DefenseYear { get; set; }
    public string Supervisor { get; set; }

    // Конструктор з параметрами
    public Thesis(string title, string student, int defenseYear, string supervisor)
        : base(title)
    {
        Student = student;
        DefenseYear = defenseYear;
        Supervisor = supervisor;
    }

    // Реалізація віртуальних методів
    public override void ShowInfo()
    {
        Console.WriteLine($"Дипломна робота: {Title}, Студент: {Student}, Рік захисту: {DefenseYear}, Керівник: {Supervisor}");
    }

    public override void ProcessDocument()
    {
        Console.WriteLine("Обробка дипломної роботи...");
    }

    // Метод: Вивести інформацію про дипломну роботу
    public void ShowThesisInfo(int year, string supervisor)
    {
        if (DefenseYear == year && Supervisor == supervisor)
        {
            Console.WriteLine($"Назва: {Title}, Студент: {Student}, Рік захисту: {DefenseYear}, Керівник: {Supervisor}");
        }
        else
        {
            Console.WriteLine("Інформацію не знайдено.");
        }
    }
}

// Основна програма
class Program
{
    static void Main(string[] args)
    {
        // Створення об'єкту класу "Курсова"
        Coursework coursework = new Coursework("Алгоритми та структури даних", "Іван Гончаров", "Програмування", 85);
        coursework.ShowInfo();
        coursework.ProcessDocument();
        coursework.UpdateGrade("Іван Гончаров", 90); // Оновлення оцінки
        coursework.ShowTitleAndGrade(); // Виведення назви роботи і оцінки

        // Створення об'єкту класу "Диплом"
        Thesis thesis = new Thesis("Розробка веб-застосунку", "Денис Петренко", 2023, "Проф. Тарас Шевченко");
        thesis.ShowInfo();
        thesis.ProcessDocument();
        thesis.ShowThesisInfo(2023, "Проф. Андрій Шевченко"); // Виведення інформації про дипломну роботу

        Console.ReadKey();
    }
}

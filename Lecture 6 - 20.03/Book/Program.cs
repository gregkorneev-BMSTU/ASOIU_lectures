// Старый вариант через SetData оставлен в комментарии:
// Book book1 = new Book();
// book1.SetData("Война и мир", "Л. Толстой", 1869, 1225);
//
// Book book2 = new Book();
// book2.SetData("Мастер и Маргарита", "М. Булгаков", 1967, 480);
//
// Book book3 = new Book();
// book3.SetData("1984", "Дж. Оруэлл", 1949, 328);

// Новый вариант через конструкторы:
Book book1 = new Book("Война и мир", "Л. Толстой", 1869, 1225);
Book book2 = new Book("Новая книга", "А. Автор");
Book book3 = new Book();

// Сокращенная форма записи (C# 9)
Book book4 = new("Евгений Онегин", "А. Пушкин", 1833, 224);

Console.WriteLine(book1.GetInfo());
Console.WriteLine(book2.GetInfo());
Console.WriteLine(book3.GetInfo());
Console.WriteLine(book4.GetInfo());

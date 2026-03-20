class Book
{
    // Закрытые поля класса
    private string title;
    private string author;
    private int year;
    private int pageCount;

    // Основной конструктор
    public Book(string title, string author, int year, int pageCount)
    {
        this.title = title;
        this.author = author;
        this.year = year;
        this.pageCount = pageCount;
    }

    // Конструктор с двумя параметрами - вызывает основной
    public Book(string title, string author)
        : this(title, author, DateTime.Now.Year, 0)
    {
    }

    // Конструктор без параметров - вызывает конструктор с двумя параметрами
    public Book()
        : this("Без названия", "Неизвестен")
    {
    }

    // Старый метод оставлен в комментарии для сравнения
    // public void SetData(string title, string author, int year, int pageCount)
    // {
    //     this.title = title;
    //     this.author = author;
    //     this.year = year;
    //     this.pageCount = pageCount;
    // }

    // Метод вывода информации
    public string GetInfo()
    {
        return $"«{title}» — {author} ({year}), {pageCount} стр.";
    }
}

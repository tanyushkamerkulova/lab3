namespace lab3
{
    // Класс, представляющий программу
    internal class Program
    {
        // Создание объекта записной книжки
        static NoteBook notebook = new NoteBook();

        // Метод запуска программы
        static void Main(string[] args)
        {
            int choice;

            // Основной цикл программы
            do
            {
                ShowMenu();         // Отображение меню
                choice = GetUserChoice();   // Получение выбора пользователя

                // Обработка выбора пользователя
                switch (choice)
                {
                    case 1:
                        notebook.ViewAllContacts();   // Показать все контакты
                        break;
                    case 2:
                        SearchOptions();   // Опции поиска
                        break;
                    case 3:
                        notebook.AddNewContact();   // Добавить новый контакт
                        break;
                    case 4:
                        notebook.ExportToJson();   // Экспорт в JSON
                        break;
                    case 5:
                        notebook.ExportToXml();   // Экспорт в XML
                        break;
                    case 6:
                        notebook.ExportToSql();   // Экспорт в SQLite
                        break;
                    case 7:
                        notebook.ImportFromJson();   // Импорт из JSON
                        break;
                    case 8:
                        notebook.ImportFromXml();   // Импорт из XML
                        break;
                    case 9:
                        notebook.ImportFromSql();   // Импорт из SQLite
                        break;
                    case 10:
                        Console.WriteLine("Ожидайте...");   // Выйти из программы
                        break;
                    default:
                        Console.WriteLine("Некорректный выбор. Попробуйте снова.");
                        break;
                }

            } while (choice != 10);   // Выполнять цикл, пока не выбран выход из программы
        }

        // Метод для отображения меню
        static void ShowMenu()
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Посмотреть все контакты");
            Console.WriteLine("2. Поиск");
            Console.WriteLine("3. Создать новый контакт");
            Console.WriteLine("4. Экспортировать в JSON");
            Console.WriteLine("5. Экспортировать в XML");
            Console.WriteLine("6. Экспортировать в SQLite");
            Console.WriteLine("7. Импортировать из JSON");
            Console.WriteLine("8. Импортировать из XML");
            Console.WriteLine("9. Импортировать из SQLite");
            Console.WriteLine("10. Выход");
            Console.Write("> ");
        }

        // Метод для получения выбора пользователя
        static int GetUserChoice()
        {
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Некорректный ввод. Введите число.");
                Console.Write("> ");
            }
            return choice;
        }

        // Метод для отображения опций поиска
        static void SearchOptions()
        {
            Console.WriteLine("Поиск по:");
            Console.WriteLine("1. Имени");
            Console.WriteLine("2. Фамилии");
            Console.WriteLine("3. Имени и фамилии");
            Console.WriteLine("4. Телефону");
            Console.WriteLine("5. E-mail");
            Console.Write("> ");

            // Вызов метода поиска контактов с передачей выбранной опции
            notebook.SearchContacts(GetUserChoice());
        }
    }
}

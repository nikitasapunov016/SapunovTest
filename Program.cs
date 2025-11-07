using System;
using LibraryLib;

namespace SapunovTest
{
    class Program
    {
        static void Main()
        {
            // экземпляр класса из библиотеки
            LibraryFunctions lib = new LibraryFunctions();

            // проверяем название библиотеки и главного библиотекаря
            Console.WriteLine("Название библиотеки: " + lib.GetLibraryName());
            Console.WriteLine("Главный библиотекарь: " + lib.GetChiefLibrarian());
            Console.WriteLine();

            // показать текущих сотрудников
            Console.WriteLine("Сотрудники:");
            foreach (var s in lib.GetStaff())
            Console.WriteLine(" - " + s);
            Console.WriteLine();

            // пробуеи установить главного библиотекаря
            Console.WriteLine("Пробуем сменить главного библиотекаря на 'Петров П.С.'");
            bool changed = lib.SetChiefLibrarian("Петров П.С.");
            Console.WriteLine("Успех: " + changed);
            Console.WriteLine("Теперь главный библиотекарь: " + lib.GetChiefLibrarian());
            Console.WriteLine();

            Console.WriteLine("Пробуем установить на имя, которого нет в списке 'Иванов И.И.'");
            bool changedFail = lib.SetChiefLibrarian("Иванов И.И.");
            Console.WriteLine("Успех: " + changedFail);
            Console.WriteLine("Главный библиотекарь остался: " + lib.GetChiefLibrarian());
            Console.WriteLine();

            // добавляем нового сотрудника
            Console.WriteLine("Добавляем нового сотрудника 'Новиков Н.Н.'");
            bool add = lib.AddStaff("Новиков Н.Н.");
            Console.WriteLine("Добавлен: " + add);

            Console.WriteLine("Повторная попытка добавить 'Новиков Н.Н.'");
            bool addAgain = lib.AddStaff("Новиков Н.Н.");
            Console.WriteLine("Добавлен снова: " + addAgain);
            Console.WriteLine();

            // вывод обновленного списка сотрудников
            Console.WriteLine("Обновлённый список сотрудников:");
            foreach (var s in lib.GetStaff())
                Console.WriteLine(" - " + s);
            Console.WriteLine();

            // генерация кодов книг
            Console.WriteLine("Генерация кода книги (категория FIC, с переданным номером 42): " + lib.GenerateBookCode("FIC", 42));
            Console.WriteLine("Генерация кода книги (категория SCI, номер <=0 -> случайный): " + lib.GenerateBookCode("SCI", 0));
            Console.WriteLine();
            Console.WriteLine("Демонстрация завершена.");
            Console.ReadKey();
        }
    }
}


using System;
using System.Text;

namespace SF_Module12
{
    class Program
    {
        static void Main(string[] args)
        {
            // (I) [12.1.2]
            /*
            static void Greetings()
            {
                Console.WriteLine("Как вас зовут?");

                var name = Console.ReadLine();

                var greetings = $"Привет, {name}";

                Console.WriteLine(greetings);
            }
            */

            // (II) [12.1.3]
            /*
            static void ReadArray()
            {
                Console.WriteLine("Сколько элементов будет в массиве?");

                var count = Int32.Parse(Console.ReadLine());

                var array = new int[count];

                for (int i = 0; i < count; i++)
                {
                    array[i] = Int32.Parse(Console.ReadLine());
                }

                Console.WriteLine("Все элементы записаны");
            }
            */

            // (III) [12.1.4]
            /*
            static void CheckAge()
            {
                Console.WriteLine("Введите свой возраст");

                var age = Int32.Parse(Console.ReadLine());

                if (age > 13)
                {
                    Console.WriteLine("Вы успешно зарегистрированы");

                }
                else
                {
                    Console.WriteLine("Пользователи младше 14 лет не могут быть зарегистрированы");
                }
            }
            */

            // (IV) [12.2.2]
            /*
            static void GetPageForUser(User user)
            {
                if (!user.LoggedId)
                    return;

                Console.WriteLine("User logged in");

                if (!user.HasAccessToSection)
                    return;

                Console.WriteLine("User has access to that section");

                if (user.HasUnseenNews)
                {
                    ShowNews();
                }

                if (user.HasAdminRights)
                {
                    DecorateAdminTools();
                }
            }
            */

            // (V) [12.3.1]
            /*
            static int BinarySearch(int value, int[] array, int left, int right)
            {
                while (left <= right)
                {
                    var middle = (left + right) / 2;

                    var midElement = array[middle];

                    if (midElement == value)
                    {
                        return middle;
                    }
                    else if (value < midElement)
                    {
                        right = middle - 1;
                    }
                    else
                    {
                        left = middle + 1;
                    }
                }

                return -1;
            }
            */

            // (VI) [12.3.3]
            /*
            static int GetIndex(int[] array, int element)
            {
                int index;
                for (index = 0; index < array.Length; index++)
                {
                    if (array[index] > element)
                        return index;
                }

                return index;
            }
            */
        }
    }
}
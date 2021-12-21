using System;
using System.Collections.Generic;
using System.Text;

namespace Kurs3e
{
    class Clients
    {
        public string _name;
        Operations _operations;
        public Clients(string name, int balance, DateTime time)// конструктор
        {
            _operations = new Operations(balance, time);
            Name = name;


        }
        public bool AddOperation(int sum, DateTime time)// добавление операции
        {
            Operations localOper;
            if (Balance() + sum < 0) // проверка баланса
            {
                return false;
            }
            Operations current = _operations;
            if (current.Next == null) //если нет ссылки на след элемент  
            {
                if (_operations.TimeOperat > time) //если новая дата меньше остальных 
                {
                    _operations.Next = new Operations(sum, time);
                    return true;
                }
                else
                {
                    localOper = _operations;
                    _operations = new Operations(sum, time);
                    _operations.Next = localOper;
                    return true;
                }
            }
            if (current.TimeOperat < time) //если новая дата больше остальных 
            {
                localOper = _operations;
                _operations = new Operations(sum, time);
                _operations.Next = localOper;
                return true;
            }
            do
            {
                if (current.Next == null) //если нет ссылки на след элемент 
                {
                    current.Next = new Operations(sum, time);// добавляем дату в конец списка 
                    return true;
                }
                else
                {
                    if (current.TimeOperat > time && current.Next.TimeOperat < time) // если новая дата больше первый даты и меньше второй даты
                    {
                        localOper = current.Next;
                        current.Next = new Operations(sum, time);
                        current.Next.Next = localOper;
                        return true;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
            } while (current != null);
            return false;

        }
        public bool DelOpereation(DateTime time)// Удаление операции
        {
            if (_operations.TimeOperat.Equals(time)) // если введенное время совпает с первым
            {
                _operations = _operations.Next;
                return true;
            }
            Operations prev = _operations;
            Operations current = _operations.Next;
            while (current.Next != null)
            {
                if (current.TimeOperat.Equals(time))// если введенное время совпает
                {
                    prev.Next = current.Next;
                    return true;
                }
                prev = current;
                current = current.Next;
            }
            return false;
        }
        public int Balance()// баланс на текущий момент
        {
            int a = 0;
            Operations current = _operations;// записываем в переменную первую операцию
            while (current != null)// проход по операциям с подсчетом суммы
            {
                a += current.Sum;
                current = current.Next;

            }
            return a;//возвращаем текущий баланс
        }
        public string Name { get => _name; set => _name = value; }

        public int ActualBalance => Balance();

        public Operations Operations { get => _operations; set => _operations = value; }

        public string Info()// вывод информации о клиенте
        {
            string oper = "";
            Operations operations = Operations;// записываем в переменную первую операцию
            while (operations != null)// проход по операциям с выводом информации
            {
                oper += operations.Sum + " " + operations.TimeOperat + "\n";
                operations = operations.Next;
            }
            return $"Имя:{_name} - баланс: {Balance()}\n" + oper;//возвращаем текущий баланс и все операции

        }
    }
}

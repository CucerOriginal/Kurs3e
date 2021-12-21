using System;
using Microsoft.Win32;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs3e
{
    class Bank
    {
        Clients[] _clients;
        int _count;
        Clients NullClient = new Clients("Not Found", 0, new DateTime());
        public Bank(int _Count)// конструктор
        {
            _count = 0;
            _clients = new Clients[_Count];
        }
        public bool AddClient(string lastName, int balance, DateTime dateTime) // добавление клиента 
        {
            Clients clients = new Clients(lastName, balance, dateTime); // создание заказа
            _clients[_count] = clients; // добавление заказа в конец
            _count++; // увеличение счетчика
            if (_count == _clients.Length) // если массив заполнен
            {
                Array.Resize(ref _clients, _clients.Length * 2); // увеличиваем его размер на 2 
                return true;
            }
            return false;
        }
        public bool DeleteClient() // удаление клиента
        {
            if (_count != 0) // если массив не пуст
            {
                _clients[0] = null; // удаление заказа из начала
                for (int i = 1; i < _clients.Length; i++) // сдвиг
                    _clients[i - 1] = _clients[i];
                _count--; // уменьшение счетчика
                return true;
            }
            else return false;
        }
        public string PrintAllInfo()// вывод информации о всех клиентах
        {
            string Info = "";
            for (int i = 0; i < _count; i++)// проход по массиву с выводом информации о всех клиентах 
            {
                Info = Info + _clients[i].Info();
            }
            return Info; // вовращаем информацию о всех клиентах 
        }
        public string PrintInfo(string name)// вывод информации по имени клиента
        {
            for (int i = 0; i < _count; i++)// проход по массиву клиентов
            {
                if (_clients[i].Name == name)// если имя совпало 
                {
                    return Clients[i].Info(); // вовращаем информацию о клиенте
                }
            }
            return "Клиента не найден";
        }
        public Clients Search(string name)// поиск клиента
        {
            for (int i = 0; i < _count; i++)// проход по массиву клиентов
            {
                if (_clients[i].Name == name)// если имя совпало 
                {
                    return Clients[i]; // вовращаем клиента из массива
                }
            }
            throw new Exception($"Client =>{name} not found");// исключение если клиент не найден 
        }

        public void Save(FileStream fs)
        {
            JsonSerializer.Serialize<Clients[]>(new Utf8JsonWriter(fs), _clients);
        }

        public async Task Load(FileStream fs)
        {
            Clients[] clients;
            clients = await JsonSerializer.DeserializeAsync<Clients[]>(fs);
            _count = 0;

            foreach (var i in clients)
            {
                if (i != null)
                {
                    //AddClient(i);
                }
                else
                {
                    break;
                }
            }

        }

        public Clients[] Clients { get => _clients; set => _clients = value; }
        public int Count { get => _count; set => _count = value; }
    }
}

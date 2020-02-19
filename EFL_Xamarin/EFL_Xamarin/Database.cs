using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFL_Xamarin
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);

            _database.CreateTableAsync<Student>().Wait();
        }

        public Task<List<Student>> GetStudentAsync()
        {
            return _database.Table<Student>().ToListAsync();
        }
        public Task<int> SaveStudentAsync(Student student)
        {
            return _database.InsertAsync(student);
        }
    }
}

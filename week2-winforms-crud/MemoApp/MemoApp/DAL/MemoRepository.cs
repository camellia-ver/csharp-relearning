using MemoApp.Models;
using Microsoft.Data.Sqlite;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MemoApp.DAL
{
    internal class MemoRepository
    {
        private string connectionString = "Data Source=memo.db";

        public MemoRepository()
        {
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                string sql = "CREATE TABLE IF NOT EXISTS Memo (" +
                "Id INTEGER PRIMARY KEY AUTOINCREMENT," +
                "Title TEXT NOT NULL," +
                "Contents TEXT NOT NULL," +
                "Date TEXT" +
                ")";

                using(var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();  
                }
            }
        }

        public async Task<List<Memo>> GetAllMemos()
        {
            var memos = new List<Memo>();

            using (var conn = new SqliteConnection(connectionString))
            {
                await conn.OpenAsync();
                string sql = "SELECT * FROM Memo";

                using (var cmd = new SqliteCommand(sql, conn)) 
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        int id = Convert.ToInt32(reader["Id"]);
                        string title = Convert.ToString(reader["Title"]);
                        string contents = Convert.ToString(reader["Contents"]);
                        DateTime date = Convert.ToDateTime(reader["Date"]);

                        memos.Add(new Memo(id,title, contents, date));
                    }
                }
            }

            return memos;
        }

        public async Task<Memo> GetMemoById(int id)
        {
            using (var conn = new SqliteConnection(connectionString))
            {
                await conn.OpenAsync();
                string sql = $"SELECT * FROM Memo WHERE Id = @id";

                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            id = Convert.ToInt32(reader["Id"]);
                            string title = Convert.ToString(reader["Title"]);
                            string contents = Convert.ToString(reader["Contents"]);
                            DateTime date = Convert.ToDateTime(reader["Date"]);

                            return new Memo(id, title, contents, date);
                        }
                        return null;
                    }
                }
            }
        }

        public async Task<bool> InsertMemo(Memo memo)
        {
            using (var conn = new SqliteConnection(connectionString))
            {
                await conn.OpenAsync();
                string sql = "INSERT INTO Memo(Title, Contents, Date) VALUES (@Title, @Contents, @Date)";
            
                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Title", memo.Title);
                    cmd.Parameters.AddWithValue("@Contents", memo.Contents);
                    cmd.Parameters.AddWithValue("@Date", memo.Date);

                    return await cmd.ExecuteNonQueryAsync() > 0;
                }
            }
        }

        public async Task<bool> UpdateMemo(Memo memo) 
        {
            using (var conn = new SqliteConnection(connectionString))
            {
                await conn.OpenAsync();
                string sql = "UPDATE Memo SET Title = @Title, Contents = @Contents WHERE Id = @Id";

                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Title", memo.Title);
                    cmd.Parameters.AddWithValue("@Contents", memo.Contents);
                    cmd.Parameters.AddWithValue("@Id", memo.Id);

                    return await cmd.ExecuteNonQueryAsync() > 0;
                }
            }
        }

        public async Task<bool> DeleteMemo(int id)
        {
            using (var conn = new SqliteConnection(connectionString))
            {
                await conn.OpenAsync();
                string sql = "DELETE FROM Memo WHERE Id = @Id";

                using(var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    return await cmd.ExecuteNonQueryAsync() > 0;
                }
            }
        }
    }
}

using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using WeChatRedPacket.Bean;
using Windows.Storage;

namespace DolbySoundBeta.Dao
{
    public static class MySqLite
    {

        private static SqliteConnection db = null;
        private static String dtataBaseName = "WechatRedPacket.sqlite";
        private static String tableName = "wx_red_packet";

        // 初始化数据库连接
        public static async Task InitializeDatabase()
        {
            if (await CheckDatabaseFile())
            {
                string path = ApplicationData.Current.LocalFolder.Path;
                Debug.Print($"--- > Sqlite 文件存储路径 {path}");
                path = Path.Combine(ApplicationData.Current.LocalFolder.Path, dtataBaseName);
                Debug.Print($"--- > Sqlite文件完整路径 {path}");
                db = new SqliteConnection($"Data Source={path}");
            }
            else
            {
                Debug.Print("--- > 数据库连接失败:文件不存在");
            }

        }

        // 复制数据库文件到本地
        public static async Task<bool> CheckDatabaseFile()
        {
            if (await ApplicationData.Current.LocalFolder.TryGetItemAsync(dtataBaseName) == null)
            {
                Debug.Print("--- > Sqlite文件不存在,从资源文件中复制过去");
                StorageFile file = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///Assets/db/"+ dtataBaseName));
                if (file != null)
                {
                    StorageFile storageFile = await file.CopyAsync(ApplicationData.Current.LocalFolder);
                    Debug.Print("--- > 复制完成");
                    return storageFile != null;
                    // 再次判断文件是否在App Data文件夹中了
                    // if (await ApplicationData.Current.LocalFolder.TryGetItemAsync("PubgDatabase.db") == null)
                    // {
                }
                // 不需要如果没此文件会报错 Debug.Print($"--- > 包中没有ms-appx:///Assets/db/{dtataBaseName}此文件");
                return false;
            }
            return true;
        }


        // ***** MouseDatas表方法 *****
        // 插入数据
        public static async void Insert(List<RedPacket> redPackets)
        {
            // 查询
            if (db == null)
            {
                await InitializeDatabase();
            }
            db.Open();  // 打开数据库
            SqliteCommand command = db.CreateCommand();
            // TODO:修改sql语句

            command.CommandText = $@"INSERT INTO {tableName} (sum, number, zero,one,two,three,four,five,six,seven,eight,nine) VALUES (@sum, @number, @zero,@one,@two,@three,@four,@five,@six,@seven,@eight,@nine)";

            for (int i = 0;i<redPackets.Count;i++) {
                RedPacket redPacket = redPackets[i];
                command.Parameters.AddWithValue("@sum", redPacket.sum);
                command.Parameters.AddWithValue("@number", redPacket.number);
                command.Parameters.AddWithValue("@zero", redPacket.zero);
                command.Parameters.AddWithValue("@one", redPacket.one);
                command.Parameters.AddWithValue("@two", redPacket.two);
                command.Parameters.AddWithValue("@three", redPacket.three);
                command.Parameters.AddWithValue("@four", redPacket.four);
                command.Parameters.AddWithValue("@five", redPacket.five);
                command.Parameters.AddWithValue("@six", redPacket.six);
                command.Parameters.AddWithValue("@seven", redPacket.seven);
                command.Parameters.AddWithValue("@eight", redPacket.eight);
                command.Parameters.AddWithValue("@nine", redPacket.nine);
                command.ExecuteReader();
                command.Parameters.Clear();
            }
            
            db.Close(); // 关闭数据库
        }
        public static async void Insert(RedPacket redPacket)
        {
            // 查询
            if (db == null)
            {
                await InitializeDatabase();
            }
            db.Open();  // 打开数据库
            SqliteCommand command = db.CreateCommand();                                                                                                                                                      
            command.CommandText = $@"INSERT INTO {tableName} (sum, number, zero,one,two,three,four,five,six,seven,eight,nine) VALUES ({redPacket.sum}, {redPacket.number}, {redPacket.zero},{redPacket.one},{redPacket.two},{redPacket.three},{redPacket.four},{redPacket.five},{redPacket.six},{redPacket.seven},{redPacket.eight},{redPacket.nine})";
            command.ExecuteReader();

            db.Close(); // 关闭数据库
        }

        // 通过枪械名查询此枪械下的所有压枪数据
        public static async Task<RedPacket> FindAllRedPacketDatasBySumNumber(int sum,int number)
        {
            // 查询
            if (db == null)
            {
                await InitializeDatabase();
            }
            db.Open();  // 打开数据库
            SqliteCommand command = db.CreateCommand();
            command.CommandText = $@"SELECT * FROM {tableName} WHERE sum = {sum} AND number = {number}";

            SqliteDataReader reader = command.ExecuteReader();
            RedPacket redPacket = new();
            while (reader.Read())
            {
                redPacket.sum += (long)reader["sum"];
                redPacket.number += (long)reader["number"];
                redPacket.zero += (long)reader["zero"];
                redPacket.one += (long)reader["one"];
                redPacket.two += (long)reader["two"];
                redPacket.three += (long)reader["three"];
                redPacket.four += (long)reader["four"];
                redPacket.five += (long)reader["five"];
                redPacket.six += (long)reader["six"];
                redPacket.seven += (long)reader["seven"];
                redPacket.eight += (long)reader["eight"];
                redPacket.nine += (long)reader["nine"];
            }
            db.Close(); // 关闭数据库
            return redPacket;

        }


    }
}

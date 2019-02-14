using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Kursovoi.Modules
{
    /// <summary>
    /// Класс для работы с ДБ (костыльный)
    /// </summary>
    class ComponentsInfo
    {
        
        private SQLiteConnection conn;
        /// <summary>
        /// конструктор
        /// </summary>
        public ComponentsInfo()
        {
            try
            {
                conn = new SQLiteConnection($"Data Source=Components.db; Version=3;");
                conn.Open();
            }
            catch (SQLiteException ex)
            {
                Logger.SaveLog($"[{DateTime.Now.ToString(new CultureInfo("en-US"))}] SQLiteError: ${ex.Message} ${ex.StackTrace} Startup");
            }
        }

        //~ComponentsInfo()
        //{
        //    conn.Close();
        //}

        /// <summary>
        /// Получить данные из таблицы ComponentsInfo
        /// </summary>
        public Dictionary<int, Dictionary<string, object>> Select()
        {
            try
            {
                string format = "SELECT * FROM ComponentsInfo";
                Dictionary<int, Dictionary<string, object>> str = new Dictionary<int, Dictionary<string, object>>();


                SQLiteCommand cmd = new SQLiteCommand(format, conn);
                SQLiteDataReader r = cmd.ExecuteReader();

                int k = 0;
                while (r.Read())
                {
                    str.Add(k, new Dictionary<string, object>()
                    {
                        ["comp_id"] = r["comp_id"],
                        ["comp_name"] = r["comp_name"],
                        ["comp_desc"] = r["comp_desc"],
                        ["comp_pic"] = r["comp_pic"],
                        ["comp_proporties"] = r["comp_proporties"]
                    });

                    k++;
                }
                return str;
            }
            catch (SQLiteException ex)
            {
                Logger.SaveLog($"[{DateTime.Now.ToString(new CultureInfo("en-US"))}] SQLiteError: ${ex.Message} ${ex.StackTrace} Startup");
                return null;
            }
           
        }

        /// <summary>
        /// Получить данные из таблицы ProgrammingLanguage (string tbl может быть любой строкой)
        /// </summary>
        public Dictionary<int, Dictionary<string, object>> Select(string tbl)
        {
            try
            {
                string format = "SELECT * FROM ProgrammingLanguage";
                Dictionary<int, Dictionary<string, object>> str = new Dictionary<int, Dictionary<string, object>>();


                SQLiteCommand cmd = new SQLiteCommand(format, conn);
                SQLiteDataReader r = cmd.ExecuteReader();

                int k = 0;
                while (r.Read())
                {
                    str.Add(k, new Dictionary<string, object>()
                    {
                        ["lang_id"] = r["lang_id"],
                        ["lang_name"] = r["lang_name"],
                        ["lang_desc"] = r["lang_desc"],
                        ["lang_listing"] = r["lang_listing"]
                    });

                    k++;
                }


                return str;
            }
            catch (SQLiteException ex)
            {
                Logger.SaveLog($"[{DateTime.Now.ToString(new CultureInfo("en-US"))}] SQLiteError: ${ex.Message} ${ex.StackTrace} Startup");
                return null;
            }
        }

        /// <summary>
        /// Получит ьопределённые данные из таблицы ComponentsInfo
        /// </summary>
        public Dictionary<int, Dictionary<string, object>> SelectWhere(string from, string to)
        {
            try
            {
                string format = $"SELECT * FROM ComponentsInfo WHERE {from} = '{to}'";
                Dictionary<int, Dictionary<string, object>> str = new Dictionary<int, Dictionary<string, object>>();


                SQLiteCommand cmd = new SQLiteCommand(format, conn);
                SQLiteDataReader r = cmd.ExecuteReader();

                int k = 0;
                while (r.Read())
                {
                    str.Add(k, new Dictionary<string, object>()
                    {
                        ["comp_id"] = r["comp_id"],
                        ["comp_name"] = r["comp_name"],
                        ["comp_desc"] = r["comp_desc"],
                        ["comp_pic"] = r["comp_pic"],
                        ["comp_proporties"] = r["comp_proporties"]
                    });

                    k++;
                }

                return str;
            }
            catch (SQLiteException ex)
            {
                Logger.SaveLog($"[{DateTime.Now.ToString(new CultureInfo("en-US"))}] SQLiteError: ${ex.Message} ${ex.StackTrace} Startup");
                return null;
            }
        }

        /// <summary>
        /// Получить определённые данные из таблицы ProgrammingLanguage (string tbl может быть любой строкой)
        /// </summary>
        public Dictionary<int, Dictionary<string, object>> SelectWhere(string from, string to, string table)
        {
            try
            {
                string format = $"SELECT * FROM ProgrammingLanguage WHERE {from} = '{to}'";
                Dictionary<int, Dictionary<string, object>> str = new Dictionary<int, Dictionary<string, object>>();


                SQLiteCommand cmd = new SQLiteCommand(format, conn);
                SQLiteDataReader r = cmd.ExecuteReader();

                int k = 0;
                while (r.Read())
                {
                    str.Add(k, new Dictionary<string, object>()
                    {
                        ["lang_id"] = r["lang_id"],
                        ["lang_name"] = r["lang_name"],
                        ["lang_desc"] = r["lang_desc"],
                        ["lang_listing"] = r["lang_listing"]
                    });

                    k++;
                }

                return str;
            }
            catch (SQLiteException ex)
            {
                Logger.SaveLog($"[{DateTime.Now.ToString(new CultureInfo("en-US"))}] SQLiteError: ${ex.Message} ${ex.StackTrace} Startup");
                return null;
            }
        }

        //public string[] Select(string[] param)
        //{
        //    string qs = "";
        //    for(int i = 0; i < param.Length-2; i++)
        //    {
        //        qs += string.Format("{0},", param[i]);
        //    }
        //    qs += param[param.Length - 1];

        //    string format = string.Format(SELECT, qs, "ComponentsInfo");
        //}


        /// <summary>
        /// Закрывает подключение к БД
        /// </summary>
        public void CloseConnection()
        {
            try
            {
                conn.Close();
            }
            catch (SQLiteException ex)
            {
                Logger.SaveLog($"[{DateTime.Now.ToString(new CultureInfo("en-US"))}] SQLiteError: ${ex.Message} ${ex.StackTrace} Startup");
            }
        }

    }
}
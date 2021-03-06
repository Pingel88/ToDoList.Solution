using System;
using MySql.Data.MySqlClient;
using ToDoList;

namespace ToDoList.Models
{
  public class DB
  {
    public static MySqlConnection Connection()
    {
      MySqlConnect conn = new MySqlConnection(DBConfiguration.ConnectionString);
      return conn;
    }
  }
}
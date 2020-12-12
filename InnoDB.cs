using Org.BouncyCastle.Crypto.Tls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Innovative
{
    class InnoDB
    {

        private Validation val = new Validation();
        private MySqlConnection connection = new MySqlConnection("server=remotemysql.com;port=3306;username=7s0UNF3QJT;password=L6WdCSWuyd;database=7s0UNF3QJT");
        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }
        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
        public bool getAuthentication(String login, String pass)
        {
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                while (connection.State != ConnectionState.Open)
                {
                    try
                    {
                        connection.Open();
                    }
                    catch (MySqlException ex)
                    {
                        new MBform(ex.Message);
                        System.Threading.Thread.Sleep(1000);
                    }
                }
                MySqlCommand com = new MySqlCommand("Select * from User where (login='" + login + "'or email='" + login + "') and password='" + pass + "'", this.getConnection());
                if (com.ExecuteScalar() == null)
                {
                    new MBform("Логин/пароль неверный");
                    return false;
                }
                else
                {
                    MySqlCommand com2 = new MySqlCommand("SELECT crypt,delfrompc,delfromzip from users where login='" + login + "'", connection);
                    MySqlDataAdapter adapt = new MySqlDataAdapter(com2);
                    DataSet ds = new DataSet();
                    connection.Close();
                    return true;
                }
            }
            new MBform("Произошла ошибка подключения.");
            return false;
        }
        public void registration(string login, string password, string email, string phone, string name)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO 7s0UNF3QJT.`User` ( idrole, email, login, password, name, phone) VALUES (@idrole, @email, @login, @password, @name, @phone);", this.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@idrole", MySqlDbType.Int32).Value = 1;
            this.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                new MBform("Отлично!", "Вы зарегистрированы.");
            }
            else
            {
                new MBform("Ошибка регистрации, повторите попытку позже.");
            }
            this.CloseConnection();
        }

        public void recovery(string email)
        {
            if (val.IsValidEmail(email)==false && val.IsValidLogin(email) == false)
            {
                new MBform("Введите свой логин или e-mail.");
            }
            else
            {
                this.openConnection();
                MySqlCommand compass = new MySqlCommand("Select password from User where login='" + email + "' or email='" + email + "'", this.getConnection());
                MySqlCommand commail = new MySqlCommand("Select email from User where login='" + email + "' or email='" + email + "'", this.getConnection());
                DataTable table = new DataTable();
                if(compass.ExecuteNonQuery()==0&& commail.ExecuteNonQuery() == 0)
                {
                    new MBform("Такого логина или e-mail не существует.");
                }
               else
               {             
                    string password = compass.ExecuteScalar().ToString();
                    string mail = commail.ExecuteScalar().ToString();
                    new MBform("Проверьте почту","На вашу почту отправлен пароль.");
                    InnoMail.SendMail("smtp.mail.ru", "innoserver@bk.ru", "A*aY2utYyaI2", mail, "Восстановление пароля на сервере инновационного облачного сервиса", "Доброго времени суток! Надеемся, что Вы сегодня хорошо покушали. предлагаем Вам загрузить фото Вашего блюда на наш облачный сервис, чтобы вспоминать каким оно было вкусным!", "Ваш пароль: " + password);     
                }
                this.CloseConnection();
                
            }
        }
    }
}
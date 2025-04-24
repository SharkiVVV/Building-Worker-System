using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

public class Program
{
   public class W_A_C
    {

        int id;
        public int Security()
        {
            Console.WriteLine("Ведите пароль");

            string password = "qwer";
            string upassword = Console.ReadLine();


            if(upassword != password)
    {
                Console.WriteLine("пароль no");
               

                return Security();
            }
            else
            {
                Console.WriteLine("All good");
            }
            return 0;





        }
        public void Base()
        {
            string[] args;
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            // Создание подключения
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Открываем подключение

                    Console.WriteLine("Подключение открыто");
                    Console.WriteLine("");
                    Console.WriteLine("Users");
                    string sqlExpression = "SELECT * FROM Users";

                    conn.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, conn);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows) // если есть данные
                    {
                        // выводим названия столбцов
                        Console.WriteLine("{0}\t{1}\t{2}", reader.GetName(0), reader.GetName(1), reader.GetName(2));

                        while (reader.Read()) // построчно считываем данные
                        {
                            object id = reader.GetValue(0);
                            object Name = reader.GetValue(1);
                            object Surname = reader.GetValue(2);

                            Console.WriteLine("{0} \t{1} \t{2}", id, Name, Surname);
                        }
                    }

                }

                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);

                }
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Открываем подключение

                    Console.WriteLine("Подключение открыто");
                    Console.WriteLine("");
                    Console.WriteLine("Building");
                    string sqlExpression = "SELECT * FROM Building";

                    conn.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, conn);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows) // если есть данные
                    {
                        // выводим названия столбцов
                        Console.WriteLine("{0}\t{1}", reader.GetName(0), reader.GetName(1));

                        while (reader.Read()) // построчно считываем данные
                        {
                            object id = reader.GetValue(0);
                            object title = reader.GetValue(1);


                            Console.WriteLine("{0} \t{1}", id, title);
                        }
                    }

                }

                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);

                }
                //finally
                //{
                //    // если подключение открыто
                //    if (connection.State == ConnectionState.Open)
                //    {
                //        // закрываем подключение

                //        Console.WriteLine("Подключение закрыто...");


            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Открываем подключение

                    Console.WriteLine("Подключение открыто");
                    Console.WriteLine("");
                    Console.WriteLine("Decision");
                    string sqlExpression = "SELECT * FROM Decision";

                    conn.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, conn);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows) // если есть данные
                    {
                        // выводим названия столбцов
                        Console.WriteLine("{0}\t{1}\t{2} \t{3}", reader.GetName(0), reader.GetName(1), reader.GetName(2), reader.GetName(3));

                        while (reader.Read()) // построчно считываем данные
                        {
                            object id = reader.GetValue(0);
                            object building_id = reader.GetValue(1);
                            object decision_date = reader.GetValue(2);
                            object decision_text = reader.GetValue(3);

                            Console.WriteLine("{0} \t{1} \t{2} \t{3}", id, building_id, decision_date, decision_text);
                        }
                    }

                }

                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);

                }
            }

        }



        public void Choose_worker()
        {

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            Console.WriteLine("Ведите id работника ");
            Int32.TryParse(Console.ReadLine(), out id);







        }



        public void Choose_Bild()
        {

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\VS_Projects\\Hackaton\\Hackaton\\Database1.mdf;Integrated Security=True";
            //Console.WriteLine("Ведите има работника ");
            //string worker_name = Console.ReadLine();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                string sqlExpression = " SELECT Building.title, Conclusion.conclusion_text From Building,Conclusion, Connection_Building  WHERE Building.id = Connection_Building.building_id and Conclusion.id = Connection_Building.decision_id";


                conn.Open();
                SqlCommand command = new SqlCommand(sqlExpression, conn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    // выводим названия столбцов
                    Console.WriteLine("{0}\t{1}", reader.GetName(0), reader.GetName(1));

                    while (reader.Read()) // построчно считываем данные
                    {

                        object title = reader.GetValue(0);
                        object conclusion_text = reader.GetValue(1);

                        //object users_id = reader.GetValue(2);
                        //object building_id = reader.GetValue(3);
                        //object decision_date = reader.GetValue(4);

                        Console.WriteLine("");
                        Console.Write("");

                        Console.WriteLine("++++++++++==========================");
                        Console.WriteLine("{0} \t{1}", title, conclusion_text);
                        Console.WriteLine("++++++++++==========================");
                    }
                }
            }



        }
        public void Print_Card()
        {
            
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
          
            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sqlExpression = "Select from  Role, UsersRole Where UsersRole.roleid= UsersRole.usersid";
               







                conn.Open();
                SqlCommand command = new SqlCommand(sqlExpression, conn);
                command.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    object id = reader.GetValue(0);
                    object Name = reader.GetValue(1);
                    object Surname = reader.GetValue(2);
                    //object role = reader.GetValue(3);






                    Console.WriteLine("_______________________________________________________");
                    Console.WriteLine("id{0} ",id);
                    Console.WriteLine("User_Name\t{0} {1}",Name , Surname);
                    Console.WriteLine("status{0}" );
                    Console.WriteLine("______________________________________________________-");
                }
            }
            
        }



        public int Cin_Card()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sqlExpression = "INSERT INTO Users (Name, Surname) VALUES (@NewName, @NewSurname) ";

                SqlCommand command = new SqlCommand(sqlExpression, conn);
 
                Console.WriteLine("Bedite Name");
               string NewName = Console.ReadLine();
                Console.WriteLine("Bedite Sername");
               string NewSurname = Console.ReadLine();
                command.Parameters.AddWithValue("@NewName", NewName);
                command.Parameters.AddWithValue("@NewSurname", NewSurname);
                string chooserole = Console.ReadLine();

                Console.WriteLine("Вод карточки ");
                
                using ( command = new SqlCommand(sqlExpression, conn))
                {
                    command.Parameters.AddWithValue("@NewName", NewName);
                    command.Parameters.AddWithValue("@NewSurname", NewSurname);
                    int res = command.ExecuteNonQuery();
                    if (res > 0)
                    {
                        Console.WriteLine("NOOO");
                    }
                    else
                    {
                        Console.WriteLine("OK");
                    }
                }
                Console.WriteLine("Вод карточки успешен ");
               

                
            }
            return 0;
            

        }

        public void Delete_Card()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                Int32.TryParse(Console.ReadLine(), out id);
                string sqlExpression = "DELETE FROM Users WHERE id = @id";
                SqlCommand command = new SqlCommand(sqlExpression, conn);

                command.Parameters.AddWithValue("@" +
                    "id",id);
                SqlDataReader reader = command.ExecuteReader();
                Console.WriteLine("Вод карточки ");
                Console.WriteLine("Вод карточки успешен ");



            }

        }

        public void Change_Card()
        {


            
        }

        static void Main()
        {
            W_A_C w = new W_A_C();
            Console.WriteLine("Workers and Customers ");
            w.Security();
            w.Base();
            w.Choose_worker();
            Console.Write(" ");
            w.Choose_Bild();
            w.Print_Card();
            w.Cin_Card();
            w.Base();
            w.Delete_Card();
            w.Change_Card();
            

        }
    }



}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class AUD
    {
        public static SqlConnection sql = new SqlConnection("Data Source = LAPTOP-FACC1SJ2\\MYSQLLOL; Initial Catalog =Pr_Hotel;" +
"Persist Security Info = true; User ID = sa; Password = \"9815\""); //строка подключения

        public static string // вывод данных из БД
            qrHotel = "SELECT id_hotel, name_hotel as 'Название отеля', mesto_hotel as 'Место отеля', stars_hotel as 'Звезды отеля' FROM Hotel",
            qrRoom = "SELECT id_room, Num_room as 'Номер комнаты',price_room as 'Цена', hotel_id as 'Код отеля' FROM Room",
            qrUborka = "SELECT id_uborka, time_uborka as 'Время уборки',sotr_id as 'Код сотрудника', room_id as 'Код комнаты' FROM Uborka",
            qrSotr = "SELECT id_sotr, Name_sotr as 'Имя сотрудника',Surname_sotr as 'Фамилия сотрудника', Otch_sotr as 'Отчество сотрудника' ,Tel_sotr as 'Телефон сотрудника'" +
            "Seria_pasp_sotr as 'Серия паспотра', Num_pasp_sotr as 'Номер паспорта', prof_id as 'Код профессии' FROM Sotr",
            qrPost = "SELECT id_post, Name_post as 'Имя постояльца',Surname_post as 'Фамилия постояльца', Otch_post as 'Отчество постояльца' ,Date_rodj as 'Дата рождения'" +
            "Seria_pasport as 'Серия паспорта', Num_pasport as 'Номер паспорта',Grajadanstvo as 'Гражданство', FROM Post",
            qrSoisk = "SELECT id_Soisk, Name_Soisk as 'Имя соискателя',Surname_Soisk as 'Фамилия соискателя', Otch_Soisk as 'Отчество соискателя' ,Opt_rab as 'Опыт работы'" +
            "Tel_soisk as 'Телефон', FROM Soisk",
            qrChek = "SELECT id_chek, Num_chek as 'Номер чека',sotr_id as 'Код сотрудника', FROM Chek",
            qrProfession = "SELECT id_prof, Name_prof as 'Название профессии',zarplata as 'Зарплата', FROM Profession",
            qrBron = "SELECT id_bron, data_priezda as 'Дата приезда',data_otezda as 'Дата отъезда',room_id as 'Код комнаты',post_id as 'Код постояльца',FROM Bron",
            qrRole = "Select id_role, Name_role as 'Название роли',Hotel as 'Отель', Room as 'Комната',  Bron as 'Бронирование',  Sotr as 'Сотрудник',Soisk as 'Соискатель'" +
            "Post as 'Постоялец', Chek as 'Чек',Profession as 'Профессия', Uborka as 'Уборка', from Role";



        public static SqlCommand cmd = new SqlCommand(string.Empty, sql);

        private static void spConfiguration(string spName)
        {
            cmd.CommandText = spName;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        }

        //Вызов процедуры Добавления в таблицу "Sotr"
        public static void Sotr_Insert(string Name_sotr, string Surname_sotr, string Otch_sotr, string Seria_pasp_sotr, string Num_pasp_sotr,string Tel_sotr, Int32 hotel_id, Int32 prof_id)
        {
            spConfiguration("Sotr_Insert");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Name_sotr", Name_sotr);
                cmd.Parameters.AddWithValue("@Surname_sotr", Surname_sotr);
                cmd.Parameters.AddWithValue("@Otch_sotr", Otch_sotr);
                cmd.Parameters.AddWithValue("@Tel_sotr", Tel_sotr);
                cmd.Parameters.AddWithValue("@Seria_pasp_sotr", Seria_pasp_sotr);
                cmd.Parameters.AddWithValue("@Num_pasp_sotr", Num_pasp_sotr);
                cmd.Parameters.AddWithValue("@hotel_id", hotel_id);
                cmd.Parameters.AddWithValue("@prof_id", prof_id);
                AUD.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                AUD.sql.Close();
            }
        }

        //Вызов процедуры обновления данных в таблице "Sotr"
        public static void Sotr_Update(Int32 id_sotr,string Name_sotr, string Surname_sotr, string Otch_sotr, string Seria_pasp_sotr, string Num_pasp_sotr, string Tel_sotr, Int32 hotel_id, Int32 prof_id)
        {
            spConfiguration("Upd_Sotr");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_sotr", id_sotr);
                cmd.Parameters.AddWithValue("@Name_sotr", Name_sotr);
                cmd.Parameters.AddWithValue("@Surname_sotr", Surname_sotr);
                cmd.Parameters.AddWithValue("@Otch_sotr", Otch_sotr);
                cmd.Parameters.AddWithValue("@Seria_pasp_sotr", Seria_pasp_sotr);
                cmd.Parameters.AddWithValue("@Num_pasp_sotr", Num_pasp_sotr);
                cmd.Parameters.AddWithValue("@Tel_sotr", Tel_sotr);
                cmd.Parameters.AddWithValue("@hotel_id", hotel_id);
                cmd.Parameters.AddWithValue("@prof_id", prof_id);
                AUD.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                AUD.sql.Close();
            }
        }

        //Вызов процедуры удаления данных в таблице "Sotr"
        public static void Sotr_Delete(Int32 ID)
        {
            spConfiguration("Del_Sotr");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_sotr", ID);
                AUD.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                AUD.sql.Close();
            }
        }
 
        //__________________________________________________________________________________________________________
        //__________________________________________________________________________________________________________
        //Вызов процедуры Добавления в таблицу "Chek"
        public static void Check_Insert(string Num_Chek, Int32 Sotr_Id)
        {
            spConfiguration("Chek_Insert");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Num_Chek", Num_Chek);
                cmd.Parameters.AddWithValue("@Sotr_Id", Sotr_Id);
                AUD.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                AUD.sql.Close();
            }
        }

        //Вызов процедуры обновления данных в таблице "Chek"
        public static void Check_Update(Int32 id_chek, string Num_chek, Int32 sotr_id)
        {
            spConfiguration("Upd_Chek");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_chek", id_chek);
                cmd.Parameters.AddWithValue("@Num_chek", Num_chek);
                cmd.Parameters.AddWithValue("@sotr_id", sotr_id);
                AUD.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                AUD.sql.Close();
            }
        }

        //Вызов процедуры удаления данных в таблице "Check"
        public static void Check_Delete(Int32 ID)
        {
            spConfiguration("Del_Chek");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_Chek", ID);
                AUD.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                AUD.sql.Close();
            }
        }
        //__________________________________________________________________________________________________________
        //__________________________________________________________________________________________________________
        //Вызов процедуры Добавления в таблицу "post"
        public static void post_Insert(string Name_post, string Surname_post, string Otch_post, string Date_rodj,string Seria_pasport, string Num_pasport,string Grajadanstvo)
        {
            spConfiguration("post_Insert");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Name_post", Name_post);
                cmd.Parameters.AddWithValue("@Surname_post", Surname_post);
                cmd.Parameters.AddWithValue("@Otch_post", Otch_post);
                cmd.Parameters.AddWithValue("@Date_rodj", Date_rodj);
                cmd.Parameters.AddWithValue("@Seria_pasport", Seria_pasport);
                cmd.Parameters.AddWithValue("@Num_pasport", Num_pasport);
                cmd.Parameters.AddWithValue("@Grajadanstvo", Grajadanstvo);
                AUD.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                AUD.sql.Close();
            }
        }

        //Вызов процедуры обновления данных в таблице "post"
        public static void post_Update(Int32 id_post, string Name_post, string Surname_post, string Otch_post, string Date_rodj,
                string Seria_pasport, string Num_pasport, string Grajadanstvo)
        {
            spConfiguration("Upd_post");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_post", id_post);
                cmd.Parameters.AddWithValue("@Name_post", Name_post);
                cmd.Parameters.AddWithValue("@Surname_post", Surname_post);
                cmd.Parameters.AddWithValue("@Otch_post", Otch_post);
                cmd.Parameters.AddWithValue("@Num_pasport", Num_pasport);
                cmd.Parameters.AddWithValue("@Seria_pasport", Seria_pasport);
                cmd.Parameters.AddWithValue("@Date_rodj", Date_rodj);
                cmd.Parameters.AddWithValue("@Grajadanstvo", Grajadanstvo);
                AUD.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                AUD.sql.Close();
            }
        }

        //Вызов процедуры удаления данных в таблице "post"
        public static void post_Delete(Int32 ID)
        {
            spConfiguration("Del_post");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_post", ID);
                AUD.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                AUD.sql.Close();
            }
        }
        //__________________________________________________________________________________________________________
        //__________________________________________________________________________________________________________
        //Вызов процедуры Добавления в таблицу "Soisk"
        public static void Soisk_Insert(string Name_soisk, string Surname_soisk, string Otch_soisk, string Opt_rab,string Tel_soisk,
                int prof_id)
        {
            spConfiguration("soisk_Insert");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Name_soisk", Name_soisk);
                cmd.Parameters.AddWithValue("@Surname_soisk", Surname_soisk);
                cmd.Parameters.AddWithValue("@Otch_soisk", Otch_soisk);
                cmd.Parameters.AddWithValue("@Opt_rab", Opt_rab);
                cmd.Parameters.AddWithValue("@Tel_soisk", Tel_soisk);
                cmd.Parameters.AddWithValue("@prof_id", prof_id);
                AUD.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                AUD.sql.Close();
            }
        }

        //Вызов процедуры обновления данных в таблице "soisk"
        public static void Delivery_Update(Int32 id_soisk, string Name_soisk, string Surname_soisk, string Otch_soisk, string Opt_rab, string Tel_soisk,
                int prof_id)
        {
            spConfiguration("Upd_soisk");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_soisk", id_soisk);
                cmd.Parameters.AddWithValue("@Name_soisk", Name_soisk);
                cmd.Parameters.AddWithValue("@Surname_soisk", Surname_soisk);
                cmd.Parameters.AddWithValue("@Otch_soisk", Otch_soisk);
                cmd.Parameters.AddWithValue("@Tel_soisk", Tel_soisk);
                cmd.Parameters.AddWithValue("@Opt_rab", Opt_rab);
                cmd.Parameters.AddWithValue("@prof_id", prof_id);
                AUD.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                AUD.sql.Close();
            }
        }

        //Вызов процедуры удаления данных в таблице "soisk"
        public static void soisk_Delete(Int32 ID)
        {
            spConfiguration("Del_soisk");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_soisk", ID);
                AUD.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                AUD.sql.Close();
            }
        }
        //__________________________________________________________________________________________________________
        //__________________________________________________________________________________________________________
        //Вызов процедуры Добавления в таблицу "Room"
        public static void room_Insert(string Num_room, decimal price_room, Int32 hotel_id)
        {
            spConfiguration("room_Insert");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Num_room", Num_room);
                cmd.Parameters.AddWithValue("@price_room", price_room);
                cmd.Parameters.AddWithValue("@hotel_id", hotel_id);
                AUD.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                AUD.sql.Close();
            }
        }

        //Вызов процедуры обновления данных в таблице "room"
        public static void Employee_Update(Int32 id_room, string Num_room, decimal price_room, Int32 hotel_id)
        {
            spConfiguration("Upd_room");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_room", id_room);
                cmd.Parameters.AddWithValue("@Num_room", Num_room);
                cmd.Parameters.AddWithValue("@price_room", price_room);
                cmd.Parameters.AddWithValue("@hotel_id", hotel_id);
                AUD.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                AUD.sql.Close();
            }
        }

        //Вызов процедуры удаления данных в таблице "room"
        public static void room_Delete(Int32 ID)
        {
            spConfiguration("Del_room");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_room", ID);
                AUD.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                AUD.sql.Close();
            }
        }
        //__________________________________________________________________________________________________________
        //__________________________________________________________________________________________________________
        //Вызов процедуры Добавления в таблицу ""
        public static void Uborka_Insert(string time_uborka,Int32 sotr_Id,Int32 room_id)
        {
            spConfiguration("Uborka_Insert");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@time_uborka", time_uborka);
                cmd.Parameters.AddWithValue("@sotr_Id", sotr_Id);
                cmd.Parameters.AddWithValue("@room_id", room_id);
                AUD.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                AUD.sql.Close();
            }
        }

        //Вызов процедуры обновления данных в таблице "Uborka"
        public static void Uborka_Update(Int32 id_uborka, string time_uborka, Int32 sotr_id, Int32 room_id)
        {
            spConfiguration("Upd_Employee_Position");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_uborka", id_uborka);
                cmd.Parameters.AddWithValue("@time_uborka", time_uborka);
                cmd.Parameters.AddWithValue("@sotr_id", sotr_id);
                cmd.Parameters.AddWithValue("@room_id", room_id);
                AUD.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                AUD.sql.Close();
            }
        }

        //Вызов процедуры удаления данных в таблице "Employee_Position"
        public static void Uborka_Delete(Int32 ID)
        {
            spConfiguration("Del_Uborka");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_Uborka", ID);
                AUD.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                AUD.sql.Close();
            }
        }
        //__________________________________________________________________________________________________________
        //__________________________________________________________________________________________________________
        //Вызов процедуры Добавления в таблицу "Bron"
        public static void Bron_Insert(string date_priezda, string date_otezda,Int32 room_id, Int32 post_id)
        {
            spConfiguration("Bron_Insert");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@date_priezda", date_priezda);
                cmd.Parameters.AddWithValue("@date_otezda", date_otezda);
                cmd.Parameters.AddWithValue("@room_id", room_id);
                cmd.Parameters.AddWithValue("@post_id", post_id);
                AUD.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                AUD.sql.Close();
            }
        }

        //Вызов процедуры обновления данных в таблице "Bron_Work"
        public static void Bron_Update(Int32 id_bron, string date_priezda, string date_otezda, Int32 room_id, Int32 post_id)
        {
            spConfiguration("Upd_Bron");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_bron", id_bron);
                cmd.Parameters.AddWithValue("@date_priezda", date_priezda);
                cmd.Parameters.AddWithValue("@date_otezda", date_otezda);
                cmd.Parameters.AddWithValue("@room_id", room_id);
                cmd.Parameters.AddWithValue("@post_id", post_id);
                AUD.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                AUD.sql.Close();
            }
        }

        //Вызов процедуры удаления данных в таблице "Bron_Work"
        public static void Bron_Delete(Int32 ID)
        {
            spConfiguration("Bron_Work");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_bron", ID);
                AUD.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                AUD.sql.Close();
            }
        }
        //__________________________________________________________________________________________________________
        //__________________________________________________________________________________________________________
        //Вызов процедуры Добавления в таблицу "Hotel"
        public static void Hotel_Insert(string Name_hotel, string mesto_hotel,string stars_hotel)
        {
            spConfiguration("Hotel_Insert");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Name_hotel", Name_hotel);
                cmd.Parameters.AddWithValue("@mesto_hotel", mesto_hotel);
                cmd.Parameters.AddWithValue("@stars_hotel", stars_hotel);
                AUD.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                AUD.sql.Close();
            }
        }

        //Вызов процедуры обновления данных в таблице "Employee_Type"
        public static void Employee_Type_Update(Int32 id_hotel, string Name_hotel, string mesto_hotel, string stars_hotel)
        {
            spConfiguration("Upd_Hotel");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_hotel", id_hotel);
                cmd.Parameters.AddWithValue("@Name_hotel", Name_hotel);
                cmd.Parameters.AddWithValue("@mesto_hotel",mesto_hotel);
                cmd.Parameters.AddWithValue("@stars_hotel", stars_hotel);
                AUD.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                AUD.sql.Close();
            }
        }

        //Вызов процедуры удаления данных в таблице "Hotel"
        public static void Hotel_Delete(Int32 ID)
        {
            spConfiguration("Del_Hotel");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_hotel", ID);
                AUD.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                AUD.sql.Close();
            }
        }
        //__________________________________________________________________________________________________________
        //__________________________________________________________________________________________________________
        //Вызов процедуры Добавления в таблицу "Profession"
        public static void Profession_Insert(string Name_prof, decimal zarplata)
        {
            spConfiguration("Profession_Insert");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Name_prof", Name_prof);
                cmd.Parameters.AddWithValue("@zarplata", zarplata);
                AUD.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                AUD.sql.Close();
            }
        }

        //Вызов процедуры обновления данных в таблице "Profession"
        public static void Profession_Update(Int32 id_prof, string Name_prof, decimal zarplata)
        {
            spConfiguration("Upd_Hookah");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_prof", id_prof);
                cmd.Parameters.AddWithValue("@Name_prof", Name_prof);
                cmd.Parameters.AddWithValue("@zarplata", zarplata);
                AUD.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                AUD.sql.Close();
            }
        }

        //Вызов процедуры удаления данных в таблице "Profession"
        public static void Profession_Delete(Int32 ID)
        {
            spConfiguration("Del_Profession");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_prof", ID);
                AUD.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                AUD.sql.Close();
            }
        }
       
        //__________________________________________________________________________________________________________
        //__________________________________________________________________________________________________________
        //Вызов процедуры Добавления в таблицу "Role"
        public static void Role_Insert(string Name_role, bool Hotel, bool Room, bool Bron, bool Sotr
            , bool Soisk, bool Post, bool Chek, bool Profession, bool Uborka)
        {
            spConfiguration("Role_Insert");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Name_role", Name_role);
                cmd.Parameters.AddWithValue("@Hotel", Hotel);
                cmd.Parameters.AddWithValue("@Room", Room);
                cmd.Parameters.AddWithValue("@Bron", Bron);
                cmd.Parameters.AddWithValue("@Sotr", Sotr);
                cmd.Parameters.AddWithValue("@Soisk", Soisk);
                cmd.Parameters.AddWithValue("@Profession", Profession);
                cmd.Parameters.AddWithValue("@Uborka", Uborka);
                cmd.Parameters.AddWithValue("@Post", Post);
                cmd.Parameters.AddWithValue("@Chek", Chek);
                AUD.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                AUD.sql.Close();
            }
        }

        //Вызов процедуры обновления данных в таблице "Role"
        public static void Role_Update(Int32 id_role, string Name_role, bool Hotel, bool Room, bool Bron, bool Sotr
            , bool Soisk, bool Post, bool Chek, bool Profession, bool Uborka)
        {
            spConfiguration("Upd_Role");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_role", id_role);
                cmd.Parameters.AddWithValue("@Name_role", Name_role);
                cmd.Parameters.AddWithValue("@Hotel", Hotel);
                cmd.Parameters.AddWithValue("@Room", Room);
                cmd.Parameters.AddWithValue("@Bron", Bron);
                cmd.Parameters.AddWithValue("@Sotr", Sotr);
                cmd.Parameters.AddWithValue("@Soisk", Soisk);
                cmd.Parameters.AddWithValue("@Chek", Chek);
                cmd.Parameters.AddWithValue("@Profession", Profession);
                cmd.Parameters.AddWithValue("@Uborka", Uborka);
                cmd.Parameters.AddWithValue("@Post", Post);
                AUD.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                AUD.sql.Close();
            }
        }

        //Вызов процедуры удаления данных в таблице "Role"
        public static void Role_Delete(Int32 ID)
        {
            spConfiguration("Del_Role");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_role", ID);
                AUD.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                AUD.sql.Close();
            }
        }
       
        //__________________________________________________________________________________________________________
        //__________________________________________________________________________________________________________
        //Вызов процедуры Добавления в таблицу "Avtoriz"
        public static void Avtoriz_Insert(string Name_user, string Pass_user, Int32 role_id)
        {
            spConfiguration("Avtoriz_Insert");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Name_user", Name_user);
                cmd.Parameters.AddWithValue("@Pass_user", Pass_user);
                cmd.Parameters.AddWithValue("@role_id", role_id);
                AUD.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                AUD.sql.Close();
            }
        }

        //Вызов процедуры обновления данных в таблице "Avtoriz"
        public static void Avtoriz_Update(Int32 id_avtoriz, string Name_user, string Pass_user, Int32 role_id)
        {
            spConfiguration("Avtoriz_Update");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_avtoriz", id_avtoriz);
                cmd.Parameters.AddWithValue("@Name_user", Name_user);
                cmd.Parameters.AddWithValue("@Pass_user", Pass_user);
                cmd.Parameters.AddWithValue("@role_id", role_id);
                AUD.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                AUD.sql.Close();
            }
        }

        //Вызов процедуры удаления данных в таблице "Avtoriz"
        public static void Avtoriz_Delete(Int32 ID)
        {
            spConfiguration("Del_Avtoriz");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_avtoriz", ID);
                AUD.sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                AUD.sql.Close();
            }
        }
    }
}

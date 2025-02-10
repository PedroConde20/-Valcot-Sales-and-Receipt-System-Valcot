using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.Model;
using DAO.interfaces;
using System.Data;
using System.Data.SqlClient;


namespace DAO.Implementation
{
    public class WineImpl : IWine
    {
        public int Delete(Wine t)
        {
            int res = 0;
            System.Diagnostics.Debug.WriteLine(string.Format("{0} - User: {1} Inicializando el Metodo Delete de la Tabla WineImpl", DateTime.Now, Session.SessionID));
            string query = @"UPDATE WineList SET image=0, status=0,lastUpdate= CURRENT_TIMESTAMP
                            WHERE wineID =@wineID";
            try
            {
                SqlCommand command = DataBase.CreateBasicCommand(query);
                command.Parameters.AddWithValue("@wineID", t.WineID);
                res = DataBase.ExecuteBasicCommand(command);
                System.Diagnostics.Debug.WriteLine(string.Format("{0} - User: {1}  Metodo Delete Ejecutado Correctamente", DateTime.Now, Session.SessionID));
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} - User: {1} Error en el metodo Delete de la Tabla WineImpl - {2} - {3}", DateTime.Now, Session.SessionID, ex.Message, query));
                throw ex;
            }
            return res;
        }

        public DataTable Find(Wine wine)
        {
            throw new NotImplementedException();
        }

        public Wine Get(int id)
        {
            Wine t = null;
            System.Diagnostics.Debug.WriteLine(string.Format("{0} - User: {1} Inicializando el Metodo Get de la Tabla WineImpl", DateTime.Now, Session.SessionID));
            string query = @"SELECT wineID, wineName, price, [Image] , stock , descriptionWine,categoryID,status,registerDate,
                            lastUpdate, UserID
                            FROM WineList
                            WHERE wineID =@wineID";
            SqlCommand command = null;
            SqlDataReader dr = null;
            try
            {
                command = DataBase.CreateBasicCommand(query);
                command.Parameters.AddWithValue("@wineID", id);
                dr = DataBase.ExecuteDataReaderCommand(command);
                System.Diagnostics.Debug.WriteLine(string.Format("{0} - User: {1}  Metodo Get Ejecutado Correctamente", DateTime.Now, Session.SessionID));
                while (dr.Read())
                {
                    t = new Wine(byte.Parse(dr[0].ToString()), dr[1].ToString(), double.Parse(dr[2].ToString()),int.Parse(dr[3].ToString()), int.Parse(dr[4].ToString()), dr[5].ToString(), byte.Parse(dr[6].ToString()), byte.Parse(dr[7].ToString()), DateTime.Parse(dr[8].ToString()), DateTime.Parse(dr[9].ToString()), short.Parse(dr[10].ToString()));
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} - User: {1} Error en el metodo Get de la Tabla WineImpl - {2} - {3}", DateTime.Now, Session.SessionID, ex.Message, query));
                throw ex;
            }
            finally
            {
                command.Connection.Close();
                dr.Close();
            }

            return t;
        }

        public int Insert(Wine t)
        {
            int res = 0;
            System.Diagnostics.Debug.WriteLine(string.Format("{0} - User: {1} Inicializando el Metodo Insert de la Tabla WineImpl Insert", DateTime.Now, Session.SessionID));
            string query = @"INSERT INTO WineList(categoryID,wineName,price,[image],stock,descriptionWine,lastUpdate,UserID)
                            VALUES (@categoryID,@wineName,@price,@image,@stock,@descriptionWine,CURRENT_TIMESTAMP,@UserID)";
            try
            {
                SqlCommand command = DataBase.CreateBasicCommand(query);
                command.Parameters.AddWithValue("@categoryID", t.CategoryID);
                command.Parameters.AddWithValue("@wineName", t.WineName);
                command.Parameters.AddWithValue("@price", t.Price);
                command.Parameters.AddWithValue("@image", t.Image);
                command.Parameters.AddWithValue("@stock", t.Stock);
                command.Parameters.AddWithValue("@descriptionWine", t.DescriptionWine);
                command.Parameters.AddWithValue("@UserID", t.UserID);
                res = DataBase.ExecuteBasicCommand(command);
                System.Diagnostics.Debug.WriteLine(string.Format("{0} - User: {1}  Metodo Insert Ejecutado Correctamente", DateTime.Now, Session.SessionID));

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} - User: {1} Error en el metodo Insert de la Tabla Wine - {2} - {3}", DateTime.Now, Session.SessionID, ex.Message, query));
                throw ex;
            }
            return res;
        }

        public int SaveId()
        {
            int id = 0;
            try
            {
                id = Convert.ToInt32(DataBase.GetIdTable("WineList"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return id;
        }

        public DataTable Selec()
        {
            DataTable dt = new DataTable();
            System.Diagnostics.Debug.WriteLine(string.Format("{0} - User: {1} Inicializando el Metodo Select de la Tabla WineImpl", DateTime.Now, Session.SessionID));
            string query = @"SELECT * FROM vwWine
                                 ORDER BY 2";
            try
            {
                SqlCommand command = DataBase.CreateBasicCommand(query);
                dt = DataBase.ExecuteDataTableCommand(command);
                System.Diagnostics.Debug.WriteLine(string.Format("{0} - User: {1}  Metodo Select Ejecutado Correctamente", DateTime.Now, Session.SessionID));
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} - User: {1} Error en el metodo Select de la Tabla WineImpl - {2} - {3}", DateTime.Now, Session.SessionID, ex.Message, query));
                throw ex;
            }
            return dt;
        }

        public DataTable SelectLikeByName(string txt)
        {
            DataTable dt = new DataTable();
            System.Diagnostics.Debug.WriteLine(string.Format("{0} - User: {1} Inicializando el Metodo SelectLikeByName de la Tabla WineImpl", DateTime.Now, Session.SessionID));
            string query = @"SELECT W.wineID, CONCAT(W.wineName, '-', C.categoryName) AS Producto, W.price
                                FROM WineList W
                                INNER JOIN Category C ON C.categoryID = W.categoryID
                                WHERE W.status=1 AND (CONCAT(W.wineName, '-', C.categoryName) LIKE @txt)";
            try
            {
                SqlCommand command = DataBase.CreateBasicCommand(query);
                command.Parameters.AddWithValue("@txt", "%"+ txt +"%");
                dt = DataBase.ExecuteDataTableCommand(command);
                System.Diagnostics.Debug.WriteLine(string.Format("{0} - User: {1}  Metodo SelectLikeByName Ejecutado Correctamente", DateTime.Now, Session.SessionID));
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} - User: {1} Error en el metodo SelectLikeByName de la Tabla WineImpl - {2} - {3}", DateTime.Now, Session.SessionID, ex.Message, query));
                throw ex;
            }
            return dt;
        }

        public int Update(Wine t)
        {
            int res = 0;
            System.Diagnostics.Debug.WriteLine(string.Format("{0} - User: {1} Inicializando el Metodo Update de la Tabla Wine Update", DateTime.Now, Session.SessionID));
            string query = @"UPDATE WineList SET categoryID = @categoryID, wineName = @wineName , price = @price, [image] =1 , stock = @stock,
					        descriptionWine= @descriptionWine, lastUpdate = CURRENT_TIMESTAMP,
					        UserID = @UserID
					        WHERE wineID = @wineID";
            try
            {
                SqlCommand command = DataBase.CreateBasicCommand(query);
                command.Parameters.AddWithValue("@categoryID", t.CategoryID);
                command.Parameters.AddWithValue("@wineName", t.WineName);
                command.Parameters.AddWithValue("@price", t.Price);
                //imagen
                command.Parameters.AddWithValue("@stock", t.Stock);
                command.Parameters.AddWithValue("@descriptionWine", t.DescriptionWine);
                command.Parameters.AddWithValue("@UserID", t.UserID);
                command.Parameters.AddWithValue("@wineID", t.WineID);
                res = DataBase.ExecuteBasicCommand(command);
                System.Diagnostics.Debug.WriteLine(string.Format("{0} - User: {1}  Metodo Update Ejecutado Correctamente", DateTime.Now, Session.SessionID));

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} - User: {1} Error en el metodo Update de la Tabla WineImpl - {2} - {3}", DateTime.Now, Session.SessionID, ex.Message, query));
            }
            return res;
        }


    }
}

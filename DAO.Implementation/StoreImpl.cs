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
    public class StoreImpl : IStore
    {
        public int Delete(Store t)
        {
            int res = 0;
            System.Diagnostics.Debug.WriteLine(string.Format("{0} - User: {1} Inicializando el Metodo Delete de la Tabla Stores", DateTime.Now, Session.SessionID));
            string query = @"UPDATE Stores SET status=0
                             WHERE storesID = @storesID";
            try
            {
                SqlCommand command = DataBase.CreateBasicCommand(query);
                command.Parameters.AddWithValue("@storesID", t.StoreID);
                res = DataBase.ExecuteBasicCommand(command);
                System.Diagnostics.Debug.WriteLine(string.Format("{0} - User: {1}  Metodo Delete Ejecutado Correctamente", DateTime.Now, Session.SessionID));
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} - User: {1} Error en el metodo Delete de la Tabla Store - {2} - {3}", DateTime.Now, Session.SessionID, ex.Message, query));
                throw ex;
            }
            return res;
        }

        public Store Get(byte id)
        {
            Store t = null;
            System.Diagnostics.Debug.WriteLine(string.Format("{0} - User: {1} Inicializando el Metodo GET de la Tabla Store", DateTime.Now, Session.SessionID));
            string query = @"SELECT storesID,storeDirection,storeName,storeEmail,storeLatitud,storeLongitud,UserID,registerDate,lastUpdate,status
                             FROM Stores
                             WHERE storesID =@storesID";
            SqlCommand command = null;
            SqlDataReader dr = null;
            try
            {
                command = DataBase.CreateBasicCommand(query);
                command.Parameters.AddWithValue("@storesID", id);
                dr = DataBase.ExecuteDataReaderCommand(command);
                System.Diagnostics.Debug.WriteLine(string.Format("{0} - User: {1}  Metodo Get Ejecutado Correctamente", DateTime.Now, Session.SessionID));
                while (dr.Read())
                {
                    t = new Store(byte.Parse(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), double.Parse(dr[4].ToString()), double.Parse(dr[5].ToString()), byte.Parse(dr[6].ToString()), DateTime.Parse(dr[7].ToString()), DateTime.Parse(dr[8].ToString()), byte.Parse(dr[9].ToString()));
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} - User: {1} Error en el metodo Get de la Tabla Store - {2} - {3}", DateTime.Now, Session.SessionID, ex.Message, query));
                throw ex;
            }
            finally
            {
                command.Connection.Close();
                dr.Close();
            }

            return t;
        }

        public int Insert(Store t)
        {
            int res = 0;
            System.Diagnostics.Debug.WriteLine(string.Format("{0} - User: {1} Inicializando el Metodo Insert de la Tabla Store", DateTime.Now, Session.SessionID));
            string query = @"  INSERT INTO Stores (storeDirection, storeName,storeEmail,storeLatitud,storeLongitud,UserID,lastUpdate)
                                    VALUES (@storeDirection,@storeName,@storeEmail,@storeLatitud,@storeLongitud,@UserID,CURRENT_TIMESTAMP)";
            try
            {
                SqlCommand command = DataBase.CreateBasicCommand(query);
                command.Parameters.AddWithValue("@storeDirection", t.StoreDirection);
                command.Parameters.AddWithValue("@storeName", t.StoreName);
                command.Parameters.AddWithValue("@storeEmail", t.StoreEmail);
                command.Parameters.AddWithValue("@storeLatitud", t.StoreLatitud);
                command.Parameters.AddWithValue("@storeLongitud", t.StoreLongitud);
                command.Parameters.AddWithValue("@UserID", t.UserID);
                res = DataBase.ExecuteBasicCommand(command);
                System.Diagnostics.Debug.WriteLine(string.Format("{0} - User: {1}  Metodo Insert Ejecutado Correctamente", DateTime.Now, Session.SessionID));

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} - User: {1} Error en el metodo Insert de la Tabla Store - {2} - {3}", DateTime.Now, Session.SessionID, ex.Message, query));
                throw ex;
            }
            return res;
        }

        public DataTable Selec()
        {
            DataTable dt = new DataTable();
            System.Diagnostics.Debug.WriteLine(string.Format("{0} - User: {1} Inicializando el Metodo Select de la Tabla Store", DateTime.Now, Session.SessionID));
            string query = @"SELECT * FROM vwStore
                                 ORDER BY 2";
            try
            {
                SqlCommand command = DataBase.CreateBasicCommand(query);
                dt = DataBase.ExecuteDataTableCommand(command);
                System.Diagnostics.Debug.WriteLine(string.Format("{0} - User: {1}  Metodo Select Ejecutado Correctamente", DateTime.Now, Session.SessionID));
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} - User: {1} Error en el metodo Select de la Tabla Store - {2} - {3}", DateTime.Now, Session.SessionID, ex.Message, query));
                throw ex;
            }
            return dt;
        }

        public DataTable SelectIDDescription()
        {
            DataTable dt = new DataTable();
            System.Diagnostics.Debug.WriteLine(string.Format("{0} - User: {1} Inicializando el Metodo SelectIDDescription de la Tabla Store", DateTime.Now, Session.SessionID));
            string query = @"SELECT storesID, storeName AS Nombre
                                FROM Stores
                                WHERE status = 1";
            try
            {
                SqlCommand command = DataBase.CreateBasicCommand(query);
                dt = DataBase.ExecuteDataTableCommand(command);
                System.Diagnostics.Debug.WriteLine(string.Format("{ 0} - User: {1}  Metodo SelectIDDescription Ejecutado Correctamente", DateTime.Now, Session.SessionID));
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} - User: {1} Error en el metodo SelectIDDescription de la Tabla Store - {2} - {3}", DateTime.Now, Session.SessionID, ex.Message, query));
                throw ex;
            }
            return dt;
        }

        public DataTable SelectLikeByName(string txt)
        {
           throw new NotImplementedException();
        }

        public DataTable SelectStoreDescription()
        {
            DataTable dt = new DataTable();
            System.Diagnostics.Debug.WriteLine(string.Format("{0} - User: {1} Inicializando el Metodo SelectStoreDescription de la Tabla Store", DateTime.Now, Session.SessionID));
            string query = @"SELECT storesID, storeName
                            FROM Stores
                            WHERE status = 1";

            try
            {
                SqlCommand command = DataBase.CreateBasicCommand(query);
                dt = DataBase.ExecuteDataTableCommand(command);
                System.Diagnostics.Debug.WriteLine(string.Format("{ 0} - User: {1}  Metodo SelectStoreDescription Ejecutado Correctamente", DateTime.Now, Session.SessionID));
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} - User: {1} Error en el metodo SelectStoreDescription de la Tabla Store - {2} - {3}", DateTime.Now, Session.SessionID, ex.Message, query));
                throw ex;
            }
            return dt;
        }

        public int Update(Store t)
        {
            int res = 0;
            System.Diagnostics.Debug.WriteLine(string.Format("{0} - User: {1} Inicializando el Metodo Update de la Tabla Store", DateTime.Now, Session.SessionID));
            string query = @"UPDATE Stores SET storeDirection = @storeDirection,storeName = @storeName, storeEmail =@storeEmail,
				          storeLatitud=@storeLatitud,storeLongitud=@storeLongitud,UserID = @UserID,lastUpdate = CURRENT_TIMESTAMP
				          WHERE storesID = @storesID";

            try
            {
                SqlCommand command = DataBase.CreateBasicCommand(query);
                command.Parameters.AddWithValue("@storeDirection", t.StoreDirection);
                command.Parameters.AddWithValue("@storeName", t.StoreName);
                command.Parameters.AddWithValue("@storeEmail", t.StoreEmail);
                command.Parameters.AddWithValue("@storeLatitud", t.StoreLatitud);
                command.Parameters.AddWithValue("@storeLongitud", t.StoreLongitud);
                command.Parameters.AddWithValue("@UserID", t.UserID);
                command.Parameters.AddWithValue("@storesID", t.StoreID);
                res = DataBase.ExecuteBasicCommand(command);
                System.Diagnostics.Debug.WriteLine(string.Format("{0} - User: {1}  Metodo Update Ejecutado Correctamente", DateTime.Now, Session.SessionID));

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} - User: {1} Error en el metodo Update de la Tabla Store - {2} - {3}", DateTime.Now, Session.SessionID, ex.Message, query));
            }
            return res;
        }
    }
}

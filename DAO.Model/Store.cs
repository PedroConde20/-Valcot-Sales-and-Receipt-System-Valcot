using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Model
{
    public class Store:BaseModel
    {
        public byte StoreID { get; set; }
        public string StoreDirection { get; set; }
        public string StoreName { get; set; }
        public string StoreEmail { get; set; }
        public double StoreLatitud { get; set; }
        public double StoreLongitud { get; set; }


        public Store()
        {

        }



        /// <summary>
        /// Get
        /// </summary>
        /// <param name="storeID"></param>
        /// <param name="storeDirection"></param>
        /// <param name="storeName"></param>
        /// <param name="storeEmail"></param>
        /// <param name="userID"></param>
        /// <param name="registerDate"></param>
        /// <param name="lastUpdate"></param>
        /// <param name="status"></param>


        //                0                     1                 2                    3            4                       5                 6               7                             8           9
        public Store(byte storeID, string storeDirection, string storeName, string storeEmail,double storeLatitud ,double storeLongitud ,byte userID , DateTime registerDate, DateTime lastUpdate, byte status)
            :base(userID,registerDate,lastUpdate,status)
        {
            StoreID = storeID;
            StoreDirection = storeDirection;
            StoreName = storeName;
            StoreEmail = storeEmail;
            StoreLatitud = storeLatitud;
            StoreLongitud = storeLongitud;
        }
        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="storeDirection"></param>
        /// <param name="storeName"></param>
        /// <param name="storeEmail"></param>
        /// <param name="userID"></param>

        public Store(string storeDirection, string storeName, string storeEmail, double storeLatitud,double storeLongitud ,short userID)
        {
            StoreDirection = storeDirection;
            StoreName = storeName;
            StoreEmail = storeEmail;
            StoreLatitud = storeLatitud;
            StoreLongitud = storeLongitud;
            UserID = userID;

        }
    }
}

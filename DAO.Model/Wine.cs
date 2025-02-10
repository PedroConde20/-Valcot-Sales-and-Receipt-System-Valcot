using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Model
{
    public class Wine: BaseModel 
    {
        #region Properties
        public byte WineID { get; set; }
        public string WineName { get; set; }
        public double Price { get; set; }
        public int Image { get; set; }
        public int Stock { get; set; }
        public string DescriptionWine { get; set; }
        public byte CategoryID { get; set; }


        #endregion



        #region Constructors
        public Wine()
        {

        }

        /// <summary>
        /// Get
        /// </summary>
        /// <param name="wineID"></param>
        /// <param name="wineName"></param>
        /// <param name="price"></param>
        /// <param name="image"></param>
        /// <param name="stock"></param>
        /// <param name="descriptionWine"></param>
        /// <param name="categoryID"></param>
        /// <param name="status"></param>
        /// <param name="registerDate"></param>
        /// <param name="lastUpdate"></param>
        /// <param name="userID"></param>
        /// 
        //                 0            1              2                3      4                  5                   6          7                  8                     9                  10
        public Wine(byte wineID, string wineName, double price, int image,int stock, string descriptionWine, byte categoryID ,byte status, DateTime registerDate, DateTime lastUpdate, short userID)
            : base(status, registerDate, lastUpdate, userID)
        {
            WineID = wineID;
            WineName = wineName;
            Price = price;
            Image = image;
            Stock = stock;
            DescriptionWine = descriptionWine;
            CategoryID = categoryID;
        }



        /// <summary>
        /// INSERT
        /// </summary>
        /// <param name="wineID"></param>
        /// <param name="categoryID"></param>
        public Wine(byte categoryID, string wineName, double price, int image, int stock, string descriptionWine, short userID)
        {
            CategoryID = categoryID;
            WineName = wineName;
            Price = price;
            Image = image;
            Stock = stock;
            DescriptionWine = descriptionWine;
            UserID = userID;
        }
        #endregion


        #region Methods



        #endregion
    }
}

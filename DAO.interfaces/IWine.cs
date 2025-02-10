using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.Model;
using System.Data;

namespace DAO.interfaces
{
    public interface IWine:IDAO<Wine>
    {
        Wine Get(int id);
        DataTable Find(Wine wine);

        DataTable SelectLikeByName(string txt);
        //Imagen
        int SaveId();
    }
}

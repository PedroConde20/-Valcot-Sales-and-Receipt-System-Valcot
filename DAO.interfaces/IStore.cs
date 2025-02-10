using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO.interfaces;
using DAO.Model;

namespace DAO.interfaces
{
    public interface IStore:IDAO<Store>
    {
        DataTable SelectLikeByName(string txt);
        Store Get(byte id);

        DataTable SelectIDDescription();
        DataTable SelectStoreDescription();
    }
}

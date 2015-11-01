using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoOrganizer.Repository
{
    interface IRepository
    {
        protected Object GetObject<T>(int id);
        protected void InsertObject<T>(Object obj);
        protected void DeleteObject<T>(int id);
        protected void UpdateObjectData<T>(int id, Object data);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoOrganizer.Repository
{
    interface IRepository
    {
        T GetObject<T>(int id);
        void InsertObject<T>(T obj);
        void DeleteObject<T>(int id);
        void UpdateObjectData<T>(int id, T data);
    }
}

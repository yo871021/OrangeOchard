using Database.Model.Enums;
using DataBase.Model;
using DataBase.Tool;

namespace DataBase.Repository
{
    public class DBRepositoryBase : IDBRepository
    {
        protected DBFactory db;

        void IDBRepository.SetDB(DBInstance dbInstance)
        {
            SetDB(dbInstance);
        }

        private void SetDB(DBInstance dbInstance)
        {
            db = new DBFactory(dbInstance);
        }
    }
}

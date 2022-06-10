using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ilmateade_
{
    public class PeamineBaseRepository
    {
        SQLiteConnection database;
        public PeamineBaseRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<PeamineBase>();
        }
        public IEnumerable<PeamineBase> GetItems()
        {
            return database.Table<PeamineBase>().ToList();
        }
        public PeamineBase GetItem(int id)
        {
            return database.Get<PeamineBase>(id);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<PeamineBase>(id);
        }
        public int SaveItem(PeamineBase item)
        {
            if (item.Id !=0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}

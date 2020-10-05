using SQLite;
using System;
using System.Collections.Generic;
using System.Text;


namespace FinAcc.Persistence
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Moca.Db;
using MocaDaoDemo.Models;

namespace MocaDaoDemo.Db.Impl
{
    /// <summary>
    /// DaoClass データアクセス
    /// </summary>
    class DaoClass1 : AbstractDao, IDaoClass1
    {

        #region Insert

        public void Insert1(TrnTableRow row)
        {
            Insert(row);
        }

        public void Insert2(TrnTableRow row)
        {
            const string sql = "DaoClass1_Insert";

            using (IDbCommandStoredProcedure cmd = CreateCommandStoredProcedure(sql))
            {
                cmd.AddParameterValue(row.Id);
                cmd.AddParameterValue(row.Name);
                cmd.AddParameterValue(row.Flg);
                cmd.AddParameterValue(row.AmountOfMoney);

                int cnt;
                cnt = cmd.ExecuteNonQuery();
                if (cnt.Equals(0))
                {
                }
            }
        }

        public void Insert3(TrnTableRow row)
        {
            const string sql = "DaoClass1_Insert";
            UpdateProcedure(sql, row);
        }

        public void Insert4(IList<TrnTableRow> rows)
        {
            Insert(rows);
        }

        #endregion

        #region Find

        public IList<TrnTableRow> Find1(TrnTableRow condition)
        {
            var sql = new System.Text.StringBuilder(512);
            sql.AppendLine(@"SELECT");
            sql.AppendLine(@"	*");
            sql.AppendLine(@"FROM	trnTable");
            sql.AppendLine(@"WHERE	(@AmountOfMoney IS NULL OR (@AmountOfMoney IS NOT NULL AND AmountOfMoney >= @AmountOfMoney))");

            return (IList<TrnTableRow>)Select<TrnTableRow>(sql.ToString(), new { AmountOfMoney = condition.AmountOfMoney });
        }

        /// <summary>
        /// sample method
        /// </summary>
        /// <returns></returns>
        public IList<TrnTableRow> Find2(TrnTableRow condition)
        {
            const string sql = "DaoClass1_Find";
            using (IDbCommandStoredProcedure cmd = CreateCommandStoredProcedure(sql))
            {
                cmd.AddParameterValue(condition.AmountOfMoney);
                return (IList<TrnTableRow>)cmd.Execute<TrnTableRow>();
            }
        }

        public IList<TrnTableRow> Find3(TrnTableRow condition)
        {
            const string sql = "DaoClass1_Find";
            return (IList<TrnTableRow>)QueryProcedure<TrnTableRow>(sql, new { AmountOfMoney = condition.AmountOfMoney });
        }

        #endregion

        #region Update

        #endregion

        #region Delete

        public void Delete1(TrnTableRow condition)
        {
            Delete(condition);
        }

        public void Delete2(TrnTableRow condition)
        {
            const string sql = "DaoClass1_Delete";

            using (IDbCommandStoredProcedure cmd = CreateCommandStoredProcedure(sql))
            {
                cmd.AddParameterValue(condition.Id);

                int cnt;
                cnt = cmd.ExecuteNonQuery();
                if (cnt.Equals(0))
                {
                }
            }
        }

        public void Delete3(TrnTableRow condition)
        {
            const string sql = "DaoClass1_Delete";
            UpdateProcedure(sql, condition);
        }

        #endregion

    }
}

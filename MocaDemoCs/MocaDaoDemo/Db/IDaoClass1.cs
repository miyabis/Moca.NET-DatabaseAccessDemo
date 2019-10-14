using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moca.Db.Attr;
using Moca.Attr;
using MocaDaoDemo.Models;

namespace MocaDaoDemo.Db
{
    /// <summary>
    /// DaoClass1 データアクセスインタフェース
    /// </summary>
    [Dao("MocaDaoDemo.Properties.Settings.Db", typeof(Impl.DaoClass1))]
    public interface IDaoClass1
    {

        #region Insert

        /// <summary>
        /// Insert 文自動生成（Definition 定義より作成します）
        /// </summary>
        /// <param name="row"></param>
        [Transaction()]
        void Insert1(TrnTableRow row);

        /// <summary>
        /// ストアドプロシージャ実行（IDbCommandStoredProcedure 使用）
        /// </summary>
        /// <param name="row"></param>
        [Transaction()]
        void Insert2(TrnTableRow row);

        /// <summary>
        /// ストアドプロシージャ実行（UpdateProcedure メソッド使用）
        /// </summary>
        /// <param name="row"></param>
        [Transaction()]
        void Insert3(TrnTableRow row);

        /// <summary>
        /// Insert 文自動生成（Definition 定義より作成します）
        /// </summary>
        /// <param name="rows"></param>
        [Transaction()]
        void Insert4(IList<TrnTableRow> rows);

        #endregion

        #region Find

        /// <summary>
        /// SQL文検索
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        IList<TrnTableRow> Find1(TrnTableRow condition);

        /// <summary>
        /// ストアドプロシージャ実行（IDbCommandStoredProcedure 使用）
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        IList<TrnTableRow> Find2(TrnTableRow condition);

        /// <summary>
        /// ストアドプロシージャ実行（QueryProcedure メソッド使用）
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        IList<TrnTableRow> Find3(TrnTableRow condition);

        #endregion

        #region Update

        #endregion

        #region Delete

        [Transaction()]
        void Delete1(TrnTableRow condition);

        [Transaction()]
        void Delete2(TrnTableRow condition);

        [Transaction()]
        void Delete3(TrnTableRow condition);

        #endregion

    }
}

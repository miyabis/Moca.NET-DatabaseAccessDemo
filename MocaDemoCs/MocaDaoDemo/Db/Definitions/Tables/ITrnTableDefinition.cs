//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MocaDaoDemo.Db.Definitions.Tables
{
    using Moca.Db;
    using Moca.Db.Attr;


    #region  Definition 
    ///  <summary> 
    ///  EntityClass1 Entity definition 
    ///  </summary> 
    ///  <remarks></remarks> 
    ///  <history> 
    ///  </history> 
    [Table("MocaDaoDemo.Properties.Settings.Db", "trnTable")]
    public interface ITrnTableDefinition
    {

        ///  <summary> 
        ///  Table (Table) Property. 
        ///  </summary> 
        Moca.Db.DbInfoTable Table
        {
            get;
            set;
        }

        ///  <summary> 
        ///  Id (Id) Property. 
        ///  </summary> 
        [Column("Id")]
        Moca.Db.DbInfoColumn Id
        {
            get;
            set;
        }

        ///  <summary> 
        ///  Name (Name) Property. 
        ///  </summary> 
        [Column("Name")]
        Moca.Db.DbInfoColumn Name
        {
            get;
            set;
        }

        ///  <summary> 
        ///  Flg (Flg) Property. 
        ///  </summary> 
        [Column("Flg")]
        Moca.Db.DbInfoColumn Flg
        {
            get;
            set;
        }

        ///  <summary> 
        ///  AmountOfMoney (AmountOfMoney) Property. 
        ///  </summary> 
        [Column("AmountOfMoney")]
        Moca.Db.DbInfoColumn AmountOfMoney
        {
            get;
            set;
        }

        ///  <summary> 
        ///  InsertDate (InsertDate) Property. 
        ///  </summary> 
        [Column("InsertDate")]
        [DbFunction("GETDATE()")]
        [Crud(System.Data.DataRowState.Added)]
        Moca.Db.DbInfoColumn InsertDate
        {
            get;
            set;
        }

        ///  <summary> 
        ///  UpdateDate (UpdateDate) Property. 
        ///  </summary> 
        [Column("UpdateDate")]
        Moca.Db.DbInfoColumn UpdateDate
        {
            get;
            set;
        }
    }
    #endregion
}
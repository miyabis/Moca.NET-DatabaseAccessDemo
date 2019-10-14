using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocaDaoDemo
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Moca.Di.MocaContainerFactory.Init();

                Db.Definitions.DbDefinition.Setup();

                Moca.Di.MocaInjector injector = new Moca.Di.MocaInjector();
                Command cmd = new Command();

                injector.Inject(cmd);

                cmd.Insert();
                cmd.Find();
                cmd.Delete();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Moca.Di.MocaContainerFactory.Destroy();

                Console.ReadKey();
            }
        }
    }

    class Command
    {

        private Db.IDaoClass1 _dao;

        public void Insert()
        {
            Models.TrnTableRow row = new Models.TrnTableRow();

            row.Id = 1;
            row.Name = "Test Desu";
            row.Flg = true;
            row.AmountOfMoney = 10000;
            _dao.Insert1(row);

            row.Id = 2;
            row.Name = "Demo Desu";
            row.Flg = false;
            row.AmountOfMoney = 2000;
            _dao.Insert2(row);

            row.Id = 3;
            row.Name = "Hoge Desu";
            row.Flg = false;
            row.AmountOfMoney = 2500;
            _dao.Insert3(row);
        }

        public void Find()
        {
            Models.TrnTableRow condition = new Models.TrnTableRow();
            condition.AmountOfMoney = 2500;

            IList<Models.TrnTableRow> lst;

            Console.WriteLine("Find: Select Method");
            lst = _dao.Find1(condition);
            foreach (Models.TrnTableRow row in lst)
            {
                Console.WriteLine("    {0}, {1}, {2}, {3}, {4}", row.Id, row.Name, row.Flg, row.AmountOfMoney, row.UpdateDate);
            }

            Console.WriteLine("Find: StoredProcedure IDbCommandStoredProcedure");
            lst = _dao.Find2(condition);
            foreach (Models.TrnTableRow row in lst)
            {
                Console.WriteLine("    {0}, {1}, {2}, {3}, {4}", row.Id, row.Name, row.Flg, row.AmountOfMoney, row.UpdateDate);
            }

            Console.WriteLine("Find: StoredProcedure QueryProcedure Method");
            lst = _dao.Find3(condition);
            foreach (Models.TrnTableRow row in lst)
            {
                Console.WriteLine("    {0}, {1}, {2}, {3}, {4}", row.Id, row.Name, row.Flg, row.AmountOfMoney, row.UpdateDate);
            }
        }

        public void Delete()
        {
            Models.TrnTableRow condition = new Models.TrnTableRow();

            condition.Id = 1;
            _dao.Delete1(condition);

            condition.Id = 2;
            _dao.Delete2(condition);

            condition.Id = 3;
            _dao.Delete3(condition);
        }

    }

}

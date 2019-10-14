using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocaDaoDemo.Db.Definitions
{

    partial class DbDefinition
    {
        #region Declare

        static DbDefinition _instance;

        #endregion

        #region コンストラクタ

        private DbDefinition()
        { }

        #endregion

        #region Methods

        #region Init

        static DbDefinition Instance()
        {
            Setup();
            return _instance;
        }

        public static void Setup()
        {
            if (_instance != null )
            {
                return;
            }
            _instance = new DbDefinition();

            Moca.Di.MocaInjector injector = new Moca.Di.MocaInjector();
            injector.Inject(_instance);

            _instance._setup(injector);
        }

        void _setup(Moca.Di.MocaInjector injector)
        {
        }

        #endregion

        #endregion
    }

}

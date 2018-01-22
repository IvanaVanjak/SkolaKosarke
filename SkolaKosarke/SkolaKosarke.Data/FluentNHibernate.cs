using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using SkolaKosarke.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SkolaKosarke.Data
{
    public class FluentNHibernate
    {
        //private static bool _prvi = true;

        public static ISession OpenSession()
        {
            var nhConfig = Fluently.Configure()
 .Database(SQLiteConfiguration.Standard
 .ConnectionString("Data Source=SkolaKosarkeDB.db;Version=3")
 .AdoNetBatchSize(100).ShowSql())
 .Mappings(x => x.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
 .BuildConfiguration();
            var sessionFactory = nhConfig.BuildSessionFactory();
            ISession sess = sessionFactory.OpenSession();
            //if (_prvi)
            //{
            //    var schemaExport = new SchemaExport(nhConfig);
            //    schemaExport.Create(false, true);
            //    _prvi = false;
            //}
            return sess;
        }
    }
}

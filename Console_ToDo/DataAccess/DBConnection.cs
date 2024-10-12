using Console_ToDo.DataAccess.Entity;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Reflection;


namespace Console_ToDo.DataAccess
{
    internal class DBConnection
    {
        private static DBConnection instance;
        private ISessionFactory sessionFactory;

        private static readonly string conString = "Data Source=OATHKEEPER;Initial Catalog=University;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";

        private DBConnection()
        {
            this.sessionFactory = CreateSessionFactory();
        }

        public static DBConnection GetInstance()
        {
            if (instance == null)
            {
                return new DBConnection();
            }
            else
            {
                return instance;
            }
        }


        private static ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012
                            .Driver<NHibernate.Driver.SqlClientDriver>()
                            .ConnectionString(conString)
                            .ShowSql()
                         )

                .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))

                .BuildSessionFactory();
        }


        public void CreateTask(Task task)
        {
            using (var session = this.sessionFactory.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {

                    //create task
                    tx.Commit();
                }

            }
        }


        public void AddUser(User user)
        {
            using(var session = this.sessionFactory.OpenSession()){

                using (var tx = session.BeginTransaction()) {

                    Console.WriteLine("Database Connected");

                    session.Save(user);
                    tx.Commit();
                }
            }
        }
    }
}


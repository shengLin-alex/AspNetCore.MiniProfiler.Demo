using Autofac;
using Autofac.Features.AttributeFilters;
using Power.Mvc.Helper;
using Power.Mvc.Helper.Extensions;
using Power.Repository.Dapper;
using System.Reflection;

namespace AspNetCore.MiniProfiler.Demo.Repository
{
    /// <summary>
    /// 類別註冊
    /// </summary>
    public class AutofacTypeRegister : ITypeRegister
    {
        /// <summary>
        /// 註冊順序
        /// </summary>
        public int Seq => 3;

        /// <summary>
        /// 註冊類別
        /// </summary>
        /// <param name="builder">ContainerBuilder</param>
        public void RegisterTypes(ContainerBuilder builder)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            builder
               .RegisterAssemblyTypes(assembly)
               .AsImplementedInterfaces()
               .WithAttributeFiltering()
               .InstancePerLifetimeScope()
               .LogExpectRegistration();

            builder
               .RegisterType<PostgreSqlConnectionFactory>()
               .As<IPostgreSqlConnectionFactory>()
               .InstancePerLifetimeScope()
               .LogExpectRegistration();

            builder
               .RegisterType<MySqlConnectionFactory>()
               .As<IMySqlConnectionFactory>()
               .InstancePerLifetimeScope()
               .LogExpectRegistration();
        }
    }
}
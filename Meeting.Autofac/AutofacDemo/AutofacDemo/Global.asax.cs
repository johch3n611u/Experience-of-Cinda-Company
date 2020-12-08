using Autofac;
using Autofac.Integration.Mvc;
using AutofacDemo.Controllers;
using System.Diagnostics;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using static AutofacDemo.Controllers.HomeController;

namespace AutofacDemo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        [Conditional("DEBUG")]
        protected void Application_Debug()
        {
            var builder = new ContainerBuilder();
            // ���U�Ҧ��� Controller �@�� Service
            builder.RegisterControllers(typeof(HomeController).Assembly);
            // ���U TextWriterLog �@�� ILog �� Service
            builder.RegisterType<TextWriterLog>().As<ILog>();
            // �إ� DI Container
            var container = builder.Build();
            // ��DI Container �@���إ� Controller �ɭԪ� DI Resolver�C
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

        protected void Application_Release()
        {
            var builder = new ContainerBuilder();
            // ���U�Ҧ��� Controller �@�� Service
            builder.RegisterControllers(typeof(HomeController).Assembly);
            // ���U TextWriterLog �@�� ILog �� Service
            builder.RegisterType<TextWriterNLog>().As<ILog>();
            // �إ� DI Container
            var container = builder.Build();
            // ��DI Container �@���إ� Controller �ɭԪ� DI Resolver�C
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

        protected void Application_Start()
        {
            Application_Debug();
            Application_Release();
            // ��L Mvc �]�w
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}

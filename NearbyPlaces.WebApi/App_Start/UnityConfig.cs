using System.Web.Http;
using Unity;
using Unity.WebApi;
using NearbyPlaces.Business;
using Unity.RegistrationByConvention;

namespace NearbyPlaces.WebApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            //container.RegisterType<IGetCachePlaces, GetCachePlaces>();
            //container.RegisterType<IGetGooglePlaces, GetGooglePlaces>();

            container.RegisterTypes(
                AllClasses.FromLoadedAssemblies(),
                WithMappings.FromMatchingInterface,
                WithName.Default);

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}
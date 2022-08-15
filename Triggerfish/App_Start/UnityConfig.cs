using System;
using System.Web.Mvc;
using Triggerfish.Repository;
using Unity;
using Unity.AspNet.Mvc;

namespace Triggerfish
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            container.RegisterType<INewsArticleRepository, NewsArticleRepository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
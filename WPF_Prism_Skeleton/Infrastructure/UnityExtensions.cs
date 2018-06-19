using Microsoft.Practices.Unity;
using System;

namespace WPF_Prism_Skeleton
{
    public static class UnityExtensions
    {
        public static void RegisterTypeForNavigation<T>(this IUnityContainer container)
        {
            container.RegisterType(typeof(Object), typeof(T), typeof(T).FullName);
        }
    }
}

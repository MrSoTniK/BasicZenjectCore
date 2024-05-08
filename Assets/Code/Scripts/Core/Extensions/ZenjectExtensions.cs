using Zenject;
using Core.Infrastructure.Systems;
using Core.Infrastructure;

namespace Core.Extensions
{
    public static class ZenjectExtensions
    {
        public static void BindPreInitializeSystem<TSystem, TSystemsManager>(this DiContainer container, TSystem system)
            where TSystem : IPreInitializeSystem
            where TSystemsManager : SystemsManagerAbstract
        {
            container.Bind<IPreInitializeSystem>()
                .To<TSystem>()
                .FromInstance(system)
                .WhenInjectedInto<TSystemsManager>();
        }
        
        public static void BindInitializeSystem<TSystem, TSystemsManager>(this DiContainer container, TSystem system)
            where TSystem : IInitializeSystem
            where TSystemsManager : SystemsManagerAbstract
        {
            container.Bind<IInitializeSystem>()
                .To<TSystem>()
                .FromInstance(system)
                .WhenInjectedInto<TSystemsManager>();
        }

        public static void BindUpdateSystem<TSystem, TSystemsManager>(this DiContainer container, TSystem system)
            where TSystem : IUpdateSystem
            where TSystemsManager : SystemsManagerAbstract
        {
            container.Bind<IUpdateSystem>()
                .To<TSystem>()
                .FromInstance(system)
                .WhenInjectedInto<TSystemsManager>();
        }

        public static void BindFixedSystem<TSystem, TSystemsManager>(this DiContainer container, TSystem system)
            where TSystem : IFixedUpdateSystem
            where TSystemsManager : SystemsManagerAbstract
        {
            container.Bind<IFixedUpdateSystem>()
                .To<TSystem>()
                .FromInstance(system)
                .WhenInjectedInto<TSystemsManager>();
        }
    }
}
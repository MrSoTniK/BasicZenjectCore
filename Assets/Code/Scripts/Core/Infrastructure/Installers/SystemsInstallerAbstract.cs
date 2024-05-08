using Core.Infrastructure.Systems;
using System;
using Zenject;

namespace Core.Infrastructure.Installers
{
    public abstract class SystemsInstallerAbstract<TSystemsManager> : MonoInstaller
        where TSystemsManager : SystemsManagerAbstract, new()
    {
        private TSystemsManager _systemsManager;

        public override void InstallBindings()
        {
            _systemsManager = new();
            CreateSystems();
            Container.Bind<TSystemsManager>().FromInstance(_systemsManager);
        }

        protected abstract void CreateSystems();   

        protected void AddPreInitSystem(Type preInitializeSystemType) 
        {
            var preInitializeSystem= (IPreInitializeSystem)Container.Instantiate(preInitializeSystemType);
            _systemsManager.AddPreInitSystem(preInitializeSystem);
        }

        protected void AddInitSystem(Type initializeSystemType)
        {
            var initializeSystem = (IInitializeSystem)Container.Instantiate(initializeSystemType);
            _systemsManager.AddInitSystem(initializeSystem);
        }

        protected void AddUpdateSystem(Type updateSystemType)
        {
            var updateSystem = (IUpdateSystem)Container.Instantiate(updateSystemType);
            _systemsManager.AddUpdateSystem(updateSystem);
        }

        protected void AddFixedUpdateSystem(Type fixedUpdateSystemType)
        {
            var fixedUpdateSystem = (IFixedUpdateSystem)Container.Instantiate(fixedUpdateSystemType);
            _systemsManager.AddFixedSystem(fixedUpdateSystem);
        }
    }
}
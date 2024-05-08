using Zenject;

namespace Core.Infrastructure.Installers 
{
    public abstract class BootstrapInstallerAbstract<TSystemsManager, TGameStartup> : MonoInstaller
        where TSystemsManager : SystemsManagerAbstract
        where TGameStartup : StartupAbstract<TSystemsManager>
    {
        public override void InstallBindings()
        {
            BindGameStartup();
        }
     
        private void BindGameStartup()
        {
            Container.BindInterfacesAndSelfTo<TGameStartup>()
                .AsSingle()
                .NonLazy();
        }
    }
}
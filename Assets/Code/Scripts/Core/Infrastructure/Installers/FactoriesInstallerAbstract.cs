using Zenject;

namespace Core.Infrastructure.Installers 
{
    public abstract class FactoriesInstallerAbstract : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindFactories();
        }

        protected abstract void BindFactories();
    }
}
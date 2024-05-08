using Zenject;

namespace Core.Infrastructure.Installers 
{
    public abstract class DatabasesInstallerAbstract : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindDataBases();
        }

        protected abstract void BindDataBases();
    }
}
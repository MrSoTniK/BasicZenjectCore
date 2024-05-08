using Zenject;

namespace Core.Infrastructure.Installers
{
    public abstract class DataInstallerAbstract : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindData();
        }

        protected abstract void BindData();        
    }
}
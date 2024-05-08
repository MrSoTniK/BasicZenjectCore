using Core.Infrastructure.Installers;
using Gameplay.Info.Test;

namespace Gameplay.Installers.Project
{
    public class ProjectDataInstaller : DataInstallerAbstract
    {

        protected override void BindData()
        {
            /* Example:
             * Container.Bind<SomeInfoClass>().FromInstance(someInfoClassExemplarFromSerializeField).AsSingle();
             Container.Bind<SomeInfoClass2>().AsSingle()*/
            Container.Bind<TestInfo>().AsSingle();
        }
    }
}
using Core.Infrastructure.Installers;
using Gameplay.Startups.Game;

namespace Gameplay.Installers.Game 
{
    public class GameSystemsInstaller : SystemsInstallerAbstract<GameSystemsManager>
    {      
        protected override void CreateSystems()
        {
            /*
                 Example:
                 AddPreInitSystem(typeof(PreInitSystem));
                 AddInitSystem(typeof(InitSystem));
                 AddUpdateSystem(typeof(UpdateSystem));
                 AddFixedUpdateSystem(typeof(FixedUpdateSystem));
             */
        }
    }
}
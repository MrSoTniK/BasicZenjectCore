using Core.Infrastructure.Installers;
using Gameplay.Systems.Project.Test;
using Gameplay.Startups.Project;

namespace Gameplay.Installers.Project
{
    public class ProjectSystemsInstaller : SystemsInstallerAbstract<ProjectSystemsManager>
    {
        protected override void CreateSystems()
        {
            AddPreInitSystem(typeof(ProjectTestSystem));
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
using Core.Infrastructure;

namespace Gameplay.Startups.Project 
{
    public class ProjectStartup : StartupAbstract<ProjectSystemsManager>
    {
        public ProjectStartup(ProjectSystemsManager systemsManager) : base(systemsManager) { }
    }
}
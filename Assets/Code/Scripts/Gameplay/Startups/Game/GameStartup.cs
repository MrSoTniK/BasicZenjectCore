using Core.Infrastructure;

namespace Gameplay.Startups.Game 
{
    public class GameStartup : StartupAbstract<GameSystemsManager>
    {
        public GameStartup(GameSystemsManager systemsManager) : base(systemsManager) { }
    }
}
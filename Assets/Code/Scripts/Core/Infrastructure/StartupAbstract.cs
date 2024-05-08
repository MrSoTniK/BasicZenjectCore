using Zenject;

namespace Core.Infrastructure 
{ 
    public abstract class StartupAbstract<TSystemsManager> : IInitializable, ITickable, IFixedTickable
        where TSystemsManager : SystemsManagerAbstract
    {
        private readonly TSystemsManager _systemsManager;

        public StartupAbstract(TSystemsManager systemsManager)
        {
            _systemsManager = systemsManager;
        }

        public void Initialize()
        {
            _systemsManager.PreInitialize();
            _systemsManager.Initialize();
        }

        public void Tick()
        {
            _systemsManager.Update();
        }

        public void FixedTick()
        {
            _systemsManager.FixedUpdate();
        }
    }
}
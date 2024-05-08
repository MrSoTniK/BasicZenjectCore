using System.Collections.Generic;
using Core.Infrastructure.Systems;

namespace Core.Infrastructure
{
    public abstract class SystemsManagerAbstract
    {
        private readonly List<IPreInitializeSystem> _preInitializeSystems;
        private readonly List<IInitializeSystem> _initializeSystems;
        private readonly List<IUpdateSystem> _updateSystems;
        private readonly List<IFixedUpdateSystem> _fixedSystems;
        private readonly List<IDestroySystem> _destroySystems;

        public SystemsManagerAbstract()
        {
            _preInitializeSystems = new();
            _initializeSystems = new();
            _updateSystems = new();
            _fixedSystems = new();
            _destroySystems = new();
        }

        public void AddPreInitSystem(IPreInitializeSystem preInitializeSystem)
        {
            if (_preInitializeSystems.Contains(preInitializeSystem)) return;

            _preInitializeSystems.Add(preInitializeSystem);
        }

        public void RemoveUpdateSystem(IPreInitializeSystem preInitializeSystem)
        {
            _preInitializeSystems.Remove(preInitializeSystem);
        }

        public bool ContainsUpdateSystem(IPreInitializeSystem preInitializeSystem)
        {
            return _preInitializeSystems.Contains(preInitializeSystem);
        }

        public void AddInitSystem(IInitializeSystem initSystem)
        {
            if (_initializeSystems.Contains(initSystem)) return;

            _initializeSystems.Add(initSystem);
        }

        public bool ContainsUpdateSystem(IUpdateSystem updateSystem)
        {
            return _updateSystems.Contains(updateSystem);
        }

        public void AddUpdateSystem(IUpdateSystem updateSystem)
        {
            _updateSystems.Add(updateSystem);
        }

        public void RemoveUpdateSystem(IUpdateSystem updateSystem)
        {
            _updateSystems.Remove(updateSystem);
        }

        public bool ContainsFixedSystem(IFixedUpdateSystem fixedSystem)
        {
            return _fixedSystems.Contains(fixedSystem);
        }

        public void AddFixedSystem(IFixedUpdateSystem fixedSystem)
        {
            _fixedSystems.Add(fixedSystem);
        }

        public void RemoveFixedSystem(IFixedUpdateSystem fixedSystem)
        {
            _fixedSystems.Remove(fixedSystem);
        }

        public void AddDestroySystem(IDestroySystem destroySystem)
        {
            if (_destroySystems.Contains(destroySystem)) return;

            _destroySystems.Add(destroySystem);
        }

        public void PreInitialize()
        {
            for (var index = 0; index < _preInitializeSystems.Count; index++)
            {
                _preInitializeSystems[index].PreInitialize();
            }
        }

        public void Initialize()
        {
            for (var index = 0; index < _initializeSystems.Count; index++)
            {
                _initializeSystems[index].Initialize();
            }
        }

        public void Update()
        {
            for (var index = 0; index < _updateSystems.Count; index++)
            {
                _updateSystems[index].Update();
            }
        }

        public void FixedUpdate()
        {
            for (var index = 0; index < _fixedSystems.Count; index++)
            {
                _fixedSystems[index].FixedUpdate();
            }
        }

        public void Destroy()
        {
            for (var index = 0; index < _destroySystems.Count; index++)
            {
                _destroySystems[index].Destroy();
            }
        }
    }
}
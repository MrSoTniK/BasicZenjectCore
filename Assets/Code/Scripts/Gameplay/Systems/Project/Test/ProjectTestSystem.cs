using Core.Infrastructure.Systems;
using Gameplay.Info.Test;
using UnityEngine;

namespace Gameplay.Systems.Project.Test 
{
    public class ProjectTestSystem : IPreInitializeSystem
    {
        private readonly TestInfo _testInfo;

        public ProjectTestSystem(TestInfo testInfo) 
        {
            _testInfo = testInfo;
        }

        public void PreInitialize()
        {
            Debug.Log(_testInfo.Text);
        }
    }
}
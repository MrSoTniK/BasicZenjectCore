using Core.Infrastructure;
using UnityEngine;
using Zenject;

namespace Game.Installers
{
    public abstract class ViewsInstallerAbstract : MonoInstaller
    {
        public override void InstallBindings()
        {
            InstallViews();
        }

        private void InstallViews()
        {
            var views = GameObject.FindObjectsByType<ViewBase>(FindObjectsSortMode.None);

            foreach (var view in views)
            {
                var binder = Container.Bind(view.GetType()).FromInstance(view);

                if (view.IsCached)
                {
                    binder.AsCached();
                }
                else
                {
                    binder.AsSingle();
                }
            }
        }
    }
}
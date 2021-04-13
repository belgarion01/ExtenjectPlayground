using UnityEngine;
using Zenject;

namespace Hura.Asteroid
{
    public class AsteroidInstaller : MonoInstaller
    {
        private ShipController _controller;
        public Ship ship;
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<ShipController>().AsSingle();
            Container.Bind<Ship>().FromComponentInNewPrefab(ship).AsSingle().NonLazy();
        }
    }
}
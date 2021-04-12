using System.Collections.Generic;
using Hura;
using UnityEngine;
using Zenject;

namespace Hura.Arena
{
    public class ArenaInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<Champion>().WithId("Host").FromInstance(new Champion("Homigo", Random.value));
            Container.Bind<Champion>().WithId("Challenger").FromInstance(new Champion("Challengerico", Random.value));
            Container.Bind<List<Supporter>>().FromInstance(new List<Supporter>
                {new Supporter(), new Supporter(), new Supporter()});
        }
    }
}
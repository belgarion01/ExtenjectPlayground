using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;


namespace Hura
{
    public class Arena : MonoBehaviour
    {
        [Inject]
        public List<Supporter> Supporters;

        [Inject(Id = "Host")]
        public Champion Host;
        
        [Inject(Id = "Challenger")]
        public Champion Challenger;

        void Start()
        {
            Debug.Log(Supporters.Count);
            for (int i = 0; i < Supporters.Count; i++)
            {
                if (i % 2 == 0)
                {
                    Supporters[i].Shout(Host.Name + " / " + Host.ID);
                }
                else
                {
                    Supporters[i].Shout(Challenger.Name + " / " + Challenger.ID);
                }
            }
        }
    }
}

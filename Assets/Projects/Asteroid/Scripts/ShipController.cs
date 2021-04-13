using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Hura.Asteroid
{
    public class ShipController : ITickable
    {
        private float hAxis;
        private float vAxis;

        public Action ShootAction;
        
        public void Tick()
        {
            hAxis = Input.GetAxisRaw("Horizontal");
            vAxis = Input.GetAxisRaw("Vertical");

            if (Input.GetKeyDown(KeyCode.Space))
            {
                ShootAction?.Invoke();
            }
        }
        
        public Vector2 GetInputDirection() => new Vector2(hAxis, vAxis).normalized;
        
    }
}

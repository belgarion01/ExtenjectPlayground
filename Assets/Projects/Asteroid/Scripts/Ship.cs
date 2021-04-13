using System.Collections;
using System.Collections.Generic;
using Hura.Asteroid;
using UnityEngine;
using Zenject;


namespace Hura.Asteroid
{
    public class Ship : MonoBehaviour
    {
        private ShipController controller;

        [SerializeField] private float speed = 1f;

        [Inject]
        public void Construct(ShipController controller)
        {
            this.controller = controller;
        }

        void Awake()
        {
            controller.ShootAction += Shoot;
        }

        void Update()
        {
            transform.Translate(controller.GetInputDirection()*speed*Time.deltaTime);
        }

        void Shoot()
        {
            Debug.Log("Shoot");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    
namespace Hura.Arena
{
    public class Champion
    {
        public Champion(string Name, float ID)
        {
            this.Name = Name;
            this.ID = ID;
        }
        public string Name;
        public float ID;
    }
}

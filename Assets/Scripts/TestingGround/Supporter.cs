using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    
namespace Hura
{
    public class Supporter
    {
        public Champion Favourite;

        public void Shout() => Debug.Log(Favourite.Name);
        public void Shout(string message) => Debug.Log(Favourite.Name);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Extra.AdvancedCode
{
    public sealed class Enemy : Tankable, IFirable, IDamagable
    {
        
        private float fireInterval;
        
        void Update()
        {
            fireInterval += Time.deltaTime;
            if (fireInterval >= 3f)
            {
                Fire();
                fireInterval = 0;
            }
        }
    }
}
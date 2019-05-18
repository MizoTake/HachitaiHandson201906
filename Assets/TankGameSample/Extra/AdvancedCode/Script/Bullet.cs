using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Extra.AdvancedCode
{
    public class Bullet : MonoBehaviour
    {
        private void OnCollisionEnter(Collision other)
        {
            var target = other.gameObject.GetComponent<IDamagable>();
            target.Damage(1);
        }
    }
}
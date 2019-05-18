using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Extra.AdvancedCode
{
    public sealed class Player : Tankable, IFirable, IDamagable, IMovable
    {

        [SerializeField] private float speed;
        
        public void Forward()
        {
            transform.Translate(Vector3.forward * speed);
        }

        public void Back()
        {
            transform.Translate(Vector3.back * speed);
        }

        public void Left()
        {
            transform.Rotate(Vector3.down * speed);
        }

        public void Right()
        {
            transform.Rotate(Vector3.up * speed);
        }
    }
}
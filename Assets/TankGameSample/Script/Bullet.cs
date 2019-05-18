using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

namespace TankGameSample
{
    public class Bullet : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Destroy(gameObject, 3f);
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnCollisionEnter(Collision other)
        {
            var player = other.gameObject.GetComponent<Player>();
            var enemy = other.gameObject.GetComponent<Enemy>();
            if (player)
            {
                player.hp -= 1;
            }
            if (enemy)
            {
                enemy.hp -= 1;
            }
            Destroy(gameObject);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Extra.TankConfig
{
    public class Enemy : MonoBehaviour
    {
        public TankConfig config;
        public Transform firePoint;
        private float fireInterval;
        
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            fireInterval += Time.deltaTime;
            if (fireInterval >= 3f)
            {
                Fire();
                fireInterval = 0;
            }

            if (config.hp <= 0)
            {
                Destroy(gameObject);
            }
        }
        
        void Fire()
        {
            var bullet = Instantiate(config.bulletPrefab, firePoint.position, firePoint.rotation);
            bullet.layer = gameObject.layer;
            foreach (Transform child in bullet.transform)
            {
                child.gameObject.layer = gameObject.layer;
            }
            var rigid = bullet.GetComponent<Rigidbody>();
            rigid.AddRelativeForce((Vector3.forward + Vector3.up) * config.firePower, ForceMode.Force);
        }
    }
}
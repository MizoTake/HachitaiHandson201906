using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Extra.TankConfig
{
    public class Player : MonoBehaviour
    {
        public TankConfig config;
        public Transform firePoint;
        
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.forward * config.speed);
            }
            
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(Vector3.down * config.speed);
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.back * config.speed);
            }
            
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(Vector3.up * config.speed);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Fire();
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
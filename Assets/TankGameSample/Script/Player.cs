using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankGameSample
{
    public class Player : MonoBehaviour
    {

        public int hp = 1;
        public float speed = 1;
        public GameObject bulletPrefab;
        public float firePower;
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
                transform.Translate(Vector3.forward * speed);
            }
            
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(Vector3.down * speed);
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.back * speed);
            }
            
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(Vector3.up * speed);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Fire();
            }
            
            if (hp <= 0)
            {
                Destroy(gameObject);
            }
        }

        void Fire()
        {
            var bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            var rigid = bullet.GetComponent<Rigidbody>();
            rigid.AddRelativeForce((Vector3.forward + Vector3.up) * firePower, ForceMode.Force);
        }
    }
}
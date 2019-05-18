using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Extra.AdvancedCode
{
    public abstract class Tankable : MonoBehaviour
    {

        [SerializeField] private uint hp = 3;
        [SerializeField] private GameObject bulletPrefab;
        [SerializeField] private float firePower;
        [SerializeField] private Transform firePoint;
        
        public void Fire()
        {
            var bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            bullet.layer = gameObject.layer;
            foreach (Transform child in bullet.transform)
            {
                child.gameObject.layer = gameObject.layer;
            }
            var rigid = bullet.GetComponent<Rigidbody>();
            rigid.AddRelativeForce((Vector3.forward + Vector3.up) * firePower, ForceMode.Force);
        }

        public void Damage(uint point)
        {
            hp -= point;
            if (hp == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
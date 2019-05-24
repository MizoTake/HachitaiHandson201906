using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankConfig : ScriptableObject
{
    public int hp = 3;
    public float speed = 1;
    public float firePower = 1;
    public GameObject bulletPrefab;
}

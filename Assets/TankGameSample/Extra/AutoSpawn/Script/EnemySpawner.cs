using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject SpawnTargetPrefab;
    
    private float spawnTimer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;
        if(spawnTimer > 3.0f) {
            Instantiate(SpawnTargetPrefab, transform.position + Vector3.down * 3f, Quaternion.identity);
            spawnTimer = 0;
        }
    }
}

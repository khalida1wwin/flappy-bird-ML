using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 2f;
    public float spawnTimer = 0;
    public float hightOffset = 10f;
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTimer < spawnRate){
            spawnTimer += Time.deltaTime;
        }
        else{
            spawnPipe();
            spawnTimer = 0;
        }
        
    }

    void spawnPipe(){
        float lowestPoint = transform.position.y - hightOffset;
        float highestPoint = transform.position.y + hightOffset;

        float spawnY = Random.Range(lowestPoint, highestPoint);
        Vector3 spawnPosition = new Vector3(transform.position.x, spawnY, transform.position.z);
        Instantiate(pipePrefab, spawnPosition, transform.rotation);
    }
}

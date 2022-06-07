using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnMeteors : MonoBehaviour
{
    [SerializeField] GameObject meteorToSpawn;
    bool spawnExtra;
    bool spawnExtra2;
    bool spawnExtra3;
    bool spawnExtra4;
    bool spawnExtra5;


    void Start()
    {
        SpawnMeteors();   
    }

    void Update()
    {
        if (Time.time > 10 && !spawnExtra)
        {
            spawnExtra = true;
            SpawnMeteors();
        }
        else if (Time.time > 15 && !spawnExtra2)
        {
            spawnExtra2 = true;
            SpawnMeteors();
        }
        else if (Time.time > 20 && !spawnExtra3)
        {
            spawnExtra3 = true;
            SpawnMeteors();
        }
        else if (Time.time > 25 && !spawnExtra4)
        {
            spawnExtra4 = true;
            SpawnMeteors();
        }
        else if (Time.time > 30 && !spawnExtra5)
        {
            spawnExtra5 = true;
            SpawnMeteors();
        }
    }

    public void SpawnMeteors()
    {
        int num1 = Random.Range(-4, 4);
        int num2 = Random.Range(-4, 4);

        Vector3 position = new Vector3(num1, 8, num2);
        GameObject thaMeteor = Instantiate(meteorToSpawn, position, Quaternion.identity);

        float num3 = Random.Range(0.005f, 0.01f);

        var meteRB = thaMeteor.GetComponent<Rigidbody>();

        if (meteRB.drag > 1)
        { 
          meteRB.drag -= num3;
        }
    }
}

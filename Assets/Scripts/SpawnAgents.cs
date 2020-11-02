using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAgents : MonoBehaviour
{
    public GameObject player;
    public GameObject food;

    public Vector3 center;
    public int size=90;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            Vector3 pos = center + new Vector3(Random.Range(-size / 2, size / 2), 1, Random.Range(-size / 2, size / 2));
            Instantiate(player, pos, Quaternion.identity);
        }
        for (int i = 0; i < 100; i++)
        {
            Vector3 pos = center + new Vector3(Random.Range(-size / 2, size / 2), 1, Random.Range(-size / 2, size / 2));
            Instantiate(food, pos, Quaternion.identity);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

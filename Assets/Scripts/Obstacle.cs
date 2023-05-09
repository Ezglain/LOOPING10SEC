using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int enemyNum;
    public GameObject[] enemies;
    public GameObject[] collectables;

    public GameObject blockObj;

    public int blockNum;

    public List<GameObject> allCollectables = new List<GameObject>();

    void Start()
    {

        for (int i = 0; i < blockNum; i++)
        {
            Debug.Log(i);

            Vector3 newPos = new Vector3(transform.position.x + Random.Range(-10, 10), transform.position.y, transform.position.z + Random.Range(-10, 10));

            GameObject newObj = Instantiate(blockObj, newPos, Quaternion.identity);

            allCollectables.Add(newObj);
        }

    }

    void Update()
    {
        Debug.Log(allCollectables.Count);
    }
}

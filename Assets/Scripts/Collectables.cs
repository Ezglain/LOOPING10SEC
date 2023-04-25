using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{

    public int enemyNum;
    public GameObject[] enemies;


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

        //x for (int i = 0; i < objNum; i++)
        //x   {
        //x       float newX = Random.Range (leftTop.position.x, rightBottom.position.x);
        //x      float newZ = Random.Range(rightBottom.position.z, leftTop.position.z);
        //x      Vector3 newPos = new Vector3(newX, transform.psotion.y, newZ);
        //x     GameObject newObj = Instantiate(objColect, newPos, Quaternion.identity);
        //x    allCollectables.Add(newObj);
        //x  }
    }

    void Update()
    {
        // Debug.Log(allCollectables.Count);
    }
}

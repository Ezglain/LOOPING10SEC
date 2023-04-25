using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{


    public int enemyNum;
    public GameObject enemyObj;

    public Transform leftTop;
    public Transform rightBottom;

    public GameObject[] enemies;

    // Start is called before the first frame update
    void Start()
    {

        enemies = new GameObject[enemyNum];

        for (int i = 0; i < enemyNum; i++)
        {
            float newX = Random.Range(leftTop.position.x, rightBottom.position.x);
            float newZ = Random.Range(rightBottom.position.z, leftTop.position.z);
            Vector3 newPos = new Vector3(newX, transform.position.y, newZ);
            GameObject newObj = Instantiate(enemyObj, newPos, Quaternion.identity);
            enemies[i] = newObj;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}

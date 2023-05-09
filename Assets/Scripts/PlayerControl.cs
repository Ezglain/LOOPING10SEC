using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerControl : MonoBehaviour
{
    bool letMove = true;

    public KeyCode upKey, downKey, rightKey, leftKey;

    CharacterController myCharControl;

    Vector3 vel;
    Vector3 rotation;

    public float speed;

    public Collectables myManager;

    //int health = 10;
    //public TMP_Text healthText;

    int score = 0;

    float thisIsADecimal = 3.14f;

    // Start is called before the first frame update
    void Start()
    {
        myCharControl = GetComponent<CharacterController>();

        // healthText.text = health.ToString();
        Debug.Log(thisIsADecimal);
        thisIsADecimal++;
        Debug.Log(thisIsADecimal);
    }

    // Update is called once per frame
    void Update()
    {

        if (letMove)
        {
            KeyControl();
        }
    }

    void KeyControl()
    {
        //vel = velocity
        vel = Vector3.zero;
        if (Input.GetKey(upKey))
        {
            vel.z = speed;
            rotation = vel;
        }
       // vel = Vector3.zero;
        if (Input.GetKey(downKey))
        {
            vel.z = -speed;
            rotation = vel;
        }
      //  vel = Vector3.zero;
        if (Input.GetKey(rightKey))
        {
            vel.x = speed;
            rotation = vel;
        }
       // vel = Vector3.zero;
        if (Input.GetKey(leftKey))
        {
            vel.x = -speed;
            rotation = vel;
        }

        Quaternion toRotate = Quaternion.LookRotation(rotation.normalized, Vector3.up);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotate, 300 * Time.deltaTime);
        //vel = transform.TransformDirection(vel);

        myCharControl.SimpleMove(vel);
    }

    void OnTriggerEnter(Collider otherThing)
    {
        Debug.Log(otherThing.name);

        if (otherThing.gameObject.tag == "Collectables")
        {
            //  health--;
            // healthText.text = health.ToString();

          //  myManager.allCollectables.Remove(otherThing.gameObject);
            Destroy(otherThing.gameObject);
        }

        if (otherThing.gameObject.tag == "Enemies")
        {
            letMove = false;
        }

    }
}
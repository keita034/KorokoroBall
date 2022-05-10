using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float power = 1;
    public new Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rigidbody.velocity.magnitude < 5)
        {
            if (Input.GetKey(KeyCode.W))
            {

                rigidbody.AddForce(new Vector3(0, 0, 1) * power);
            }

            if (Input.GetKey(KeyCode.A))
            {
                rigidbody.AddForce(new Vector3(-1, 0, 0) * power);
            }

            if (Input.GetKey(KeyCode.S))
            {
                rigidbody.AddForce(new Vector3(0, 0, -1) * power);
            }

            if (Input.GetKey(KeyCode.D))
            {
                rigidbody.AddForce(new Vector3(1, 0, 0) * power);
            }



        }
    }
}

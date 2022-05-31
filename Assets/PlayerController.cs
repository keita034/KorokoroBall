using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float power = 1;
    public new Rigidbody rigidbody;

    public GameObject gameoverText;//レベルクリア
    public GameObject resetButton;//レベル移行


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(rigidbody.position.y < -10)
        {
            rigidbody.position.Set(rigidbody.position.x,-10, rigidbody.position.z);
            gameoverText.SetActive(true);
            resetButton.SetActive(true);
        }
        

        if (rigidbody.velocity.magnitude < 5)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {

                rigidbody.AddForce(new Vector3(0, 0, 1) * power);
            }
            
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rigidbody.AddForce(new Vector3(-1, 0, 0) * power);
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                rigidbody.AddForce(new Vector3(0, 0, -1) * power);
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                rigidbody.AddForce(new Vector3(1, 0, 0) * power);
            }



        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            rigidbody.velocity = Vector3.zero;
            rigidbody.angularVelocity = Vector3.zero;
        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            rigidbody.velocity = Vector3.zero;
            rigidbody.angularVelocity = Vector3.zero;
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            rigidbody.velocity = Vector3.zero;
            rigidbody.angularVelocity = Vector3.zero;
        }

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            rigidbody.velocity = Vector3.zero;
            rigidbody.angularVelocity = Vector3.zero;
        }
    }
}

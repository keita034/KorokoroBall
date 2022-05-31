using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{

    public GameObject clearText;//レベルクリア
    public GameObject nextButton;//レベル移行

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ゴール");
        clearText.SetActive(true);
        nextButton.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

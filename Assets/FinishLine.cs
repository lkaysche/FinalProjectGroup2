using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    private GameObject GameControllerObj;
    // Start is called before the first frame update
    void Start()
    {
        GameControllerObj = GameObject.Find("GameController");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameControllerObj.GetComponent<GameController>().win();
            Debug.Log("Next");
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolController : MonoBehaviour
{
  [SerializeField] GameObject coin;
  [SerializeField] Transform spawner;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q")){
          Debug.Log("pressed");
          GameObject Coin  = Instantiate(coin, spawner.position, spawner.rotation);
          Coin.GetComponent<Rigidbody>().AddForce(spawner.forward*400);
          Coin.GetComponent<Rigidbody>().AddForce(spawner.up*150);
          Coin.GetComponent<Rigidbody>().AddTorque(60f, 0f, 0f);
        }
    }
}

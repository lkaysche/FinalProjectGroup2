using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPersist : MonoBehaviour
{
    public static ObjectPersist instance;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (!ObjectPersist.instance)
        {
            ObjectPersist.instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
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

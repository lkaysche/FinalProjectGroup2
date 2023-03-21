using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine;

public class CutScene : MonoBehaviour
{

    public bool playing;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playing)
        {
            if (this.GetComponent<VideoPlayer>().isPaused)
            {
                playing = false;
                GameObject.Find("GameController").GetComponent<GameController>().movieOver = true;
            }
        }
    }
}

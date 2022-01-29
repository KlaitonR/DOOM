using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveDoor : MonoBehaviour
{

    public bool open = false;
    public int frames = 0;
    public int maxFrames = 70;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(open){
            if(frames < maxFrames){
                frames++;
                transform.position += new Vector3(0.05f, 0, 0);
            }else{
                open = false;
            }
        }

    }
}

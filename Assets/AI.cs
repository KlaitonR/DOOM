using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{

    public float spd;
    public int life;

    void Start()
    {
        spd = 0.01f;
        life = 5;
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = new Vector3(0, GameObject.Find("Main Camera").transform.eulerAngles.y, 0);

        transform.position -= transform.forward * this.spd;

    }

    void onCollisionStay(Collision collision){
        if(collision.gameObject.tag == "MainCamera"){
            playerMove.vidaAtual--;
        }
    }
}

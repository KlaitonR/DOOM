using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWapon : MonoBehaviour
{

public AudioSource audio;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){ //mouse esquerdo
            audio.Play();
        RaycastHit hit;

        if(Physics.Raycast(transform.position, transform.forward, out hit, 10f)){
            if(hit.collider.gameObject.tag == "enemy"){
                GameObject enemy = hit.collider.gameObject;
                enemy.GetComponent<AI>().life--;
                Debug.Log(enemy.GetComponent<AI>().life);
                if(enemy.GetComponent<AI>().life == 0){
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
    }
}

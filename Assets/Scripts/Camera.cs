using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject player;
    public float offset;
    private Vector3 cameraPos;
    // Start is called before the first frame update
    void Start()
    {
        cameraPos = new Vector3();
    }

    // Update is called once per frame
    void Update()
    {
        cameraPos = transform.position;
        if(player.transform.position.x>=cameraPos.x+5f){
            cameraPos.x+=10f;
            Debug.Log("Debería desplazarme hacia la derecha");
        }
        if(player.transform.position.x<=cameraPos.x-5f){
            cameraPos.x-=10f;
            Debug.Log("Debería desplazarme hacia la derecha");
        }
        //cameraPos.x = player.transform.position.x;

        transform.position = cameraPos;
    }
}

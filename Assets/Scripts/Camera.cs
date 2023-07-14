using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject player;
    public float sideOffset;
    public float topBotOffset;
    public float camOffset;
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
        Vector3 newCameraPos;
        if(player.transform.position.x>=cameraPos.x+sideOffset+camOffset){
           // cameraPos.x+=10f;
           newCameraPos = player.transform.position;
           cameraPos.x = newCameraPos.x+sideOffset;
        }
        if(player.transform.position.x<=cameraPos.x-sideOffset-camOffset){
           // cameraPos.x-=10f;
           newCameraPos = player.transform.position;
           cameraPos.x = newCameraPos.x-sideOffset;
        }
        if(player.transform.position.y>=cameraPos.y+topBotOffset+camOffset){
           // cameraPos.x+=10f;
           newCameraPos = player.transform.position;
           cameraPos.y = newCameraPos.y+topBotOffset;
        }
        if(player.transform.position.y<=cameraPos.y-topBotOffset-camOffset){
           // cameraPos.x-=10f;
           newCameraPos = player.transform.position;
           cameraPos.y = newCameraPos.y-topBotOffset;
        }
        //cameraPos.x = player.transform.position.x;

        transform.position = cameraPos;
    }
}

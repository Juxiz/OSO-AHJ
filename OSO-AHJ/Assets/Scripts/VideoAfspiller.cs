using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoAfspiller : MonoBehaviour
{
    public GameObject Video;
    public KeyCode VideoStarter = KeyCode.F;
    private bool playing = false;
    public GameObject spiller;
    public GameObject thing;
    public float VideoDistance;
    public PlayerMovement ms;

    void Start(){
        ms = FindObjectOfType<PlayerMovement>();
        Debug.Log(ms.moveSpeed);
    }
    
    void Update()
    {
         VideoDistance = Vector2.Distance(spiller.transform.position, thing.transform.position);

        if (Input.GetKeyDown(VideoStarter))
        {   
            if (VideoDistance < 9) {
                
            if (playing == false){
                playing = true;
                ms.moveSpeed = 0;}
            else if (playing == true){
                playing = false;
                ms.moveSpeed = 25;}
            Video.SetActive(playing);
            }
        }
           


       }

        
}

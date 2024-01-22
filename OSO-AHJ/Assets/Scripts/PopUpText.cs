using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpText : MonoBehaviour
{

    public GameObject Player;
    public GameObject trophy;
    public GameObject text;
    public float popupRadius;
    public float Distance_;


    void Start()
    {
        text.SetActive(false);
    }

    void Update()
    {
       Distance_ = Vector2.Distance(Player.transform.position, trophy.transform.position);
        
        if(Distance_ < 9)
       {
        text.SetActive(true);
       }
       else
       {
        text.SetActive(false);  
       }

    }
}

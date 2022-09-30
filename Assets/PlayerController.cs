using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // ###############################################
    //             NAME : KimJaeMin                      
    //             MAIL : woals1566@gmail.com         
    // ###############################################
    [SerializeField]
    private float moveSpeed = 0.5f;
    private float movex;
    private float movez;
    Vector3 movec;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Updatemove();
    }

    private void Updatemove()
    {
       if(Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(-moveSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(+moveSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(0, 0,+moveSpeed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(0, 0,-moveSpeed);
        }
    }

    
}

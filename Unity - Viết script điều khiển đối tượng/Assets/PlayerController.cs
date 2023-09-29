using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform[] targetPos;
    private float moveSpeed = 1.0f;
    private bool dis1Arrive;
    private bool dis2Arrive;
    private bool dis3Arrive;
    
    void Start()
    {
        /*targetPos[0] = new Vector3(21.48f, 0.529f, -0.05305707f);
       
        targetPos[1] = new Vector3(-11.63f, 0.529f, -30.87f);;
        
        targetPos[2] = new Vector3(-18.75f, 0.529f, -0.05305707f);
        */
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dis1 = targetPos[0].position - transform.position;
        Vector3 dis2 = targetPos[1].position - transform.position;
        Vector3 dis3 = targetPos[2].position - transform.position;
        float x = dis1.sqrMagnitude;
        Debug.Log(x);

        if (dis1Arrive == false)
        {
            transform.position += dis1 * Time.deltaTime * moveSpeed;
            if (dis1.sqrMagnitude < 2)
            {
                dis1Arrive = true;
            }
        }


        else if (dis2Arrive == false)
        {
            
            transform.position += dis2 * Time.deltaTime * moveSpeed;

            if(dis2.sqrMagnitude < 2) 
            { 
                dis2Arrive = true;
            }

        }
        else if (dis3Arrive == false)
        {
            
            transform.position += dis3 * Time.deltaTime * moveSpeed;

        }
        
    }
}

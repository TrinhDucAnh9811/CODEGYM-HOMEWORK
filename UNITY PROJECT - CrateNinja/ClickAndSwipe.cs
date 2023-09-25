using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TrailRenderer), typeof(BoxCollider))]

public class NewBehaviourScript : MonoBehaviour
{
    public AudioClip swipeSoundEffect;
    private AudioSource swipeSound; 
    private GameManager gameManager;
    private Camera cam;
    private TrailRenderer trail;
    private BoxCollider col;

    private bool swiping = false;
    private Vector3 mousePos;

    void Awake()
    {
        cam = Camera.main;
        trail = GetComponent<TrailRenderer>();
        col = GetComponent<BoxCollider>();
        trail.enabled = false;
        col.enabled = false;

        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        swipeSound = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (gameManager.isGameActive)
        {
            if (Input.GetMouseButtonDown(0))
            {
                swiping = true;
                UpdateComponents();
            }
            else if (Input.GetMouseButtonUp(0))
            {
                swiping = false;
                UpdateComponents();
                swipeSound.PlayOneShot(swipeSoundEffect, 0.3f); 
            }
            if (swiping)
            {
                UpdateMousePosition();
            }

        }
    }

    private void UpdateMousePosition()
    {
        mousePos = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f)); 
        transform.position = mousePos;
    }

    private void UpdateComponents()
    {
        trail.enabled = swiping;
        col.enabled = swiping;
    }

    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Target>() && !collision.gameObject.CompareTag("Boss1"))
        {
            //Destroy the target (good targets)
            collision.gameObject.GetComponent<Target>().DestroyTarget();
        }
            
        if(collision.gameObject.GetComponent<Target>() && collision.gameObject.CompareTag("Boss1") && gameManager.isBossAlive)
        {
            //Hit Boss 1
            collision.gameObject.GetComponent<Target>().DestroyBoss();
            gameManager.bossHits++;
        }
        
    }
}

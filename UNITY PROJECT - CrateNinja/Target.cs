using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Target : MonoBehaviour
{   
    public Animator screenShake;   
    public ParticleSystem explosionParticle;
    private GameManager gameManager;             
    private Rigidbody targetRb;

    public AudioSource targetAudio;

    //Target characteristic:
    private float minSpeed = 13.0f;
    private float maxSpeed = 16.0f;
    private float maxTorque = 10.0f;
    private float xSpawnPos = 4.0f;
    private float ySpawnPos = -2.0f;

    //Points attach to each target prefab
    public int pointValue;

    

    void Start()
    {
        screenShake = Camera.main.GetComponent<Animator>();  
        gameManager = FindObjectOfType<GameManager>();
        targetAudio = GetComponent<AudioSource>();

        targetRb = GetComponent<Rigidbody>();
        targetRb.AddForce(RandomForce(), ForceMode.Impulse);
        targetRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);
        transform.position = RandomPos();
    }
    private void OnTriggerEnter(Collider other)  //Sensor destroy target out of bounds
    { 
        Destroy(gameObject);
        if(!gameObject.CompareTag("Bad") &&!gameObject.CompareTag("Bonus1") && gameManager.isGameActive)
        {
            gameManager.UpdateLives(1);
            gameManager.PlayTargetSound(0);
        }   
    }
    public void DestroyBoss() 
    {
        if (gameObject.CompareTag("Boss1") && gameManager.isBossAlive == true) 
        {        
            if (gameManager.bossHits >= 20)
            { 
                gameManager.isBossAlive = false;
                gameManager.bossHits = 0;
                Time.timeScale = 1.0f;
                Destroy(gameObject);
                gameManager.PlayTargetSound(3); // Sound of Boss being destroyed
                Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
                gameManager.UpdateScore(pointValue);
                screenShake.SetTrigger("shake");
                
            }
        }
    }
    public void DestroyTarget() 
    {
        if (gameManager.isGameActive)
        {
            Destroy(gameObject);
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
            gameManager.UpdateScore(pointValue);
            screenShake.SetTrigger("shake");

            if (gameObject.CompareTag("Good"))
            {
                gameManager.PlayTargetSound(4);
            }

            if (gameObject.CompareTag("Bad"))
            {
                gameManager.PlayTargetSound(7);
            }


            if (gameObject.CompareTag("Bonus1"))
            {
                Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
                gameManager.TimeSlowed();
                screenShake.SetTrigger("shake");
                gameManager.PlayTargetSound(5); //Sound of  Bonus 1 destroyed

            }

            if(gameObject.CompareTag("Bonus2")) 
            {
                Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation); 
                gameManager.Lightning();
                screenShake.SetTrigger("shake");
                gameManager.PlayTargetSound(5); //Sound of  Bonus 2 destroyed
            } 

        }
    }

    private Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }

    private float RandomTorque()
    {
        return Random.Range(-maxTorque, maxTorque);
    }

    private Vector3 RandomPos()
    {
        return new Vector3(Random.Range(-xSpawnPos, xSpawnPos), ySpawnPos);
    }
}

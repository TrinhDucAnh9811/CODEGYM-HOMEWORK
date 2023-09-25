using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<AudioClip> targetSounds;
    public List<GameObject> targets;
    private DifficultButton difficultButton;

    private Target target;
    private AudioSource audioSource;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI gameoverText;
    public TextMeshProUGUI livesText;

    public Button restartButton;
    public GameObject titleButton;
    public GameObject pauseScreen;
    public GameObject restartScreen;
    public GameObject volumeScreen;
    public GameObject whiteBackGround;
    

    public int score;
    private int highScore = 0;
    public int lives;
    private float spawnRate = 2.0f;
    public bool isGameActive;
    private bool paused;
    public int pausedTime;
    public int crateWaves = 0;
    public int bonusInterval1 = 0;
    public int bonusInterval2 = 0;
    public int bossInterval = 0;

    //BONUS1: Slow Motion variables:
    public bool isSlowMotion;
    private float slowDuration = 5.0f;
    private float slowTimer = 0;

    //BOBUS2: Lightning destoy everything:
    public bool isLightning;
    private float lightDuration = 8.0f;
    private float lightTimer = 0;

    //BOSS1: 
    public int bossHits = 0;
    public bool isBossAlive;
    private float bossDuration = 15.0f;
    private float bossTimer = 0;

    //Combo point:
    public int comboCount =0;
    public float comboTimer = 0;
    private float comboTimeout = 1.5f; //Time between combo

    private void Start()
    {
        if(PlayerPrefs.HasKey("HighScore"))
        {
            highScore = PlayerPrefs.GetInt("HighScore");
        }
        highScoreText.text = "High Score: " + highScore.ToString();

        target = FindObjectOfType<Target>();
        audioSource = GetComponent<AudioSource>();
        difficultButton = FindObjectOfType<DifficultButton>();
    }

    public void PlayTargetSound(int soundIndex) 
    {
        for(int i =0; i< targetSounds.Count; i++) 
        {
            if (soundIndex == i)
            {
                audioSource.PlayOneShot(targetSounds[soundIndex], 1.0f);
            } 
        }
    }
    
    private void Update()
    {
        //Combo Counter: link to method UpdatePoint:
        comboTimer += Time.deltaTime;  
        if (comboTimer >= comboTimeout)  //Reset every 3s to perform combo point counter
        {
            comboCount = 0;
            comboTimer = 0;
        }


        //BONUS - Slow Motion Action:
        if (isSlowMotion)
        {
            audioSource.pitch = 0.8f;  
            Time.timeScale = 0.3f;
            Time.fixedDeltaTime = Time.timeScale * 0.01f; //without this code, game will be lag when slow motion
            
            slowTimer += Time.unscaledDeltaTime; 
            if(slowTimer >= slowDuration)
            {
                Time.timeScale = 1.0f;
                isSlowMotion = false;
                slowTimer = 0;
                audioSource.pitch = 1.0f; 
            }
        }

        //BONUS2 - Lightning destroy everything:
        if(isLightning)
        {
            DestroyEveryThing();
            isLightning = false;
            lightTimer = 0;
            
        }

        //BOSS1:EYE BALL:
        if(isBossAlive)
        {
            /*PlayTargetSound(2);*/ //Sound of Boss Fight Appear
            StartCoroutine(WaitForSpawnBoss());
            Time.timeScale = 0.05f;
            audioSource.pitch = 0.8f;  
            Time.fixedDeltaTime = Time.timeScale * 0.01f; 
            bossTimer += Time.unscaledDeltaTime; 

            if (bossTimer >= bossDuration || isBossAlive ==false)
            {
                Time.timeScale = 1.0f;
                isBossAlive = false;
                bossTimer = 0;
                audioSource.pitch = 1.0f;  
            }
        }

        //Pause:
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            CheckForPaused();
        }
        
    }

    public void StartGame(int difficulty)
    {
        spawnRate /= difficulty;
        titleButton.gameObject.SetActive(false);
        isGameActive = true;
        StartCoroutine(SpawnTarget());
        //Score initial:
        score = 0;
        UpdateScore(0);
        //Lives initial:
        lives = 5;
        UpdateLives(0);

        //Set off White BackGround:
        whiteBackGround.gameObject.SetActive(false);    
    }

    public void CheckForPaused()
    {
     if(!paused)
        {
            paused = true;
            pauseScreen.SetActive(true);
            restartScreen.SetActive(true);
            volumeScreen.SetActive(true);
            Time.timeScale = 0;
        }
     else
        {
            paused = false; 
            pauseScreen.SetActive(false);
            restartScreen.SetActive(false);
            volumeScreen.SetActive(false);
            Time.timeScale = 1;
        }
    }

    //Wair for boss appear in the middle of the screen:
    IEnumerator WaitForSpawnBoss()
    {
        yield return new WaitForSeconds(3.0f);
    }
    IEnumerator SpawnTarget() 
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int Index = Random.Range(0, targets.Count - 3); //Normal propotion
            int[] highRateIndex = { 2, 3, 4 }; //Ratio of good stuff aapear
            if (Random.Range(0, targets.Count - 3) < 6)
            {
                int highIndex = Random.Range(2, 5);
                Instantiate(targets[highIndex]);
            }
            else
            { Instantiate(targets[Index]); }
            PlayTargetSound(6); 
           
            

            crateWaves++;
            
            if(crateWaves >= 6) 
            {
                yield return new WaitForSeconds(1);
                Index = Random.Range(0, targets.Count - 3);
                Instantiate(targets[Index]);
                PlayTargetSound(6); //SSSSSS Spawn things
                Instantiate(targets[Index]);
                PlayTargetSound(6); //SSSSSS Spawn things
                Instantiate(targets[Index]);
                PlayTargetSound(6); //SSSSSS Spawn things
                Instantiate(targets[Index]);
                PlayTargetSound(6); //SSSSSS Spawn things

                crateWaves = 0;
            }

            //Spawn Bonus 1:appear after 10 spawn times
            
            bonusInterval1++;
            if(bonusInterval1 >= 10)
            {
                Instantiate(targets[5]);
                bonusInterval1 = 0;
                PlayTargetSound(6); 
            }

            //Spawn Bonus 2 after 20 spawn times
            bonusInterval2++;
            if (bonusInterval2 >= 20)
            {
                Instantiate(targets[6]);
                bonusInterval2 = 0;
                PlayTargetSound(6);
            }

            //Spawn Boss after 50 rounds
            bossInterval++;
            if (bossInterval >= 50)
            {
                Instantiate(targets[7]);
                bossInterval = 0;
                isBossAlive = true;
                PlayTargetSound(2); 
            }
        }
    }

    public void UpdateLives(int livesToMinus)
    {
        lives -= livesToMinus;      
        livesText.text = "Lives: " + lives.ToString();
        if(lives <= 0)
        {
            GameOver();
        }
        
    }
    public void UpdateScore(int scoreToAdd)
    {
        comboCount++;
        if (comboCount >= 3 && comboTimer < comboTimeout)
        {
            scoreToAdd += comboCount * 20;
            
        }
        score += scoreToAdd;
        scoreText.text = "Score: " + score;

        if(score > highScore)
        {
            highScore = score;
            highScoreText.text = "High Score: " + highScore.ToString();
            PlayerPrefs.SetInt("HighScore", highScore);
        }
    }

    public void GameOver()
    {
       
        gameoverText.gameObject.SetActive(true);
        isGameActive = false;
        restartButton.gameObject.SetActive(true);

        
    }

    public void RestartGame()
    {
      
        difficultButton.SetDifficulty();
        Time.timeScale = 1.0f;
        isSlowMotion = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    //BONUS 1:
    public void TimeSlowed()  //Link to update and Target.cs()
    {
        isSlowMotion = true;
    }

    //BONUS2: 
    public void Lightning() //Link to update and Target.cs()
    {
        isLightning = true;
    }
    public void DestroyEveryThing()
    {
        GameObject[] goodCrates = GameObject.FindGameObjectsWithTag("Good");
        foreach(GameObject goodCrate in goodCrates)
        {
            Destroy(goodCrate);
        }
    }


}

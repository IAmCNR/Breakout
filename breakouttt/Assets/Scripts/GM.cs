using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GM : MonoBehaviour
{
    public int lives;
    public int bricks;
    public float resetDelay;
    public float timeSlow;
    public Text livesText;
    public GameObject gameOver;
    public GameObject youWon;
    public GameObject bricksPrefab;
    public GameObject paddle;
    public GameObject deathParticles;
    public static GM instance = null;

    private GameObject clonePaddle;
    

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void Setup()
    {
        clonePaddle = Instantiate(paddle, transform.position, Quaternion.identity) as GameObject;
        Instantiate(bricksPrefab, transform.position, Quaternion.identity);
    }

    void CheckGameOver()
    {
        if (bricks < 1)
        {
            youWon.SetActive(true);
            Time.timeScale = timeSlow;
            Invoke("Reset", resetDelay);
        }

        if (lives < 1)
        {
            gameOver.SetActive(true);
            Time.timeScale = timeSlow;
            Invoke("Reset", resetDelay);
        }
    }

    void Reset()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoseLife()
    {
        lives--;
        livesText.text = "Lives = " + lives;
        Instantiate(deathParticles, clonePaddle.transform.position, Quaternion.identity);
        Destroy(clonePaddle);
        Invoke("SetupPaddle", resetDelay);
        CheckGameOver();
    }

    void SetupPaddle()
    {
        clonePaddle = Instantiate(paddle, transform.position, Quaternion.identity) as GameObject;
    }

   public void DestroyBrick()
    {
        bricks--;
        CheckGameOver();
    }
}

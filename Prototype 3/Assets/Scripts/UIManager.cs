using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;
    public Image backgroundImage;
    private PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        FinishGame();
        scoreText.text = "Score: " + score;
    }

    void FinishGame()
    {
        if (playerController.gameOver == true)
        {
            backgroundImage.gameObject.SetActive(true);
        }
        else
        {
            score += 1;
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Prototype 3");
    }

    
}

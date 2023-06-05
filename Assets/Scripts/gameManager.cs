using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    private float PlayerLightIntensity;
    [SerializeField] LightHead lightHead;
    [SerializeField] GameObject player;
    [SerializeField] GameObject gameOverUI;
    void Start()
    {
        gameOverUI.SetActive(false);
        Time.timeScale = 1f;

    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y < -10)
        {
            Time.timeScale = 0;
            gameOverUI.SetActive(true);            
        } 
                
    }
    public void Reset()
    {
        SceneManager.LoadScene(0);
        gameOverUI.SetActive(false);
        Time.timeScale = 1;
    }
}

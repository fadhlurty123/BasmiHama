using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class score : MonoBehaviour
{
    public Text scoreText;
    public float scoreAmount;
    public float scoreDecreasedPerSecond;
    // Use this for initialization
    void Start() {
        scoreAmount = 100f;
        scoreDecreasedPerSecond = 1f;
    }
    // Update is called once per frame
    void Update()
    {
        if (scoreAmount > 0)
        {
            scoreText.text = "Waktu Tersisa " + (int)scoreAmount;
            scoreAmount -= scoreDecreasedPerSecond * Time.deltaTime;
        }
        else
            SceneManager.LoadScene("EndScene");
    }


}
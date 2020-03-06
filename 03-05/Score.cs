using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ui;

public class Score : MonoBehaviour
{
  public static int scoreAmount;
  private Text scoreText;

  public void Start()
  {
    scoreText = GetComponent<Text>();
    scoreAmount = 0;
  }

  public void Update()
  {
    scoreText.text = "Score: " + scoreAmount;
  }
}
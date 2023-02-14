using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Logic : MonoBehaviour
{
    private int score = 0;
    [SerializeField] Text score_text;
    public void addScore()
    {
        score++;
        score_text.text = score.ToString();
    }
}

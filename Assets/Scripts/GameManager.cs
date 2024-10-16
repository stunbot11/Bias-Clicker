using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("canvas refrences")]
    public TMP_Text pointsTXT;

    [Header("Point data")]
    public int points;

    //clicks
    public int basePointsPerClick;
    public int pointsPerClick;

    //auto
    public int basePointsPerSecond;
    public int pointsPerSecond;

    [Header("upgraders")]
    public int upgrader1;
    public int upgrader2;
    public int upgrader3;
    public int upgrader4;
    public int upgrader5;
    public int upgrader6;
    public int upgrader7;
    public int upgrader8;
    public int upgrader9;
    public int upgrader10;


    private void Start()
    {
        StartCoroutine(Gain_Points_Per_Second());
    }


    IEnumerator Gain_Points_Per_Second()
    {
        yield return new WaitForSeconds(1);
        pointsPerSecond = basePointsPerSecond + upgrader1 + upgrader3 + upgrader5 + upgrader7 + upgrader9;
        points += pointsPerSecond;
        update_Points();
        StartCoroutine(Gain_Points_Per_Second());
    }

    public void clicked()
    {
        pointsPerClick = basePointsPerClick + upgrader2 + upgrader4 + upgrader6 + upgrader8 + upgrader10;
        points += pointsPerClick;
        update_Points();
    }

    public void update_Points()
    {
        pointsTXT.text = "Points: " + points;
    }

    public void Quit()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class Upgrade_Clicks : MonoBehaviour
{
    private bool unlocked;
    public int basePoints;
    public int flatBonus;
    public int flatBounusIncrease;
    public int mult;
    public int multIncrease;
    public int total;
    public int level;
    public int price;
    public int[] superUpgrades;
    public int count;
    public TMP_Text priceTXT;
    public TMP_Text moneyViewer;
    public TMP_Text levelTXT;

    public void Start()
    {
        priceTXT.text = "Price: " + price;
        moneyViewer.text = "Clicks per second: " + total;
        levelTXT.text = "Level: " + level;
    }

    public void Unlock(GameManager Gm)
    {
        if (Gm.points >= price)
        {
            Gm.points -= price;
            price = Mathf.RoundToInt((price * 2 + 5) / 1.5f);
            if (!unlocked)
            {
                unlocked = true;
                level = 1;
                total += basePoints;
            }
            else
                Upgrade();
            Gm.update_Points();
            total = basePoints + (flatBonus * mult);
            priceTXT.text = "Price: " + price;
            moneyViewer.text = "Clicks per second: " + total;
            levelTXT.text = "Level: " + level;
            AddToGameManager(Gm);
        }
    }

    public virtual void Upgrade()
    {

    }

    public virtual void AddToGameManager(GameManager gameManager)
    {

    }
}

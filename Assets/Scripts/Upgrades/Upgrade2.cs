using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade2 : Upgrade_Clicks
{
    public override void Upgrade()
    {
        base.Upgrade();
        level++;
        /*
        if ((level % 100) == 0)
        {
            mult += multIncrease * ((level / 100) + 1);
            flatBounusIncrease *= 4;
        }
        else if ((level % 25) == 0)
        {
            mult += multIncrease;
            flatBounusIncrease *= 2;
        }
        */
        if (level == 25)
        {
            print("it worked");
        }
        else
        {
            flatBonus += flatBounusIncrease;
        }
    }

    public override void AddToGameManager(GameManager gameManager)
    {
        base.AddToGameManager(gameManager);
        gameManager.upgrader2 = total;
    }
}

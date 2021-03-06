﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowBalloon : MonoBehaviour, Collectable
{
    public void collide()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player.GetComponent<PlayerController>().balloons.Count <= 3)
        {
            player.GetComponent<PlayerController>().balloons.Add("Yellow");
            player.GetComponent<PlayerController>().AdjustBalloons();
        }
        Destroy(gameObject);
    }
}

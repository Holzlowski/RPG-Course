﻿using RPG.Stats;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace RPG.Attributes
{
    public class LevelDisplay : MonoBehaviour
    {
        BaseStats baseStats;

        private void Awake()
        {
            baseStats = GameObject.FindGameObjectWithTag("Player").GetComponent<BaseStats>();
        }

        private void Update()
        {
            GetComponent<Text>().text = String.Format("{0:0}", baseStats.CalculateLevel());
        }
    }
}



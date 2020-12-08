﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    public Slider slider;

    public int maxhealth;
    public int health;

    // Start is called before the first frame update
    void Start()
    {
        health = maxhealth;
        slider.value = maxhealth;
    }

    public void IncreaseHealth()
    {
        health++;
        UpdateHealth(health);
    }

    public void DecreaseHealth()
    {
        health--;
        UpdateHealth(health);
    }

    public void UpdateHealth(int health)
    {
        slider.value = health;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}

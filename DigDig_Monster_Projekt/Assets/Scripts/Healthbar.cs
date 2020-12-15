using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    public Slider slider;

    public int maxhealth;
    public int health;
    public Image monsterImage;
    public Sprite defaultMonster;
    public Sprite damagedMonster;
    public GameObject monster;

    
    // Start is called before the first frame update
    void Start()
    {
        health = maxhealth;
        slider.value = maxhealth;
    }

    public void IncreaseHealth()
    {
        if (health < maxhealth)
        {
            health++;
            UpdateHealth(health);
        }
    }

    public void DecreaseHealth()
    {
        health--;
        UpdateHealth(health);
        if (health <= 0)
        {
            Destroy(monster);
            Destroy(gameObject);
        }
    }

    public void UpdateHealth(int health)
    {
        slider.value = health;


        if (health <= maxhealth/2)
        {
            monsterImage.sprite = damagedMonster;
        }
        else
        {
            monsterImage.sprite = defaultMonster;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}

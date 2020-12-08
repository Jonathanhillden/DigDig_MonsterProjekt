using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damagebutton : MonoBehaviour
{

    public Healthbar healthbar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPress()
    {
        healthbar.health--;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class Armor_pickup : MonoBehaviour
{
    // Start is called before the first frame update

    //[SerializeField] private int _armoramount = 0;
    //[SerializeField] private PlayerAddOns _playerscript;
    [SerializeField] private int _armorAdditionAmount = 10;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            //_playerscript.currentHealth += _armorAdditionAmount;
            FindObjectOfType<PlayerAddOns>().GetComponent<PlayerAddOns>().playerHealth.IncreaseHealth(_armorAdditionAmount);
            Destroy((this.gameObject));
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRed : Item
{
    private void OnTriggerEnter2D(Collider2D other) //Polymorphism - unique red feature
    {
        if (other.gameObject.CompareTag("Player"))
        {
            var player = other.gameObject.GetComponent<Player>();
            player.LowerHealth(20); //Polymorphism, overriden method to restore health
            Destroy(gameObject);
        }
    }
}

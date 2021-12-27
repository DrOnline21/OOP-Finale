using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBlue : Item
{
    private Rigidbody2D itemRbB;
    private void Start()
    {
        SetItemGravity();
    }

    protected override void SetItemGravity()
    {
        itemRbB = GetComponent<Rigidbody2D>(); ;
        itemRbB.gravityScale = 1.5f; ;
    }

    private void OnTriggerEnter2D(Collider2D other) //Polymorphism - unique blue feature
    {
        if (other.gameObject.CompareTag("Player"))
        {
            var player = other.gameObject.GetComponent<Player>();
            player.RestoreHealth(20); //Polymorphism, overriden method to restore health
            Destroy(gameObject);
        }
    }
}

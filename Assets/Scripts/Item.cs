using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public Rigidbody2D itemRb;
    private readonly float itemGravityDefault = 1;
    public float itemGravity { get; private set; } = 1;

    private void Start()
    {
         
        SetItemGravity();
    }

    protected virtual void SetItemGravity()
    {
        itemRb = GetComponent<Rigidbody2D>();
        itemRb.gravityScale = itemGravityDefault;
    }

}

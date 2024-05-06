using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit
{
    private int health;
    private int size;
    private bool hostile;
    private Vector2 location;

    public Unit(int initHealth, int initSize, bool initHostile = true) //location not set due to both clunkyness and the desire to randomly set locations
    {
        health  = initHealth;
        size = initSize;
        hostile = initHostile;
    }


    //---Getters---//
    public Vector2 GetLocation()
    {
        return location;
    }
    public int GetHealth()
    {
        return health;
    }
    public bool IsAlive()
    {
        return health > 0;
    }
    public bool IsHostile()
    {
        return hostile;
    }
    public int GetSize()
    {
        return size;
    }


    //---"Setters"---//
    public void SetLocation(int x, int y)
    {
        location = new Vector2(x, y);
    }
    public void Damage()
    {
        health -= 1;
    }
    
}

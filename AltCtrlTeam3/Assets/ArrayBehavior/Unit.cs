using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

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
    public bool IsHit(int x, int y)
    {
        int xOffset = x - (int)location.x;
        int yOffset = y - (int)location.y; //not as efficient but easier to read this way
        if (xOffset < size && xOffset >= 0 && yOffset < size && yOffset >= 0)
        {
            return true;
        }
        else return false;
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

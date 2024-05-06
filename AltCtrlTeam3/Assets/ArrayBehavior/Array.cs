using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{

    [Header("FOR DEBUGGING ONLY, please do not mess with this unless you know what you are doing.")]
    [SerializeField] private int[] PlayingField = {
        0, 0, 0, 0, 0, 0, 0,
        0, 0, 0, 0, 0, 0, 0,
        0, 0, 0, 0, 0, 0, 0,
        0, 0, 0, 0, 0, 0, 0,
        0, 0, 0, 0, 0, 0, 0,
        0, 0, 0, 0, 0, 0, 0,
        0, 0, 0, 0, 0, 0, 0
    };
    public int GetValue(int x, int y)
    {
        return PlayingField[(x - 1) + (7 - y) * 7];  //visually returns the x,y coordinates from the graph above
    }

    public void SetValue(int x, int y, int value)
    {
        PlayingField[(x - 1) + (7 - y) * 7] = value;
    }

    public int[] GetPlayingField()
    {
        return PlayingField;
    }
}

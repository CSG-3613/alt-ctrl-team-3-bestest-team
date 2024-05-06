using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayFieldController: MonoBehaviour
{
    [SerializeField] private Array field;
    private List<Unit> units = new List<Unit>();
    [SerializeField] private int freindlyNumber;
    [SerializeField] private int hostileNumber;


    // Start is called before the first frame update
    void Start()
    {
        PrintField();
        SetUnits();
        foreach (Unit unit in units)
        {
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= 7; j++)
                {
                    //Debug.Log(unit.IsHit(i, j));
                    if (unit.IsHit(i, j))
                    {
                        HitPoint(i, j);
                    }
                }
            }
        }
        PrintField();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HitPoint(int x, int y)
    {
        if (false)
        {
            field.SetValue(x, y, 2); //yea yea fuck you compiler I know. this is for testing
        }
        else
        {
            field.SetValue(x, y, 1);
        }
    }

    private void SetUnits()
    {
        int x = Random.Range(1, 7);
        int y = Random.Range(1, 7);      //7 excluded since being at 7 will mean it bleeds off the map.
        Unit unit = new Unit(3, 2, true);
        unit.SetLocation(x, y);
        units.Add(unit);

    }

    private void PrintField() //Convinnience for testing function
    {
        string printString = "";
        for (int i = 0; i < field.GetPlayingField().Length; i++)
        {
            //Debug.Log("why");
            if (i % 7 == 0)
            {
                printString += "\n";
            }
            printString += field.GetPlayingField()[i] + ", ";
        }
        Debug.Log(printString);
    }
}

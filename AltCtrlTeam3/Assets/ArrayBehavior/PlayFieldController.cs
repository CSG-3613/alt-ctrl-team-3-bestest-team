using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class PlayFieldController: MonoBehaviour
{
    [SerializeField] private Array field;
    private List<Unit> units = new List<Unit>();
    [SerializeField] private int freindlyNumber;
    [SerializeField] private int hostileNumber;
    public int score = 0;
    public int scoreNegative;
    public bool WinCondition = false;


    // Start is called before the first frame update
    void Start()
    {
        SetUnits();
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    /*
     * return key:
     * 0 = unit already dead
     * 1 = miss
     * 2 = hit
     * 3 = hostile down
     * 4 = friendly hit
     * 5 = friendly down
     * 6 = all hostiles down you win
    */
    public int HitPoint(int x, int y)
    {
        bool isHit = false;
        Unit unitHit = null;
        foreach (Unit unit in units)
        {
            //Debug.Log(unit.IsHit(i, j));
            if (unit.IsHit(x, y))
            {
                unitHit = unit;
                isHit = true;
                break;
            }
        }
        if (isHit)
        {
            Debug.Log("hi");
            if (unitHit.IsAlive())
            {
                field.SetValue(x, y, 2);
                unitHit.Damage();
                if (!unitHit.IsAlive())
                {
                    field.SetValue((int)unitHit.GetLocation().x,        (int)unitHit.GetLocation().y,       2);
                    field.SetValue((int)unitHit.GetLocation().x + 1,    (int)unitHit.GetLocation().y,       2);
                    field.SetValue((int)unitHit.GetLocation().x,        (int)unitHit.GetLocation().y + 1,   2);
                    field.SetValue((int)unitHit.GetLocation().x + 1,    (int)unitHit.GetLocation().y + 1,   2);
                    if (unitHit.IsHostile())
                    {
                        score++;
                        if (score >= 3)
                        {
                            WinCondition = true;
                            return 6;
                        }
                        else return 3;
                    }
                    else
                    {
                        scoreNegative++;
                        return 5;
                    }
                }
                if (!unitHit.IsHostile()) return 2;
                else return 4;

            }
            return 0;
        }
        else
        {
            field.SetValue(x, y, 1);
            return 1;
        }
    }

    private void SetUnits()
    {
        Unit unit = new Unit(3, 2, true);
        unit.SetLocation(1, 2 );
        units.Add(unit);

        Unit unit2 = new Unit(3, 2, true);
        unit2.SetLocation(6, 2);
        units.Add(unit2);

        Unit unit3 = new Unit(3, 2, true);
        unit3.SetLocation(3, 3);
        units.Add(unit3);

        Unit unit4 = new Unit(2, 2, false);
        unit4.SetLocation(4, 6);
        units.Add(unit4);

        Unit unit5 = new Unit(2, 2, false);
        unit5.SetLocation(6, 6);
        units.Add(unit5);
    }

    public void PrintField() //Convinnience for testing function
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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayFieldController: MonoBehaviour
{
    public Array field;

    // Start is called before the first frame update
    void Start()
    {
        PrintField();
        HitPoint(4, 3);
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
            field.SetValue(x, y, 2);
        }
        else
        {
            field.SetValue(x, y, 1);
        }
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

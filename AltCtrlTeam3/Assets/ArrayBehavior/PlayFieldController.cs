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
        field.SetValue(7, 7, 1);
        PrintField();
        field.SetValue(1, 1, 1);
        field.SetValue(3, 5, 1);
        field.SetValue(7, 1, 1);
        PrintField();
    }

    // Update is called once per frame
    void Update()
    {
        
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

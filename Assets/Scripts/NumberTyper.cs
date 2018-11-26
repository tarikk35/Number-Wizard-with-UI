using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberTyper : MonoBehaviour
{

    private static int min=0, max=0;

    public static int Min
    {
        get
        {
            return min;
        }
        set
        {
            min = value;
        }
    }

    public static int Max
    {
        get
        {
            return max;
        }
        set
        {
            max = value;
        }
    }

    bool minSelected =false;
    NumberChecker numberCheck;

    private void Awake()
    {
        Min = 0;
        Max = 0;
    }

    [SerializeField] TextMeshProUGUI minText;
    [SerializeField] TextMeshProUGUI maxText;
    [SerializeField] TextMeshProUGUI infoText;

    public void TypeMin()
    {
        minSelected = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
        {
            TypeKey(minSelected);
        }
    }

    public void TypeMax()
    {
        minSelected = false;
    }

    public void CheckNumbersAndLoad()
    {
        numberCheck = new NumberChecker();
        numberCheck.CheckMinAndMax(min, max,infoText);
    }

    void TypeKey(bool isMin)
    {
        string key = Input.inputString;
        int x;
        bool isNumeric = int.TryParse(key, out x);

        if ((isNumeric || key == "\b") && isMin)
        {
            min = UpdateNumber(min, key);
            minText.text = min.ToString();
        }

        else if ((isNumeric||key=="\b") && !isMin)
        {
            max = UpdateNumber(max, key);
            maxText.text = max.ToString();
        }
    }

    int UpdateNumber(int number,string key)
    {
        if(key=="\b")
        {
            number /= 10;
        }

        else
        {
            string tempNumber = number.ToString();
            tempNumber += key;
            number = int.Parse(tempNumber);
        }
       
        return number;
    }

    void RestartNumbers()
    {
        max = 0;
        min =0 ;
    }
}



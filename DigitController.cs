using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DigitController : MonoBehaviour
{
    public int digit = 0;


    // Start is called before the first frame update
    void Start()
    {
        digit=0;
        updateDisplayText();
    }

    void updateDisplayText()
    {
        this.transform.parent.GetComponentInChildren<TMPro.TextMeshPro>().text = digit.ToString();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AdvanceNumber()
    {
        digit++;
        if (digit > 9)
        {
            digit = 0;
        }

        updateDisplayText();

    }

    public void setDigit(int _digit){
        digit=_digit;
        updateDisplayText();
    }
}

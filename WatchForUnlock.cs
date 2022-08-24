using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Utilities;

public class WatchForUnlock : MonoBehaviour
{
    public GameObject lock1;
    public GameObject lock2;
    public GameObject lock3;
    public GameObject safeDoor;
    public int lock1Solution;
    public int lock2Solution;
    public int lock3Solution;

    private DigitController lock1DC;
    private DigitController lock2DC;
    private DigitController lock3DC;

    public Material successMaterial;

    public GameObject leftController;
    public GameObject rightController;

    // Start is called before the first frame update
    void Start()
    {
        lock1DC = lock1.GetComponentInChildren<DigitController>();
        lock2DC = lock2.GetComponentInChildren<DigitController>();
        lock3DC = lock3.GetComponentInChildren<DigitController>();
    }

    // Update is called once per frame
    public void tryToUnlock()
    {
        int digit1 = lock1DC.digit;
        int digit2 = lock2DC.digit;
        int digit3 = lock3DC.digit;

        if (digit1 == lock1Solution && digit2 == lock2Solution && digit3 == lock3Solution)
        {
            Debug.Log("Safe has been unlocked");
            safeDoor.SetActive(false); //hide the door

            //this.transform.parent.GetComponentInChildren<TextMesh>().text="Success";
            this.transform.parent.GetComponentInChildren<TMPro.TextMeshPro>().text="Success";
            this.GetComponent<Renderer>().material=this.successMaterial;
        }
        else
        {
            Debug.Log("Failed to unlock safe!");

            lock1DC.setDigit(0);
            lock2DC.setDigit(0);
            lock3DC.setDigit(0);
        }
    }
}

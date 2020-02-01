using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowEnding : MonoBehaviour
{

    public Text winText;

    public enum Ending
    {
        Win, WrongPlace, NotCompleted
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (ending == Ending.Win)
        {
            winText.text = "You win!";
        } 
        else if (ending == Ending.NotCompleted)
        {
            winText.text = "You got to the wrong place!";
        }
        else if (ending == Ending.WrongPlace)
        {
            winText.text = "You not completed your road!";
        }
    }

    public Ending ending;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

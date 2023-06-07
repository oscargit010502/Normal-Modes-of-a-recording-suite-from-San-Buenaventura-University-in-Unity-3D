using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonsManager : MonoBehaviour
{
    public Text displayText;

    public Image img42Hz;
 
    public void Button42Hz()
    {
        displayText.text = "42 Hz";
        img42Hz.gameObject.SetActive(true);
    }    
    public void Button55_3Hz()
    {
        displayText.text = "55.3 Hz";

    }
    public void Button63Hz()
    {
        displayText.text = "63 Hz";
    }

    public void Button68_9Hz()
    {
        displayText.text = "69 Hz";
    }
    public void Button82_98Hz()
    {
        displayText.text = "83 Hz";
    }

    public void Button98_5Hz()
    {
        displayText.text = "98.5 Hz";
    }

    public void Button104Hz()
    {
        displayText.text = "104 Hz";
    }

    public void Button110Hz()
    {
        displayText.text = "110 Hz";
    }
    public void Button115Hz()
    {
        displayText.text = "115 Hz";
    }

    public void Button126Hz()
    {
        displayText.text = "126 Hz";
    }

    public void Button138Hz()
    {
        displayText.text = "138 Hz";
    }

    public void ButtonStop()
    {
        displayText.text = "...";
    }

}
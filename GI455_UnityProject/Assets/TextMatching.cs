using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextMatching : MonoBehaviour
{
    public InputField input;
    public GameObject result;

    string Steam = "Steam";
    string Ubisoft = "Ubisoft";
    string Origin = "Origin";
    string Epic = "Epic";
    string Blizzard = "Blizzard";

    public void Matching()
    {
        if (input.text == "Steam")
        {
            result.GetComponent<Text>().text = "[ " + Steam + " ] is found.";
        }
        else if (input.text == "Ubisoft")
        {
            result.GetComponent<Text>().text = "[ " + Ubisoft + " ] is found.";
        }
        else if (input.text == "Origin")
        {
            result.GetComponent<Text>().text = "[ " + Origin + " ] is found.";
        }
        else if (input.text == "Epic")
        {
            result.GetComponent<Text>().text = "[ " + Epic + " ] is found.";
        }
        else if (input.text == "Blizzard")
        {
            result.GetComponent<Text>().text = "[ " + Blizzard + " ] is found.";
        }
        else
        {
            result.GetComponent<Text>().text = "[ " + input.text + " ] is not found.";
        }
    }
}

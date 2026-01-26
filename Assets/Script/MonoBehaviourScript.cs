using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

public class NameScript: MonoBehaviour
{
    private string text;
    private string[] input = {"Sveiks","Jauku dienu","Prieks tevi redzet","Uzredzesanos","Jauki, ka atnaci","Tiksimies rit"};
    private int rand;
    public GameObject inputField;
    public GameObject textField;

    public GameObject GetTextField()
    {
        return textField;
    }

    public void getText()
    {
        rand = Random.Range(0, input.Length);
        text = inputField.GetComponent<TMP_InputField>().text;
textField.GetComponent<TMP_Text>().text = input[rand] + " " + text + "!";

    }
}

using Unity.Burst;
using UnityEngine;
using UnityEngine.UI;


public class TogleScript : MonoBehaviour
{
    public GameObject bean;
    public GameObject teddy;
    public GameObject car;
    public GameObject granny;
    public GameObject toggleLeft;
    public GameObject toggleRight;

    public void toggleBean(bool value)
    {
        bean.SetActive(value);
        toggleLeft.GetComponent<Toggle>().interactable = value;
        toggleRight.GetComponent<Toggle>().interactable = value;
    }
    public void ToLeft()
    {
        bean.transform.localScale = new Vector2(1, 1);  
    }

    public void ToRught()
    {
        bean.transform.localScale = new Vector2(-1, 1);
    }
    public void toggleTeddy(bool value)
    {
        teddy.SetActive(value);
    }
    public void toggleCar(bool value)
    {
        car.SetActive(value);
        }
    public void toggleGranny(bool value)
    {
    granny.SetActive(value);
    }
    
       
    

}


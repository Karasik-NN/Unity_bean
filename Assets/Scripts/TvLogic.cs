using UnityEngine;

public class TvLogic : MonoBehaviour 
{
   
    public void ChangeVolume(float value) 
    {
        AudioListener.volume = value;

    }
    public GameObject channel1; 
    public GameObject channel2; 

    
    public void ChangeChannel(int index) 
    {
        if (index == 0) 
        {
            channel1.SetActive(true);
            channel2.SetActive(false);
            
        }
        else if (index == 1) 
        {
            channel1.SetActive(false);
            channel2.SetActive(true);
           
        }
    }
}
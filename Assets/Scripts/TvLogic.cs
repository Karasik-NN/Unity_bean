using UnityEngine;
using UnityEngine.UI;

public class TvLogic : MonoBehaviour {
  
    public AudioSource[] characterSounds;

    
    public void ChangeVolume(float volume) {
        foreach (AudioSource source in characterSounds) {
            source.volume = volume;
        }
    }
}
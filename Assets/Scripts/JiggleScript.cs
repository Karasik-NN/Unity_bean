using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [Range(0f, 1f)]
    public float power = 0.5f;

    [Header("Position Jiggler")]
    public bool jigglePosition = true;
    public Vector2 positionJigAmount;
    [Range(0f, 100f)]
    public float positionFrequency = 10f;
    float positionTimer;


    //Turpinasim
    private void Start()
    {
        
    }
}

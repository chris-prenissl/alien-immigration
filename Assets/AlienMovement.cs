using UnityEngine;

public class AlienMovement : MonoBehaviour
{
    [SerializeField] private Animation _Animation;


    private void Start()
    {
        _Animation = GetComponent<Animation>();
    }

    public void Appear()
    {
        _Animation.Play("AlienUIAppearing");
    }
    
    public void Idle()
    {
        _Animation.Play("AlienIdle");
    }
    
    public void DisAppearBack()
    {
        _Animation.Play("AlienUIDisappearingBack");
    }
 
    public void DisAppearIn()
    {
        _Animation.Play("AlienUIDisappearingIn");
    }
}

using UnityEngine;
using UnityEngine.UI;

public class AlienMovement : MonoBehaviour
{

   private Image _sprite;

   public void SetSprite(Sprite sprite)
   {
      _sprite.sprite = sprite;
   }
}

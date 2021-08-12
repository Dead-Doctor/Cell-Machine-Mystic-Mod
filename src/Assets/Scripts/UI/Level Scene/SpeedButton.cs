using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedButton : MonoBehaviour
{
    public Sprite slowSprite;
    public Sprite normalSprite;
    public Sprite fastSprite;
    public Image image;

    private float slowSpeed = 1f;
    private float normalSpeed = .2f;
    private float fastSpeed = .04f;

    public void changeSpeed()
    {
        if (GridManager.animationLength == normalSpeed)
        {
            GridManager.animationLength = fastSpeed;
            image.sprite = fastSprite;
        }
        else if (GridManager.animationLength == fastSpeed)
        {
            GridManager.animationLength = slowSpeed;
            image.sprite = slowSprite;
        } 
        else
        {
            GridManager.animationLength = normalSpeed;
            image.sprite = normalSprite;
        }
    }
}

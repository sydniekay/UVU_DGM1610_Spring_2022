using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


// Taking notes on scriptable objects based on Anthony's provided practice code
// You have to create the script as an asset because scriptable objects cannot be applied to game objects.
[CreateAssetMenu]

// We need to replace MonoBehavior with ScriptableObject in order for this to work
public class IntData : ScriptableObject
{
    public UnityEvent onZeroEvent;
    public float value;


    public void UpdateValue(float number)
    {
        value += number;
    }

    public void ReplaceValue(float number)
    {
        value = number;
    }

    public void DisplayImage(Image img)
    {
        img.fillAmount = value;
    }

    public void DisplayNumber(Text txt)
    {
        // .ToString allows you to easily convert an int or float into a string.
        txt.text = value.ToString();
    }
}

/* Scriptable objects are not bound to a scene's run time, so its values can be edited during gameplay
 * Another nice feature of scriptable objects is that instead of making copies of the data for each 
 * instance on a prefab, for example, it stores one set of the data and you call back to it when invoked

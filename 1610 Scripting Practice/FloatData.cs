using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


// Taking notes on scriptable objects based on Anthony's provided practice code

[CreateAssetMenu]

// We need to replace MonoBehavior with ScriptableObject in order for this to work
public class FloatData : ScriptableObject
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
        if (value <= 0)
        {
            onZeroEvent.Invoke();
        }
        else if (value >= 0)
        {
            value = 1;
        }

        img.fillAmount = value;
    }

    public void DisplayNumber(Text txt)
    {
        // .ToString allows you to easily convert an int or float into a string.
        txt.text = value.ToString();
    }
}

/* Why do we have two of the same scripts for "FloatData" and "IntData"?
 * My guess is that you'd want the asset to function the same, accept the data
 * inside of the floats can be much more precise due to its ability to hold a decimal.
 * Otherwise, they hold essentialy the same data and perform the same actions with it.
 */

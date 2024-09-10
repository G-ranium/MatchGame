using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.UIElements;

[RequireComponent(typeof(Text))]
public class TextLabelBehavior : MonoBehaviour
{
    private Text _label;
    public UnityEvent startEvent;

    private void Start()
    {
        _label = GetComponent<Text>();
        startEvent.Invoke();
    }

    public void UpdateLabel(FloatData obj)
    {
        _label.text = obj.value.ToString((CultureInfo.InvariantCulture));
    }

    public void UpdateLabel(IntData obj)
    {
        _label.text = obj.value.ToString((CultureInfo.InvariantCulture));
    }
    
}

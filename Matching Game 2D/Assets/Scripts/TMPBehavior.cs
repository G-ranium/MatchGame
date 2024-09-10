using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class TMPBehavior : MonoBehaviour
{
    private TextMeshProUGUI _label;
    public UnityEvent startEvent;

    private void Start()
    {
        _label = GetComponent<TextMeshProUGUI>();
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

using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    [System.Serializable]
    public class LightControl
    {
        public Light light;
        public KeyCode toggleKey;    // 触发控制该灯的按键
        public bool startOn = true;
        [HideInInspector] public bool isOn;
    }

    public LightControl[] controls;

    void Start()
    {
        foreach (var lc in controls)
        {
            if (lc.light != null)
            {
                lc.isOn = lc.startOn;
                lc.light.enabled = lc.isOn;
            }
        }
    }

    void Update()
    {
        foreach (var lc in controls)
        {
            if (lc.light != null && Input.GetKeyDown(lc.toggleKey))
            {
                lc.isOn = !lc.isOn;
                lc.light.enabled = lc.isOn;
                Debug.Log($"Toggled {lc.light.name} to {lc.isOn}");
            }
        }
    }
}


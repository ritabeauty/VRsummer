using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public Light pointLight; // 拖拽要控制的灯进来

    private bool isOn = true;

    // 模拟开关触发（测试用，按空格键切换）
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))//开关灯的接口
        {
            isOn = !isOn;
            pointLight.enabled = isOn;
        }
    }
}

using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public Light pointLight; // ��קҪ���Ƶĵƽ���

    private bool isOn = true;

    // ģ�⿪�ش����������ã����ո���л���
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))//���صƵĽӿ�
        {
            isOn = !isOn;
            pointLight.enabled = isOn;
        }
    }
}

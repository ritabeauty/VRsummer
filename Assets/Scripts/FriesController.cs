using UnityEngine;

public class ActivateFriesPhysics : MonoBehaviour
{
    public float activateTime = 2f; // �������ʼ����ģ��

    void Start()
    {
        Invoke(nameof(EnablePhysics), activateTime);
    }

    void EnablePhysics()
    {
        foreach (Transform fry in transform)
        {
            Rigidbody rb = fry.gameObject.AddComponent<Rigidbody>();
            rb.collisionDetectionMode = CollisionDetectionMode.Continuous;
            rb.interpolation = RigidbodyInterpolation.Interpolate;
            rb.mass = 0.1f;
        }
    }
}

using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField]
    private Health health;
    private void OnEnable()
    {
        health.initializeHealth(100f);
    }
}

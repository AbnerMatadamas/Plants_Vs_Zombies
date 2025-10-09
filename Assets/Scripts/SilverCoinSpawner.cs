using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class SilverCoinSpawner : MonoBehaviour
{
    [SerializeField]
    private UnityEvent<Vector3> onSilverCoinSpawned;
    [SerializeField]
    private LaneManager laneManager;
    [SerializeField]
    private float spawnInterval = 6f;
    [SerializeField]
    private float offsetY = 0f;
    private Coroutine spawnCoroutine;
    private bool isActive = false;
    private void Start()
    {
        Activate(true);
    }
    public void Activate(bool Active)
    {
        isActive = Active;
        if (isActive)
        {
            spawnCoroutine = StartCoroutine(SpawnSilverCoins());
        }
        else
        {
            if (spawnCoroutine != null)
            {
                StopCoroutine(spawnCoroutine);
                spawnCoroutine = null;
            }
        }
    }
    private IEnumerator SpawnSilverCoins()
    {
        while (isActive)
        {
            yield return new WaitForSeconds(spawnInterval);
            Transform frame = laneManager.GetFrameInLane();
            onSilverCoinSpawned?.Invoke(frame.position + Vector3.up * offsetY);
        }
    }
}

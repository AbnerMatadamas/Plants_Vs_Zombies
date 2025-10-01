using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private Lane[] lanes;

    public Transform GetFrameInLane()
    {
        int laneIndex = Random.Range(0, lanes.Length);
        Lane selectedLane = lanes[laneIndex];
        int frameIndex = Random.Range(0, selectedLane.Frames.Count);
        return selectedLane.Frames[frameIndex];
    }
}

using UnityEngine;
using UnityEngine.Events;

public class LevelAnimation : MonoBehaviour
{
    [SerializeField]
    private string readySoundName = "ready";
    [SerializeField]
    private string goSoundName = "go";
    [SerializeField]
    private string LevelAnimationName = "LevelAnimation";
    [SerializeField]
    private UnityEvent onStartGame;
    [SerializeField]
    private Animator animator;
    private void Start()
    {
        animator.Play(LevelAnimationName, 0, 0f);
    }
    public void ReadyEvent()
    {
        SoundManager.instance.Play(goSoundName);
    }

    public void GoEvent()
    {
        SoundManager.instance.Play(goSoundName);
    }

    public void StartGame()
    {
        onStartGame?.Invoke();
    }
}

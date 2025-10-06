using UnityEngine;

public class DestroyAfterAnimation : MonoBehaviour
{
    public void DestroySelf()
    {
        Destroy(gameObject);
    }
    public void PlayStarTrekAudio()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SpaceShip_Lauching", transform.position);
    }
    public void WakeUpFromDream2()
    {
        ProgressionDream2._instance.dream2Completed = true;
    }

}

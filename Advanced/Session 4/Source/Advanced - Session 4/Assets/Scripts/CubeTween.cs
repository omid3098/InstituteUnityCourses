using Omid3098;
using Prime31.ZestKit;
using UnityEngine;

public class CubeTween : MonoBehaviour
{
    Material material;
    int mehdiInt = 5;
    void Start()
    {
        material = GetComponent<MeshRenderer>().material;
        // transform.ZKpositionTo(new Vector3(5, 5, 5), 1.3f)
        // .setLoops(LoopType.PingPong)
        // .start();
        // material.ZKcolorTo(Color.yellow, 2.5f)
        // .setFrom(Color.green)
        // .start();
        transform.ZKlocalScaleTo(new Vector3(5, 5, 5), 2.5f)
        .setDelay(2f)
        .setIsTimeScaleIndependent()
        .setEaseType(EaseType.BounceOut)
        .setCompletionHandler((t) =>
        {
            transform.Shake();
        })
        .start();
        Debug.Log(mehdiInt.Add(11));
    }
}
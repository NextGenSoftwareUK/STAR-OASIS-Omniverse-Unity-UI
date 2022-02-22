using UnityEngine;

public class Rotator : MonoBehaviour
{
    LTDescr rotate;
    public float add;
    public float time;
    void Start()
    {
        StartRotation();
    }

    public void StartRotation()
    {
        rotate = LeanTween.rotateAroundLocal(gameObject, Vector3.up, add, time).setOnComplete(() =>
        {
            StartRotation();
        });
    }
}

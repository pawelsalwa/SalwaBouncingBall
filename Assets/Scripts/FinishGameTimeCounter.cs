using ScriptableObjects;
using ScriptableObjects.Events;
using UnityEngine;

public class FinishGameTimeCounter : MonoBehaviour
{

    public FloatReference timeSincelvlLoad;
    public FinishGameEvent FinishGameEvent;
    public float maxGameTime = 60f;
    
    private void Update()
    {
        timeSincelvlLoad.Value = Time.timeSinceLevelLoad;
        if (Time.timeSinceLevelLoad >= maxGameTime)
            FinishGameEvent.RaiseEvent();
    }
}


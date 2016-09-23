using UnityEngine;
using System;

public class UnityEventScript : MonoBehaviour
{
    [SerializeField]
    Action _onStart;
    
    public Action onStart
    {
        get
        {
            return _onStart;
        }

        set
        {
            _onStart = value;
        }
    }

    void Start()
    {
        _onStart.Invoke();
    }
}

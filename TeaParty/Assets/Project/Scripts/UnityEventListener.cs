using UnityEngine;

public class UnityEventListener : MonoBehaviour
{
    [SerializeField]
    UnityEventScript _scriptReference;

    void OnEnable()
    {
        if (_scriptReference != null)
        {
            //_scriptReference.onStart.AddListener(OnStart);

            //_scriptReference.onStart += OnStart;
        }
    }

    void OnDisable()
    {
        if (_scriptReference != null)
        {
            //_scriptReference.onStart.RemoveListener(OnStart);

            //_scriptReference.onStart -= OnStart;
        }
    }

    void OnStart()
    {
        Debug.Log("I did the thing");
    }
}

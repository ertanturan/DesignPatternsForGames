using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Component
{
    public bool DontDestroyOnLoading = false;

    public T Instance
    {
        get
        {

            if (_instance == null)
            {
                _instance = FindObjectOfType<T>();
                if (_instance == null)
                {
                    GameObject obj = new GameObject(typeof(T).Name);
                    obj.AddComponent<T>();
                }
            }

            return _instance;

        }
    }

    private T _instance;

    protected virtual void Awake()
    {
        if (_instance == null)
        {
            _instance = this as T;
            if (DontDestroyOnLoading)
                DontDestroyOnLoad(gameObject);

        }
        else
        {
            Destroy(gameObject);
        }
    }
}

using System;
using System.Collections;
using UnityEngine;

public class Tool : MonoBehaviour
{
    private static Tool _instance;

    public static Tool Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject toolObject = new GameObject("Tool");
                _instance = toolObject.AddComponent<Tool>();
                DontDestroyOnLoad(toolObject); // ·ÀÖ¹Ïú»Ù
            }
            return _instance;
        }
    }

    private Tool() { }

    public IEnumerator DelayAction(float delayTime, Action action)
    {
        Debug.Log($"Starting delay for {delayTime} seconds.");
        yield return new WaitForSeconds(delayTime);
        Debug.Log("Delay completed.");

        if (action != null)
        {
            Debug.Log("Executing action.");
            action();
        }
        else
        {
            Debug.LogWarning("Action is null, no action will be executed.");
        }
    }
}
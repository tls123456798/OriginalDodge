using UnityEngine;

public class Exit : MonoBehaviour
{
   

   
    void Update()
    {
        if (Input.GetKey("escape")) Application.Quit();
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else 
Application.Quit();
#endif
    }
}

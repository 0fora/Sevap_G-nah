using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class QuitGame : MonoBehaviour
{
    public void OyunuKapat()
    {
        Debug.Log("Oyun kapatılıyor...");
        Application.Quit();

        #if UNITY_EDITOR
        EditorApplication.isPlaying = false; // Editörde Play modunu durdurur
        #endif
    }
}

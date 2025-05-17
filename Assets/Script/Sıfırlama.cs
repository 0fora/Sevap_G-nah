using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetVeDon : MonoBehaviour
{
    public void SifirlaVeGeriDon()
    {
        PlayerPrefs.SetInt("ToplamPuan", 0); // Toplam puanı sıfırla
        SceneManager.LoadScene("MainScene"); // Sahne geçişi yap
    }
}

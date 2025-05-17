using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GirisKontrol : MonoBehaviour
{
    public TMP_InputField isimInput;
    public TMP_InputField soyisimInput;
    public TMP_InputField tcInput;

    public void GirisYap()
    {
        string isim = isimInput.text;
        string soyisim = soyisimInput.text;
        string tc = tcInput.text;

        if (string.IsNullOrEmpty(isim) || string.IsNullOrEmpty(soyisim) || tc.Length != 11)
        {
            Debug.Log("Lütfen geçerli bilgiler girin!");
            return;
        }

        PlayerPrefs.SetString("isim", isim);
        PlayerPrefs.SetString("soyisim", soyisim);
        PlayerPrefs.SetString("tc", tc);

        SceneManager.LoadScene("MainScene");  // Ana sahne adını buraya yaz

    }
 void Start()
{
    string isim = PlayerPrefs.GetString("isim");
    string soyisim = PlayerPrefs.GetString("soyisim");
    string tc = PlayerPrefs.GetString("tc");

    Debug.Log("Hoş geldin: " + isim + " " + soyisim + " (" + tc + ")");
}

}

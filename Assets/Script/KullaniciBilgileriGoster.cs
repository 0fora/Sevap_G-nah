using UnityEngine;
using TMPro;

public class KullaniciBilgiGoster : MonoBehaviour
{
    public TMP_Text isimText;
    public TMP_Text tcText;

    void Start()
    {
        string isim = PlayerPrefs.GetString("isim", "Bilinmiyor");
        string soyisim = PlayerPrefs.GetString("soyisim", "");
        string tc = PlayerPrefs.GetString("tc", "");

        isimText.text = "Hoş Geldin: " + isim + " " + soyisim;
        tcText.text = "TC No: " + tc;
    }
}

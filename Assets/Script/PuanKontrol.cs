using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PuanKontrol : MonoBehaviour
{
    public int sevap = 0;
    public int gunah = 0;
    public int toplam = 0;

    public TextMeshProUGUI sevapText;
    public TextMeshProUGUI gunahText;
    public TextMeshProUGUI toplamText;

    // Butonlara bağlayacağımız metodlar
    public void YardimEt()
    {
        sevap++;
        toplam++;
        UpdateUI();
        CheckSonuc();
    }

    public void DogruyuSoyle()
    {
        sevap++;
        toplam++;
        UpdateUI();
        CheckSonuc();
    }

    public void IyilikYap()
    {
        sevap++;
        toplam++;
        UpdateUI();
        CheckSonuc();
    }

    public void YalanSoyle()
    {
        gunah++;
        toplam--;
        UpdateUI();
        CheckSonuc();
    }

    public void ZararVer()
    {
        gunah++;
        toplam--;
        UpdateUI();
        CheckSonuc();
    }

    public void HaksizlikYap()
    {
        gunah++;
        toplam--;
        UpdateUI();
        CheckSonuc();
    }

    void UpdateUI()
    {
       
        toplamText.text = "   Sevap Sayar: " + toplam;
    }

    void CheckSonuc()
    {
        if (sevap >= 10)
        {
            SceneManager.LoadScene("CennetScene");
        }
        else if (gunah >= 10)
        {
            SceneManager.LoadScene("CehennemScene");
        }
    }
}

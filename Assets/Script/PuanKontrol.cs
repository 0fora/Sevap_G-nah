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
        sevap+=3;
        toplam+=3;
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
        sevap+=2;
        toplam+=2;
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
        gunah+= 3;
        toplam-= 3;
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
     public void ChpOyVer()
    {
        gunah+= 4;
        toplam-= 4;
        UpdateUI();
        CheckSonuc();
    }
     public void TaşÇal()
    {
        gunah++;
        toplam--;
        UpdateUI();
        CheckSonuc();
    }
     public void CamiSmack()
    {
        gunah+=2;
        toplam-=2;
        UpdateUI();
        CheckSonuc();
    }

    void UpdateUI()
    {
       
        toplamText.text = "   Sevap Sayar: " + toplam;
    }

    void CheckSonuc()
    {
        if (toplam >= 10)
        {
            SceneManager.LoadScene("CennetScene");
        }
        else if (toplam <= -10)
        {
            SceneManager.LoadScene("CehennemScene");
        }
    }
}

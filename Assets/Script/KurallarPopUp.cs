using UnityEngine;

public class KurallarPopup : MonoBehaviour
{
    public GameObject bilgiPanel;
    public GameObject anaMenuUI;

    void Start()
    {
        bilgiPanel.SetActive(true);
        anaMenuUI.SetActive(false);
        if (anaMenuUI != null)
        anaMenuUI.SetActive(false);
    
    if (bilgiPanel != null)
        bilgiPanel.SetActive(true);
    }

    public void KapatPanel()
    {
        bilgiPanel.SetActive(false);
        anaMenuUI.SetActive(true);
        Debug.Log("KapatPanel çalıştı");
        bilgiPanel.SetActive(false);
        anaMenuUI.SetActive(true);


    }


}

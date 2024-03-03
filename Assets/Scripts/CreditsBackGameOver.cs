using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreditsBackGameOver : MonoBehaviour
{
    public Button BackToMenu;
    // Start is called before the first frame update
    void Start()
    {
         BackToMenu.onClick.AddListener(BMenu);
    }

    // Update is called once per frame
    public void BMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

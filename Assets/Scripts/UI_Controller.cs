using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Controller : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 1;
    }
    public GameObject GameBattle;
    public GameObject MainMenu;
    public Button PlayBtn;
    public void PressPlayBtn()
    {
        Time.timeScale = 1;
        GameBattle.SetActive(true);
        transform.parent.gameObject.SetActive(false);
    }


}

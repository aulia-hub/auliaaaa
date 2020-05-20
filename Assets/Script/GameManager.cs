using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void FullVideo()
    {
        SceneManager.LoadScene("FullVideo");
    }

    public void PartVideo()
    {
        SceneManager.LoadScene("Part01");
    }

    public void BackToHome()
    {
        SceneManager.LoadScene("SplashScreen");
    }

    public void PartKedua()
    {
        SceneManager.LoadScene("Part02");
    }
    public void PartKetiga()
    {
        SceneManager.LoadScene("Part03");
    }
    public void PartKeempat()
    {
        SceneManager.LoadScene("Part04");
    }
    public void PartKelima()
    {
        SceneManager.LoadScene("Part05");
    }
    public void PartKeenam()
    {
        SceneManager.LoadScene("Part06");
    }
    public void PartKetujuh()
    {
        SceneManager.LoadScene("Part07");
    }
    public void PartKedelapan()
    {
        SceneManager.LoadScene("Part08");
    }
    public void PartKesembilan()
    {
        SceneManager.LoadScene("Part09");
    }
    public void PartKesepuluh()
    {
        SceneManager.LoadScene("Part10");
    }
    public void PartKesebelas()
    {
        SceneManager.LoadScene("Part11");
    }
    public void PartKeduabelas()
    {
        SceneManager.LoadScene("Part12");
    }
    public void PartKetigabelas()
    {
        SceneManager.LoadScene("Part13");
    }
    public void PartKeempatbelas()
    {
        SceneManager.LoadScene("Part14");
    }

    public void ExitDariGame()
    {
        Application.Quit(0);
    }
}

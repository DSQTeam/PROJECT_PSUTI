using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelRandom : MonoBehaviour
{
    public string MGname;
    public int levelGenerate;
    [SerializeField] public GameObject InDevTab;
    [SerializeField] public GameObject Ивт;
    [SerializeField] public GameObject Иб;
    [SerializeField] public GameObject Сми;
    [SerializeField] public GameObject Радио;
    [SerializeField] public GameObject Экономика;
    [SerializeField] public GameObject Утс;
    public void LoadRandLevel()
    {
        //int Random.Range[min,max)
        //levelGenerate = Random.Range(1, 4);   
        //SceneManager.LoadScene(levelGenerate);

        if (Ивт.activeInHierarchy)
        {
            MGname = "ИВТ";
        }
        else if (Иб.activeInHierarchy)
        {
            MGname = "ИБ";
        }
        else if (Сми.activeInHierarchy)
        {
            MGname = "СМИ";
        }
        else if (Радио.activeInHierarchy)
        {
            MGname = "Радио";
        }
        else if (Экономика.activeInHierarchy)
        {
            MGname = "Экономика";
        }
        else if (Утс.activeInHierarchy)
        {
            MGname = "УТС";
        }
        else
        {
            MGname = "0";
        }

        switch (MGname)
        {
            case "ИВТ":
                 levelGenerate = Random.Range(1, 4);
                SceneManager.LoadScene(levelGenerate);
                break;

            case "ИБ":
                SceneManager.LoadScene(4);
                break;

            case "0":
                break;

            default:
                InDevTab.SetActive(true);
                Invoke(nameof(IsOff),3);
                break;
        }

    }


    public void IsOff()
    {
        InDevTab.SetActive(false);
    }
    

}

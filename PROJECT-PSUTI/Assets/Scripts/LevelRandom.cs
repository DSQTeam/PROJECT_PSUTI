using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelRandom : MonoBehaviour
{
    public string MGname;
    public int levelGenerate;
    [SerializeField] public GameObject InDevTab;
    [SerializeField] public GameObject ���;
    [SerializeField] public GameObject ��;
    [SerializeField] public GameObject ���;
    [SerializeField] public GameObject �����;
    [SerializeField] public GameObject ���������;
    [SerializeField] public GameObject ���;
    public void LoadRandLevel()
    {
        //int Random.Range[min,max)
        //levelGenerate = Random.Range(1, 4);   
        //SceneManager.LoadScene(levelGenerate);

        if (���.activeInHierarchy)
        {
            MGname = "���";
        }
        else if (��.activeInHierarchy)
        {
            MGname = "��";
        }
        else if (���.activeInHierarchy)
        {
            MGname = "���";
        }
        else if (�����.activeInHierarchy)
        {
            MGname = "�����";
        }
        else if (���������.activeInHierarchy)
        {
            MGname = "���������";
        }
        else if (���.activeInHierarchy)
        {
            MGname = "���";
        }
        else
        {
            MGname = "0";
        }

        switch (MGname)
        {
            case "���":
                 levelGenerate = Random.Range(1, 4);
                SceneManager.LoadScene(levelGenerate);
                break;

            case "��":
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

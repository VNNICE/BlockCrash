using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TitleManager : MonoBehaviour
{
    [SerializeField] GameObject ST1_root;
    [SerializeField] GameObject ST2_root;
    [SerializeField] TextMeshProUGUI ST1_Clear;
    [SerializeField] TextMeshProUGUI ST_2Clear;
    public bool ST1_CLR = false;
    public bool ST2_CLR = false;

    public void ST1_CLEAR()
    {
        if (ST1_CLR == false)
        {
            ST1_root.SetActive(false);
        }
        else {
            ST1_root.SetActive(true);
        }
    }
    public void ST2_CLEAR()
    {
        if (ST1_CLR == false)
        {
            ST2_root.SetActive(false);
        }
        else
        {
            ST2_root.SetActive(true);
        }
    }

    void Start()
    {
        ST1_CLEAR();
        ST2_CLEAR();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

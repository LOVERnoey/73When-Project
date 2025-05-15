using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TestCount : MonoBehaviour, IDataPersistence
{
    public TMP_Text textMeshPro; // ใช้ TextMeshPro แทน TextMesh
    public int count = 0;

    void Start()
    {
        if (textMeshPro != null)
        {
            textMeshPro.text = "Count: " + count;
        }
    }

    public void LoadData(GameData data)
    {
        this.count = data.count;

        if (textMeshPro != null)
        {
            textMeshPro.text = "Count: " + count;
        }
    }

    public void SaveData(ref GameData data)
    {
        data.count = this.count;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            count++;
            if (textMeshPro != null)
            {
                textMeshPro.text = "Count: " + count;
            }
        }
    }
}
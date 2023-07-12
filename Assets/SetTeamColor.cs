using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTeamColor : MonoBehaviour
{
    [SerializeField]
    private Color childrensColor;
    private Renderer[] renderers;

    void Awake()
    {
        RefreshRenderersList();
        ChangeColor();
    }

    void RefreshRenderersList()
    {
        renderers = GetComponentsInChildren<Renderer>();
    }

    public void ChangeColor()
    {
        int count = 3;
        foreach (Renderer r in GetComponentsInChildren<Renderer>())
        {
            if (count % 3 == 0)
            {
                count = 1;
                r.material.color = childrensColor;
            }
            else
            {

                count++;
            }

            //r.material.color= childrensColor;

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabGroup : MonoBehaviour
{
    public List<TabButton> tabButtons;
    public Color tabIdle;
    public Color tabActive;
    public Color tabHover;

    public TabButton selectedTab;

    public List<GameObject> pages;

    public void Subscribe(TabButton tabButton)
    {
        if (tabButtons == null)
        {
            tabButtons = new List<TabButton>();
        }

        tabButtons.Add(tabButton);
    }

    public void OnTabEnter(TabButton tabButton)
    {
        
    }

    public void OnTabExit(TabButton tabButton)
    {

    }

    public void OnTabSelected(TabButton tabButton)
    {
        selectedTab = tabButton;

        int index = tabButton.transform.GetSiblingIndex();
        for (int i = 0; i < pages.Count; i++)
        {
            if (i == index)
            {
                pages[i].SetActive(true);
            }
            else
            {
                pages[i].SetActive(false);
            }
        }
    }

    public void ResetTabs()
    {
        foreach (TabButton tabButton in tabButtons)
        {
            if (selectedTab != null && tabButton == selectedTab) { continue; }
            
            // if implemented with image
            //tabButton.backgroundImage.sprite = tabIdle;
        }
    }
}

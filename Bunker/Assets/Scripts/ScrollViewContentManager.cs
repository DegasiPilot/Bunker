using System.Collections.Generic;
using UnityEngine;

public class ScrollViewContentManager : MonoBehaviour
{
    [SerializeField] private GameObject _popUp;
    [SerializeField] private List<GameObject> _pages;
    private int _pagesCount;

    public void SetActivePage(int index)
    {
        _popUp.SetActive(false);
        if (_pagesCount == 0)
        {
            _pagesCount = _pages.Count;
        }

        for(int i = 0; i < _pagesCount; i++)
        {
            _pages[i].SetActive(i == index);
        }
    }

    public void ActivatePopUp()
    {
        _popUp.SetActive(true);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topikSlider : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> item;
    public GameObject leftButton;
    public GameObject rightButton;
    [SerializeField] int index = 1;

    public void left()
    {
        item[index].transform.LeanMoveLocal(new Vector2(2000, -11), 1).setEaseOutQuart();

        index--;

        if (index == 1)
        {
            item[0].transform.LeanMoveLocal(new Vector2(-2000, -11), 1).setEaseOutQuart();
            item[1].transform.LeanMoveLocal(new Vector2(8, -11), 1).setEaseOutQuart();
            item[2].transform.LeanMoveLocal(new Vector2(2000, -11), 1).setEaseOutQuart();
        }
        if (index == 0)
        {
            if (index != 1)
            {
                item[index].transform.LeanMoveLocal(new Vector2(8, -11), 1).setEaseOutQuart();
            }
            leftButton.SetActive(false);
        }
        else
        {
            rightButton.SetActive(true);
            leftButton.SetActive(true);
        }

    }

    public void right()
    {
        item[index].transform.LeanMoveLocal(new Vector2(-2000, -11), 1).setEaseOutQuart();
        index++;

        if (index == 1)
        {
            item[0].transform.LeanMoveLocal(new Vector2(-2000, -11), 1).setEaseOutQuart();
            item[1].transform.LeanMoveLocal(new Vector2(8, -11), 1).setEaseOutQuart();
            item[2].transform.LeanMoveLocal(new Vector2(2000, -11), 1).setEaseOutQuart();
        }

        if (index == 2)
        {
            if (index != 1)
            {
                item[index].transform.LeanMoveLocal(new Vector2(8, -11), 1).setEaseOutQuart();
            }
            rightButton.SetActive(false);
        }
        else
        {
            leftButton.SetActive(true);
            rightButton.SetActive(true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSlot : MonoBehaviour {

    public Material[] slotMats;

    private bool hasCard = false;
    private string slotElement;
    private bool isHighlighted = false;
    private bool isMouseOn = false;
    private Renderer thisRend;

    private void Start()
    {
        thisRend = GetComponent<Renderer>();
    }

    private void OnMouseOver()
    {
        isHighlighted = true;
        SlotHighlight(isHighlighted);
    }
    private void OnMouseExit()
    {
        isHighlighted = false;
        SlotHighlight(isHighlighted);
    }

    private void SlotHighlight(bool isHovered)
    {
        if(isHovered && (!isMouseOn))
        {
            thisRend.material = slotMats[1];
            isMouseOn = true;
        }
        else if((!isHovered))
        {
            thisRend.material = slotMats[0];
            isMouseOn = false;
        }
    }
}

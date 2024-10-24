using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    public void Mirar()
    {
        UIManager.Instance.ShowMessage("La puerta está cerrada.");
    }

    public void Usar()
    {
        if (GameManager.Instance.hasKey)
        {
            GameManager.Instance.WinGame();
        }
        else
        {
            UIManager.Instance.ShowMessage("No puedes abrir la puerta sin una llave.");
        }
    }
}

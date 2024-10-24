using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightStand : MonoBehaviour, IInteractable
{
    public void Mirar()
    {
        UIManager.Instance.ShowMessage("Hay una llave dentro de la mesita de noche.");
    }

    public void Usar()
    {
        if (!GameManager.Instance.hasKey)
        {
            GameManager.Instance.hasKey = true;
            UIManager.Instance.ShowMessage("Has tomado la llave.");
        }
    }
}

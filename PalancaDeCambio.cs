using UnityEngine;

public class PalancaDeCambio : MonoBehaviour
{
    public enum Marcha
    {
        Reversa,
        Neutro,
        Primera,
        Segunda,
        Tercera,
        Cuarta,
        Quinta,
        Sexta
    }

    public Marcha marchaActual = Marcha.Neutro;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
            CambiarMarcha(Marcha.Neutro);

        if (Input.GetKeyDown(KeyCode.Alpha1))
            CambiarMarcha(Marcha.Primera);

        if (Input.GetKeyDown(KeyCode.Alpha2))
            CambiarMarcha(Marcha.Segunda);

        if (Input.GetKeyDown(KeyCode.Alpha3))
            CambiarMarcha(Marcha.Tercera);

        if (Input.GetKeyDown(KeyCode.Alpha4))
            CambiarMarcha(Marcha.Cuarta);

        if (Input.GetKeyDown(KeyCode.Alpha5))
            CambiarMarcha(Marcha.Quinta);

        if (Input.GetKeyDown(KeyCode.Alpha6))
            CambiarMarcha(Marcha.Sexta);

        if (Input.GetKeyDown(KeyCode.R))
            CambiarMarcha(Marcha.Reversa);
    }

    void CambiarMarcha(Marcha nuevaMarcha)
    {
        if (marchaActual != nuevaMarcha)
        {
            marchaActual = nuevaMarcha;
            Debug.Log("Marcha actual: " + marchaActual.ToString());
        }
    }
}

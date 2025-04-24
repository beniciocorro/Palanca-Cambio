using UnityEngine;

public class PalancaDeCambio : Simulator
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

    [SerializeField] private Creadores creadores;

    private void Start()
    {
        AsignarCreador(creadores);
        Describir();
    }

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

    public override void Describir()
    {
        Debug.Log("Soy la palanca de cambio, hija de Simulator");
    }

    public override void AsignarCreador(Creadores creador)
    {
        CreadoresSimulator = creador;
    }
}

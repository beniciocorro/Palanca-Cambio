using UnityEngine;
using static UnityEngine.InputSystem.HID.HID;

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

    [Header("Configuración de Teclas")]
    [SerializeField] private KeyCode teclaNeutro;
    [SerializeField] private KeyCode teclaPrimera;
    [SerializeField] private KeyCode teclaSegunda;
    [SerializeField] private KeyCode teclaTercera;
    [SerializeField] private KeyCode teclaCuarta;
    [SerializeField] private KeyCode teclaQuinta;
    [SerializeField] private KeyCode teclaSexta;
    [SerializeField] private KeyCode teclaReversa;

    [Header("Creador")]
    [SerializeField] private Creadores creadores;

    private void Start()
    {
        AsignarCreador(creadores);
        Describir();
    }

    private void Update()
    {
        if (Input.GetKeyDown(teclaNeutro))
            CambiarMarcha(Marcha.Neutro);

        if (Input.GetKeyDown(teclaPrimera))
            CambiarMarcha(Marcha.Primera);

        if (Input.GetKeyDown(teclaSegunda))
            CambiarMarcha(Marcha.Segunda);

        if (Input.GetKeyDown(teclaTercera))
            CambiarMarcha(Marcha.Tercera);

        if (Input.GetKeyDown(teclaCuarta))
            CambiarMarcha(Marcha.Cuarta);

        if (Input.GetKeyDown(teclaQuinta))
            CambiarMarcha(Marcha.Quinta);

        if (Input.GetKeyDown(teclaSexta))
            CambiarMarcha(Marcha.Sexta);

        if (Input.GetKeyDown(teclaReversa))
            CambiarMarcha(Marcha.Reversa);
    }

    private void CambiarMarcha(Marcha nuevaMarcha)
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

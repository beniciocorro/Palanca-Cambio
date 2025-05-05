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

    [Header("Configuración de Teclas")]
    [SerializeField] private KeyCode teclaNeutro = KeyCode.Alpha0;
    [SerializeField] private KeyCode teclaPrimera = KeyCode.Alpha1;
    [SerializeField] private KeyCode teclaSegunda = KeyCode.Alpha2;
    [SerializeField] private KeyCode teclaTercera = KeyCode.Alpha3;
    [SerializeField] private KeyCode teclaCuarta = KeyCode.Alpha4;
    [SerializeField] private KeyCode teclaQuinta = KeyCode.Alpha5;
    [SerializeField] private KeyCode teclaSexta = KeyCode.Alpha6;
    [SerializeField] private KeyCode teclaReversa = KeyCode.R;

    private Creadores creador = Creadores.Corro_Benicio;

    private void Start()
    {
        AsignarCreador(creador);
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
        marchaActual = nuevaMarcha;
        Debug.Log("Marcha actual: " + marchaActual.ToString());
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

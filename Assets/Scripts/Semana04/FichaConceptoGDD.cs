using UnityEngine;

public class FichaConceptoGDD : MonoBehaviour
{
    [Header("Ficha de concepto (completa con tu propio juego)")]
    public string tituloJuego = "";
    public string generoJuego = "";
    public string plataformaObjetivo = "";

    [TextArea(3, 6)]
    [Tooltip("Escribe aqui tu elevator pitch. Debe tener entre 15 y 40 palabras.")]
    public string elevatorPitch = "";

    [Header("Personalizacion por DNI (ver Paso 9 del documento)")]
    [Tooltip("Coloca aqui los ultimos 3 digitos de tu DNI, tal cual, sin modificarlos.")]
    public int codigoProyecto = 0;

    [Header("Criterios de validacion (no modificar)")]
    public int palabrasMinimas = 15;
    public int palabrasMaximas = 40;

    void Start()
    {
        char[] separadores = new char[] { ' ', '\n', '\r', '\t' };
        string[] palabras = elevatorPitch.Split(separadores, System.StringSplitOptions.RemoveEmptyEntries);
        int cantidadPalabras = palabras.Length;

        bool cumpleLongitud = (cantidadPalabras >= palabrasMinimas && cantidadPalabras <= palabrasMaximas);

        bool fichaCompleta = !string.IsNullOrWhiteSpace(tituloJuego)
            && !string.IsNullOrWhiteSpace(generoJuego)
            && !string.IsNullOrWhiteSpace(plataformaObjetivo)
            && !string.IsNullOrWhiteSpace(elevatorPitch);

        Debug.Log("=== FICHA DE CONCEPTO GDD - SEMANA 04 ===");
        Debug.Log("Codigo de Proyecto (ultimos 3 digitos de tu DNI): " + codigoProyecto);
        Debug.Log("Titulo del juego: " + tituloJuego);
        Debug.Log("Genero: " + generoJuego);
        Debug.Log("Plataforma objetivo: " + plataformaObjetivo);
        Debug.Log("Elevator pitch: " + elevatorPitch);
        Debug.Log("Cantidad de palabras del pitch: " + cantidadPalabras);
        Debug.Log("Rango permitido: " + palabrasMinimas + " a " + palabrasMaximas + " palabras");
        Debug.Log("Validacion de longitud del pitch: " + (cumpleLongitud ? "CUMPLE" : "NO CUMPLE"));
        Debug.Log("Ficha completa (todos los campos llenos): " + (fichaCompleta ? "SI" : "NO"));
    }
}
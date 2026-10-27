using System;
using System.Collections.Generic;

namespace ColaCircularWinForms;

/// <summary>Cola circular fija de cinco posiciones con frente, inserción y cantidad.</summary>
public sealed class ColaCircular
{
    public const int Capacidad = 5;
    private readonly string?[] _elementos = new string?[Capacidad];
    private int _frente;
    private int _siguienteInsercion;
    private int _cantidad;

    public int Cantidad => _cantidad;
    public bool EstaVacia => _cantidad == 0;
    public bool EstaLlena => _cantidad == Capacidad;
    public int IndiceFrente => _frente;
    public int IndiceSiguienteInsercion => _siguienteInsercion;
    public IReadOnlyList<string?> Posiciones => _elementos;

    public bool Encolar(string documento)
    {
        if (EstaLlena) return false;
        _elementos[_siguienteInsercion] = documento;
        _siguienteInsercion = (_siguienteInsercion + 1) % Capacidad;
        _cantidad++;
        return true;
    }

    public bool IntentarImprimir(out string? documento)
    {
        documento = null;
        if (EstaVacia) return false;
        documento = _elementos[_frente];
        _elementos[_frente] = null;
        _frente = (_frente + 1) % Capacidad;
        _cantidad--;
        return true;
    }

    public void Limpiar()
    {
        Array.Clear(_elementos);
        _frente = 0;
        _siguienteInsercion = 0;
        _cantidad = 0;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISpeakable: IDisposable
{

    /// <summary>
    /// Agrega un texto a la cola de habla
    /// </summary>
    /// <param name="msg">Texto que se agrega a la cola de habla</param>
    void AddToSpeechQueue(string msg);

    /// <summary>
    /// Para el habla y limpia la cola de habla
    /// </summary>
    void Stop();

    /// <summary>
    /// Pausa el habla
    /// </summary>
    void Pause();

    /// <summary>
    /// Continua con el habla, si se realizó una pausa
    /// </summary>
    void Continue();
}
